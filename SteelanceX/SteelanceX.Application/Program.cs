#nullable disable

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Microsoft.OpenApi.Models;
using SteelanceX.Contracts.DataTransferObjects.FreelancerProfile.Response;
using SteelanceX.Contracts.DataTransferObjects.Job.Request;
using SteelanceX.Contracts.DataTransferObjects.Job.Response;
using SteelanceX.Contracts.MapperConfig;
using SteelanceX.Data.EF;
using SteelanceX.DataAccess.DataAccessObjects;
using SteelanceX.Domain.Models;
using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<SteelanceXDbContext>();
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<SteelanceXDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<SteelanceXDbContext>();
builder.Services.AddScoped<JobRepository>();
builder.Services.AddScoped<CategoryRepository>();
builder.Services.AddScoped<FreelancerProfileRepository>();
builder.Services.AddScoped<BusinessProfileRepository>();
builder.Services.AddScoped<JobCategoryRepository>();
builder.Services.AddScoped<FreelancerCategoryRepository>();
builder.Services.AddScoped<ApplicationRepository>();

builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(MapperProfile)));

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
}).AddOData(options => options.Select().Filter().Count()
    .OrderBy().Expand().SetMaxTop(100)
    .AddRouteComponents("odata", GetEdmModel()));

//password policy configuration
builder.Services.Configure<IdentityOptions>(options =>
{
    // Default Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 0;
});

JsonSerializerOptions options = new()
{
    ReferenceHandler = ReferenceHandler.IgnoreCycles,
    WriteIndented = true
};

//JWT configuration 
string issuer = builder.Configuration.GetValue<string>("JwtSettings:validIssuer");
string signingKey = builder.Configuration.GetValue<string>("JwtSettings:Key");

builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})

.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidIssuer = issuer,
        ValidateAudience = true,
        ValidAudience = issuer,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = System.TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(signingKey))
    };
});

builder.Services.AddAuthorization();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger asset managment solution", Version = "v1" });
    c.CustomSchemaIds(type => type.ToString());
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,
                        },
                        new List<string>()
                      }
                    });
});

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseODataBatching();

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseODataRouteDebug();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

//app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();

static IEdmModel GetEdmModel()
{
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    var jobs = builder.EntitySet<JobResponse>("Jobs").EntityType;
    builder.EntityType<CreateJobRequest>();
    jobs.Collection.Function("GetOpenJobs").Returns<JobResponse>();

    builder.Namespace = "JobsService";
    var action = builder.EntityType<JobResponse>().Action("CreateAsync");
    action.Parameter<JsonElement>("request");

    builder.EntitySet<Category>("Categories");

    var freelancers = builder.EntitySet<FreelancerResponse>("FreelancerProfiles").EntityType;
    //var getProfileByJob = freelancers.Collection.Function("GetProfileByJob");
    //getProfileByJob.Parameter<int>("JobId");
    //getProfileByJob.Returns<JobResponse>();

    builder.EntitySet<BusinessProfile>("BusinessProfiles");

    return builder.GetEdmModel();
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using SteelanceX.DataAccess.DataAccessObjects;
using SteelanceX.Domain.Models;

namespace SteelanceX.Application.Controllers;

public class CategoriesController : ODataController
{
    private readonly CategoryRepository _categoryRepo;

    public CategoriesController(CategoryRepository categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }

    [EnableQuery]
    public ActionResult<IQueryable<Category>> Get()
    {
        return Ok(_categoryRepo.QueryAll());
    }

    [EnableQuery]
    public ActionResult<Category> Get([FromRoute] int key)
    {
        var category = _categoryRepo.QueryAll()
            .SingleOrDefault(d => d.Id.Equals(key));

        if (category == null)
        {
            return NotFound();
        }

        return Ok(category);
    }
}

using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SteelanceX.Application.Utilities;

public static class ErrorHelper
{
    public static string ValidateError(this ModelStateDictionary modelState)
    {
        var errorMessages = modelState.Values
               .SelectMany(v => v.Errors)
               .Select(e => e.ErrorMessage)
               .ToList();
        return $"Invalid input format. Errors: {string.Join(", ", errorMessages)}";
    }
}

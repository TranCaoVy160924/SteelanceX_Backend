﻿using System.ComponentModel.DataAnnotations;

namespace SteelanceX.Contract.ValidationAttributes;
public class DateLaterThanAttribute : ValidationAttribute
{
    private readonly string _comparisonProperty;

    public DateLaterThanAttribute(string comparisonProperty)
    {
        _comparisonProperty = comparisonProperty;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        ErrorMessage = ErrorMessageString;
        var currentValue = (DateTime)value;

        var property = validationContext.ObjectType.GetProperty(_comparisonProperty);

        if (property == null)
            throw new ArgumentException("Property with this name not found");

        var comparisonValue = (DateTime)property.GetValue(validationContext.ObjectInstance);

        if (currentValue < comparisonValue)
            return new ValidationResult(ErrorMessage);

        return ValidationResult.Success;
    }
}
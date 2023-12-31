﻿using FluentValidation.Results;
using Emulair.Common.Exceptions;

namespace Emulair.Common.Extensions
{
    public static class ValidationExtensions
    {
        public static void ThenThrow(this ValidationResult result,object model)
        {
            if (!result.IsValid)
            {
                throw new ValidationErrorException(result,model);
            }
        }
    }
}

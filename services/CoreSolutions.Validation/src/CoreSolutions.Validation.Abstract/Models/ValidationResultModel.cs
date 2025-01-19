using System.Linq;
using System.Collections.Generic;

namespace CoreSolutions.Validation.Abstract
{
    /// <summary>
    /// Represents the result of a validation process, including validation errors and the status of the validation
    /// </summary>
    public sealed class ValidationResultModel
    {
        /// <summary>
        /// Gets the collection of validation errors encountered during the validation process
        /// </summary>
        public ICollection<ValidationErrorModel> Errors { get; private init; } = new List<ValidationErrorModel>();

        /// <summary>
        /// Gets the validation status, which is determined based on the presence of errors
        /// </summary>
        public ValidationStatusResult ValidationStatus 
            => this.Errors.Any() ? ValidationStatusResult.Success : ValidationStatusResult.Failed;
    }
}
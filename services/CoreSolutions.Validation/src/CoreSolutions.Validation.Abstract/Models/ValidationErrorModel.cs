using System;

namespace CoreSolutions.Validation.Abstract
{
    /// <summary>
    /// Represents a model for validation errors with a description and an error type
    /// </summary>
    public sealed class ValidationErrorModel
    {
        /// <summary>
        /// Gets the description of the validation error
        /// </summary>
        public string Description { get; private init; }

        /// <summary>
        /// Gets the type of the validation error
        /// </summary>
        public ValidationErrorType EventType { get; private init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorModel"/> class with a description and error type
        /// </summary>
        /// <param name="description">The description of the validation error</param>
        /// <param name="eventType">The type of validation error</param>
        /// <exception cref="ArgumentNullException">Thrown if the description is null or empty</exception>
        public ValidationErrorModel(string description, ValidationErrorType eventType)
        {
            this.EventType = eventType;
            this.Description = string.IsNullOrEmpty(description) ? description : throw new ArgumentNullException(nameof(description));
        }
    }
}
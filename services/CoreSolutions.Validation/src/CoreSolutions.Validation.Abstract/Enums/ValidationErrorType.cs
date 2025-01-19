namespace CoreSolutions.Validation.Abstract
{
    /// <summary>
    /// Enumeration representing the types of validation errors
    /// </summary>
    public enum ValidationErrorType
    {
        /// <summary>
        /// Represents a non-critical validation issue
        /// </summary>
        Warning,

        /// <summary>
        /// Represents a critical validation issue
        /// </summary>
        Error
    }
}
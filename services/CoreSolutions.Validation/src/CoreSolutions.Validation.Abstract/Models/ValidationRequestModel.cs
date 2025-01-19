using System;
using System.IO;

namespace CoreSolutions.Validation.Abstract
{
    /// <summary>
    /// Represents a model for a validation request containing a document stream and the source document path
    /// </summary>
    public sealed class ValidationRequestModel
    {
        /// <summary>
        /// Gets the stream representing the document to be validated
        /// </summary>
        public Stream DocumentStream { get; private init; }

        /// <summary>
        /// Gets the source file path of the document to be validated
        /// </summary>
        public string SourceDocumentPath { get; private init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationRequestModel"/> class with a document stream and source document path
        /// </summary>
        /// <param name="documentStream">The stream representing the document to be validated</param>
        /// <param name="sourceDocumentPath">The path of the source document</param>
        /// <exception cref="ArgumentNullException">Thrown if the documentStream or sourceDocumentPath is null or empty</exception>
        public ValidationRequestModel(Stream documentStream, string sourceDocumentPath)
        {
            this.DocumentStream = documentStream ?? throw new ArgumentNullException(nameof(documentStream));
            this.SourceDocumentPath = string.IsNullOrEmpty(sourceDocumentPath) ? sourceDocumentPath : throw new ArgumentNullException(nameof(sourceDocumentPath));
        }
    }
}
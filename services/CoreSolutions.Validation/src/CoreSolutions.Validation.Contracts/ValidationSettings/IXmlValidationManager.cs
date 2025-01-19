using System.IO;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreSolutions.Validation.Contracts
{
    /// <summary>
    /// Defines the contract for a service that manages XML document validation
    /// </summary>
    public interface IXmlValidationManager
    {
        /// <summary>
        /// Validates an XML document asynchronously using the provided document stream and source XML document path
        /// </summary>
        /// <param name="sourceXmlDocumentPath">The path to the source XML document to be validated</param>
        /// <param name="documentStream">The stream containing the XML document to be validated</param>
        /// <returns>A task that represents the asynchronous operation, with a result of type <see cref="ValidationResult"/></returns>
        public Task<ValidationResult> ValidateDocumentAsync(string sourceXmlDocumentPath, Stream documentStream);
    }
}
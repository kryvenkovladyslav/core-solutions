using System.IO;
using System.Xml;
using System.Threading.Tasks;

namespace CoreSolutions.Validation.Contracts
{
    /// <summary>
    /// Defines the contract for a service that validates XML documents asynchronously
    /// </summary>
    public interface IXmlDocumentValidationService
    {
        /// <summary>
        /// Validates the provided XML document stream asynchronously using the specified XML reader settings
        /// </summary>
        /// <param name="xmlDocumentStream">The stream containing the XML document to validate</param>
        /// <param name="xmlReaderSettings">The XML reader settings to be used during validation</param>
        /// <returns>A task representing the asynchronous operation</returns>
        public Task ValidateDocumentAsync(Stream xmlDocumentStream, XmlReaderSettings xmlReaderSettings);
    }
}
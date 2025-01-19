using System.IO;
using System.Xml;
using System.Threading.Tasks;

namespace CoreSolutions.Validation.Contracts
{
    /// <summary>
    /// Defines the contract for a strategy that processes and validates XML documents
    /// </summary>
    public interface IXmlDocumentValidationStrategy
    {
        /// <summary>
        /// Determines whether the strategy can process the provided XML document stream
        /// </summary>
        /// <param name="xmlDocumentStream">The stream containing the XML document to check</param>
        /// <returns>True if the strategy can process the document; otherwise, false</returns>
        public bool CanProcess(Stream xmlDocumentStream);

        /// <summary>
        /// Processes and validates the provided XML document stream asynchronously using the specified XML reader settings
        /// </summary>
        /// <param name="xmlDocumentStream">The stream containing the XML document to validate</param>
        /// <param name="xmlReaderSettings">The XML reader settings to be used during validation</param>
        /// <returns>A task representing the asynchronous operation</returns>
        public Task ProcessAsync(Stream xmlDocumentStream, XmlReaderSettings xmlReaderSettings);
    }
}
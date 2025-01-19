using System;
using System.Xml;
using System.Xml.Schema;
using System.Threading.Tasks;

namespace CoreSolutions.Validation.Contracts
{
    /// <summary>
    /// Defines the contract for a service that creates XML validation settings asynchronously,
    /// using a specific validation strategy and event arguments type
    /// </summary>
    /// <typeparam name="TStrategy">The type of the XML document validation strategy</typeparam>
    /// <typeparam name="TEventArgs">The type of the event arguments used for validation events</typeparam>
    public interface IValidationXmlSettingProvider<out TStrategy, TEventArgs>
        where TEventArgs : ValidationEventArgs
        where TStrategy : IXmlDocumentValidationStrategy
    {
        /// <summary>
        /// Creates XML reader settings for validation asynchronously, using the specified source XML document path and event handler
        /// </summary>
        /// <param name="sourceXmlDocumentPath">The path to the source XML document to validate</param>
        /// <param name="eventHandler">An event handler to handle validation events</param>
        /// <returns>A task that represents the asynchronous operation, with the result being the created <see cref="XmlReaderSettings"/></returns>
        public Task<XmlReaderSettings> CreateValidationSettingsAsync(string sourceXmlDocumentPath, Action<object, TEventArgs> eventHandler);
    }
}
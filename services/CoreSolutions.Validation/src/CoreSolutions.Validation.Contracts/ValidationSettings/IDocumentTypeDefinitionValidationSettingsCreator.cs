using System;
using System.Xml;
using System.Xml.Schema;

namespace CoreSolutions.Validation.Contracts
{
    /// <summary>
    /// Defines the contract for a service that creates validation settings for Document Type Definition (DTD) validation.
    /// This interface extends <see cref="IXmlValidationSettingsCreator"/>.
    /// </summary>
    public interface IDocumentTypeDefinitionValidationSettingsCreator : IXmlValidationSettingsCreator
    {
        /// <summary>
        /// Creates XML reader settings for validating a Document Type Definition (DTD) with the specified URL resolver and event handler
        /// </summary>
        /// <param name="xmlUrlResolver">The XML URL resolver used to resolve external entities referenced in the DTD</param>
        /// <param name="eventHandler">An event handler to handle validation events during the validation process</param>
        /// <returns>XML reader settings configured for DTD validation</returns>
        public XmlReaderSettings CreateValidationSettings(XmlUrlResolver xmlUrlResolver, Action<object, ValidationEventArgs> eventHandler);
    }
}
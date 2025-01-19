using System;
using System.Xml;
using System.Xml.Schema;

namespace CoreSolutions.Validation.Contracts
{
    /// <summary>
    /// Defines the contract for a service that creates XML schema validation settings.
    /// This interface extends <see cref="IXmlValidationSettingsCreator"/>.
    /// </summary>
    public interface IXmlSchemaValidationSettingsCreator : IXmlValidationSettingsCreator
    {

        /// <summary>
        /// Creates XML reader settings for validating an XML document against a set of XML schemes
        /// </summary>
        /// <param name="schemaSet">The XML schema set containing the schemes used for validation</param>
        /// <param name="eventHandler">An event handler to handle validation events, such as warnings or errors</param>
        /// <returns>XML reader settings configured for schema validation</returns>
        public XmlReaderSettings CreateValidationSettings(XmlSchemaSet schemaSet, Action<object, ValidationEventArgs> eventHandler);
    }
}
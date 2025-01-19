namespace CoreSolutions.Validation.Contracts
{
    /// <summary>
    /// Defines the contract for a service that provides external XML schema resources from Azure.
    /// This interface extends both <see cref="IAzureExternalXmlResourceProvider"/> and <see cref="IExternalXmlSchemaProvider"/>.
    /// </summary>
    public interface IAzureExternalXmlSchemaProvider : IAzureExternalXmlResourceProvider, IExternalXmlSchemaProvider 
    { }
}
namespace CoreSolutions.Validation.Contracts
{
    /// <summary>
    /// Defines the contract for a service that provides external Document Type Definition (DTD) resources from Azure.
    /// This interface extends both <see cref="IAzureExternalXmlResourceProvider"/> and <see cref="IExternalDocumentTypeDefinitionProvider"/>.
    /// </summary>
    public interface IAzureExternalDocumentTypeDefinitionProvider : IAzureExternalXmlResourceProvider, IExternalDocumentTypeDefinitionProvider 
    { }
}
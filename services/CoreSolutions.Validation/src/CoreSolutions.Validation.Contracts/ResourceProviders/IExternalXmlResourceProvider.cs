using System.IO;
using System.Threading.Tasks;

namespace CoreSolutions.Validation.Contracts
{
    /// <summary>
    /// Defines the contract for a service that provides external XML resources
    /// </summary>
    public interface IExternalXmlResourceProvider
    {
        /// <summary>
        /// Checks if the specified XML resource exists asynchronously
        /// </summary>
        /// <param name="sourceXmlResourcePath">The path to the XML resource</param>
        /// <returns>A task representing the asynchronous operation, with a boolean result indicating if the resource exists</returns>
        public Task<bool> ExistsAsync(string sourceXmlResourcePath);

        /// <summary>
        /// Provides the specified XML resource as a stream asynchronously
        /// </summary>
        /// <param name="sourceXmlResourcePath">The path to the XML resource</param>
        /// <returns>A task representing the asynchronous operation, with a result of a stream containing the XML resource</returns>
        public Task<Stream> ProvideResourceAsync(string sourceXmlResourcePath);
    }
}
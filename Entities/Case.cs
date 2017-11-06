using WorkflowServer.Foundation.DocumentServices;
using Entities.Interfaces;

namespace Entities
{
    public partial class Case : ICase
    {
        public string Promote()
        {
            var caseDocumentService = DocumentServiceFactory.Get<ICaseDocumentService>(this);
            return caseDocumentService.Promote();
        }
    }
}

using Entities.Interfaces;
using WorkflowServer.Foundation.DocumentServices;

namespace Entities.Services
{
    public class CaseDocumentService : DocumentServiceBase<ICase>, ICaseDocumentService
    {
        public CaseDocumentService(ICase document) : base(document)
        {}

        public string Promote()
        {            
            return Document.ID;
        }
    }
}

using DocumentServices.Services;

namespace DocumentServices.Entities
{
    public partial class Case
    {
        public string Promote()
        {
            var caseDocumentService = DocumentServiceFactory.GetDocumentService<ICaseDocumentService, ICase>(this);
            return caseDocumentService.Promote();
        }
    }
}

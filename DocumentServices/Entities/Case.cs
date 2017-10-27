using DocumentServices.Services;

namespace DocumentServices.Entities
{
    public partial class Case
    {
        public string Promote()
        {
            var caseDocumentService = DocumentServiceFactory.GetDocumentService<ICaseDocumentService>(this);
            return caseDocumentService.Promote();
        }
    }
}

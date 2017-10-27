using DocumentServices.Services;

namespace DocumentServices.Entities
{
    public partial class Case
    {
        public string Promote()
        {
            var caseDocumentService = DocumentServiceFactory.Get<ICaseDocumentService>(this);
            return caseDocumentService.Promote();
        }
    }
}

using DocumentServices.Entities;
using DocumentServices.Services;

namespace DocumentServices
{
    public static class DocumentServiceFactory
    {
        public static TDocumentService GetDocumentService<TDocumentService>(IDocument document) where TDocumentService : IDocumentService
        {
            var ds = new CaseDocumentService((ICase)document);
            var idc = (IDocumentService)ds;
            return (TDocumentService)idc;
        }
    }
}

using DocumentServices.Entities;
using DocumentServices.Services;

namespace DocumentServices
{
    public static class DocumentServiceFactory
    {
        public static TDocumentService GetDocumentService<TDocumentService, TDocument>(TDocument document) 
            where TDocumentService : IDocumentService<TDocument> where TDocument : IDocument
        {
            var ds = new CaseDocumentService((ICase)document);
            var idc = (ICaseDocumentService)ds;
            return (TDocumentService)idc;
        }
    }
}

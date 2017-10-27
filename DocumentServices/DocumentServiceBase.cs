namespace DocumentServices
{
    public abstract class DocumentServiceBase<TDocument> : IDocumentService<TDocument> where TDocument : IDocument
    {
        public TDocument Document { get; set; }

        public DocumentServiceBase(TDocument document)
        {
            Document = document;
        }
    }

}

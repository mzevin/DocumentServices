namespace DocumentServices
{
    public interface IDocumentService { }

    public interface IDocumentService<TDocument> : IDocumentService where TDocument : IDocument
    {
    }
}

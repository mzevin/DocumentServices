namespace WorkflowServer.Foundation.DocumentServices
{
    public interface IDocumentService { }

    public interface IDocumentService<TDocument> : IDocumentService where TDocument : IDocument
    {
    }
}

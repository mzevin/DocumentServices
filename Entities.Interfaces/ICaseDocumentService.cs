using WorkflowServer.Foundation.DocumentServices;

namespace Entities.Interfaces
{
    public interface ICaseDocumentService : IDocumentService<ICase>
    {
        string Promote();
    }

}

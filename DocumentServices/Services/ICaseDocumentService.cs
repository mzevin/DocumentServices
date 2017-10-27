using DocumentServices.Entities;

namespace DocumentServices.Services
{
    public interface ICaseDocumentService : IDocumentService<ICase>
    {
        string Promote();
    }

}

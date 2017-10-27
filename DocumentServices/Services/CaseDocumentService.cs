using DocumentServices.Entities;
using System;

namespace DocumentServices.Services
{
    public class CaseDocumentService : DocumentServiceBase<ICase>, ICaseDocumentService
    {
        public CaseDocumentService(ICase document) : base(document)
        {}

        public string Promote()
        {            
            return Document.ID;
        }
    }
}

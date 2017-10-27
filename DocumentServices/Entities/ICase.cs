using System;

namespace DocumentServices.Entities
{
    public interface ICase : IDocument
    {
        DateTime? DateOfService { get; set; }
        string EnteredBy { get; set; }
        DateTime? EnteredDate { get; set; }
    }
}

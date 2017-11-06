using System;
using WorkflowServer.Foundation.DocumentServices;

namespace Entities.Interfaces
{
    public interface ICase : IDocument
    {
        DateTime? DateOfService { get; set; }
        string EnteredBy { get; set; }
        DateTime? EnteredDate { get; set; }
    }
}

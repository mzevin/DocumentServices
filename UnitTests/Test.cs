using Entities;
using NUnit.Framework;
using WorkflowServer.Foundation.DocumentServices;
using Entities.Interfaces;
using Entities.Services;

namespace UnitTests
{
    [TestFixture]
    public class Test
    {
        public Test()
        {
            var t = typeof(CaseDocumentService);
        }

        [Test]
        public void TestServiceFactory()
        {
            const string CASE_ID = "ABC";
            var caseDoc = new Case { ID = CASE_ID };

            // Direct service call
            var service = DocumentServiceFactory.Get<ICaseDocumentService>(caseDoc);
            Assert.IsNotNull(service);
            var id1 = service.Promote();
            Assert.AreEqual(CASE_ID, id1);

            // Call service using existing method that is defined on Case document
            var id2 = caseDoc.Promote();
            Assert.AreEqual(id1, id2);
        }
    }
}

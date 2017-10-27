using NUnit.Framework;
using DocumentServices.Services;
using DocumentServices.Entities;

namespace DocumentServices
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestServiceFactory()
        {
            const string CASE_ID = "ABC";
            var caseDoc = new Case { ID = CASE_ID };

            var service = DocumentServiceFactory.GetDocumentService<ICaseDocumentService, ICase>(caseDoc);
            Assert.IsNotNull(service);
            var id1 = service.Promote();
            Assert.AreEqual(CASE_ID, id1);
            var id2 = caseDoc.Promote();
            Assert.AreEqual(id1, id2);
        }
    }
}

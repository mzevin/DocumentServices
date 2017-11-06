using System;

namespace WorkflowServer.Foundation.DocumentServices
{
    public static class DocumentServiceFactory
    {
        public static TDocumentService Get<TDocumentService>(IDocument document) where TDocumentService : IDocumentService
        {
            var type = GetServiceImplementationType(typeof(TDocumentService));
            if (type != null)
                return (TDocumentService)InstanciateService(type, document);

            var msg = string.Format("Unable to find {0} implementation", typeof(TDocumentService));
            throw new Exception(msg);
        }

        private static Type GetServiceImplementationType(Type requestedInterface)
        {
            foreach(var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    try
                    {
                        foreach (var type in assembly.GetTypes())
                            if (type.IsClass &&  !type.IsAbstract && requestedInterface.IsAssignableFrom(type)) return type;
                    }
                    catch(Exception e)
                    {
                        continue;
                    }
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
            return null;
        }

        private static object InstanciateService(Type serviceType, IDocument document)
        {
            var documentType = document.GetType();
            foreach (var ctor in serviceType.GetConstructors())
            {
                var prms = ctor.GetParameters();
                if (prms.Length == 1 && prms[0].ParameterType.IsAssignableFrom(documentType))
                    return ctor.Invoke(new object[] { document });
            }
            return null;
        }
    }
}

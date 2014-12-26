using Kooboo.CMS.Common.Runtime;
using Kooboo.CMS.Common.Runtime.Dependency;

namespace syberside.Kooboo.CMS.Content.UserKeyGenerator.Unicode
{
    public class AssemblyRegistrer : IDependencyRegistrar
    {
        public void Register(IContainerManager containerManager, ITypeFinder typeFinder)
        {
            global::Kooboo.CMS.Content.Models.UserKeyGenerator.DefaultGenerator =
                new UserKeyGenerator();
        }

        public int Order
        {
            get { return 100; }
        }
    }
}
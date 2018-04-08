using DIInterface;
using DataInList;
using Unity;
using DataInArray;

namespace DIResolver
{
    public static class IoCInjection
    {
        public static IPickDataSource ConfigurUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IPickDataSource, ListData>();
            ArrayData DList = container.Resolve<ArrayData>();
            return DList;
        }

       
    }
}

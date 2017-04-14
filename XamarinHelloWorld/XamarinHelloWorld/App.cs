using XamarinHelloWorld.Helpers;
using XamarinHelloWorld.Interfaces;
using XamarinHelloWorld.Services;
using XamarinHelloWorld.Model;

namespace XamarinHelloWorld
{
    public partial class App
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}
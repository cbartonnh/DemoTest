using Prism.Unity;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using DemoTest.Views;

namespace DemoTest
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {

        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
        }

        protected override void OnStart()
        {
            MobileCenter.Start("20d16c23-31ff-4862-8293-04c7f758e83b;",
                   typeof(Analytics), typeof(Crashes));
        }
    }
}

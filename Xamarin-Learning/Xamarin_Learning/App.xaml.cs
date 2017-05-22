using Xamarin_Learning.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Learning.Sidebar;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamarin_Learning
{
    public partial class App : Application
    {
        public NavigationPage NavigationPage { get; private set; }
        public App()
        {
            InitializeComponent();
            var rootPage = new RootPage();
            MainPage = rootPage;
        }

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_Learning.ViewModels.Sidebar;
using Xamarin_Learning.Views;

namespace Xamarin_Learning.Sidebar
{
 public   class RootPage:MasterDetailPage
    {
        MenuPage menuPage;
        public RootPage()
        {
           
            MasterBehavior = MasterBehavior.Popover;
            menuPage = new MenuPage();
            Master = menuPage;
            Detail = new NavigationPage(new RegistrationPage());
            menuPage.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            Type page = item.TargetType;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(page)); 
                //menuPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}

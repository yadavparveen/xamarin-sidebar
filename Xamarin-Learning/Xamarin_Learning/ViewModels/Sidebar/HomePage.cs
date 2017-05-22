using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Learning.Sidebar
{
   public class HomePage :ContentPage
    {
        public HomePage()
        {
            
            var stacklayout = new StackLayout
            {
                Children =
                {
                    new Label {Text="Welcome Xamarin" }
                }
            };

            this.Content = stacklayout;
                
        }
    }
}

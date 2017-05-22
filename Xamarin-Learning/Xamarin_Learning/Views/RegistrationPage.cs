using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_Learning.Sidebar;
using Xamarin_Learning.ViewModels;

namespace Xamarin_Learning.Views
{
  public  class RegistrationPage: CustomView
    {
        public NavigationPage navigationPage { get; private set; }
        public RegistrationPage()
        {
            RenderUI();
        }
        public override void RenderUI()
        {
            var btnSignUp = new Button { Text = "Sign Up" };
            btnSignUp.Clicked += Register;
            var stackLayout = new StackLayout
            {
                Children =
                {
                   
                    new Entry {Placeholder="Enter your first name",Keyboard= Keyboard.Create(KeyboardFlags.All) },
                    new Entry {Placeholder="Enter your last name",Text="" },
                    new Entry {Placeholder="Enter your Password",IsPassword=true },
                    new Entry {Placeholder="Enter confirm Password",IsPassword=true },
                    new Entry {Placeholder="Enter your Email",IsPassword=true },
                   btnSignUp
                }
            };

            this.Content = stackLayout;
        }

        private void Register(object sender,EventArgs e)
        {

        }

    }

    
}

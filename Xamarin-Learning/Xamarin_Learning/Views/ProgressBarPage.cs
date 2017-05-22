using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Learning.Views
{
    public class ProgressBarPage : ContentPage
    {
        public ProgressBarPage()
        {
            Content = new StackLayout
            {
                
                Children = {
                    new Label { Text = "Progress Bar Example" },
                    new ProgressBar {VerticalOptions=LayoutOptions.Center },
                    new DatePicker {MinimumDate=DateTime.Now.AddYears(-5),MaximumDate=DateTime.Now.AddYears(2) }
                }
            };
           
            this.Content = Content;
        }
    }
}

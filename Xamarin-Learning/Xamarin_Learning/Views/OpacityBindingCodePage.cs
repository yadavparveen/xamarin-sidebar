using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Learning.Views
{
    public class OpacityBindingCodePage : ContentPage
    {
        public OpacityBindingCodePage()
        {
            var label = new Label
            {
                Text = "Opacity demo binding",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center,
            };

            var slider = new Slider
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };


            Content = new StackLayout
            {
                Children = {
                   label,
                   slider
                }
            };
            label.BindingContext = slider;

            /// Bind the properties: target is Opacity; source is Value.
            label.SetBinding(Label.OpacityProperty, "Value");
            Padding = new Thickness(10, 0);
            this.Content = Content;
        }
    }
}

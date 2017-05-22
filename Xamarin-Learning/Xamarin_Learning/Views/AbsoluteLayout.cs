using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Learning.Views
{
    public class AbsoluteLayouts : ContentPage
    {
        public AbsoluteLayouts()
        {

            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                Padding = new Thickness(50)
            };

            absoluteLayout.Children.Add(
               new BoxView
               {
                   Color=Color.Accent
               },
               new Rectangle(0,10,200,5)
               );

            absoluteLayout.Children.Add(
              new BoxView
              {
                  Color = Color.Accent
              },
              new Rectangle(0, 20, 200, 5)
              );

            absoluteLayout.Children.Add(
              new BoxView
              {
                  Color = Color.Accent
              },
              new Rectangle(10, 0, 5, 65)
              );

            absoluteLayout.Children.Add(
              new BoxView
              {
                  Color = Color.Accent
              },
              new Rectangle(20, 0, 5, 65)
              );


            absoluteLayout.Children.Add(
              new Label
              {
                  Text = "Label1"
              },
                new Point( 30, 25)
              );

            this.Content = absoluteLayout;
        }
    }
}

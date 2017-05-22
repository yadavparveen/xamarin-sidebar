using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_Learning.ViewModels;
using Xamarin_Learning.ViewModels.Sidebar;
using Xamarin_Learning.Views;

namespace Xamarin_Learning.Sidebar
{
  public  class MenuPage: ContentPage
    {
        public ListView ListView { get { return listView; } }
        ListView listView;
        public MenuPage()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contacts",
                IconSource = "contacts.png",
                TargetType = typeof(RegistrationPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                IconSource = "todo.png",
                TargetType = typeof(ProgressBarPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Reminders",
                IconSource = "reminders.png",
                TargetType = typeof(AbsoluteLayouts)
            });

            listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() => {
                    var imageCell = new ImageCell();
                    imageCell.SetBinding(TextCell.TextProperty, "Title");
                  //  imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                    return imageCell;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };

            Padding = new Thickness(0, 40, 0, 0);
            Icon = "hamburger.png";
            Title = "Personal Organiser";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                listView
            }};

        }

        private void NavigateA_AbsoulatePage(object sender,EventArgs eve)
        {
            Navigation.PushModalAsync(new AbsoluteLayouts());
            
        }

        private void Navigate_RegistrationPage(object sender, EventArgs eve)
        {
            
            //Navigation.PushModalAsync(new RegistrationPage());

        }

        private void Navigate_APICallage(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new APICall());
        }
        private void Navigate_Calanderage(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CalanderPage());
        }

        private void RenderUI()
        {
            var btnAbsoulate = new Button
            {
                Text = "Absolute Layout"
                ,BackgroundColor=Color.Transparent
            };

            var btnRegistartion = new Button
            {
                Text = "Registration",
                BackgroundColor = Color.Transparent
            };

            var btnAPICall = new Button
            {
                Text = "API Call",
                BackgroundColor = Color.Transparent
            };

            var btnCalander = new Button
            {
                Text = "Calander",
                BackgroundColor = Color.Transparent
            };

            btnAbsoulate.Clicked += NavigateA_AbsoulatePage;
            btnRegistartion.Clicked += Navigate_RegistrationPage;
            btnAPICall.Clicked += Navigate_APICallage;
            btnCalander.Clicked += Navigate_Calanderage;

            var stacklayout = new StackLayout
            {
                Children =
                {

                   new Frame
                   {
                       Content=btnAbsoulate
                   },
                    new Frame
                   {
                       Content=new Label {Text="Absolute Layout" }
                   },
                     new Frame
                   {
                       Content=new Label {Text="Progress Bar" }
                   },
                      new Frame
                   {
                       Content=btnRegistartion
                   },
                      new Frame
                      {
                          Content=btnAPICall
                      },
                      new Frame
                      {
                          Content=btnCalander
                      }
                      
                },
                BackgroundColor = Color.AliceBlue
            };

            Padding = new Thickness(0, 25, 0, 0);

            this.Content = stacklayout;
        }



    }
}

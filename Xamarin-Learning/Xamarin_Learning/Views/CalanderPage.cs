using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;
using Xamarin_Learning.Views.Calander;
using XamForms.Controls;

namespace Xamarin_Learning.Views
{
    public class CalanderPage : ContentPage
    {
        Calendar calendar;
        CalendarVM _vm;
        public CalanderPage()
        {
            var embeddedImage = new Image { Aspect = Aspect.AspectFit };
            embeddedImage.Source = ImageSource.FromResource("WorkingWithImages.beach.jpg");
            calendar = new Calendar
            {
                //MaxDate = DateTime.Now.AddDays(30),
                // MinDate = DateTime.Now.AddDays(-1),
                //  DisableDatesLimitToMaxMinRange = true,
                MultiSelectDates = false,
                DisableAllDates = false,
                IsEnabled = true,
                WeekdaysShow = true,
                ShowNumberOfWeek = true,
                ShowNumOfMonths = 1,
                EnableTitleMonthYearView = true,
                SelectedDate = DateTime.Now,
                WeekdaysTextColor = Color.Black,
                StartDay = DayOfWeek.Monday,
                SelectedTextColor = Color.Fuchsia,
                BorderWidth = 0,
                // HeightRequest=3500,
                //  WidthRequest=3500,
                SpecialDates = new List<SpecialDate>{

                     new SpecialDate(DateTime.Now.AddDays(2))
                    {
                         //BackgroundColor = Color.Red,
                         Selectable = true,
                         //BackgroundImage="slideout.png" ///uncomment this for underline image

            //BackgroundPattern = new BackgroundPattern(1)
            //{

            //   Pattern = new List<Pattern>
            //        {
            //            new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Transparent},
            //            new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Transparent},
            //            new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Transparent},
            //           new Pattern{ WidthPercent = 0.1f, HightPercent = 0.25f, Color = Color.Red},
            //            new Pattern{  WidthPercent = 5f, HightPercent = 0.1f,Color = Color.Yellow}
            //        }
            //}
        },
                    new SpecialDate(DateTime.Now.AddDays(3))
                    {
                        BackgroundColor = Color.Orange,
                        //TextColor = Color.Blue,
                        
                        Selectable = true,
                        BackgroundPattern = new BackgroundPattern(1)
                        {

                            Pattern = new List<Pattern>
                            {
                                new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Transparent},
                                new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Transparent},
                                new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Transparent},
                                new Pattern{ WidthPercent = 0.1f, HightPercent = 0.25f, Color = Color.Red}
                            },
                        }
                    },
                    new SpecialDate(DateTime.Now.AddDays(4))
                    {
                        // BackgroundColor = Color.Transparent,
                         Selectable = true,
                         TextColor=Color.Orange,
                        BackgroundPattern = new BackgroundPattern(1)
                        {
                            
                           Pattern = new List<Pattern>
                                {
                                    new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Transparent},
                                    new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Transparent},
                                    new Pattern{ WidthPercent = 1f, HightPercent = 0.25f, Color = Color.Transparent},
                                    new Pattern{ WidthPercent = 0.1f, HightPercent = 1f, Color = Color.Red},
                                }
                        }
                    }
                }
            };

            calendar.DateClicked += (sender, e) => {
                System.Diagnostics.Debug.WriteLine(calendar.SelectedDates);
            };
            //_vm = new CalendarVM();
            //var c2 = new CalendarXamlView();
           // calendar.SetBinding(Calendar.DateCommandProperty, nameof(_vm.DateChosen));
           // calendar.SetBinding(Calendar.SpecialDatesProperty, nameof(_vm.Attendances));
           // c2.BindingContext = _vm;

            // The root page of your application
            var page= new StackLayout
            {
                BackgroundColor = Color.White,
               
                Children =
                {
                     new ScrollView
                     {
                        
                        Content = new StackLayout
                        {
                           
                            Padding = new Thickness(5, Device.RuntimePlatform == Device.iOS ? 25 : 5, 5, 5),
                            Children = {
                                calendar//,c2
                               
                            },
                        }
                     }
                }
            };

            this.Content = page;
        }
    }
}

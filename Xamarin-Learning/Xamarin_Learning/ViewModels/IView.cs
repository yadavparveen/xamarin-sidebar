using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Learning.ViewModels
{
   public abstract class CustomView: ContentPage
    {
        public abstract void RenderUI();
    }
}

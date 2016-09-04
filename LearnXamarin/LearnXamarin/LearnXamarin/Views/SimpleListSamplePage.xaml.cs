using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LearnXamarin.Views
{
    public partial class SimpleSamplePage : ContentPage
    {
        ViewModels.SimpleListSamplePageViewModel ViewModel;
        public SimpleSamplePage()
        {
            InitializeComponent();
            this.ViewModel = new ViewModels.SimpleListSamplePageViewModel();
            BindingContext = ViewModel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BlogspotXamarin.Views
{
    public partial class ArticlePage : ContentPage
    {
        ViewModels.ArticlePageViewModel ViewModel;

        public ArticlePage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new ViewModels.ArticlePageViewModel();
        }

        private void OnWebNavigated(object sender, WebNavigatedEventArgs e)
        {
            WaitingGrid.IsVisible = false;
            WebView.IsVisible = true;
        }
    }
}

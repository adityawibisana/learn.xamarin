using BlogspotXamarin.ViewModels;
using System;
using Xamarin.Forms;

namespace BlogspotXamarin.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel ViewModel;

        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<MainPageViewModel>(this, Constants.Constant.NO_INTERNET, async (sender) =>
            {
                await DisplayAlert("No Internet", Constants.Constant.RELOAD_MESSAGE, "OK");
                ViewModel.UpdateFeed();
            });

            ViewModel = new MainPageViewModel();
            BindingContext = ViewModel;
        } 

        private void OnItemTapped(Object sender, ItemTappedEventArgs e)
        {    
            ViewModel.OnItemTapped(e); 
            Navigation.PushModalAsync(new ArticlePage()); 
        }
    }
}

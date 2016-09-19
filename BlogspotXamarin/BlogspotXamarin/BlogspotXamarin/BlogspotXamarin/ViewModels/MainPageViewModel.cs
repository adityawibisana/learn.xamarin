using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using FeedParserPCL;
using BlogspotXamarin.Services;

namespace BlogspotXamarin.ViewModels
{
	public class MainPageViewModel : INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;
		public ObservableCollection<Item> FeedList { get; set; }
        private RSSService _rssService;

        public MainPageViewModel()
        { 
			UpdateFeed();
        }

		private async void UpdateFeed()
		{
            _rssService = RSSService.Instance;

			FeedParser parser = new FeedParser();
			var items = await parser.Parse(new Uri("http://aditya-wibisana.blogspot.com/feeds/posts/default?alt=rss"), FeedType.Rss);
            
			FeedList = new ObservableCollection<Item>();
			foreach (Item item in items)
			{
				FeedList.Add(item);
			}

			OnPropertyChanged("FeedList");
		} 

        public void OnItemTapped(Xamarin.Forms.ItemTappedEventArgs e)
        {
            Item item = e.Item as Item;
            _rssService.Link = item.Link;
        }


		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}

            
		}


    }
}

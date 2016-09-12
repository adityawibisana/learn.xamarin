using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using FeedParserPCL;

namespace BlogspotXamarin.ViewModels
{
	public class MainPageViewModel : INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;
		public ObservableCollection<Item> FeedList { get; set; }
        public MainPageViewModel()
        { 
			UpdateFeed();
        }

		private async void UpdateFeed()
		{
			FeedParser parser = new FeedParser();
			var items = await parser.Parse(new Uri("http://aditya-wibisana.blogspot.com/feeds/posts/default?alt=rss"), FeedType.Rss);

			FeedList = new ObservableCollection<Item>();
			foreach (Item item in items)
			{
				FeedList.Add(item);
			}

			OnPropertyChanged("FeedList");
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

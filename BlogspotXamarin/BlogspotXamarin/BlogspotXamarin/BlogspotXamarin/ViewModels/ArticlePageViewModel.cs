using BlogspotXamarin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogspotXamarin.ViewModels
{
    public class ArticlePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        RSSService _rssService;
    
        private String _link;
        public String Link
        {
            get
            {
                return _link;
            }
            set
            {
                if (!value.EndsWith("?m=1"))
                {
                    value = value + "?m=1";
                }
                _link = value;
                OnPropertyChanged("Link");
            }
        }

        public ArticlePageViewModel()
        {
            _rssService = RSSService.Instance;
            Link = _rssService.Link;
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

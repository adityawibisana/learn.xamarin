using System;	
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FeedParserPCL
{
        /// <summary>
        /// Represents a feed item.
        /// </summary>
        public class Item
        {
		    public string Link { get; set; }
		    public string Title { get; set; }

            private string _content;
		    public string Content
            {
                get
                {
                    return _content;
                }
                set
                {
                    _content = value;
					if (String.IsNullOrEmpty(_content))
						return;
                    ShortContent = HtmlRemoval.StripTagsRegex(_content);
                    ShortContent = ShortContent.Length > 50 ? ShortContent.Substring(0, 50) + "..." : ShortContent;
					ImageLink = Regex.Match(_content, "<img.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
                }
            }
		    public DateTime PublishDate { get; set; }
		    public FeedType FeedType { get; set; }
            public string ShortContent { get; set; }
            public string ImageLink { get; set; }

		    public Item()
		    {
			    Link = string.Empty;
			    Title = string.Empty;
			    Content = string.Empty;
			    PublishDate = DateTime.Today;
			    FeedType = FeedType.Rss;
		    }
        }
}

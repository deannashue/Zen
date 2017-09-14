using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Model
{

    public class VideoClip
    {

        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailImage { get; set; }
        public string OwnerName { get; set; }
        public string ClipLength { get; set; }
        public string Plays { get; set; }
        public string Rank { get; set; }

        public VideoClip(string title)
        {

            Title = title;
            Url = "colorado_rain.jpg";
            ThumbnailImage = "bigzenlogo.png";
            OwnerName = "Deanna Shue";
            ClipLength = "12";
            Plays = "5,124";
            Rank = "52";

        }

    }


}

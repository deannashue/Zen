using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Zen.Model;


namespace Zen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayClip : ContentPage
    {
        private int clickCount = 0;

        public PlayClip(VideoClip ClipToPlay)
        {
            InitializeComponent();
        }

        public PlayClip()
        {

            InitializeComponent();
            //CrossMediaManager.Current.Play("https://archive.org/download/BigBuckBunny_328/BigBuckBunny_512kb.mp4", MediaFileType.Video);

        }

        async private void VideoPlayer_Failed(object sender, Octane.Xam.VideoPlayer.Events.VideoPlayerErrorEventArgs e)
        {
            await DisplayAlert("video fail", "Video did not load", "cancle");

        }

        async private void VideoPlayer_Playing(object sender, Octane.Xam.VideoPlayer.Events.VideoPlayerEventArgs e)
        {
            await DisplayAlert("video playing", "Video playing", "cancle");
        }

        async private void VideoPlayer_Paused(object sender, Octane.Xam.VideoPlayer.Events.VideoPlayerEventArgs e)
        {
            await DisplayAlert("video paused", "Video paused", "cancle");
        }
    }
}
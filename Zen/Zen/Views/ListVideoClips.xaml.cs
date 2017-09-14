using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Zen.Model;

namespace Zen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListVideoClips : ContentPage
    {
        public ObservableCollection<VideoClip> Items { get; set; }

        public ListVideoClips()
        {
            InitializeComponent();

            Items = new ObservableCollection<VideoClip>
            {
                new VideoClip("One"),
                new VideoClip("Two"),
                new VideoClip("Three"),
                new VideoClip("Four"),
                new VideoClip("Five"),
                new VideoClip("six"),
                new VideoClip("seven"),
                new VideoClip("eight")

            };

            BindingContext = this;
        }

        async void Handle_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;



            //await DisplayAlert("Item Tapped", e.SelectedItem.GetType().ToString(), "OK");
            await Navigation.PushAsync(new Zen.Views.PlayClip((VideoClip)e.SelectedItem));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
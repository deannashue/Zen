using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace Zen.Views
{



    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Guest : ContentPage
    {


        public class GuestCarouselItem
        {
            public string ImageUrl { get; set; }
            public string Theme { get; set; }
            public int Position { get; set; }
        }

        public ObservableCollection<GuestCarouselItem> GuestCarousel { get; set; }
        public GuestCarouselItem CurrentGCItem;



        public Guest()
        {
           

            GuestCarousel = new ObservableCollection<GuestCarouselItem>
            {
                new GuestCarouselItem
                {
                    ImageUrl = "atlantic.jpg",
                    Theme = "Atlantic Morning",
                    Position = 0
                },
                new GuestCarouselItem
                {
                    ImageUrl = "colorado.jpg",
                    Theme = "Colorado Meadow",
                    Position = 1
                    },
                new GuestCarouselItem
                {
                    ImageUrl = "danube.jpg",
                    Theme = "Danube",
                    Position = 2
                }
            };

            InitializeComponent();
            BindingContext = this;




        }

        async private void DoSkip(object sender, EventArgs e)
        {
            //DisplayAlert("Skipped", "You want to skip!: " + s, "Cancel");
            await Navigation.PushAsync(new Zen.Views.ListVideoClips());
        }
    }


}
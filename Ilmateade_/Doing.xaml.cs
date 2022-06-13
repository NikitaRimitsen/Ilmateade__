using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ilmateade_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Doing : ContentPage
    {
        Grid grid2x1;
        Button kto_sdelal, knopka;
        Image kartinka;
        public Doing()
        {
            InitializeComponent();
            grid2x1 = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.DarkGray,
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                }
            };
            kto_sdelal = new Button()
            {
                Text = "Arendajad"
            };
            kto_sdelal.Clicked += Kto_sdelal_Clicked;
            knopka = new Button()
            {
                Text = "Ilmateate veebisait"
            };
            knopka.Clicked += Knopka_Clicked;
            kartinka = new Image()
            {
                Source = "solnceizobl.png",
                BackgroundColor = Color.LightCyan
            };
            StackLayout knopki = new StackLayout
            {
                Children = { kto_sdelal, knopka }
            };
            grid2x1.Children.Add(kartinka, 0, 0);
            grid2x1.Children.Add(knopki, 0, 1);
            Content = grid2x1;
        }

        private void Kto_sdelal_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Areng", "Arendaja - Nikita Rimitsen\n Disainer - Nikita Rimitsen\n Testija - Nikita Rimitsen", "Okei");
        }

        private async void Knopka_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://pogoda.ee/");
            await Browser.OpenAsync(uri);
        }
    }
}
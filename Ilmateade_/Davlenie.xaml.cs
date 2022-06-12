using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ilmateade_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Davlenie : ContentPage
    {
        int i = 0;
        public Davlenie()
        {
            /*Label text = new Label
            {
                Text = "Õhurõhk",
                HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center,
                FontSize = 30,
                TextColor = Color.White
            };
            this.Content = new StackLayout { Children = { text } };
            this.BackgroundColor = Color.SteelBlue;//LightSteelBlue -- можно исопользовать для светлого оформления*/
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            /*if (Binding.Zapomnit = 1)
            {
                var apple = from s in base.Table<PeamineBase>()
                            where s.Symbol.StartsWith("A")
                            select s;
            }*/
            ListViewi.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
    }
}
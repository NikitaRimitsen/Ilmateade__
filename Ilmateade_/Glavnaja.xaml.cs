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
    public partial class Glavnaja : ContentPage
    {
        public ListView ListView;
        public Glavnaja()
        {
            ListView = new ListView();
            ListView.ItemsSource = App.Database.GetItems();
            Label text = new Label
            {
                Text = "Ilmateade",
                HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center,
                FontSize = 30,
                TextColor = Color.White
            };
            this.Content = new StackLayout { Children = { text,ListView } };
            this.BackgroundColor = Color.SteelBlue;//LightSteelBlue -- можно исопользовать для светлого оформления
        }
    }
}
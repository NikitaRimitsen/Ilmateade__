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
    public partial class Vlaznost : ContentPage
    {
        int i = 0;
        public Vlaznost()
        {
            /*Label text = new Label
            {
                Text = "Õhuniiskus",
                HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center,
                FontSize = 30,
                TextColor = Color.White
            };
            this.Content = new StackLayout { Children = { text } };
            this.BackgroundColor = Color.SteelBlue;//LightSteelBlue -- можно исопользовать для светлого оформления*/
            InitializeComponent();
        }

        public string Niiskus { get; private set; }//ne uveren cto budet rabotat

        private void entry_Completed(object sender, EventArgs e)
        {
            ListView.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
            if (Niiskus == "da" )
            {

            }
        }
    }
}
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
        string okmaa = "";
        int j;
        int a = 1;
        public Glavnaja()
        {
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
            ListView.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private void Entry_Completed(object sender, EventArgs e)
        {


            /*okmaa = entry.Text;
            if (okmaa == Riik)
            {

            }*/
            /*a = 1;
            int c = 0;
            for (int i = 0; i < PeamineBase.Length; i++)
            {
                for (j = 0; j < votetonado.Length; j++)
                {
                    if (okmaa =  Binding.Riik)
                    {

                    }
                }
            }
            if (okmaa == "")
            {
                DisplayAlert("Tähelepanu", "Sellist maakonda pole, kontrollige, kas olete Maakonna õigesti kirjutanud", "Hästi");
            }*/
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Select 
            Kartinka.Source = ImageSource.FromFile("iconkap.png");
        }
    }
}
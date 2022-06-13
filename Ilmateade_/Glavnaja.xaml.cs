using SQLite;
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
        SQLiteConnection database;

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

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PeamineBase peamineBase = (PeamineBase)((ListView)sender).SelectedItem;
            await Navigation.PushAsync(new Detaila(peamineBase));
        }

        public IEnumerable<PeamineBase> Riik()
        {
            return database.Table<PeamineBase>().ToList();
        }
    }
}
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
    public partial class Uuedimateade : ContentPage
    {
        public Uuedimateade()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            peaminebaseList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void peaminebaseList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PeamineBase selecteBase = (PeamineBase)e.SelectedItem;
            DBPeaminePage peaminePage = new DBPeaminePage();
            peaminePage.BindingContext = selecteBase;
            await Navigation.PushAsync(peaminePage);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            PeamineBase peamine = new PeamineBase();
            DBPeaminePage peaminePage = new DBPeaminePage();
            peaminePage.BindingContext = peamine;
            await Navigation.PushAsync(peaminePage);
        }
    }
}
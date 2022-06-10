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
    public partial class DBPeaminePage : ContentPage
    {
        public DBPeaminePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var peamine = (PeamineBase)BindingContext;
            if (!String.IsNullOrEmpty(peamine.Riik))
            {
                App.Database.SaveItem(peamine);
            }
            this.Navigation.PopAsync();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var peamine = (PeamineBase)BindingContext;
            App.Database.DeleteItem(peamine.Id);
            this.Navigation.PopAsync();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}
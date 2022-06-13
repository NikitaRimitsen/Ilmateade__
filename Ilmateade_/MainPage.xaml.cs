using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ilmateade_
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("iconkap.png");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Glavnaja);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }
        public List<Ilmateadebase> GetMenuList()
        {
            var list = new List<Ilmateadebase>();
            list.Add(new Ilmateadebase()
            {
                Text = "Peamine",
                Detail = "Teave ilmateate kohta",
                ImagePath = "about.png",
                TargetPage = typeof(Glavnaja)
            });
            list.Add(new Ilmateadebase()
            {
                Text = "Õhurõhk",
                Detail = "Teave tänava rõhu kohta",
                ImagePath = "opet.png",
                TargetPage = typeof(Davlenie)
            });
            /*list.Add(new Ilmateadebase()
            {
                Text = "Niiskus",
                Detail = "Teave niiskuse kohta tänaval",
                ImagePath = "skills.png",
                TargetPage = typeof(Vlaznost)
            });*/
            list.Add(new Ilmateadebase()
            {
                Text = "Tuule suund",
                Detail = "Uurige tuule suunda",
                ImagePath = "aci2.png",
                TargetPage = typeof(Napravlenievetra)
            });
            list.Add(new Ilmateadebase()
            {
                Text = "Ilmade lisamine",
                Detail = "Uurige tuule suunda",
                ImagePath = "aci2.png",
                TargetPage = typeof(Uuedimateade)
            });
            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (Ilmateadebase)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}

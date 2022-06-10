using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ilmateade_
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "peaminebase.db";
        public static PeamineBaseRepository database;
        public static PeamineBaseRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new PeamineBaseRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

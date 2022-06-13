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
    public partial class Detaila : ContentPage
    {
        public Detaila(PeamineBase peamineBase)
        {
            InitializeComponent();
            BindingContext = peamineBase;
        }
    }
}
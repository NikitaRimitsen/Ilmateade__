﻿using System;
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
        public Davlenie()
        {
            Label text = new Label
            {
                Text = "Õhurõhk",
                HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center,
                FontSize = 30,
                TextColor = Color.White
            };
            this.Content = new StackLayout { Children = { text } };
            this.BackgroundColor = Color.SteelBlue;//LightSteelBlue -- можно исопользовать для светлого оформления
        }
    }
}
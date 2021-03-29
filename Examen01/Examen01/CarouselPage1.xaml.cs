﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage1 : CarouselPage
    {
        public CarouselPage1()
        {
            InitializeComponent();
            BtnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }
    }
}
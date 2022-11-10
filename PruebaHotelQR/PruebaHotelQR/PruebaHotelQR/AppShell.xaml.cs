using PruebaHotelQR.ViewModels;
using PruebaHotelQR.Views;
using PruebaHotelQR.Views.LoginPages;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PruebaHotelQR
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
        }

    }
}

using PruebaHotelQR.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PruebaHotelQR.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
using System.ComponentModel;
using Xamarin.Forms;
using CoffeeApp.ViewModels;

namespace CoffeeApp.Views
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

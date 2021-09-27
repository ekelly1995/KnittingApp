using EmilysKnittingApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EmilysKnittingApp.Views
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
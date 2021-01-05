using CollectionViewTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace CollectionViewTest.Pages
{
    public partial class CollectionViewPage : ContentPage
    {
        public CollectionViewPage(object viewModel)
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            this.BindingContext = viewModel;
        }
    }
}

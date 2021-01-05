using CollectionViewTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace CollectionViewTest.Pages
{
    public partial class BindableLayoutPage : ContentPage
    {
        public BindableLayoutPage(object viewModel)
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            this.BindingContext = viewModel;
        }
    }
}

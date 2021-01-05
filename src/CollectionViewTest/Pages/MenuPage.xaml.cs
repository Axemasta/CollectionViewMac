using CollectionViewTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace CollectionViewTest.Pages
{
    public partial class MenuPage : ContentPage
    {
        private ItemsViewModel _itemsViewModel;

        public MenuPage()
        {
            InitializeComponent();

            _itemsViewModel = new ItemsViewModel();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        void OnClicked(object sender, System.EventArgs e)
        {
            if (!(sender is Button button))
                return;

            switch (button.Text)
            {
                case "Collection View":
                    this.Navigation.PushAsync(new CollectionViewPage(_itemsViewModel));
                    break;

                case "List View":
                    this.Navigation.PushAsync(new ListViewPage(_itemsViewModel));
                    break;

                case "Stack Layout":
                    this.Navigation.PushAsync(new BindableLayoutPage(_itemsViewModel));
                    break;
            }
        }
    }
}

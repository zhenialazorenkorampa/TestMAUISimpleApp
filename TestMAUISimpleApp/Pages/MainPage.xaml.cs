using TestMAUISimpleApp.ViewModels;

namespace TestMAUISimpleApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }
    }
}

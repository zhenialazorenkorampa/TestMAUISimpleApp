
using TestMAUISimpleApp.ViewModels;

namespace TestMAUISimpleApp.Pages
{
    public partial class CreateUserPage : ContentPage
    {
        public CreateUserPage()
        {
            InitializeComponent();
            BindingContext = new CreateUserPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current?.MainPage != null && Application.Current?.MainPage is AppShell appShell)
            {
                appShell.Title = Constants.Headers.CreateUser;
            }
        }
    }
}

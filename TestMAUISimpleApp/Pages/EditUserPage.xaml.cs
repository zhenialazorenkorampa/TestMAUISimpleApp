
using TestMAUISimpleApp.ViewModels;

namespace TestMAUISimpleApp.Pages
{
    public partial class EditUserPage : ContentPage
    {
        public EditUserPage()
        {
            InitializeComponent();
            BindingContext = new EditUserPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current?.MainPage != null && Application.Current?.MainPage is AppShell appShell)
            {
                appShell.Title = Constants.Headers.EditUser;
            }
        }
    }
}

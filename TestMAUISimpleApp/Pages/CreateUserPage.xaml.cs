
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
    }
}

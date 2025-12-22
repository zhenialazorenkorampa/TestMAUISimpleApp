
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
    }
}

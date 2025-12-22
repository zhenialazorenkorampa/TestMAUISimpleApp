using TestMAUISimpleApp.Models;
using TestMAUISimpleApp.ViewModels;

namespace TestMAUISimpleApp.Pages
{
    public partial class UserListPage : ContentPage
    {
        public UserListPage()
        {
            InitializeComponent();

            BindingContext = new UserListPageViewModel();
        }

        public async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;
            
            if (e.CurrentSelection[0] is not User user)
                return;

            await Shell.Current.GoToAsync(
                nameof(EditUserPage),
                new Dictionary<string, object>
                {
                    ["User"] = user
                });
        }
    }
}

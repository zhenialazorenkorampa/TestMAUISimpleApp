using CommunityToolkit.Mvvm.Input;
using TestMAUISimpleApp.Pages;

namespace TestMAUISimpleApp.ViewModels
{
    public partial class MainPageViewModel
    {

        [RelayCommand]
        public static async Task GoToUserList()
        {
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;

            await Shell.Current.GoToAsync($"//{nameof(UserListPage)}");
        }
    }
}

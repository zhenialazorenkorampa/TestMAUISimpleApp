using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TestMAUISimpleApp.Pages;

namespace TestMAUISimpleApp.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _userName = string.Empty;


        [RelayCommand]
        public async Task GoToUserList()
        {
            if (string.IsNullOrEmpty(UserName))
                return;

            if (Application.Current?.MainPage != null && Application.Current?.MainPage is AppShell appShell)
            {
                appShell.FlyoutBehavior = FlyoutBehavior.Flyout;

                appShell.FlyoutHeader = UserName;
            }    

            await Shell.Current.GoToAsync($"//{nameof(UserListPage)}");
        }
    }
}

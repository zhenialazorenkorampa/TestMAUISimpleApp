using CommunityToolkit.Mvvm.Input;
using TestMAUISimpleApp.Pages;

namespace TestMAUISimpleApp.ViewModels
{
    public partial class MainPageViewModel
    {

        [RelayCommand]
        public async Task GoToUserList()
        {
            await Shell.Current.GoToAsync(nameof(UserListPage));
        }
    }
}

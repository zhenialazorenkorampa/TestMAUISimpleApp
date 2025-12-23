using CommunityToolkit.Mvvm.Input;
using TestMAUISimpleApp.Pages;

namespace TestMAUISimpleApp.ViewModels
{
    public partial class BurgerMenuViewModel
    {

        [RelayCommand]
        public async Task UserClickSome()
        {
            Shell.Current.FlyoutIsPresented = false;
            await Shell.Current.GoToAsync(nameof(SomePage));
        }

        [RelayCommand]
        public async Task UserClickSave()
        {
            Shell.Current.FlyoutIsPresented = false;
            await Shell.Current.GoToAsync(nameof(CreateUserPage));
        }
    }
}

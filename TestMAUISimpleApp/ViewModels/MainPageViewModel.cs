using CommunityToolkit.Mvvm.Input;

namespace TestMAUISimpleApp.ViewModels
{
    public partial class MainPageViewModel
    {

        [RelayCommand]
        public static async Task GoToUserList() 
            => Application.Current!.MainPage = new AppShell();
    }
}

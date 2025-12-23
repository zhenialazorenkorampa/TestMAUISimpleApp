using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using TestMAUISimpleApp.EventMessages;
using TestMAUISimpleApp.Models;

namespace TestMAUISimpleApp.ViewModels
{
    public partial class CreateUserPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name = string.Empty;

        [ObservableProperty]
        private string _age = string.Empty;

        [RelayCommand]
        public async Task Save()
        {
            if (!int.TryParse(Age, out var age))
                return;

            var createUserResult = User.Create(Name, age);
            if (createUserResult.IsFailure)
                return;

            WeakReferenceMessenger.Default.Send(
                new UserCreatedEventMessage(createUserResult.Value!)
            );

            await Shell.Current.GoToAsync("..");
        }
    }
}

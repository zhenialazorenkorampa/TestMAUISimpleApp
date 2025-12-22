using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using TestMAUISimpleApp.EventMessages;
using TestMAUISimpleApp.Models;

namespace TestMAUISimpleApp.ViewModels
{
    [QueryProperty(nameof(User), "User")]
    public partial class EditUserPageViewModel : ObservableObject
    {
        private User _user = null!;

        [ObservableProperty]
        private string name = string.Empty;

        [ObservableProperty]
        private string age = string.Empty;

        public User User
        {
            get => _user;
            set
            {
                _user = value;
                Name = value.Name;
                Age = value.Age.ToString();
            }
        }

        [RelayCommand]
        private async Task Save()
        {
            if (!int.TryParse(Age, out var age))
                return;

            var result = _user.Update(Name, age);
            if (result.IsFailure)
                return;

            WeakReferenceMessenger.Default.Send(
                new UserUpdatedEventMessage(_user)
            );

            await Shell.Current.GoToAsync("..");
        }
    }
}

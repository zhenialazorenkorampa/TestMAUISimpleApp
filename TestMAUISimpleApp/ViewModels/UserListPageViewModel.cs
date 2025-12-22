using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using TestMAUISimpleApp.EventMessages;
using TestMAUISimpleApp.Models;
using TestMAUISimpleApp.Services;

namespace TestMAUISimpleApp.ViewModels;

public partial class UserListPageViewModel : ObservableObject, IRecipient<UserUpdatedEventMessage>
{
    public ObservableCollection<User> Users { get; } = [];

    [ObservableProperty]
    private string name = string.Empty;

    [ObservableProperty]
    private string age = string.Empty;

    public UserListPageViewModel()
    {
        WeakReferenceMessenger.Default.Register(this);
        LoadUsers();
    }

    [RelayCommand]
    public void AddUser()
    {
        if (!int.TryParse(Age, out var age))
            return;

        var createUserResult = User.Create(Name, age);
        if (createUserResult.IsFailure)
            return;

        Users.Add(createUserResult.Value!);
        SaveUsers();
    }

    private void LoadUsers()
    {
        var users = UsersStorage.Load();

        Users.Clear();
        foreach (var user in users)
            Users.Add(user);
    }

    public void SaveUsers()
    {
        UsersStorage.Save([.. Users]);
    }

    public void Receive(UserUpdatedEventMessage message)
    {
        SaveUsers();
        LoadUsers();
    }
}

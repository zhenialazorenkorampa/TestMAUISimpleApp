using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using TestMAUISimpleApp.EventMessages;
using TestMAUISimpleApp.Models;
using TestMAUISimpleApp.Pages;
using TestMAUISimpleApp.Services;

namespace TestMAUISimpleApp.ViewModels;

public partial class UserListPageViewModel : ObservableObject, 
    IRecipient<UserUpdatedEventMessage>, 
    IRecipient<UserCreatedEventMessage>
{
    public ObservableCollection<User> Users { get; } = new ObservableCollection<User>();

    public UserListPageViewModel()
    {
        WeakReferenceMessenger.Default.RegisterAll(this);
        LoadUsers();
    }

    [RelayCommand]
    public async Task AddUser()
    {
        await Shell.Current.GoToAsync(nameof(CreateUserPage));
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

    public void Receive(UserCreatedEventMessage message)
    {
        Users.Insert(0, message.Value);
        SaveUsers();
        LoadUsers();
    }
}

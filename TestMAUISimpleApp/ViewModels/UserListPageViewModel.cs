using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using TestMAUISimpleApp.EventMessages;
using TestMAUISimpleApp.Models;
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
        Users.Add(message.Value);
        SaveUsers();
        LoadUsers();
    }
}

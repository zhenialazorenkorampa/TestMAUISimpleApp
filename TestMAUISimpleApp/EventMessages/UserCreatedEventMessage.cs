using CommunityToolkit.Mvvm.Messaging.Messages;
using TestMAUISimpleApp.Models;

namespace TestMAUISimpleApp.EventMessages
{
    public sealed class UserCreatedEventMessage(User user) : ValueChangedMessage<User>(user)
    {
    }
}

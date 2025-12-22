using CommunityToolkit.Mvvm.Messaging.Messages;
using TestMAUISimpleApp.Models;

namespace TestMAUISimpleApp.EventMessages
{
    public sealed class UserUpdatedEventMessage(User user) : ValueChangedMessage<User>(user)
    {
    }
}

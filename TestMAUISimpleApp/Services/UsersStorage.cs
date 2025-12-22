using System.Text.Json;
using TestMAUISimpleApp.Models;

namespace TestMAUISimpleApp.Services
{
    public static class UsersStorage
    {
        public static readonly string Key = "users_list";

        public static User[] Load()
        {
            var usersJson = Preferences.Default.Get(Key, string.Empty);

            if (string.IsNullOrEmpty(usersJson))
                return [];

            try
            {
                return JsonSerializer.Deserialize<User[]>(usersJson) ?? [];
            }
            catch
            {
                return [];
            }
        }

        public static void Save(User[] users)
        {
            var usersJson = JsonSerializer.Serialize(users);

            Preferences.Default.Set(Key, usersJson);
        }
    }
}

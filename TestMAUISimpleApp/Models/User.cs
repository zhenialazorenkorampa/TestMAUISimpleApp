using System.Text.Json.Serialization;
using TestMAUISimpleApp.CleanArchitecture.Application;

namespace TestMAUISimpleApp.Models
{
    public class User
    {
        public Guid Id { get; init; }
        public string Name { get; private set; } = string.Empty;
        public int Age { get; private set; }

        [JsonConstructor]
        internal User(string name, int age)
        {
            Id = Guid.CreateVersion7();
            Name = name;
            Age = age;
        }

        private User() { }

        static public Result<User> Create(string name, int age)
        {
            var isValidResult = IsValid(name, age);
            if (isValidResult.IsFailure)
                return Result<User>.Failure(isValidResult.Error!);

            return new User(name, age);
        }

        public Result Update(string name, int age)
        {
            var isValidResult = IsValid(name, age);
            if (isValidResult.IsFailure)
                return Result.Failure(isValidResult.Error!);

            Name = name;
            Age = age;

            return Result.Success();
        }

        
        static private Result IsValid(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
                return Result.Failure("Name is empty");

            if (age <= 0)
                return Result.Failure("Age is less than or equal to 0");

            return Result.Success();
        } 
    }
}

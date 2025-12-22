namespace TestMAUISimpleApp.CleanArchitecture.Application
{
    public class Result
    {
        public string? Error { get; init; }
        public bool IsSuccess => Error == null;
        public bool IsFailure => Error != null;

        protected Result(string? error)
        {
            Error = error;
        }

        public static Result Failure(string error) => new(error);

        public static Result Success() => new(error: null);
    }

    public class Result<T> : Result
    {
        public T? Value { get; }

        protected internal Result(T? value, string? error) : base(error) => Value = value;

        public static Result<T> Success(T value) => new(value, error: null);
        public static new Result<T> Failure(string error) => new(default, error);

        public static implicit operator Result<T>(T value) => Success(value);
    }
}

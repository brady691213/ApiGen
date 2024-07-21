namespace CodeGenerators.Errors;

// Not really an error but better than `NotImplementedException`.
public class NotFinishedError(string message) : Error
{
    public override string Message { get; } = message;
}
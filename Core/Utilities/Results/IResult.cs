namespace Core.Utilities.Results
{
    // Tmel Voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}

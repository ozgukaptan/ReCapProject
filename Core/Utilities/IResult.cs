using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    // Tmel Voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}

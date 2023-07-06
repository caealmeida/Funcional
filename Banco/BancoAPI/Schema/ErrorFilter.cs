using HotChocolate;
using System;

namespace BancoAPI.Schema;
public class ErrorFilter : IErrorFilter
{
    public IError OnError(IError error)
    {
        return error.WithMessage(error.Exception.Message);
    }
}
}

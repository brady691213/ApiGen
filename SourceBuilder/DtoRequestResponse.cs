using Vogen;

namespace SourceBuilder;

[ValueObject<string>]
public partial struct DtoRequestResponse
{
    public static readonly DtoRequestResponse Request = From("Request");
    public static readonly DtoRequestResponse Response = From("Response");
} 
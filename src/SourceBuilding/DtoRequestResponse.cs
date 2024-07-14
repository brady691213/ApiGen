using Vogen;

namespace SourceBuilding;

[ValueObject<string>]
// ReSharper disable once StructCanBeMadeReadOnly
public partial struct DtoRequestResponse
{
    public static readonly DtoRequestResponse Request = From("Request");
    public static readonly DtoRequestResponse Response = From("Response");
} 
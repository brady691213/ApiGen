using FastEndpoints;

namespace SampleFastEndpoints;

public class MyEndpoint : Endpoint<MyRequest, MyResponse>
{
    public override void Configure()
    {
        Post("/api/user/create");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MyRequest req, CancellationToken ct)
    {
        MyResponse resp = new()
        {
            FullName = req.FirstName + " " + req.LastName
        };
        await SendAsync(resp);
    }
}
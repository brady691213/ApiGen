using System.CodeDom;
using CodeGenerators.CodeDom;
using CodeGenerators.Models;

namespace CodeGenerators.Builders;

public class EndpointBuilder
{
    private ClassBuilder _builder = new();

    private CodeMemberMethod BuildHandleAsyncMethod(string requestType, string responseType)
    {
        var req = new CodeParameterDeclarationExpression(requestType, "req");
        var ct = new CodeParameterDeclarationExpression(typeof(CancellationToken), "ct");

        var respDec = new CodeVariableDeclarationStatement(responseType, "resp");
        
        var respRef = new CodeVariableReferenceExpression("resp");
        var respAss = new CodeAssignStatement(
            new CodePropertyReferenceExpression(respRef, "FullName"),
            FullNameFromReq(new CodeArgumentReferenceExpression("req")));
        var send = new CodeSnippetStatement("await SendAsync(resp);");

        var handle = new CodeMemberMethod
        {
            Attributes = MemberAttributes.Override | MemberAttributes.Public,
            ReturnType = new CodeTypeReference($"async {typeof(Task)}")
        };
        handle.Statements.Add(respDec);
        handle.Statements.Add(respAss);
        handle.Statements.Add(send);
        
        return handle;
    }
    
    private CodeFileModel BuildEndpoint(string endpointName, string requestType, string responseType)
    {
        var baseType = new CodeTypeDeclaration("Endpoint");
        baseType.TypeParameters.Add(new CodeTypeParameter(requestType));
        baseType.TypeParameters.Add(new CodeTypeParameter(responseType));

        var cfg = BuildConfigureMethod("/api/user/create");





 

        var code = """
                   public class MyEndpoint : Endpoint<MyRequest, MyResponse>
                   {
                       public override void Configure()
                       {
                           Post("/api/user/create");
                           AllowAnonymous();
                       }
                   
                       public override async Task HandleAsync(MyRequest req, CancellationToken ct)
                       {
                           await SendAsync(new()
                           {
                               FullName = req.FirstName + " " + req.LastName,
                               IsOver18 = req.Age > 18
                           });
                       }
                   }
                   """;
        return new CodeFileModel("MyEndpoint", code);
    }

    private CodeMethodInvokeExpression FullNameFromReq(CodeArgumentReferenceExpression reqArg)
    {
        var full = CodeElements.BuildMethodCallExpression(
            typeof(string),
            "Concat",
            [
                new CodePropertyReferenceExpression(reqArg, "FirstName"),
                new CodePrimitiveExpression(" "),
                new CodePropertyReferenceExpression(reqArg, "LastName")
            ]
        );
        return full;
    }
    
    private CodeMemberMethod BuildConfigureMethod(string routePattern)
    {
        var route = new CodePrimitiveExpression(routePattern);
        var post = CodeElements.BuildMethodCallExpression("Post", [route]);
        var allow = CodeElements.BuildMethodCallExpression("AllowAnonymous", []);
        
        var configure = _builder.BuildMethodDec("Configure", [], [post, allow], MemberAttributes.Override | MemberAttributes.Public);

        return configure;
    }


}
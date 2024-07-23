using System.CodeDom;
using CodeGenerators.CodeDom;
using CodeGenerators.Models;

namespace CodeGenerators.Builders;

public class EndpointBuilder
{
    private static ClassBuilder _builder = new();

    private static CodeMemberMethod BuildHandleAsyncMethod(string requestType, string responseType)
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
        handle.Parameters.Add(req);
        handle.Parameters.Add(ct);
        handle.Statements.Add(respDec);
        handle.Statements.Add(respAss);
        handle.Statements.Add(send);
        
        return handle;
    }
    
    public static CodeTypeDeclaration BuildEndpoint(string endpointName, string requestType, string responseType)
    {
        var baseType = new CodeTypeDeclaration("Endpoint");
        baseType.TypeParameters.Add(new CodeTypeParameter(requestType));
        baseType.TypeParameters.Add(new CodeTypeParameter(responseType));

        var cfg = BuildConfigureMethod("/api/user/create");
        var handle = BuildHandleAsyncMethod(requestType, responseType);

        var epDec = new CodeTypeDeclaration(endpointName);
        var bt = new CodeTypeReference("Endpoint<MyRequest, MyResponse>");
        epDec.BaseTypes.Add(bt);
        epDec.IsClass = true;
        epDec.Members.Add(cfg);
        epDec.Members.Add(handle);


        return epDec;
    }

    private static CodeMethodInvokeExpression FullNameFromReq(CodeArgumentReferenceExpression reqArg)
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
    
    private static CodeMemberMethod BuildConfigureMethod(string routePattern)
    {
        var route = new CodePrimitiveExpression(routePattern);
        var post = CodeElements.BuildMethodCallExpression("Post", [route]);
        var allow = CodeElements.BuildMethodCallExpression("AllowAnonymous", []);
        
        var configure = _builder.BuildMethodDec("Configure", [], [post, allow], MemberAttributes.Override | MemberAttributes.Public);

        return configure;
    }


}
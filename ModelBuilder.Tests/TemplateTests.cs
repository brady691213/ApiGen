using EntityDecompiler;
using Scriban;
using Scriban.Parsing;
using Shouldly;
using Xunit;

namespace ModelBuilder.Tests;

public class TemplateTests
{

    
    [Fact]
    public void ParseDtoTemplateHasNoErrors()
    {
        var expectedMessages = new List<string>();
        
        var builder = new TemplateBuilder();
        var template = builder.ParseDtoTemplate();

        var actualMsgs = template.Messages
            .Where(m => m.Type == ParserMessageType.Error)
            .Select(m => m.Message)
            .ToList();

        actualMsgs.ShouldBe(expectedMessages);
    }


}
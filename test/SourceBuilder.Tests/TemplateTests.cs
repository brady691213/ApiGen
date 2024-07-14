using Scriban.Parsing;
using Shouldly;
using SourceBuilding;
using Xunit;

namespace SourceBuilder.Tests;

public class TemplateTests
{

    
    [Fact]
    public void ParseDtoTemplateHasNoErrors()
    {
        var expectedMessages = new List<string>();
        
        var builder = new TemplateLoader();
        var template = builder.LoadDtoTemplate();

        var actualMsgs = template.Messages
            .Where(m => m.Type == ParserMessageType.Error)
            .Select(m => m.Message)
            .ToList();

        actualMsgs.ShouldBe(expectedMessages);
    }


}
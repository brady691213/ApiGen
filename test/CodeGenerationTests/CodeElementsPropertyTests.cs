using System.CodeDom;
using CodeGenerators.CodeDom;
using CodeGenerators.Models;
using Reflection;
using Shouldly;
using Xunit;

namespace CodeGeneratorTests;

public class CodeElementsPropertyTests
{
    [Fact]
    public void BackingFieldTypeCorrect()
    {
        var exType = typeof(string);
        var expectedField = new CodeMemberField
        {
            Name = Guid.NewGuid().ToString(),
            Type = new CodeTypeReference(exType)
        };

        var model = new PropertyModel(exType, expectedField.Name);
        var actualDec = CodeElements.BuildPropertyDec(model);
        var actualField = actualDec[0] as CodeMemberField;
        
        actualField.ShouldNotBeNull();
        actualField.Type.BaseType.ShouldBe<string>(expectedField.Type.BaseType);
    }
    
    [Fact]
    public void BackingFieldNameCorrect()
    {
        var exType = typeof(string);
        var expectedField = new CodeMemberField
        {
            Type = new CodeTypeReference(exType),
            Name = Guid.NewGuid().ToString()
        };

        var model = new PropertyModel(exType, expectedField.Name);
        var actualDec = CodeElements.BuildPropertyDec(model);
        var actualField = actualDec[0] as CodeMemberField;
        
        actualField.ShouldNotBeNull();
        actualField.Name.ShouldBe($"_{expectedField.Name}");
    }
    
    [Fact]
    public void PublicPropertyTypeCorrect()
    {
        var exType = typeof(string);
        var expectedProp = new CodeMemberProperty
        {
            Type = new CodeTypeReference(exType),
            Name = Guid.NewGuid().ToString()
        };

        var model = new PropertyModel(exType, expectedProp.Name);
        var actualDec = CodeElements.BuildPropertyDec(model);
        var actualProp = actualDec[1] as CodeMemberProperty;
        
        actualProp.ShouldNotBeNull();
        actualProp.Type.BaseType.ShouldBe<string>(expectedProp.Type.BaseType);
    }  
    
    [Fact]
    public void PublicPropertyNameCorrect()
    {
        var exType = typeof(string);
        var expectedProp = new CodeMemberProperty();
        expectedProp.Type = new CodeTypeReference(exType);
        expectedProp.Name = Guid.NewGuid().ToString();

        var model = new PropertyModel(exType, expectedProp.Name);
        var actualDec = CodeElements.BuildPropertyDec(model);
        var actualProp = actualDec[1] as CodeMemberProperty;
        
        actualProp.ShouldNotBeNull();
        actualProp.Name.ShouldBe(expectedProp.Name);
    }  
    
    //[Theory]
    [ClassData(typeof(TypesTheoryData))]
    public void PropertyMembersFromModelsCorrect(PropertyModel model, CodeMemberProperty expectedProp)
    {
        
    }
    
    public class TypesTheoryData: TheoryData<PropertyModel, CodeMemberProperty>
    {
        public TypesTheoryData()
        {
            var types = CSharpTypeMaps.TypeKeyedDictionary.Keys;
        }
    }
}
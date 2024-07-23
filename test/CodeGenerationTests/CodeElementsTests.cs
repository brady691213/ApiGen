using System.CodeDom;
using CodeGenerators.CodeDom;
using CodeGenerators.Models;
using Reflection;
using Shouldly;
using Xunit;

namespace CodeGeneratorTests;

public class CodeElementsTests
{
    [Fact]
    public void BackingFieldCorrect()
    {
        var exType = typeof(string);
        var expectedField = new CodeMemberField();
        expectedField.Type = new CodeTypeReference(exType);
        expectedField.Name = Guid.NewGuid().ToString();

        var model = new PropertyModel(exType, expectedField.Name);
        var actualDec = CodeElements.BuildPropertyDec(model);
        var actualField = actualDec[0] as CodeMemberField;
        
        actualField.ShouldNotBeNull();
        actualField.Name.ShouldBe($"_{expectedField.Name}");
        actualField.Type.BaseType.ShouldBe<string>(expectedField.Type.BaseType);
    }
    
    [Fact]
    public void PublicPropertyCorrect()
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
        actualProp.Type.BaseType.ShouldBe<string>(expectedProp.Type.BaseType);
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
// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
  
    RenderFragment<Person> p = (person) => 

#line default
#line hidden
#nullable disable
            (__builder2) => {
                __builder2.OpenElement(0, "div");
                __builder2.OpenComponent<Test.MyComponent>(1);
                __builder2.AddAttribute(2, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                     person.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                                         ;

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    class Person
    {
        public string Name { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

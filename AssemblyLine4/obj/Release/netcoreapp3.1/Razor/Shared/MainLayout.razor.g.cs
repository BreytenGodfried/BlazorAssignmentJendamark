#pragma checksum "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "266bddf2d3779758156cccbb6365249720b33d19"
// <auto-generated/>
#pragma warning disable 1591
namespace AssemblyLine4.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\_Imports.razor"
using AssemblyLine4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\_Imports.razor"
using AssemblyLine4.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content px-4");
            __builder.AddMarkupContent(5, "\r\n        ");
#nullable restore
#line 9 "C:\Program Files (x86)\Visual Studio Projects\AssemblyLine4\AssemblyLine4\Shared\MainLayout.razor"
__builder.AddContent(6, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
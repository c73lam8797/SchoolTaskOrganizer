#pragma checksum "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6d20d95fdaaf0db83a6a3154434357438fcf15"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebAssem.Shared
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using BlazorWebAssem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using BlazorWebAssem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using static System.Console;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using static System.Math;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using ObjectClasses;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<BlazorWebAssem.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 13 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

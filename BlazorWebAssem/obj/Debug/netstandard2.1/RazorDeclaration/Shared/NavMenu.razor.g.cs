#pragma checksum "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "499ded647d4cb4b7839670ab522858f112eb9717"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = false;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

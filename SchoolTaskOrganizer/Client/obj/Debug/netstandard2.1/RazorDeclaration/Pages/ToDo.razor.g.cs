#pragma checksum "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bd2540cccfcb5960ff72eb7b05fbff4deb1d2f2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SchoolTaskOrganizer.Client.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using SchoolTaskOrganizer.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using SchoolTaskOrganizer.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using SchoolTaskOrganizer.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using static System.Console;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using static System.Math;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\_Imports.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
           

        public bool editable = true;

        void KeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter") { editable = false; }
        }

        void Clicked()
        {
            editable = true;
        }

        public string newCategoryTitle = " ";
        public List<Category> categories = new List<Category>();


        public void AddCategory()
        {
            if (!string.IsNullOrEmpty(newCategoryTitle))
            {
                categories.Add(new Category { Title = newCategoryTitle });
                newCategoryTitle = " ";
            }
        }

        public void AddToDo(Category category)
        {
            if (!string.IsNullOrEmpty(category.TempToDo))
            {
                category.ListToDos.Add(new ToDoObject { ThingToDo = category.TempToDo });
                category.TempToDo = " ";
            }
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

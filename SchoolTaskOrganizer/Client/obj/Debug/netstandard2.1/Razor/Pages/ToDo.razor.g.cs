#pragma checksum "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bd2540cccfcb5960ff72eb7b05fbff4deb1d2f2"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>ToDo</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                    newCategoryTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newCategoryTitle = __value, newCategoryTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                () => AddCategory()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Add a To Do Category");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "cellpadding", "20");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 8 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
     if (categories.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.AddMarkupContent(14, "<thead>\r\n        <th>Here are your tasks:</th>\r\n        </thead>\r\n");
#nullable restore
#line 13 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.AddMarkupContent(16, "<thead>\r\n        <th>You currently do not have any tasks.</th>\r\n        </thead>\r\n");
#nullable restore
#line 19 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.OpenElement(18, "tbody");
            __builder.AddAttribute(19, "class", "d-flex flex-wrap");
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 23 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
         foreach (Category category in categories)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(22);
            __builder.AddAttribute(23, "Style", "width:400px;");
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "td");
                __builder2.AddMarkupContent(27, "\r\n");
#nullable restore
#line 27 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
             if (categories.Any())
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(28, "            ");
                __builder2.OpenElement(29, "tr");
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "button");
                __builder2.AddAttribute(32, "type", "button");
                __builder2.AddAttribute(33, "class", "close");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                              () => categories.Remove(category)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "aria-label", "Close");
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.AddMarkupContent(37, "<span aria-hidden=\"true\">&times;</span>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.OpenElement(39, "h2");
                __builder2.AddAttribute(40, "contenteditable", 
#nullable restore
#line 33 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                      editable

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(41, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                                                                                       KeyPress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                                                                                                            Clicked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                             category.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => category.Title = __value, category.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddContent(45, 
#nullable restore
#line 33 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                                                                                                                      category.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n");
                __builder2.AddContent(48, "            ");
                __builder2.OpenElement(49, "tr");
                __builder2.AddMarkupContent(50, "\r\n");
#nullable restore
#line 37 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                 foreach (ToDoObject todos in category.ListToDos)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(51, "                ");
                __builder2.OpenElement(52, "tr");
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenElement(54, "button");
                __builder2.AddAttribute(55, "type", "button");
                __builder2.AddAttribute(56, "class", "close");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                                  () => category.ListToDos.Remove(todos)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "aria-label", "Close");
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.AddMarkupContent(60, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n                    ");
                __builder2.OpenElement(62, "table");
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "td");
                __builder2.OpenElement(65, "input");
                __builder2.AddAttribute(66, "type", "checkbox");
                __builder2.AddAttribute(67, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                          todos.IsDone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todos.IsDone = __value, todos.IsDone));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.OpenElement(70, "td");
                __builder2.AddAttribute(71, "style", "width: 80px");
                __builder2.OpenElement(72, "p");
                __builder2.AddAttribute(73, "contenteditable", 
#nullable restore
#line 46 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                                     editable

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(74, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                                                                                                                       KeyPress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                                                                                                                                            Clicked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                                                            todos.ThingToDo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todos.ThingToDo = __value, todos.ThingToDo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddContent(78, 
#nullable restore
#line 46 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                                                                                                                                                      todos.ThingToDo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n");
#nullable restore
#line 49 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.OpenElement(83, "tr");
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.OpenElement(85, "td");
                __builder2.OpenElement(86, "input");
                __builder2.AddAttribute(87, "placeholder", "Add a New ToDo");
                __builder2.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                                          category.TempToDo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => category.TempToDo = __value, category.TempToDo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.OpenElement(91, "td");
                __builder2.OpenElement(92, "button");
                __builder2.AddAttribute(93, "type", "button");
                __builder2.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
                                                        () => AddToDo(category)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(95, " Add ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n");
#nullable restore
#line 56 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"

            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(99, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 60 "C:\Users\charm\source\repos\SchoolTaskOrganizer\SchoolTaskOrganizer\Client\Pages\ToDo.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.CloseElement();
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

#pragma checksum "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\Pages\Deliverables.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf9438eb88e91cae8cf1f7cdb848cfee266a6981"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebAssem.Pages
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
#line 9 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using static System.Console;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using static System.Math;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\_Imports.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\Pages\Deliverables.razor"
using ObjectClasses;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deliverables")]
    public partial class Deliverables : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\charm\source\repos\BlazorWebAssemSolution\BlazorWebAssem\Pages\Deliverables.razor"
 

    //Everything below this is for the Course Colour Modal -----------------------------------------------------------
    public string ModalDisplay2 = "none";
    public string ModalClass2 = "";

    public int NumberOfCourses = 0;
    public int PrevInput = 0;


    public List<Courses> courses = new List<Courses>();

    public void Initialize()
    {
        if (NumberOfCourses - PrevInput < 0) //this means that the user wants to remove courses
        {
            for (int i = 0; i < Abs(NumberOfCourses - PrevInput); i++)
            {
                courses.RemoveAt(courses.Count-1);
                WriteLine(courses.Count);
            }
        }
        else
        {
            for (int i = 0; i < NumberOfCourses - PrevInput; i++) //user is adding more courses, by default with empty strings
            {
                courses.Add(new Courses("", ""));
                WriteLine(courses.Count);
            }
        }

        PrevInput = NumberOfCourses;
    }

    public void DisplayCourseColourOptions() //method uses a string to change the styling of the modal to "block", which is to show
    {
        ModalDisplay2 = "block;";
        ModalClass2 = "Show";
        StateHasChanged();
    }

    public void CloseCourseColourOptions()//method uses a string to change the styling of the modal to "none"
    {
        ModalDisplay2 = "none";
        ModalClass2 = "";
        StateHasChanged();
    }

    public string CourseColours(string code) //method is passed a course code associated with the deliverable displayed.
    {
        //searches through a list of courses; if the code matches one of the courses previously inputted by the user, it will return the colour associated with that course
        foreach (Courses course in courses)
        {
            if (course.CourseCode == code){return course.Colour;}
        }
        //otherwise, it returns a default colour of grey
        return "grey";
    }




    //Everything below this is for the Deliverable Modal -----------------------------------------------------------
    public string ModalDisplay = "none;";
    public string ModalClass = "";


    //initializing variables
    public List<Deliverable> deliverables = new List<Deliverable>();

    //placeholder variables, which is binded to the input in the form, and is used to initialize new Deliverable objects
    Deliverable newDeliverable;
    string newCoursecode;
    string newTask;
    DateTime newDueDate = DateTime.Now;
    string newNote;

    public void Check(Deliverable deliverable)
    {
        if (string.IsNullOrEmpty(deliverable.CourseCode)){ deliverable.CourseCode = "----";}
    }
    
    
    public void DisplayForm() //method uses a string to change the styling of the modal to "block", which is to show
    {
        ModalDisplay = "block;";
        ModalClass = "Show";
        StateHasChanged();
    }

    public void Close() //method uses as string to change the styling of the modal display to none
    {
        ModalDisplay = "none";
        ModalClass = "";
        ResetForm();
        StateHasChanged();
    }

    private void AddDeliverable() //creates a new deliverable, and adds it a list of deliverables
    {
        //adding deliverable to list
        deliverables.Add(newDeliverable = new Deliverable(newCoursecode, newTask, newDueDate, newNote));

        ResetForm();

        //reloading page by closing the modal when a deliverable is added
        Close();
    }

    private void ResetForm() //method sets all the parameters in the form back to its default
    {
        //resetting the values
        newCoursecode = " ";
        newDueDate = DateTime.Now;
        newTask = " ";
        newNote = " ";
    }

    private void Remove(Deliverable deliverable) //method removes a deliverable from the list 
    {
        deliverables.Remove(deliverable);
    }


    //for edit on click
    public bool editable = true;

    void KeyPress(KeyboardEventArgs e, Deliverable deliverable)
    {
        Check(deliverable);
        if (e.Key == "Enter") {editable = false;}
    }

    void Clicked()
    {
        editable = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

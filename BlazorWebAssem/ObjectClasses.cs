using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;
using System.Collections.Generic;
using DevExpress.Blazor;

namespace ObjectClasses
{
    public class Deliverable
    {
        public string CourseCode {get; set;} =  " ";
        public string Task { get; set; } = " ";
        public DateTime DueDate { get; set; } = DateTime.Now.Date;
        public string AdditionalNotes { get; set; } = " ";
        public bool IsDone { get; set; } = false;

        public Deliverable(string courseCode, string task, DateTime dueDate, string note)
        {
            CourseCode = courseCode;
            Task = task;
            DueDate = dueDate.Date;
            AdditionalNotes = note;
        }
    }

    public class Courses
    {
        public string CourseCode { get; set; }
        public string Colour { get; set; }

        public Courses(string courseCode, string colour)
        {
            CourseCode = courseCode;
            Colour = colour;
        }
    }

    public class Category
    {
        public string Title { get; set; } = " ";
        public string TempToDo { get; set; } = " ";
        public List<ToDoObject> ListToDos = new List<ToDoObject>();
    }

    public class ToDoObject
    {
        public string ThingToDo { get; set; } = " ";
        public bool IsDone { get; set; } = false;
    }
}

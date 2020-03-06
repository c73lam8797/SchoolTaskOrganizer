using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;
using System.Collections.Generic;
using DevExpress.Blazor;

namespace SchoolTaskOrganizer.Shared.Models
{
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

    public class Deliverable
    {
        public string CourseCode { get; set; }
        public string Task { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now; 
        public string AdditionalNotes { get; set; }
        public bool IsDone { get; set; }

        public Deliverable()
        {
            CourseCode = "----";
            Task = "----";
            DueDate = DateTime.Now;
            AdditionalNotes = "----";
            IsDone = false;
        }
        public Deliverable(string courseCode, string task, DateTime dueDate, string note)
        {
            if (string.IsNullOrWhiteSpace(courseCode)){ CourseCode = "----"; }
            else { CourseCode = courseCode; }

            if (string.IsNullOrWhiteSpace(task))
            { Task = "----"; }
            else { Task = task; }

            if (string.IsNullOrWhiteSpace(note))
            { AdditionalNotes = "----"; }
            else { AdditionalNotes = note; }

            DueDate = dueDate.Date;
        }
    }
}

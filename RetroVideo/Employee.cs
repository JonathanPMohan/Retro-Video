using System;
using System.Collections.Generic;
using System.Text;

namespace RetroVideo
{
    public class EmployeeInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public void AddFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public void AddLastName(string lastName)
        {
            LastName = lastName;
        }

        public void AddTitle(string title)
        {
            Title = title;
        }

        public void AddStartDate(DateTime startDate)
        {
            StartDate = startDate;
        }

        public EmployeeInfo(string lastName, string firstName, string title, DateTime startDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = startDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RetroVideo
{
    class EmployeeInfo
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int StartDate { get; set; }

        public EmployeeInfo(string name, string title, int startdate)
        {
            Name = name;
            Title = title;
            StartDate = startdate;
        }
    }
}

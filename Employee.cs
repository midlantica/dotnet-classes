using System;
using System.Collections.Generic;

namespace Planner
{
  public class Employee
  {

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime StartDate { get; set; }

    public string GetEmployeeDescription
    {
      get
      {
        return
        @$"
---------------------------------------------------
|  Name:        | {FirstName} {LastName}
|  Title:       | {Title}
|  Date & Time: | {StartDate}
---------------------------------------------------
        ";
      }
    }

  }
}

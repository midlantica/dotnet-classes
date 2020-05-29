using System;
using System.Collections.Generic;

namespace Planner
{
  public class Company
  {
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public List<Employee> Employees { get; } = new List<Employee>();

    public void AddEmployee(Employee EmployeeToAdd) {
      Employee.Add(EmployeeToAdd);
    }

    public string GetCompanyDescription
    {
      get
      {
        return
        @$"
---------------------------------------------------
|  Name:        | {Name}
|  Date & Time: | {StartDate}
|  Employees:   | {Employees}
---------------------------------------------------
        ";
      }
    }

  }
}

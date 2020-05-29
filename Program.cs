using System;
using System.Collections.Generic;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create an instance of a company. Name it whatever you like.
      Company AcmeCorp = new Company();
      AcmeCorp.Name = "Acme Corp";
      Console.WriteLine(AcmeCorp);

      // Create three employees

      Employee JoeSmith = new Employee();
      AcmeCorp.AddEmployee("Martin Frobisher");
      // Employee.Add("Martin Frobisher");
      // Assign the employees to the company

      /*
      Iterate the company's employee list and generate the
      simple report shown above
      */

      // Create a public property for holding a list of current employees
      List<string> Employees = new List<string>();
      Employee.Add("Martin Frobisher");

      /*
        Create a constructor method that accepts two arguments:
        1. The name of the company
        2. The date it was created

        The constructor will set the value of the public properties
      */

    }
  }
}

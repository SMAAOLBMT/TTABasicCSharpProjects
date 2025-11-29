using System;

namespace DemoPolymorphism
{
   //Interface feature, so the other classes can call it  
  interface IQuittable
    {
        void employeeQuit(); //interface fuction
    }

  // Employee "implements" the IQuittable interface
  class Employee : IQuittable
  {
    public void employeeQuit() 
    {
      // The functionality of employeeQuit function is here
      Console.WriteLine("Talk to Employee : Are you sure to Quit the job...");
    }
  }

  class PolymorphismAssignmentProgram
    {
    static void Main(string[] args) 
    {
      Employee myEmpy = new Employee();  // Eployee object to use interface.
      myEmpy.employeeQuit();
    }
  }
    
}
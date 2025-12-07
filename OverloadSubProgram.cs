// Employee class file
using System;

namespace  OperatorOverloadAssignment  //soluction namespace name
{
    public class Employee
    {
        public int ID
        {
            get;
            set;
        }

        public string FirstName 
        { 
            get; 
            set; 
        }
        
        public string LastName 
        { 
            get; 
            set; 
        }
        
        

        public static bool operator ==(Employee e1, Employee e2)
        {
            if (e1.ID == e2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            if(e1.ID != e2.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
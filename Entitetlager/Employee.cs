﻿namespace Entitetlager
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public bool VerifyPassword(string inputPassword)
        {
            
            return inputPassword == Password;
        }
    }
}

﻿
internal class Program
{
    private static void Main(string[] args)
    {    // defining the variables
        int Infulltime = 1, emp_rate_hour = 20, emphrs = 0, employe_part_time = 2, employeewage = 0;

        Random random = new Random();        // Random they give the number randomly
        int empcheck = random.Next(1, 3);
        if (empcheck == Infulltime)      // we apply ifelse condition  employee is present full time
        {
            emphrs = 8;
        }
        else if (employe_part_time == empcheck)   // we apply else if condition employee is part time
        {
            emphrs = 4;
        }
        else                       // by defaulte else is shows employee is absentm and 
        {
            emphrs = 0;
        }
        employeewage = emphrs * emp_rate_hour;     // calculate employee wage
        Console.WriteLine("Empwage :" + employeewage);    // display the employee wage

    }
}
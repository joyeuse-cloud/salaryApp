﻿using System;

namespace SalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal=new Calculator();
           
            cal.employee_id = Convert.ToInt32(Console.ReadLine());
           
            cal.employee_name = Console.ReadLine();
           
            cal.employee_position = Console.ReadLine();
           
            cal.employee_gendeer= Console.ReadLine();
            
            double grossSalary;
            grossSalary = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"{cal.employee_name} your monthly salary on position of {cal.employee_position}   is {cal.MonthlySalary(grossSalary)}");
            
            Console.WriteLine($"{cal.employee_name} your one-time salary on position of {cal.employee_position} is {cal.OneTimeSalary(grossSalary)}");
                
            Console.WriteLine("Enter your rate ");
            double rate;
            rate = Convert.ToDouble(Console.ReadLine());
            
            double hour;
            hour = Convert.ToDouble(Console.ReadLine());
            if (rate != 0 && hour != 0)
            {
                Console.WriteLine($"{cal.employee_name} Your hourly salary is {cal.HourlySalary(rate,hour)}");
            }
            else
            {
                Console.WriteLine(" Your hourly salary is 0");
            }
            
           
            
            
        }
    }
}
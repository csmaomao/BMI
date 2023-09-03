// See https://aka.ms/new-console-template for more information
using System;
 Console.WriteLine("**************************");
    Console.WriteLine("BODY MASS INDEX CALCULATOR");
    Console.WriteLine("**************************");
    Console.WriteLine("Choose a System: Input The Mumber of Your Choice");
    Console.WriteLine("[1] Imperial System");
    Console.WriteLine("[2] Metric System");
    int choice = Int32.Parse(Console.ReadLine());

    if (choice == 1)
    {
        Console.Write("Input Weigth in Pounds: ");
        double pounds = Double.Parse(Console.ReadLine());
        Console.Write("Input Height in Inches: ");
        double inches = Double.Parse(Console.ReadLine());

        //computation ofr bmi in imperial system
        double impbmi = pounds / (inches * inches);
        double impFinalBMI = 703 * impbmi;

    Console.WriteLine("Your BMI is: " + String.Format("{0:0.00}",impFinalBMI));

        if (impFinalBMI > 40)
        {
            Console.WriteLine("Very Severely Obese");
        }
        else if (impFinalBMI >= 35)
        {
            Console.WriteLine("Severely Obese");
        }
        else if (impFinalBMI >= 30)
        {
            Console.WriteLine("Moderately Obese");
        }
        else if (impFinalBMI >= 25)
        {
            Console.WriteLine("Overweight");
        }
        else if (impFinalBMI >= 18.5)
        {
            Console.WriteLine("Normal");
        }
        else if (impFinalBMI >= 16)
        {
            Console.WriteLine("Underweight");
        }
        else if (impFinalBMI >= 15)
        {
            Console.WriteLine("Severely Underweight");
        }
        else
        {
            Console.WriteLine("Very Severely Underweight");
        }
    }
    else if (choice == 2)
    {
        Console.Write("Input Weigth in Kilograms: ");
        double kg = Double.Parse(Console.ReadLine());
        Console.Write("Input Height in Meters: ");
        double meters = Double.Parse(Console.ReadLine());

        //computation ofr bmi in imperial system
        double metricBMI = kg / (meters * meters);

        Console.WriteLine("Your BMI is: " + String.Format("{0:0.00}",metricBMI));
        if (metricBMI > 40)
        {
            Console.WriteLine("Very Severely Obese");
        }
        else if (metricBMI >= 35)
        {
            Console.WriteLine("Severely Obese");
        }
        else if (metricBMI >= 30)
        {
            Console.WriteLine("Moderately Obese");
        }
        else if (metricBMI >= 25)
        {
            Console.WriteLine("Overweight");
        }
        else if (metricBMI >= 18.5)
        {
            Console.WriteLine("Normal");
        }
        else if (metricBMI >= 16)
        {
            Console.WriteLine("Underweight");
        }
        else if (metricBMI >= 15)
        {
            Console.WriteLine("Severely Underweight");
        }
        else
        {
            Console.WriteLine("Very Severely Underweight");
        }
    }
    else
    {
        Console.WriteLine("Invalid Input! System Error");
    }
    Console.ReadLine();


using System;

class Program
{
    static void Main(string[] args)
    {
        //Instantiates first Job object.
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Instantiates second Job object. 
        Job job2 = new Job();
        job2._jobTitle = "Quality Assurance Specialist";
        job2._company = "Apple";


        //Calls on Display() method for both objects to print out job decription.
        job1.Display();
        // job2.Display();



    }
}
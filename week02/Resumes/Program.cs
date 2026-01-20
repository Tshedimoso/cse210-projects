using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        Console.WriteLine(job1._jobTitle);

        Job job2 = new Job();
        job2._jobTitle = "Apple";
        Console.WriteLine(job2._jobTitle);
    }

}
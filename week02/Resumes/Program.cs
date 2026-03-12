using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Warrenty Claims Specialist";
        job1._company = "Toyota Financial Services";
        job1._startYear = "2020";
        job1._endYear = "2022";

        Job job2 = new Job();
        job2._jobTitle = "Quality Assurance Specialist";
        job2._company = "Toyota Motor Corporation";
        job2._startYear = "2022";
        job2._endYear = "Present";

        Resume myResume = new Resume();
        myResume._name = "Toshio Holt";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}
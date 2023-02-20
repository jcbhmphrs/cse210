using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume.name = "Niel J. Armstrong";
        
        Job jobOne = new Job();
        jobOne.jobTitle = "Astronaut";
        jobOne.companyName = "NASA";
        jobOne.startYear = "1968";
        jobOne.endYear = "1976";

        Job jobTwo = new Job();
        jobTwo.jobTitle = "Trapeeze Artist";
        jobTwo.companyName = "Cirk d' Ole;";
        jobTwo.startYear = "1976";
        jobTwo.endYear = "1981";

        myResume.jobs.Add(jobOne);
        myResume.jobs.Add(jobTwo);

        myResume.Show();
    }
}
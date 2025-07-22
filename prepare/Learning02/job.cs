public class Job
{
    //Attribute definition for Job class.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Method that displays job description in formatted string.
    public void Display()
    {

        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");

    }


}
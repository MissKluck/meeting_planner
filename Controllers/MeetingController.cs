public class MeetingController
{
    Meeting meeting = new Meeting();
    //Employees employees = new Employees();

    public void planningMeeting()
    {
        Console.WriteLine("What do you want to call this meeting?");
        string meetingTitle = Console.ReadLine();
        meeting.MeetingTitle = meetingTitle;

        // date
        Console.WriteLine("What date is the meeting?");
        string date = Console.ReadLine();
        // double.TryParse(Console.ReadLine(), out double date);

        meeting.Date = date;
        //Console.WriteLine($"The date of your meeting is {meeting.Date}. Press any key to continue");
        //Console.ReadKey();

        // time
        Console.WriteLine("What time is the meeting?");
        string time = Console.ReadLine();
        // double.TryParse(Console.ReadLine(), out double time);

        meeting.Time = time;

        // place
        Console.WriteLine("Where does the meeting take place?");
        string place = Console.ReadLine();
        meeting.Place = place;

        // people at meeting
        Console.WriteLine("Who is going to the meeting?");
        string PeopleAtMeeting = Console.ReadLine();
    }

    public void MadeMeeting()
    {
        string finishedMeeting = ($"The date of the meeting is {meeting.Date}\nThe meeting starts at {meeting.Time}\nThe meeting takes place at {meeting.Place}\nThe people attending are {meeting.PeopleAtMeeting}");
        string filePath = $"Meeting{meeting.MeetingTitle}.txt";
        File.WriteAllText(filePath, finishedMeeting);

    }



    // public void ChoosingName()
    // {
    //Console.WriteLine("Choose employee naame: ");
    //string input = Console.ReadLine();
    //employees.Name = input;
    //Console.WriteLine($"Your new employee is named {employees.Name}. Press any key to continue");
    //Console.ReadKey();

    //string[]

    // }
}
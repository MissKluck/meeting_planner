namespace meeting_planner;

class Program
{
    static void Main(string[] args)
    {
        MeetingController meetingController = new MeetingController();

        meetingController.planningMeeting();

        meetingController.MadeMeeting();
    }
}

using System.Timers;
public class TimeManager
{
    // Timer d'une seconde
    System.Timers.Timer MyTimer = new(1000);
    public int SecondsLeft {get; private set;}

    public TimeManager(int secondsLeft)
    {
        SecondsLeft = secondsLeft;
        MyTimer.Elapsed += OnSecEvent;
        MyTimer.AutoReset = true;
        MyTimer.Enabled = true;
    }
    private void OnSecEvent(Object source, ElapsedEventArgs e) 
    {
        SecondsLeft -=1;
    }
}
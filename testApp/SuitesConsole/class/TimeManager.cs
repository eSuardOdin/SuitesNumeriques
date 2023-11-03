using System.Timers;
/// <summary>
/// Gère le temps restant d'une question
/// </summary>
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
    /// <summary>
    /// Evenement déclenché toutes les secondes
    /// </summary>
    /// <param name="source">Le timer MyTimer</param>
    /// <param name="e">Objet qui contient les données de l'event</param>
    private void OnSecEvent(Object source, ElapsedEventArgs e) 
    {
        SecondsLeft -=1;
    }
}
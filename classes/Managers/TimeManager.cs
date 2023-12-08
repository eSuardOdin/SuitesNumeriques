using System.Timers;
/// <summary>
/// Gère le temps restant d'une question
/// </summary>
public class TimeManager
{
    /// <summary>
    /// Timer d'une seconde
    /// </summary>
    public System.Timers.Timer MyTimer { get ; private set; }
    /// <summary>
    /// Les secondes restantes
    /// </summary>
    public int SecondsLeft {get; private set;}
    /// <summary>
    /// Nombre de secondes initiales
    /// </summary>
    private int StartingSeconds { get; set; }
    /// <summary>
    /// Delegate qui return void et prend un int en argument, utilisé dans le JeuTimer.
    /// </summary>
    public event Action<int> SecondsLeftChanged;

    /// <summary>
    /// Constructeur de TimeManager, on définit l'intervalle entre les evenements, on s'abonne
    /// à l'evenement, on le déclenche en continu (AutoReset = true) et on l'active   
    /// </summary>
    /// <param name="startingSecond">Le nombre de secondes de base du timer</param>
    public TimeManager(int startingSeconds)
    {
        MyTimer = new System.Timers.Timer(1000);
        StartingSeconds = startingSeconds;
        SecondsLeft = startingSeconds;
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
        // On déclenche s'il reste au moins une seconde
        if (SecondsLeft > 0)
        {
            SecondsLeft -=1;
            // On déclenche l'event
            SecondsLeftChanged.Invoke(SecondsLeft);
        }
    }

    /// <summary>
    /// Remet le timer à neuf
    /// </summary>
    public void ResetTimer()
    {
        SecondsLeft = StartingSeconds;
    }

    /// <summary>
    /// Permet de se désinscrire à l'event timer dans le jeu avec contrainte
    /// </summary>
    public void DetachEvent()
    {
        MyTimer.Elapsed -= OnSecEvent;
    }
}
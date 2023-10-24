using System.Timers;
class Program
{
    static int secondsLeft = 30;
    static void Main(string[] args)
    {
        // ExoTerme exo = new("arithmétique");
        // ExoPremierTerme exo = new("arithmétique");
        // ExoRang exo = new("arithmétique");
        // ExoRaison exo = new("arithmétique");
        // ExoSomme exo = new("arithmétique");
        // ExoMonotonie exo = new("arithmétique");


        // Console.WriteLine(exo.Enonce);
        // string res = Console.ReadLine();

        // if (res == exo.Reponse) Console.WriteLine("Bonne réponse ! ");
        // else                    Console.WriteLine($"Faux, la réponse est : {exo.Reponse}");

        /* Partie partie = new("arithmétique"); */
        Player p1 = new("Erwann");
        Player p2 = new("Autre");
        // Versus vs = new("arithmétique", p1, p2);
        
        SetTimer();
        Console.ReadLine();
    }
    private static void SetTimer()
    {
        System.Timers.Timer aTimer = new(1000);
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }


    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        secondsLeft -=1;
        Console.WriteLine($"{secondsLeft} seconds left.");
    }
}


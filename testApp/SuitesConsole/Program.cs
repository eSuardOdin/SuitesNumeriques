


// ExoTerme exo = new("arithmétique");
// ExoPremierTerme exo = new("arithmétique");
// ExoRang exo = new("arithmétique");
ExoRaison exo = new("arithmétique");
// Console.WriteLine(exo.SuiteExo.Raison);
// Console.WriteLine(exo.SuiteExo.PremierTerme);

Console.WriteLine(exo.Enonce);
string res = Console.ReadLine();

if (res == exo.Reponse) Console.WriteLine("Bonne réponse ! ");
else                    Console.WriteLine($"Faux, la réponse est : {exo.Reponse}");
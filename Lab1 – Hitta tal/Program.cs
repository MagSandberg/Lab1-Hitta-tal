/* -- Lab1 – Hitta tal i sträng med tecken --
Skapa en konsollapplikation som tar en textsträng (string) som argument till Main 
eller uppmanar användaren mata in en sträng i konsollen.
Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
siffror förekommer där emellan.
ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
t.ex 95a9 är inte heller ett korrekt tal.

-- Skriv ut och markera varje korrekt delsträng --
För varje sådan delsträng som matchar kriteriet ovan ska programmet skriva ut en
rad med hela strängen, men där delsträngen är markerad i en annan färg.
Exempel output för input ”29535123p48723487597645723645”:

-- Addera ihop alla tal och skriv ut totalen --
Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.
Exempel output för input ”29535123p48723487597645723645”:
Total = 5836428677242*/

// While-loop med bool för att enkelt testa min kod
bool closeProgram = false;
while (!closeProgram)
{
    
    // Användarens textsträng som söks igenom efter talsekvenser
    Console.Write("Skriv in valfri sekvens: ");
    string userString = Console.ReadLine();

    // Bool med IF för att kontrollera att sekvensen ENBART innehåller siffror
    bool stringDigit = true;

    if (int.TryParse(userString, out int userDigitString))
    {
        stringDigit = true;
    }
    else
    {
        stringDigit = false;
    }

    // For-loop som söker igenom userString och sparar sekvenser i en Array
    int index = 1;
    double[] sequenceArray = new double[index];
    
    for (int i = 0; i < userString.Length; i++)
    {
        if (stringDigit)
        {
            sequenceArray[i] = userString[i];
            Console.WriteLine(userString[i]);
            index++;
        }
        else
        {
            Console.WriteLine("Jag kunde inte hitta en nummersekvens.");
        }
    }
    Console.WriteLine(sequenceArray[index]);

    // ReadLine som styr while-loopens bool.
    Console.Write("Tryck 0 för att avsluta eller valfritt tecken för att fortsätta: ");
    string close = Console.ReadLine();
    Console.WriteLine();
    if (close == "0")
    {
        closeProgram = true;
    }
}
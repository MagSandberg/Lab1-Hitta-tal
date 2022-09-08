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
using System;

bool closeProgram = false;
while (!closeProgram)
{
    
    // Användarens textsträng
    Console.Write("Skriv in valfri sekvens: ");
    string userInput = Console.ReadLine();

    // Används för att ge platshållar-arrayerna rätt index.
    int inputIndex = 0;
    foreach (char c in userInput)
    {
        inputIndex++;
    }

    // Konverterar anvnändarens sträng till en char array
    char[] userInputToChar = userInput.ToCharArray();

    char[] digits = new char[inputIndex];
    char[] others = new char[inputIndex];

    // Skriver ut alla siffror i userInputToChar
    for (int i = 0; i < userInputToChar.Length; i++)
    {
        if (char.IsDigit(userInputToChar[i]))
        {
            digits[i] = userInputToChar[i];
        }
        else
        {
            others[i] = userInputToChar[i];
        }
    }

    // Skapar en sträng av alla siffror
    string numbers = "";

    for (int i = 0; i < userInputToChar.Length; i++)
    {
        numbers += digits[i].ToString();
        numbers += others[i].ToString();
    }

    //Array.Sort(digits);
    //string match = "";
    //for (int i = 0; i < digits.Length; i++)
    //{
    //    if (i = 1)
    //    {

    //    }
    //}
    //Console.WriteLine(match);

    // Konverterar char till int
    //int[] digitsInts = Array.ConvertAll(digits, c => (int)Char.GetNumericValue(c));

    // ReadLine som styr while-loopens bool.
    Console.Write("\nTryck 0 för att avsluta eller valfritt tecken för att fortsätta: ");
    string close = Console.ReadLine();
    Console.WriteLine();
    if (close == "0")
    {
        closeProgram = true;
    }
}

string name;
string surname;
int phoneNumber;
string email;
decimal growth;
decimal weight;

Console.WriteLine("Podaj imię: ");
name = Console.ReadLine();

Console.WriteLine("Podaj nazwisko: ");
surname = Console.ReadLine();

Console.WriteLine("Podaj numer telefonu: ");
Int32.TryParse(Console.ReadLine(), out phoneNumber);

Console.WriteLine("Podaj numer email: ");
email = Console.ReadLine();

Console.WriteLine("Podaj wzrost: ");
decimal.TryParse(Console.ReadLine(), out growth);

Console.WriteLine("Podaj wagę: ");
decimal.TryParse(Console.ReadLine(), out weight);

Console.WriteLine($"Twoje dane: \n Imię: {name} \n " +
                                 $"Nazwisko: {surname} \n Numer telefonu: {phoneNumber} \n" +
                                 $"Email: {email} \n Wzrost: {growth} \n Waga: {weight}");
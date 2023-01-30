Console.WriteLine("Vvedite chislo");
int daynNumber = Convert.ToInt32(Console.ReadLine());
if (daynNumber <= 5 && daynNumber >= 1) {
    Console.WriteLine("No");
} else if (daynNumber == 6 || daynNumber == 7) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("Wrong dayNumber");
}

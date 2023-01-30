Console.WriteLine("Vvedite chislo");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN < 100) {
  Console.WriteLine("Tretey sifri net");  
 } else {
    Console.WriteLine(numberN % 10);
 }
 

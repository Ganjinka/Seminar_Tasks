Console.WriteLine("Vvedite chislo A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo B:");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B) {
    Console.WriteLine( A );
} else if (B > A) {
    Console.WriteLine( B );
} else {
    Console.WriteLine(A + " = " + B);
}

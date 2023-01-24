Console.WriteLine("Vvedite chislo A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo B:");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo C:");
int C = Convert.ToInt32(Console.ReadLine());
if (A > B && A > C) {
    Console.WriteLine( A );
} else if (B > A && B > C) {
    Console.WriteLine( B );
} else if (C > A && C > B) {
    Console.WriteLine( C );
} else if (A == B && A == C) {
    Console.WriteLine( "Vse chisla ravni" );
}


namespace Lab02_RecursivoFibonacci;
class Program
{
    static int Main(string[] args)
    {
         
         int n, k;
         do{
                Console.Write("Introduzca el número de términos: ");
                n = int.Parse(Console.ReadLine()!);

         }while(n<=1);

        Console.Write("\nSerie números de fibonacci recursivo: ");

            DateTime inicio1 = DateTime.Now;

            for (k = 0; k < n; k++)	{
             
        		Console.Write(" " + FibonacciRecursivo(k));
	        }
            
        double tiempo1 = DateTime.Now.Subtract(inicio1).Milliseconds;
        Console.Write(" Tiempo de Ejecucion: "  + tiempo1 + " milisegundo");

        Console.Write("\nSerie números de fibonacci iterativo: ");

           DateTime inicio2 = DateTime.Now;
	        FibonacciIterativo(n);
        double tiempo2 = DateTime.Now.Subtract(inicio2).Milliseconds;
        Console.Write(" Tiempo de Ejecucion: "  + tiempo2 + " milisegundo");
        
        return 0;


    }

    static long FibonacciRecursivo(int n){
        if (n < 2) { 
            return n; }
	    else { 

            return FibonacciRecursivo(n - 2) 
                + FibonacciRecursivo (n - 1); }

    }

    static void FibonacciIterativo(int n) { 
	    int i;	long ant1,ant2;  
  	    ant1 = ant2 = 1; 
        Console.Write("0 1 1 ");
     	    for (i=1; i<n-2; i++) { 
                int actual =(int) (ant1 + ant2); 
        
                Console.Write(" " + actual);
                ant2 = ant1; 
                ant1 = actual; 
	        }


    }
}

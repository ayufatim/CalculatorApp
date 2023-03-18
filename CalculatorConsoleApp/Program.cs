namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            //int a = 10; // declarasi variabel a, dg nilai awal 10;
            //int b = 6; //declarasi variabel b, dg nilai awal 6;

            Console.WriteLine("Pilih Menu Calculator");
            Console.WriteLine("\n1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("\nInput Nomor Menu [1..4]: ");
            int nomor = int.Parse(Console.ReadLine());

            int a, b; //switch
            switch (nomor)
            {
                case 1:
                    Console.Write("Inputkan Nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());//proses casting 
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());//proses casting 

                    Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
                    break;

                case 2:
                    Console.Write("Inputkan Nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());//proses casting 
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());//proses casting 

                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;

                case 3:
                    Console.Write("Inputkan Nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());//proses casting 
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());//proses casting 

                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                    break;

                case 4:
                    Console.Write("Inputkan Nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());//proses casting 
                    Console.Write("Inputkan Nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());//proses casting 

                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                    break;

                default:
                    Console.WriteLine("\nMaaf menu yang and pilih tidak tersedia");
                    break;
            }
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        { 
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
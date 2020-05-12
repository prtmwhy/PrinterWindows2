using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();

            Console.WriteLine("Pilih Printer: \n1. Epson\n2. Canon\n3. LaserJet");

            Console.Write("\nNomor Printer [1 ... 3] : ");
            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            IPrinterWindows printer = new PrinterWindows();

            if (pilihPrinter > 0 && pilihPrinter < 4)
            {
                if (pilihPrinter == 1)
                {
                    printer = new Epson();
                }
                else if (pilihPrinter == 2)
                {
                    printer = new Canon();
                }
                else
                {
                    printer = new LaserJet();
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid \n");
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
   
   public interface IPrinterWindows
    {
        void Show();

        void Print();
    }
    
   
   class PrinterWindows : IPrinterWindows 
    {
        public void Show()
        {
            Console.WriteLine("Printer Windows display dimension: ");
        }

        public void Print()
        {
            Console.WriteLine("Printer Windows printing... ");
        }
    }
   
    
    public class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Epson printer printing...");
        }
    }
    
    public class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }
    
    public class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }
        public void Print()
        {
            Console.WriteLine("LaserJet printer printing...");
        }
    }
    
}
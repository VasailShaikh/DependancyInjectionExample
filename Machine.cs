using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TESTApp
{
    public interface IPrinter
    {
        void Print(string text);
    }

    public interface IScanner
    {
        void Print(string text);
    }

    public class Machine : IPrinter, IScanner
    {
        void IPrinter.Print(string text)
        {
            Console.WriteLine($"Printer: {text}");
        }

        void IScanner.Print(string text)
        {
            Console.WriteLine($"Scanner: {text}");
        }
    }

    public class MakeCopy
    {
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;

        public MakeCopy(IPrinter printer, IScanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }

        public void PrintXerox(string scannedText)
        {
            _scanner.Print(scannedText);
            _printer.Print(scannedText);
        }
    }
}

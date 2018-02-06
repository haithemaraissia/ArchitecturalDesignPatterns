using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Behavioral.Template
{
    public abstract class Exporter
    {
        public abstract void ReadData();
        public abstract void WriteData();
    }

    public class PdfExporter: Exporter
    {
        public override void ReadData()
        {
            Console.WriteLine("Reading Data from PDFExpoter");
        }

        public override void WriteData()
        {
            Console.WriteLine("Writing Data from PDFExpoter");
        }
    }

    public class ExcelExporter : Exporter
    {
        public override void ReadData()
        {
            Console.WriteLine("Reading Data from ExcelExporter");
        }

        public override void WriteData()
        {
            Console.WriteLine("Writing Data from ExcelExporter");
        }
    }
}

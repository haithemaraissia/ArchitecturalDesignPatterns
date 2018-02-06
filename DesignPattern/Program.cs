using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DesignPattern.DP.Behavioral.Observer.Observer;
using DesignPattern.DP.Behavioral.Observer.Subject;
using DesignPattern.DP.Behavioral.State;
using DesignPattern.DP.Behavioral.State.ConcreteState;
using DesignPattern.DP.Behavioral.Strategy.SalaryStrategy.Concrete;
using DesignPattern.DP.Behavioral.Strategy.SalaryStrategy.Context;
using DesignPattern.DP.Behavioral.Template;
using DesignPattern.DP.Creational.Builder.InvoiceBuilder.Builder;
using DesignPattern.DP.Creational.Builder.InvoiceBuilder.Concrete;
using DesignPattern.DP.Creational.Builder.InvoiceBuilder.Director;
using DesignPattern.DP.Creational.Factory.AirlineFactory.Creator.Concrete;
using DesignPattern.DP.Creational.Prototype.Concrete;
using DesignPattern.DP.Structural;
using DesignPattern.DP.Structural.Adapter.Adapter;
using DesignPattern.DP.Structural.Adapter.Target;
using DesignPattern.DP.Structural.Composite.Composite;
using DesignPattern.DP.Structural.Composite.Leaf;
using DesignPattern.DP.Structural.Composite.xSample;
using DesignPattern.DP.Structural.Facade;
using DesignPattern.DP.Structural.Proxy.Proxy;
using DesignPattern.DP.Structural.Proxy.xSample;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Creational

            // FactoryPattern();
            // BuilderPattern();
            //PrototypePattern();

            #endregion

            #region Behavioral

            //TemplatePattern();
            //StrategyPattern();
            //ObserverPattern();
            //StatePattern();

            #endregion

            #region Structural

            //FacadePattern();

            //AdapterPattern();

            //CompositePattern();

            //ProxyPattern();

            Console.ReadLine();

            #endregion
        }


        #region Creational

        #region FactoryPattern

        private static void FactoryPattern()
        {
            var airlines = new string[]
            {
                "delta",
                "jetblue",
                "united"
            };

            var factory = new ConcreteAirlineFactory();

            foreach (var airline in airlines)
            {
                var airlineType = factory.GetAirline(airline);
                Console.Write("Airline: {0} -- Price: {1}", airline, airlineType.GetPrice());
            }
        }

        #endregion

        #region BuilderPattern

        private static void BuilderPattern()
        {
            var invoiceDirector = new InvoiceDirector();
            IInvoiceBuilder invoice = new GazInvoice();
            invoiceDirector.Construct(invoice);
            Console.Write("Construction of Gaz's Invoice : {0}", invoice.GetInvoice());
        }






        #endregion

        #region Prototype

        private static void PrototypePattern()
        {
            var Cat1 = new Cat();
            Cat1.Age = 5;
            Cat1.Name = "James";

            var Cat2 = (Cat)Cat1.Clone();
            Console.WriteLine("Name - Age: {0}", Cat1.GetDetails());
            Console.WriteLine("Name - Age: {0}", Cat2.GetDetails());
        }

        #endregion

        #endregion

        #region Behavioral

        #region Template

        private static void TemplatePattern()
        {
            Exporter export = null;

            export = new ExcelExporter();
            export.ReadData();
            export.WriteData();

            export = new PdfExporter();
            export.ReadData();
            export.WriteData();
        }

        #endregion

        #region Strategy

        private static void StrategyPattern()
        {
            var newEmployeeSalary = new SalaryContext(new SeniorSoftwareEnginner());
            Console.Write(string.Format("Salary for Senior Software Enginner:{0}", newEmployeeSalary.GetSalary()));
        }


        #endregion

        #region Observer

        public static void ObserverPattern()
        {
            var tick = new Tick("MSFT", 100);
            tick.Add(new Trader("Haithem"));
            tick.Add(new Trader("Fred"));

            tick.Price = 101;
            tick.Price = 102;
            tick.Price = 103;
        }

        #endregion

        #region State

        public static void StatePattern()
        {
            var vm = new VendingMachine(new Full());
            vm.Request();
        }


        #endregion


        #endregion

        #region Structural

        #region FacadePattern

        private static void FacadePattern()
        {
            var developer = new Developer();

            Console.WriteLine("----WORKING ON TASK");
            developer.WorkOnTask();
            Console.WriteLine();

            Console.WriteLine("----SUBMIT TO QA");
            developer.SubmitToQA();
            Console.WriteLine();
        }

        #endregion

        #region AdapterPattern

        private static void AdapterPattern()
        {
            Battery carBattery = new Charger();
            carBattery.Charge();
        }

        #endregion

        #region CompositePattern

        public static void CompositePattern()
        {
            var HLead = new TeamLeader("Haithem");
            var JLead = new TeamLeader("Jerry");
            var MM = new Member("Mike");
            var SM = new Member("Sabrina");
            var OM = new Member("Monica");

            HLead.AddMember(MM);
            HLead.AddMember(SM);
            JLead.AddMember(OM);
            HLead.AddMember(JLead);
            HLead.Show();

        }

        #endregion

        #region ProxyPattern

        private static void ProxyPattern()
        {
            var proxyClient = new ProxyClient();

            proxyClient.GetData();

        }

        #endregion

        #endregion

    }
}

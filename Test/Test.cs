using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp.GetInspector();
            FunctionInsp.GetСarInspection();
            FunctionInsp.GetWorker();
            FunctionInsp.SetInspector();
            FunctionInsp.GetInspector();
            FunctionInsp.AddWorker();
            FunctionInsp.GetWorker();
            FunctionInsp.GenerateNumber(123, "а", 75);
            FunctionInsp.GenerateNumber(123, "а", 85);
            Console.ReadLine();
        }
    }
}

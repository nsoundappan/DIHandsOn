using System;
using System.Collections.Generic;
using DataInList;
using DIInterface;
using DIResolver;
using ServiceLayer;

namespace DI_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListData LD = new ListData();
           // IPickDataSource DS = IoCInjection.ConfigurUnityContainer();
            DataService DS = new DataService(IoCInjection.ConfigurUnityContainer());
            List<string> Lst = new List<string>();
            DS.Add("Array");
            Lst = DS.GetList();
            foreach (string str in Lst)
                Console.WriteLine(str);


            Console.Read();
        
        }
    }
}

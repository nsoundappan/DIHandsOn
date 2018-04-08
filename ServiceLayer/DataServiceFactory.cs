using DIInterface;
using System;
using System.Configuration;
using System.Reflection;

namespace ServiceLayer
{
    public static class DataServiceFactory
    {
        public static IPickDataSource GetInstance()
        {
            string StrSource =  ConfigurationSettings.AppSettings["DataSource"];
            Type TSource = Type.GetType(StrSource);
            Assembly ass = Assembly.GetExecutingAssembly();
            foreach (Type T in ass.GetTypes())
            {
                Console.WriteLine(T.GetType().ToString());
            }

            object OSource = Activator.CreateInstance(TSource);
            IPickDataSource Source = OSource as IPickDataSource;
            return Source;
        }
    }
}


using DIInterface;
using System.Collections.Generic;


namespace ServiceLayer
{
    public class DataService
    {
        private IPickDataSource LD;

        public DataService(IPickDataSource source)
        {
            LD = source;
        }
        public void Add(string str)
        {            
            LD.AddToList(str);
        }

        public List<string> GetList()
        {            
            return LD.ReturnList();
        }
    }
}

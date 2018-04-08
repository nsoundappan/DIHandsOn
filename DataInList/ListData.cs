
using DIInterface;
using System.Collections.Generic;


namespace DataInList
{
    public class ListData : IPickDataSource
    {
        public List<string> LstDi = new List<string>();

        public List<string> ReturnList()
        {
            return LstDi;
        }

        public void AddToList(string ToAdd)
        {
            LstDi.Add(ToAdd);            
        }
    }
}

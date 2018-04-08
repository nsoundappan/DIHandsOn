using DIInterface;
using System.Collections.Generic;
using System.Linq;


namespace DataInArray
{
    public class ArrayData : IPickDataSource
    {
        string[] str = new string[10]; 

        public void AddToList(string ToAdd)
        {
            str.SetValue(ToAdd, 0);
            str.SetValue("2nd", 1);
        }

        public List<string> ReturnList()
        {
            return str.ToList();
        }
    }
}

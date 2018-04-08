using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIInterface
{
    public interface IPickDataSource
    {       
        List<string> ReturnList();

        void AddToList(string ToAdd);
    }
}

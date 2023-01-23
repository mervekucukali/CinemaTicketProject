using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketProject
{
    internal interface ICrud<T>
    {
        bool Add(T obj);
        bool Delete(int id);
        List<T> List();
        T Detail(int id);
    }
}

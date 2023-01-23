using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketProject
{
    internal class TheaterProccess : ICrud<Theater>
    {
        public bool Add(Theater obj)
        {
            Theater theater = obj;
            if (theater != null)
            {
                DbContext.TheaterList.Add(theater);
                return true;
            }
            else return false;
        }

        public bool Delete(int id)
        {
            bool IsDelete = false;
            foreach (var theater in DbContext.TheaterList.ToList())
            {
                if (theater.Id == id)
                {
                    DbContext.TheaterList.Remove(theater);
                    IsDelete = true;
                    break;
                }
            }

            return IsDelete;
        }

        public Theater Detail(int id)
        {
            Theater theaterDetail = null;
            foreach (var theater in DbContext.TheaterList.ToList())
            {
                if (theater.Id == id)
                {
                    theaterDetail = theater;
                    break;
                }
            }

            return theaterDetail;
        }

        public List<Theater> List()
        {
            List<Theater> theaters = DbContext.TheaterList.ToList();
            return theaters;
        }
    }
}

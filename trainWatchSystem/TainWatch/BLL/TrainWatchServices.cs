using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainWatchSystem.DAL;
using TrainWatchSystem.Entities;

namespace TrainWatchSystem.BLL
{
    public class TrainWatchServices
    {

        private readonly TrainWatchContext _context;


        internal TrainWatchServices(TrainWatchContext regContext)
        {
            _context = regContext;
        }


        public DbVersion GetDbVersion()
        {


            DbVersion info = _context.DbVersions.FirstOrDefault();
            return info;
        }
    }
}

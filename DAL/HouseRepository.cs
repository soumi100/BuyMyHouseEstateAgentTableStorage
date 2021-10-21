using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HouseRepository : RepositoryBase<House>
    {
        public HouseRepository(AzureContext context)
          : base(context)
        {
            if (context == null)
                throw new ArgumentNullException("Context cannot be null!");
        }
    }
}

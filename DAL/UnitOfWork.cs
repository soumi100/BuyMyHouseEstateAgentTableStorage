using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IDisposable
    {
        AzureContext context;

        private HouseRepository houseRepository;

        public UnitOfWork(string tenantId)
        {
            string connectionString = "DefaultEndpointsProtocol=http;AccountName=<my storage name>;AccountKey=<my account key>";

            this.context = new AzureContext(connectionString, tenantId);
        }

        public HouseRepository HouseRepository
        {
            get
            {
                if (houseRepository == null)
                    houseRepository = new HouseRepository(context);

                return houseRepository;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }
        }
    }
}

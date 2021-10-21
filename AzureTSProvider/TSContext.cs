using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureTSProvider
{
    public abstract class TSContext
    {
        private string tableName { get; set; }
        private string connectionString { get; set; }

        public TSContext(string connectionString, string tableName)
        {
            this.tableName = tableName;
            this.connectionString = connectionString;
        }

        public virtual TableSet<TEntity> Set<TEntity>()
            where TEntity : class, new()
        {
            var set = new TableSet<TEntity>(connectionString, tableName);

            return set;
        }
    }
}

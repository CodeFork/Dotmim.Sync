using Dotmim.Sync.Manager;
using System.Data.Common;

namespace Dotmim.Sync.SqlServer.Manager
{
    public class SqlManager : DbTableManagerFactory
    {

        public SqlManager(string tableName, string schemaName) : base(tableName, schemaName)
        {

        }

        public override IDbTableManager CreateManagerTable(DbConnection connection, DbTransaction transaction = null)
        {
            return new SqlManagerTable(connection, transaction)
            {
                TableName = this.TableName,
                SchemaName = this.SchemaName
            };
        }


    }
}

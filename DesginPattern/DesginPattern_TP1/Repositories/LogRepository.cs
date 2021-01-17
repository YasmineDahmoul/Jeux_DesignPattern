using DesignPatternCL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Repositories
{
    public class LogRepository
    {

        private DatabaseConnection db; 

        public LogRepository()
        {
            db = DatabaseConnection.GetInstance();
        }

        public List<Log> Get()
        {
            string query = "SELECT * FROM Log";
            List<Log> Logs = new List<Log>();
            DataTable dt = db.Get(query, null);
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    Logs.Add(new Log(row));
            return Logs;
        }

        public void Insert(Log log)
        {
            string query = "INSERT INTO Log VALUES(@Id,@Session,@Action,@Object,@CreatedAt)";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("Id",log.Id),
                new SqlParameter("Session",log.Session),
                new SqlParameter("Action",log.Action),
                new SqlParameter("Object",log.Object),
                new SqlParameter("CreatedAt",log.CreatedAt),
            };
            db.Execute(query, parameters);
        }
    }
}

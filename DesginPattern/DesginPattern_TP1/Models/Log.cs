using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models
{
    public class Log
    {
        public string Id { get; set; }
        public string  Session { get; set; }
        public string Action { get; set; }
        public string Object { get; set; }
        public DateTime CreatedAt { get; set; }

        public Log()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
        }

        public Log(DataRow row)
        {
            Id = row["Id"].ToString();
            Session = row["Session"].ToString();
            Action = row["Action"].ToString();
            Object = row["Object"].ToString();
            CreatedAt = Convert.ToDateTime(row["CreatedAt"]); 
        }

        public Log(string _session,string _action,string _object)
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            Session = _session;
            Action = _action;
            Object = _object;
        }
    }
}

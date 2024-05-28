using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesses.Models
{
    [Table("Logger", Schema = "LOG")]
    public class LogEvent
    {
        public long ID { get; set; }
        public string ControllerName { get; set; }
        public string MethodControllerName { get; set; }
        public string MethodControllerParameters { get; set; }
        public string ServiceName { get; set; }
        public string MethodServiceName { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public DateTime DateTime { get; set; }
    }
}

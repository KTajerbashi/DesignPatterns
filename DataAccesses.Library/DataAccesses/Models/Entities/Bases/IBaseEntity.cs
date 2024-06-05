using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesses.Models.Entities.Bases
{
    public interface IBaseEntity
    {
        int ID { get; set; }
    }
    public class BaseEntity : IBaseEntity
    {
        public int ID { get; set; }
    }
}

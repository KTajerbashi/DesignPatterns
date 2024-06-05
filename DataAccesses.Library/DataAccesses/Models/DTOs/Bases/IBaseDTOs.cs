using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesses.Models.DTOs.Bases
{
    public interface IBaseDTOs
    {
        int Id { get; set; }
    }
    public class BaseDTO : IBaseDTOs
    {
        public int Id { get; set; }
    }
}

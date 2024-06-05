using DataAccesses.Models.Entities.Bases;

namespace DataAccesses.Models.Entities.Security
{
    public class Person : BaseEntity
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public override string ToString()
        {
            return $"{ID} - {Name} - {Family} ({Guid})";
        }
    }
}

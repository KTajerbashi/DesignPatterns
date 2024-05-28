namespace DataAccesses.Models
{
    public class Person
    {
        public Guid Guid { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public override string ToString()
        {
            return $"{ID} - {Name} - {Family} ({Guid})";
        }
    }
}

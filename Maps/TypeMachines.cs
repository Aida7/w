namespace Maps
{
    public class TypeMachines
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string NumberMachin { get; set; }
        public virtual Routes Routes { get; private set; }
    }
}
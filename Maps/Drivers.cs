namespace Maps
{
    public class Drivers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Purse { get; set; }
        public virtual TypeMachines TypeMachines { get; private set; }
        public int TypeMachinesId { get; private set; }
        public int RoutesId { get; private set; }
       public bool OrderCompleted { get; set; }

    }
}
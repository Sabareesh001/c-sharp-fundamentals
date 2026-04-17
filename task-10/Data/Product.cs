namespace task_10.Data
{
    public class Product(string Name, int Id, float Price)
    {
        public string Name { get; set; } = Name;
        public int Id { get; set; } = Id;
        public float Price { get; set; } = Price;
    }

}

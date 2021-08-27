namespace Trucker
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public abstract string ConvertToCsv();

    }
}

namespace WebAppDETAug2022.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public String Category { get; set; }

        public int Price { get; set; }

        public int MaxLimit { get; set; }

        internal static object FindIndex(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        internal static void Remove(Pizza ticket)
        {
            throw new NotImplementedException();
        }
    }
}

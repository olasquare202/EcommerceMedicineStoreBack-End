namespace EMedicineBE.Models
{
    public class Orders
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int OrderNo { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; }
    }
}

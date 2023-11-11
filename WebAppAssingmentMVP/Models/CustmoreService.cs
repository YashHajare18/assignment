namespace WebAppAssingment.Models
{
    public class CustmoreService : Icustomer
    {
        private static List<Customer> _custlist;
        public CustmoreService()
        {
            _custlist = new List<Customer>() {
              new Customer() { Id = 1,Name = "Yash", Mobno= "9823191893", BillAmt=2000},
              new Customer() { Id = 2, Name = "Jay", Mobno = "8007466317", BillAmt = 6000 },
              new Customer() { Id = 3, Name = "Shubham", Mobno = "8732792336", BillAmt = 6000 }
            };

        }
        public IEnumerable<Customer> GetAllEmployee()
        {
            return _custlist;
        }
    }
}

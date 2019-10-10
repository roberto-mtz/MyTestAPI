namespace WebAPIStarter.Models
{
    public class Customer
    {
        private int myVar;
        public int MyProperty {
            get { return myVar;}
            set { myVar = value; }
        }
        public long Id {get; set;}
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string Email { get; set;}
    }
}
using System;
namespace AspCoreCRUD.Models
{
    public class Employee
    {
        //public int id
        //{
        //    get;
        //    set;
        //}
        //public string firstName
        //{
        //    get;
        //    set;
        //}
        //public string lastName
        //{
        //    get;
        //    set;
        //}
        //public string phoneNumber
        //{
        //    get;
        //    set;
        //}

        public int trackingNumber
        {
            get;
            set;
        }
        public int shippingCost
        {
            get;
            set;
        }
        public int handlingCost
        {
            get;
            set;
        }
        public int subtotal
        {
            get;
            set;
        }
        public int grandTotal
        {
            get;
            set;
        }
        public int balance
        {
            get;
            set;
        }
        public int cardNumber
        {
            get;
            set;
        }
        public int cvv
        {
            get;
            set;
        }
        public int payAmount
        {
            get;
            set;
        }
        public string orderStatus
        {
            get;
            set;
        }
        public string shipAddress
        {
            get;
            set;
        }
        public string shipAddressEmail
        {
            get;
            set;
        }
        public string paymentEmail
        {
            get;
            set;
        }
        public string expiryDate
        {
            get;
            set;
        }
        public string orderDate
        {
            get;
            set;
        }
        public string shippedDate
        {
            get;
            set;
        }
        public int id
        {
            get;
            set;
        }
        public Employee()
        {

        }
    }
}
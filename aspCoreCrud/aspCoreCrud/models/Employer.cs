using System;
namespace AspCoreCRUD.Models
{

    public class Employer
    {
        public int id
        {
            get;
            set;
        }
        public int orderid
        {
            get;
            set;
        }
        public string productId
        {
            get;
            set;
        }
        public int Quantity
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }

        public Employer()
        {
        }
    }
}

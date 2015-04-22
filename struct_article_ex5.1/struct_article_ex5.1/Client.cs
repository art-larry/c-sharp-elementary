using System;

namespace struct_article_ex5._1
{
    struct Client
    {
        int codeClient;
        string nameClient;
        string sonameClient;
        string addressClient;
        string phoneClient;
        int ordersQuantity;
        double totalSumOrders;
        ClientType typeClient;

        public int CodeCient
        {
            get { return codeClient; }
            set { codeClient = value; }
        }

        public string NameClient
        {
            get { return nameClient; }
            set { nameClient = value; }
        }

        public string SonameClient
        {
            get { return sonameClient; }
            set { sonameClient = value; }
        }

        public string AddressClient
        {
            get { return addressClient; }
            set { addressClient = value; }
        }

        public string PhoneClient
        {
            get { return phoneClient; }
            set { phoneClient = value; }
        }

        public int OrdersQuantity
        {
            get { return ordersQuantity; }
            set { ordersQuantity = value; }
        }

        public double TotalSumOreders
        {
            get { return totalSumOrders; }
            set { totalSumOrders = value; }
        }

        public ClientType TypeClient
        {
            get { return typeClient; }
            set { typeClient = value; }
        }
    }
}

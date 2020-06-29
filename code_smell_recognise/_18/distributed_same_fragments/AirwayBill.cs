using System;

namespace code_smell_recognise._18.distributed_same_fragments
{
    public class AirwayBill //快递单
    {
        private CustomerName toCustomerName;
        private Address toAddress;
        private string toTel;
        private CustomerName fromCustomerName;
        private Address fromAddress;
        private string fromTel;
        
        public string to() {
            return "Customer: " +
                   toCustomerName.Title + toCustomerName.FirstName + " " + toCustomerName.LastName +
                   Environment.NewLine +
                   "Address: " +
                   toAddress.HouseNumber + " " +
                   toAddress.StreetAddress + ", " +
                   toAddress.City + ", " +
                   toAddress.Province + ", " +
                   toAddress.ZipCode +
                   Environment.NewLine +
                   "Tel: " + toTel;
        }

        public string from() {
            return "Customer: " +
                   fromCustomerName.Title + fromCustomerName.FirstName + " " + fromCustomerName.LastName +
                   Environment.NewLine +
                   "Address: " +
                   fromAddress.HouseNumber + " " +
                   fromAddress.StreetAddress + ", " +
                   fromAddress.City + ", " +
                   fromAddress.Province + ", " +
                   fromAddress.ZipCode +
                   Environment.NewLine +
                   "Tel: " + fromTel;
        }
    }
}
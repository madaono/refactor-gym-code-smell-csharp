using System;

namespace code_smell_recognise._20
{
    public class DeliveryManager
    {
        private string toAddress;
        private string fromAddress;

        public DeliveryManager(string address, string fromAddress)
        {
            toAddress = address;
            this.fromAddress = fromAddress;
        }

        public DeliverCenter AllocateTo(){
            if (getProvince(toAddress) == getProvince(fromAddress)) {
                return DeliverCenter.Local;
            }
            if (getProvince(toAddress) == "湖北" && getCity(toAddress) == "武汉"){
                Console.WriteLine("因疫情原因站点暂无法派送");
                return DeliverCenter.Local;
            }
            return DeliverCenter.Foreign;
        }

        private string getCity(String address) {
            return address.Substring(address.IndexOf("省", StringComparison.Ordinal) + 1, address.IndexOf("市", StringComparison.Ordinal));
        }

        private string getProvince(String address) {
            return address.Substring(0, address.IndexOf("省", StringComparison.Ordinal));
        }
    }
}
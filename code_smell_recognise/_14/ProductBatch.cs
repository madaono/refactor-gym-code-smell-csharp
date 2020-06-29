using System;

namespace code_smell_recognise._14
{
    public class ProductBatch
    {
        public string Name { get; set; }
        public string BatchId { get; set; }
        public int BatchCountTotal { get; set; }
        public int BatchCountLeft { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}
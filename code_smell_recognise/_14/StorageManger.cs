using System;
using System.Collections.Generic;
using System.Linq;

namespace code_smell_recognise._14
{
    public class StorageManger
    {
        public List<ProductBatch> ProductBatches { get; } = new List<ProductBatch>();
        public List<ProductBatch> ProductBatchesToExpired { get; private set; }
        
        public void AddProductBatch(ProductBatch productBatch) {
            ProductBatches.Add(productBatch);
            ProductBatchesToExpired = ProductBatches.Where(batch => DateTime.Now.AddDays(30) > batch.ExpiredDate).ToList();
        }

        public void RemoveProductBatch(ProductBatch productBatch) {
            ProductBatches.RemoveAll(batch => batch.BatchId == productBatch.BatchId);
        }

        public void SendExpiredAlert() {
            Console.WriteLine("Expired alert:");
            ProductBatchesToExpired.ForEach(productBatch =>
                Console.WriteLine(productBatch.Name + " " + productBatch.BatchId
                                   + " will expired on " + productBatch.ExpiredDate));
        }
    }
}
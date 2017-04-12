using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    public class Products_Suppliers
    {
        public int ProductSupplierId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }

        private string GetProductName()
        {

            //string result = products.Find(i => i.ProductId == ProductId).ProdName;
            //return result;
            return "";
        }

        private string GetSupplierName(List<Supplier> suppliers)
        {
            string result = suppliers.Find(i => i.SupplierId == SupplierId).SupName;
            return result;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

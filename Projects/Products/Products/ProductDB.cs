using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public static class ProductDB
    {
        // reads ands saves products data to a local file named "products.txt"
        const string path = "products.txt";
        public static void Save(List<Product> prodlist)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach(Product p in prodlist)
                {
                    //string line = p.Name + ", " + p.Price + ", " + p.Qty;
                    sw.WriteLine(p.CsvString());
                }
                MessageBox.Show("Data written Successfully!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Could not find file " + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ": " + ex.Message);
            }
            finally
            {
                if(sw != null)
                {
                    sw.Close(); // close if file is not null
                }                
            }
        }
    }
}

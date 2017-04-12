using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTest
{
    public partial class Form1 : Form
    {
        private List<Package> packages = PackageDB.GetPackages();
        public List<Product> Products = new List<Product>();
        public List<Supplier> suppliers = new List<Supplier>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count = 0;
            foreach(Package p in packages)
            {
                Button button = new Button();
                button.Location = new Point(10, 30*count);
                button.Name = "btn" + p.PackageId.ToString();
                button.Size = new Size(200, 30);
                button.TabIndex = count;
                button.Text = p.PkgName;
                button.Tag = count.ToString();
       
                button.Click += button_click;
                Controls.Add(button);
                count++;
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            Button origin = (Button) sender;
            textBox1.Text = packages[Convert.ToInt32(origin.Tag)].PkgDesc;
            textBox2.Text = packages[Convert.ToInt32(origin.Tag)].PkgAgencyCommission.ToString();

            List<Product> products = PackageDB.GetProductsByPackageId(2);

            listBox1.Items.Clear();
            foreach (Product p in products)
            {
                listBox1.Items.Add(p);
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBostonTutorials
{
    public partial class Form1 : Form
    {
        private List<Person> people = null;
        private BindingList<Person> bindingList;
        public Form1()
        {
            InitializeComponent();
            var people = new List<Person>()
            {
                new Person("Bob"),
                new Person("Joe"),
                new Person("Steve")
            };
            bindingList = new BindingList<Person>(people);
            var source = new BindingSource(bindingList, null);
            dataGridView.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingList.Add(new Person("John"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextFile
{
    public partial class Form1 : Form
    {
        // storage array
        const int MAX_SIZE = 100;
        int[] numbers = new int[MAX_SIZE];
        int howmany = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // reads data from a file that contains one int number per line
        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr = null;
            string path;
            string line;
            int num;

            // get the path
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
            else
            {
                return;
            }
            try
            {
                // create FileStream and StreamReader objects
                fs = new FileStream(path, FileMode.Open, FileAccess.Read); // open for reading
                sr = new StreamReader(fs);

                // do the reading and close
                while (!sr.EndOfStream) // while still data in array
                {
                    line = sr.ReadLine();
                    num = Convert.ToInt32(line); // one in number per line
                    numbers[howmany] = num; // store in next empty element in array
                    howmany++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString() + ": " + ex.Message, "Error while reading");
            }
            finally
            {
                if(sr != null)
                {
                    sr.Close(); // closes the file
                }
            }
            

            // call the display method
            DisplayNumbers();
            howmany = 0;
        } // end of handler

        private void DisplayNumbers()
        {
            // clear listbox first
            lstNumbers.Items.Clear();
            for(int i = 0; i < howmany; i++)
            {
                lstNumbers.Items.Add(numbers[i]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(txtAdd.Text);
            numbers[howmany] = num;
            howmany++;
            DisplayNumbers();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamWriter sw = null;
            string path;
            // get the path
            DialogResult dr = saveFileDialog1.ShowDialog();
            
            if(dr == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            else
            {
                return;
            }
            try
            {
                // create filestream and streamwriter objects
                fs = new FileStream(path, FileMode.Create, FileAccess.Write); // open for writing
                sw = new StreamWriter(fs);

                // do the writing and close the file
                for (int i = 0; i < howmany; i++)
                {
                    sw.WriteLine(numbers[i]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString() + ": " + ex.Message, "Error while reading");
            }
            finally
            {
                if(sw != null)
                {
                    sw.Close();
                }
            }
            
        }
    }
}

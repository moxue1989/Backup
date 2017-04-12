using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //On Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            lvData.View = View.Details;//View the data details
            lvData.FullRowSelect = true;//Select the entire row of data

            //Add Columns
            lvData.Columns.Add("Name", 150);//Add Name column with and set width to 150
            lvData.Columns.Add("Position", 150);//Add Position column with and set width to 150
            lvData.Columns.Add("Team", 150);//Add Team column with and set width to 150
        }

        private void lvData_MouseClick(object sender, MouseEventArgs e)
        {
            String name = lvData.SelectedItems[0].SubItems[0].Text;//store list item name in string
            String pos = lvData.SelectedItems[0].SubItems[1].Text;//store list item pos in string
            String team = lvData.SelectedItems[0].SubItems[2].Text;//store list item team in string

            txtName.Focus();
            txtName.Text = name;//Display selected row "name" in input box
            txtPos.Text = pos;//Display selected row "pos" in input box
            txtTeam.Text = team;//Display selected row "team" in input box
        }

            //Add Row
        private void add(string name, String pos, String team)
        {
            String[] row = { name, pos, team };// Create array for storing user data

            ListViewItem item = new ListViewItem(row); //Store user input in array

            //Add Items
            lvData.Items.Add(item);//Add user input in List View
        }
        //Add record button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add(txtName.Text, txtPos.Text, txtTeam.Text);//add all inputed data into ListView

            //Clear Text
            txtName.Clear();
            txtPos.Clear();
            txtTeam.Clear();

            txtName.Focus();

        }
        //Clear Inputs
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear Text
            txtName.Clear();
            txtPos.Clear();
            txtTeam.Clear();

            txtName.Focus();
        }

        //Update Input Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lvData.SelectedItems[0].SubItems[0].Text = txtName.Text;//pull list item name and update if necassary with new iput
            lvData.SelectedItems[0].SubItems[1].Text = txtPos.Text;//pull list item pos and update if necassary with new iput
            lvData.SelectedItems[0].SubItems[2].Text = txtTeam.Text;//pull list item team and update if necassary with new iput

            //Clear Text
            txtName.Clear();
            txtPos.Clear();
            txtTeam.Clear();

            txtName.Focus();
        }

        //Delete Method declared
        private void delete()
        { 
            if (MessageBox.Show("Sure ??", "DELETE",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lvData.Items.RemoveAt(lvData.SelectedIndices[0]);//remove the selected row
                //Clear Text
                txtName.Clear();
                txtPos.Clear();
                txtTeam.Clear();

                txtName.Focus();
            }
        }

        //Delete Records
        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}

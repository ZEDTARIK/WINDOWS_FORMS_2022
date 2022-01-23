using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectToDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.databaseDataSet.customers);
            // TODO: This line of code loads data into the 'databaseDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.databaseDataSet.customers);

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genderCheckBox.CheckState == CheckState.Checked)
                genderCheckBox.Text = "Male";
            else if (genderCheckBox.CheckState == CheckState.Unchecked)
                genderCheckBox.Text = "Female";
            else
                genderCheckBox.Text = "";
        }
    }
}

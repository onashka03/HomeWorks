using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restraunt
{
    public partial class TastyForm1 : Form
    {
        Employee employee;
        string MenuItem;
        object order;
        public TastyForm1()
        {
            InitializeComponent();
            employee = new Employee();
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(NametextBox1.Text);
                order = employee.NewRequest(quantity, MenuItem);
            }
            catch (Exception ex)
            { 
              MessageBox.Show(ex.Message,"Error!");
            }
            Quantitylabel.Text = employee.Inspect(order);
            Food.Items.Add("order accepted!");

        }
        private void Copybutton_Click(object sender, EventArgs e)
        {
            try
            {
                order = employee.CopyRequest();
                Quantitylabel.Text = employee.Inspect(order);
                Food.Items.Add("order is Copied!");
             }
             catch (Exception ex)
            { 
              MessageBox.Show(ex.Message,"Error!");
            }
            
        }
        private void Preparebutton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = employee.PrepareFood(order);
                Food.Items.Add(item: result);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ChickenradioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobutton = (RadioButton)sender;
            MenuItem = ChickenradioButton1.Text;
        }
        private void EggradioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobutton = (RadioButton)sender;
            MenuItem = EggradioButton2.Text;
        }
    }
}

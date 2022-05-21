using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASAR
{
    public partial class Passenger1 : Form
    {
        public Passenger1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPerson form2 = new AddPerson();
            MessageBox.Show("Passenger Is Submitted Successfully");
        }
    }
}

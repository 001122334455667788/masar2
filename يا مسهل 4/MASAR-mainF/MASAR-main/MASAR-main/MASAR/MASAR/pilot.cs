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
    public partial class pilot : Form
    {
        public pilot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPerson form3 = new AddPerson();
            MessageBox.Show("Pilot Is Submitted Successfully");
        }
    }
}

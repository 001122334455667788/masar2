using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MASAR
{
    public partial class AddPerson:Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Salma Mahmoud\Downloads\Airline-1.mdf;Integrated Security = True; Connect Timeout = 30");
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || phone.Text == "" ||  nation.Text == "" || gender.Text == "" || airline_id.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Person values (" + id.Text + ",'" + name.Text + "','" + phone.Text + "','" + nation.Text + "','" + gender.Text + "','" + airline_id.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record added successfully");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Passenger1 passenger1 = new Passenger1();
            passenger1.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendant attendant = new Attendant();
            attendant.per_id = id.Text;
            attendant.ShowDialog();
            if (id.Text == "" || name.Text == "" || phone.Text == "" || nation.Text == "" || gender.Text == "" || airline_id.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Person values (" + id.Text + ",'" + name.Text + "','" + phone.Text + "','" + nation.Text + "','" + gender.Text + "','" + airline_id.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record added successfully");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
            Attendant att = new Attendant();
            att.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || nation.Text == "" || gender.Text == "" || airline_id.Text == ""||airline_id.Text=="")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Person values (" + id.Text + ",'" + name.Text + "','" + phone.Text + "','" + nation.Text + "','" + gender.Text + "','" + airline_id.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record added successfully");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }
    }
}

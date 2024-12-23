using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-23IT4LN\\SQLEXPRESS;Initial Catalog=CRUDFROM;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into ur values(@ID,@NAME,@AGE)", con);

            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NAME",textBox2.Text);
            cmd.Parameters.AddWithValue("@AGE", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Succsessfully Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-23IT4LN\\SQLEXPRESS;Initial Catalog=CRUDFROM;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update ur set NAME=@NAME,AGE=@AGE, where ID=@ID",con);

            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@AGE", double.Parse(textBox3.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Succsessfully Updated");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-23IT4LN\\SQLEXPRESS;Initial Catalog=CRUDFROM;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete ur where id=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("Succsessfully deleted");
        }
    }


}
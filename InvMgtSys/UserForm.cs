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

namespace InvMgtSys
{
    public partial class UserForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tech Louisville\Documents\dbInvMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }
        public void LoadUser()
        {
            dgvUser.Rows.Clear();
            cmd = new SqlCommand("Select * FROM tbUser", conn);
            conn.Open();
            
        }
    }
}

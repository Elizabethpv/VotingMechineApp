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

namespace VotingMechineApp
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        String Connection = DatabaseConnection.Connection;
        private void Result_Load(object sender, EventArgs e)
        {
            
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlCommand command = new SqlCommand("VotingMechineSystem", connect);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            lblCountSachin.Text= reader["SachinCount"].ToString();
            lblCountSavrav.Text = reader["SavravCount"].ToString();
            lblCountKhan.Text = reader["KhanCount"].ToString();
           
            connect.Close();
        }
    }
}

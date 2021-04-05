using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingMechineApp
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
           (
              int nLeft,
              int nTop,
              int nRight,
              int nBottom,
              int nWidthEllipse,
              int nHeightEllipse
           );
        public Form1()
        {
            InitializeComponent();
        }
        String Connection = DatabaseConnection.Connection;
        private void Form1_Load(object sender, EventArgs e)
        {
            butnSachin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, butnSachin.Width, butnSachin.Height, 50, 50));
            btnKhan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnKhan.Width, btnKhan.Height, 50, 50));
            btnSavrav.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSavrav.Width, btnSavrav.Height, 50, 50));
            btnSachinSelect.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSachinSelect.Width, btnSachinSelect.Height, 100, 100));
            btnKhanSelect.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnKhanSelect.Width, btnKhanSelect.Height, 100, 100));
            btnSavravSelect.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSavravSelect.Width, btnSavravSelect.Height, 100, 100));
            btnReady.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnReady.Width, btnReady.Height, 100, 100));

            PresidingOfficer po = new PresidingOfficer();
            po.Show();

            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlCommand cmd = new SqlCommand("VotingMechineSystem", connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            String status;
            if (ds.Tables[0].Rows.Count > 0)
            {
                status = ds.Tables[0].Rows[0]["VotingState"].ToString();


                if (status == "VoterReady")
                {
                    btnReady.BackColor = Color.Green;
                }
                else
                {
                    btnReady.BackColor = Color.Red;
                   
                }

            }
        }


        private void butnSachin_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlCommand command = new SqlCommand("UpdateSachinCount", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connect.Close();

            btnSachinSelect.BackColor = Color.Green;
            btnSavravSelect.BackColor = Color.RoyalBlue;
            btnKhanSelect.BackColor = Color.RoyalBlue;
            btnReady.BackColor = Color.Red;

        }

        private void btnSavrav_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlCommand command = new SqlCommand("UpdateSavravCount", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connect.Close();

            btnSavravSelect.BackColor = Color.Green;
            btnSachinSelect.BackColor = Color.RoyalBlue;
            btnKhanSelect.BackColor = Color.RoyalBlue;
            btnReady.BackColor = Color.Red;
        }

        private void btnKhan_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlCommand command = new SqlCommand("UpdateKhanCount", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connect.Close();
            
            btnKhanSelect.BackColor = Color.Green;
            btnSavravSelect.BackColor = Color.RoyalBlue;
            btnSachinSelect.BackColor = Color.RoyalBlue;
            btnReady.BackColor = Color.Red;
        }
    }
}





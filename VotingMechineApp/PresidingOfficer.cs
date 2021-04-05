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
    public partial class PresidingOfficer : Form
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

        public PresidingOfficer()
        {
            InitializeComponent();
        }
        String Connection = DatabaseConnection.Connection;

        private void PresidingOfficer_Load(object sender, EventArgs e)
        {
            btnVoterReady.Region=Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVoterReady.Width, btnVoterReady.Height, 60, 60));
            btnStop.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnStop.Width, btnStop.Height, 60, 60));
            btnVotereadySelection.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVotereadySelection.Width, btnVotereadySelection.Height, 60, 60));
            btnStopSelection.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnStopSelection.Width, btnStopSelection.Height, 60, 60));
            btnFinish.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFinish.Width, btnFinish.Height, 60, 60));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlCommand command = new SqlCommand("UpdateVoteState", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("VotingState", btnStop.Text);
            command.ExecuteNonQuery();
            connect.Close();
            btnStopSelection.BackColor = Color.Green;
            btnVotereadySelection.BackColor = Color.White;
        }

        private void btnVoterReady_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlCommand command = new SqlCommand("UpdateVoteState", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("VotingState", btnVoterReady.Text);
            command.ExecuteNonQuery();
            connect.Close();
            btnVotereadySelection.BackColor = Color.Green;
            btnStopSelection.BackColor = Color.White;
            


        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlCommand command = new SqlCommand("UpdateVoteState", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("VotingState", btnFinish.Text);
            command.ExecuteNonQuery();
            connect.Close();
            btnVotereadySelection.BackColor = Color.White;
            btnStopSelection.BackColor = Color.White;
            Result result =new Result();
            result.Show();
        }
    }
}


namespace VotingMechineApp
{
    partial class PresidingOfficer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnVoterReady = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnVotereadySelection = new System.Windows.Forms.Button();
            this.btnStopSelection = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.tmrPresiding = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoterReady
            // 
            this.btnVoterReady.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVoterReady.FlatAppearance.BorderSize = 0;
            this.btnVoterReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoterReady.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoterReady.ForeColor = System.Drawing.Color.White;
            this.btnVoterReady.Location = new System.Drawing.Point(52, 64);
            this.btnVoterReady.Name = "btnVoterReady";
            this.btnVoterReady.Size = new System.Drawing.Size(240, 57);
            this.btnVoterReady.TabIndex = 0;
            this.btnVoterReady.Text = "VoterReady";
            this.btnVoterReady.UseVisualStyleBackColor = false;
            this.btnVoterReady.Click += new System.EventHandler(this.btnVoterReady_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(52, 192);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(240, 57);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(52, 312);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(240, 57);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Finish Election";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnVotereadySelection
            // 
            this.btnVotereadySelection.BackColor = System.Drawing.Color.White;
            this.btnVotereadySelection.FlatAppearance.BorderSize = 0;
            this.btnVotereadySelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotereadySelection.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotereadySelection.ForeColor = System.Drawing.Color.White;
            this.btnVotereadySelection.Location = new System.Drawing.Point(139, 26);
            this.btnVotereadySelection.Name = "btnVotereadySelection";
            this.btnVotereadySelection.Size = new System.Drawing.Size(52, 32);
            this.btnVotereadySelection.TabIndex = 3;
            this.btnVotereadySelection.UseVisualStyleBackColor = false;
            // 
            // btnStopSelection
            // 
            this.btnStopSelection.BackColor = System.Drawing.Color.White;
            this.btnStopSelection.FlatAppearance.BorderSize = 0;
            this.btnStopSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopSelection.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopSelection.ForeColor = System.Drawing.Color.White;
            this.btnStopSelection.Location = new System.Drawing.Point(139, 154);
            this.btnStopSelection.Name = "btnStopSelection";
            this.btnStopSelection.Size = new System.Drawing.Size(52, 32);
            this.btnStopSelection.TabIndex = 4;
            this.btnStopSelection.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnStop);
            this.panel.Controls.Add(this.btnStopSelection);
            this.panel.Controls.Add(this.btnVoterReady);
            this.panel.Controls.Add(this.btnVotereadySelection);
            this.panel.Controls.Add(this.btnFinish);
            this.panel.Location = new System.Drawing.Point(12, 37);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(340, 410);
            this.panel.TabIndex = 5;
            // 
            // tmrPresiding
            // 
            this.tmrPresiding.Tick += new System.EventHandler(this.tmrPresiding_Tick);
            // 
            // PresidingOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 456);
            this.Controls.Add(this.panel);
            this.Name = "PresidingOfficer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PresidingOfficer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PresidingOfficer_FormClosed);
            this.Load += new System.EventHandler(this.PresidingOfficer_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoterReady;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnVotereadySelection;
        private System.Windows.Forms.Button btnStopSelection;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer tmrPresiding;
    }
}
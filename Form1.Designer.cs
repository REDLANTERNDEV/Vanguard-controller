namespace Vanguard_Controller
{
    partial class Form1
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
            this.btnDisableVanguard = new System.Windows.Forms.Button();
            this.btnEnableVanguard = new System.Windows.Forms.Button();
            this.btnRestartComputer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisableVanguard
            // 
            this.btnDisableVanguard.BackColor = System.Drawing.Color.Brown;
            this.btnDisableVanguard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDisableVanguard.Location = new System.Drawing.Point(12, 12);
            this.btnDisableVanguard.Name = "btnDisableVanguard";
            this.btnDisableVanguard.Size = new System.Drawing.Size(200, 23);
            this.btnDisableVanguard.TabIndex = 0;
            this.btnDisableVanguard.Text = "Disable Vanguard";
            this.btnDisableVanguard.UseVisualStyleBackColor = false;
            this.btnDisableVanguard.Click += new System.EventHandler(this.btnDisableVanguard_Click);
            // 
            // btnEnableVanguard
            // 
            this.btnEnableVanguard.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEnableVanguard.Location = new System.Drawing.Point(12, 41);
            this.btnEnableVanguard.Name = "btnEnableVanguard";
            this.btnEnableVanguard.Size = new System.Drawing.Size(200, 23);
            this.btnEnableVanguard.TabIndex = 1;
            this.btnEnableVanguard.Text = "Enable Vanguard";
            this.btnEnableVanguard.UseVisualStyleBackColor = false;
            this.btnEnableVanguard.Click += new System.EventHandler(this.btnEnableVanguard_Click);
            // 
            // btnRestartComputer
            // 
            this.btnRestartComputer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRestartComputer.Location = new System.Drawing.Point(12, 70);
            this.btnRestartComputer.Name = "btnRestartComputer";
            this.btnRestartComputer.Size = new System.Drawing.Size(200, 23);
            this.btnRestartComputer.TabIndex = 2;
            this.btnRestartComputer.Text = "Restart Computer";
            this.btnRestartComputer.UseVisualStyleBackColor = false;
            this.btnRestartComputer.Click += new System.EventHandler(this.btnRestartComputer_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(224, 105);
            this.Controls.Add(this.btnRestartComputer);
            this.Controls.Add(this.btnEnableVanguard);
            this.Controls.Add(this.btnDisableVanguard);
            this.Name = "Form1";
            this.Text = "Vanguard Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisableVanguard;
        private System.Windows.Forms.Button btnEnableVanguard;
        private System.Windows.Forms.Button btnRestartComputer;
    }
}


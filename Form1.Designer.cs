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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDisableVanguard = new System.Windows.Forms.Button();
            this.btnEnableVanguard = new System.Windows.Forms.Button();
            this.btnRestartComputer = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisableVanguard
            // 
            this.btnDisableVanguard.BackColor = System.Drawing.Color.Brown;
            this.btnDisableVanguard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDisableVanguard.Location = new System.Drawing.Point(28, 33);
            this.btnDisableVanguard.Name = "btnDisableVanguard";
            this.btnDisableVanguard.Size = new System.Drawing.Size(200, 40);
            this.btnDisableVanguard.TabIndex = 0;
            this.btnDisableVanguard.Text = "Disable Vanguard";
            this.btnDisableVanguard.UseVisualStyleBackColor = false;
            this.btnDisableVanguard.Click += new System.EventHandler(this.btnDisableVanguard_Click);
            // 
            // btnEnableVanguard
            // 
            this.btnEnableVanguard.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEnableVanguard.Location = new System.Drawing.Point(28, 125);
            this.btnEnableVanguard.Name = "btnEnableVanguard";
            this.btnEnableVanguard.Size = new System.Drawing.Size(200, 40);
            this.btnEnableVanguard.TabIndex = 1;
            this.btnEnableVanguard.Text = "Enable Vanguard";
            this.btnEnableVanguard.UseVisualStyleBackColor = false;
            this.btnEnableVanguard.Click += new System.EventHandler(this.btnEnableVanguard_Click);
            // 
            // btnRestartComputer
            // 
            this.btnRestartComputer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRestartComputer.Location = new System.Drawing.Point(28, 219);
            this.btnRestartComputer.Name = "btnRestartComputer";
            this.btnRestartComputer.Size = new System.Drawing.Size(200, 40);
            this.btnRestartComputer.TabIndex = 2;
            this.btnRestartComputer.Text = "Restart Computer";
            this.btnRestartComputer.UseVisualStyleBackColor = false;
            this.btnRestartComputer.Click += new System.EventHandler(this.btnRestartComputer_Click);
            // 
            // btn_test
            // 
            this.btn_test.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_test.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_test.Location = new System.Drawing.Point(28, 79);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(200, 40);
            this.btn_test.TabIndex = 3;
            this.btn_test.Text = "Check Status";
            this.btn_test.UseVisualStyleBackColor = false;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(260, 271);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btnRestartComputer);
            this.Controls.Add(this.btnEnableVanguard);
            this.Controls.Add(this.btnDisableVanguard);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanguard Control";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisableVanguard;
        private System.Windows.Forms.Button btnEnableVanguard;
        private System.Windows.Forms.Button btnRestartComputer;
        private System.Windows.Forms.Button btn_test;
    }
}


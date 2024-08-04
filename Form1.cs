using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanguard_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisableVanguard_Click(object sender, EventArgs e)
        {
            try
            {
                RunCommand("sc config vgc start= disabled");
                RunCommand("sc config vgk start= disabled");
                RunCommand("net stop vgc");
                RunCommand("net stop vgk");
                RunCommand("taskkill /IM vgtray.exe");

                MessageBox.Show("Vanguard başarıyla kapatıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnEnableVanguard_Click(object sender, EventArgs e)
        {
            try
            {
                RunCommand("sc config vgc start= demand");
                RunCommand("sc config vgk start= system");

                MessageBox.Show("Vanguard başarıyla etkinleştirildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnRestartComputer_Click(object sender, EventArgs e)
        {
            try
            {
                RunCommand("shutdown /r /f /t 00");

                MessageBox.Show("Bilgisayar yeniden başlatılıyor.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
        private void RunCommand(string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                Verb = "runas", 
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processInfo))
            {
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output); 
            }
        }
    }
}

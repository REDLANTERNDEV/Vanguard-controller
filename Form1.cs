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

                MessageBox.Show("Vanguard successfuly disabled.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnEnableVanguard_Click(object sender, EventArgs e)
        {
            try
            {
                RunCommand("sc config vgc start= demand");
                RunCommand("sc config vgk start= system");

                MessageBox.Show("Vanguard successfuly enabled.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnRestartComputer_Click(object sender, EventArgs e)
        {
            try
            {
                // Show confirmation message to the user
                DialogResult result = MessageBox.Show(
                    "Do you want to restart the computer?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // If the user selects "Yes"
                if (result == DialogResult.Yes)
                {
                    RunCommand("shutdown /r /f /t 00");
                    MessageBox.Show("The computer is restarting.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void RunCommand(string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                Verb = "runas",  // Run as administrator
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using (Process process = Process.Start(processInfo))
                {
                    // Read the standard output and error
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit(); // Wait for the process to exit

                    // Optionally, show output and error messages if needed
                    if (!string.IsNullOrEmpty(output))
                    {
                        // You can log output to a file or a textbox, for example
                        Console.WriteLine("Output: " + output);
                    }

                    if (!string.IsNullOrEmpty(error))
                    {
                        // You can log errors to a file or a textbox, for example
                        Console.WriteLine("Error: " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while running the command: {ex.Message}");
            }

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                // CMD'yi yönetici olarak çalıştırma
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c \"sc query vgk && sc query vgc\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,  // Çıktıyı yakalamak için
                    RedirectStandardError = true,   // Hataları yakalamak için
                    CreateNoWindow = false,         // Komut istemcisini göstermeye devam et
                    Verb = "runas"                  // Bu, CMD'yi yönetici olarak çalıştırır
                };

                Process process = new Process
                {
                    StartInfo = processInfo
                };

                process.Start();

                // Çıktıyı ve hataları okuma
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit(); // Komutların tamamlanmasını bekler

                // Çıktıyı ve hataları kullanıcıya gösterme
                if (!string.IsNullOrEmpty(output))
                {
                    MessageBox.Show("Output:\n" + output);
                }

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error:\n" + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

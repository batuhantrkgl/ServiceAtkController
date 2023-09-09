using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAtkController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { if (!File.Exists("C:/serviceatkkiller.txt"))
            {
                // Show an error message indicating that the source file doesn't exist.
                MessageBox.Show("SeviceAtkKiller not installed yet, please install and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (File.Exists("C:/serviceatkkiller.exe"))
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sourcePath = "C:/serviceatkkiller.exe.bckp";
                string destinationPath = "C:/serviceatkkiller.exe";
                if (File.Exists(sourcePath))
                {
                    // Rename the file.
                    File.Move(sourcePath, destinationPath);

                    // Now, you can update your button states as needed.
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
                else
                {
                    // Show an error message indicating that the source file doesn't exist.
                    MessageBox.Show("The source file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the file operation.
                // You can show an error message or log the exception details.
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sourcePath = "C:/serviceatkkiller.exe.bckp";
                string destinationPath = "C:/serviceatkkiller.exe";
                if (File.Exists(destinationPath))
                {
                    // Rename the file.
                    File.Move(destinationPath, sourcePath);

                    // Now, you can update your button states as needed.
                    button1.Enabled = true;
                    button2.Enabled = false;
                }
                else
                {
                    // Show an error message indicating that the source file doesn't exist.
                    MessageBox.Show("The source file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the file operation.
                // You can show an error message or log the exception details.
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

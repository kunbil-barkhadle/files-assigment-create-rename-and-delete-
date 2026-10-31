using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace craete_new_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
            private void btnCreate_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter file name");
                return;
            }

            if (Path.GetFileName(fileName) != fileName ||
                Path.GetExtension(fileName) != ".txt")
            {
                MessageBox.Show("Enter a valid .txt file name");
                return;
            }

            string path = Path.Combine(
                Application.StartupPath, fileName);

            if (File.Exists(path))
            {
                MessageBox.Show("File already exists");
            }
            else
            {
                File.Create(path).Close();

                MessageBox.Show("File Created Successfully");
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string oldName = txtFileName.Text.Trim();
            string newName = txtNewFileName.Text.Trim();

            if (string.IsNullOrWhiteSpace(oldName) ||
                string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Enter both file names");
                return;
            }

            if (Path.GetFileName(oldName) != oldName ||
                Path.GetFileName(newName) != newName ||
                Path.GetExtension(oldName) != ".txt" ||
                Path.GetExtension(newName) != ".txt")
            {
                MessageBox.Show("Enter valid .txt file names");
                return;
            }

            string oldPath = Path.Combine(
                Application.StartupPath, oldName);

            string newPath = Path.Combine(
                Application.StartupPath, newName);

            if (!File.Exists(oldPath))
            {
                MessageBox.Show("Old File Not Found");
            }
            else if (File.Exists(newPath))
            {
                MessageBox.Show("New File Name Already Exists");
            }
            else
            {
                File.Move(oldPath, newPath);

                txtFileName.Clear();
                txtNewFileName.Clear();

                MessageBox.Show("File Renamed Successfully");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Enter file name");
                return;
            }

            if (Path.GetFileName(fileName) != fileName ||
                Path.GetExtension(fileName) != ".txt")
            {
                MessageBox.Show("Enter a valid .txt file name");
                return;
            }

            string path = Path.Combine(
                Application.StartupPath, fileName);

            if (File.Exists(path))
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this file?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    File.Delete(path);

                    txtFileName.Clear();

                    MessageBox.Show("File Deleted Successfully");
                }
            }
            else
            {
                MessageBox.Show("File Not Found");
            }
        }
    }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logFilter.core;

namespace logFilter
{
    public partial class FrmLogFilter : Form
    {
        private List<string> result;
        private String dateTime = DateTime.Now.ToString("yyyyMMdd");

        public FrmLogFilter()
        {
            InitializeComponent();
            btnSearch.Enabled = false;
            btnDropFile.Enabled = false;
            txtSearchKeyword.Text = "error";
        }

        private void txtFileSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Log Files (*.txt)|*.log|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    txtLogFileLocation.Text = filePath;
                    afterLogFileLocationSet(filePath);

                }
            }

            
        }

        private void afterLogFileLocationSet(string filePath)
        {
            txtSaveLocation.Text = filePath + "-" + dateTime + "-filttered.txt";
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FileUtils fu = new FileUtils();
            lstResult.Items.Clear();
            string readFilePath = txtLogFileLocation.Text.Trim();
            string savePath = txtSaveLocation.Text.Trim();
            string searchKeyWord = txtSearchKeyword.Text.Trim();
            
            if (searchKeyWord.Length > 0)
            {
                result = new List<string>();
                result = fu.readFileContents(readFilePath, savePath, searchKeyWord);

                foreach (string line in result )
                {
                    lstResult.Items.Add(line);
                }

                MessageBox.Show("Finished");
                btnDropFile.Enabled = true;
            }
            else
            {
                MessageBox.Show("검색어가 비어 있습니다.");
                txtSearchKeyword.Focus();
            }
        }

        private void btnDropFile_Click(object sender, EventArgs e)
        {

            try
            {
                // Open the output file in the default text editor
                Process.Start(new ProcessStartInfo()
                {
                    FileName = txtSaveLocation.Text.Trim(),
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the output file: " + ex.Message);
            }

        }

        private void FrmLogFilter_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void FrmLogFilter_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && File.Exists(files[0]))
                {
                    txtLogFileLocation.Text = files[0];
                    afterLogFileLocationSet(files[0]);
                }
            }
        }

    }
}

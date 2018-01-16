using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SimpleCompress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFolderNav_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            fbDialog.Description = "Select path";
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbDialog.SelectedPath;
            }

        }

        private void btnFileNav_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "All files| *.*", ValidateNames = true, Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtName.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnZipFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Please select your folder", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtFolder.Focus();
                return;
            }
            string path = txtFolder.Text;
            Thread thread = new Thread(t =>
                {
                    using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                    {
                        zip.AddDirectory(path);
                        System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(path);
                        zip.SaveProgress += Zip_SaveProgress;
                        zip.Save(string.Format("{0}{1}.zip", directoryInfo.Parent.FullName, directoryInfo.Name));
                    }
                })
            { IsBackground = true };
            thread.Start();
        }

        private void Zip_SaveProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = e.EntriesTotal;
                    progressBar.Value = e.EntriesSaved + 1;
                    progressBar.Update();
                    label3.Text = progressBar.Value.ToString();
                    if (progressBar.Value == progressBar.Maximum)
                    {
                        MessageBox.Show("Completed");
                    }
                }));
            }
        }
        private void Zip_SaveFileProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = 100;
                    progressBar.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar.Update();
                    label3.Text = progressBar.Value.ToString();
                    if (progressBar.Value == progressBar.Maximum)
                    {
                        MessageBox.Show("Completed");
                    }
                }));
            }
        }

        private void btnZipFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please select your file", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            string fileName = txtName.Text;
            Thread thread = new Thread(t =>
                {
                    using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                    {
                        FileInfo fileInfo = new FileInfo(fileName);
                        zip.AddFile(fileName);
                        System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(fileName);
                        zip.SaveProgress += Zip_SaveFileProgress;
                        zip.Save(string.Format("{0}/{1}.zip", directoryInfo.Parent.FullName, directoryInfo.Name));
                    }
                })
            { IsBackground = true };
            thread.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

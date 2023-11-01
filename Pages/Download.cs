using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace UIKitTutorials.Pages
{
    public partial class Download : Form
    {
        public Download()
        {
            InitializeComponent();
        }


        private void btndownload_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
           "Le path de votre jeu est enregistré",
           "GalaxiaPath",
           MessageBoxButtons.OK);
            
            string filename = getFileName(txturl.Text);
            string url = txturl.Text;

            lblfilename.Text = "File Name: " + getFileName(url);
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += wc_completed;
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(new Uri(url), txtpath.Text + filename);
            }
        }

        private void wc_completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed!");
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            txtpercent.Text = e.ProgressPercentage + "%";

            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            lbldownloaded.Text = "Downloaded: " + bytesIn + "/" + totalBytes;
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select a folder/Selectionner un dossier";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtpath.Text = dlg.SelectedPath + "\\";
                }
            }
        }

        private String getFileSize(String url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "HEAD";
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            long len = resp.ContentLength;

            return len.ToString();
        }

        private String getFileName(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            string fileName = "";
            try
            {

                HttpWebResponse res = (HttpWebResponse)request.GetResponse();
                using (Stream rstream = res.GetResponseStream())
                {
                    fileName = res.Headers["Content-Disposition"] != null ?
                       res.Headers["Content-Disposition"].Replace("attachment; filename=", "").Replace("\"", "") :
                       res.Headers["Location"] != null ? Path.GetFileName(res.Headers["Location"]) :
                       Path.GetFileName(url).Contains('?') || Path.GetFileName(url).Contains('=') ?
                       Path.GetFileName(res.ResponseUri.ToString()) : GetFileName(url);
                }
                res.Close();
            }
            catch { }

            return fileName;
        }

        private string GetFileName(string url)
        {
            string[] parts = url.Split('/');
            string fileName = "";

            if (parts.Length > 0)
                fileName = parts[parts.Length - 1];
            else
                fileName = url;
            return fileName;
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}

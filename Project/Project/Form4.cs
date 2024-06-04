using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project
{
    public partial class Form4 : Form
    {
        private string videoFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "Video.csv");
        private Video currentVideo;

        public Form4(Video video)
        {
            InitializeComponent();
            currentVideo = video;
            txtYouTubeId.Text = video.Id;
            txtYouTubeLink.Text = video.Link;
            txtDescription.Text = video.Description;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validasyonları kontrol et
            if (string.IsNullOrWhiteSpace(txtYouTubeId.Text) || string.IsNullOrWhiteSpace(txtYouTubeLink.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtYouTubeId.Text.Contains("|") || txtYouTubeLink.Text.Contains("|") || txtDescription.Text.Contains("|"))
            {
                MessageBox.Show("Fields cannot contain the pipe character '|'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Güncellenmiş video bilgilerini al
            currentVideo.Id = txtYouTubeId.Text;
            currentVideo.Link = txtYouTubeLink.Text;
            currentVideo.Description = txtDescription.Text;
            currentVideo.DateAdded = DateTime.Now;
            currentVideo.IsDeleted = false;

            // Video listesini güncelle ve dosyaya yaz
            var form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            var videoList = form2?.videos;

            var videoToUpdate = videoList?.FirstOrDefault(v => v.Id == currentVideo.Id);
            if (videoToUpdate != null)
            {
                videoToUpdate.Link = currentVideo.Link;
                videoToUpdate.Description = currentVideo.Description;
                videoToUpdate.DateAdded = currentVideo.DateAdded;
                videoToUpdate.IsDeleted = currentVideo.IsDeleted;
            }

            form2?.WriteVideosToCsv(form2.videoFilePath, videoList);
            this.Close();
            form2?.LoadVideos();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

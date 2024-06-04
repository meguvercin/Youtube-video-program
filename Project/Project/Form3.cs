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
    public partial class Form3 : Form
    {
        private string videoFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "Video.csv"); // Video.csv dosyasının yolu
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Alanların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtYouTubeId.Text) || string.IsNullOrWhiteSpace(txtYouTubeLink.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Alanlarda pipe karakteri olup olmadığını kontrol et
            if (txtYouTubeId.Text.Contains("|") || txtYouTubeLink.Text.Contains("|") || txtDescription.Text.Contains("|"))
            {
                MessageBox.Show("Fields cannot contain the pipe character '|'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yeni video kaydını oluştur
            var newVideo = new Video
            {
                Id = txtYouTubeId.Text,
                Link = txtYouTubeLink.Text,
                Description = txtDescription.Text,
                DateAdded = DateTime.Now,
                IsDeleted = false
            };

            // Yeni video kaydını CSV dosyasına ekle
            AddVideoToCsv(newVideo);
            this.Close();

            // Form2'ye geri dön
            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            form2?.LoadVideos();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Dosya işlemi yapmadan Form2'ye geri dön
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
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

            // Yeni video oluştur ve kaydet
            var newVideo = new Video
            {
                Id = txtYouTubeId.Text,
                Link = txtYouTubeLink.Text,
                Description = txtDescription.Text,
                DateAdded = DateTime.Now,
                IsDeleted = false
            };

            AddVideoToCsv(newVideo);
            this.Close();
        }
        private void AddVideoToCsv(Video video)
        {
            var line = $"{video.Id}|{video.Link}|{video.Description}|{video.DateAdded:yyyy-MM-dd HH:mm:ss}|{(video.IsDeleted ? "1" : "0")}";
            File.AppendAllLines(videoFilePath, new[] { line });
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            // Dosya işlemi yapmadan Form2'ye geri dön
            this.Close();
        }
    }
}

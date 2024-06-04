using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.LinkLabel;

namespace Project
{
    public partial class Form2 : Form
    {
        public string videoFilePath = string.Empty;
        public List<Video> videos = new List<Video>();
        private System.Windows.Forms.Timer? updateTimer = null;
        public Form2()
        {
            InitializeComponent();
            videoFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "Video.csv");
            LoadVideos();
            InitializeTimer();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void LoadVideos()
        {
            if (!File.Exists(videoFilePath))
            {
                MessageBox.Show("Video.csv dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            videos = ReadVideosFromCsv(videoFilePath);
            UpdateVideoListView();
        }
        private void InitializeTimer()
        {
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 15000; // 15 saniye
            updateTimer.Tick += Timer_Tick;
            updateTimer.Start();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            LoadVideos();
            lblStatus.Text = $"There are {videos.Count(v => !v.IsDeleted)} saved videos. There are also {videos.Count(v => v.IsDeleted)} deleted videos. Last update date is {DateTime.Now.ToString("yyyy.MM.dd HH:mm")}.";
        }

        private void UpdateVideoListView()
        {
            videoListView.Items.Clear();
            foreach (var video in videos.Where(v => !v.IsDeleted))
            {
                var item = new ListViewItem
                {
                    ImageIndex = 0 // İlk simgeyi kullanacak (ImageList'teki ilk simge)
                };
                item.SubItems.Add(video.Description); // Video Adı
                item.SubItems.Add(video.DateAdded.ToString("yyyy-MM-dd HH:mm:ss")); // Eklenme Tarihi
                item.Tag = video;
                videoListView.Items.Add(item);
            }
        }

        private List<Video> ReadVideosFromCsv(string filePath)
        {
            List<Video> videos = new List<Video>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var values = line.Split('|');
                videos.Add(new Video
                {
                    Id = values[0],
                    Link = values[1],
                    Description = values[2],
                    DateAdded = DateTime.Parse(values[3]),
                    IsDeleted = values[4] == "1"
                });
            }
            return videos;
        }
        private void videoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                var video = (Video)selectedItem.Tag;

                lblVideoInfo.Text = $"Video: {video.Description}\nAdded: {video.DateAdded}";

                string videoId = GetYouTubeVideoId(video.Link);
                string thumbnailUrl = $"https://img.youtube.com/vi/{videoId}/default.jpg";

                pictureBox1.Load(thumbnailUrl);
                pictureBox1.Click += (s, ev) => Process.Start(new ProcessStartInfo { FileName = video.Link, UseShellExecute = true });
            }
        }
        private string GetYouTubeVideoId(string url)
        {
            var uri = new Uri(url);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            return query["v"];
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                var video = (Video)selectedItem.Tag;
                Process.Start(new ProcessStartInfo { FileName = video.Link, UseShellExecute = true });
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                var video = (Video)selectedItem.Tag;
                Form4 updateForm = new Form4(video);
                updateForm.Show();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                var video = (Video)selectedItem.Tag;

                if (MessageBox.Show("Are you sure you want to remove this video?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    video.IsDeleted = true;
                    WriteVideosToCsv(videoFilePath, videos);
                }
            }
        }

        private void DeleteVideo(string filePath, string videoId)
        {
            var videos = ReadVideosFromCsv(filePath);
            var video = videos.FirstOrDefault(v => v.Id == videoId);
            if (video != null)
            {
                video.IsDeleted = true;
                WriteVideosToCsv(filePath, videos);
            }
        }
        private void btnAddNewVideo_Click(object sender, EventArgs e)
        {

            Form3 addNewVideoForm = new Form3();
            addNewVideoForm.Show();
        }

        public void WriteVideosToCsv(string filePath, List<Video> videos)
        {
            List<string> lines = new List<string>();
            foreach (var video in videos)
            {
                lines.Add($"{video.Id}|{video.Link}|{video.Description}|{video.DateAdded.ToString("yyyy-MM-dd HH:mm:ss")}|{(video.IsDeleted ? "1" : "0")}");
            }
            File.WriteAllLines(filePath, lines);
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                var video = (Video)selectedItem.Tag;
                Process.Start(new ProcessStartInfo { FileName = video.Link, UseShellExecute = true });
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                var video = (Video)selectedItem.Tag;

                lblVideoInfo.Text = $"Video: {video.Description}\nAdded: {video.DateAdded}";
                lblCreatedDate.Text = $"Created Date: {video.DateAdded}";
                lblVideoName.Text = $"{video.Description}";

                string videoId = GetYouTubeVideoId(video.Link);
                string thumbnailUrl = $"https://img.youtube.com/vi/{videoId}/default.jpg";

                pictureBox1.Load(thumbnailUrl);
                pictureBox1.Click += (s, ev) => Process.Start(new ProcessStartInfo { FileName = video.Link, UseShellExecute = true });
            }
        }

        private void btnAddNewVideo_Click_1(object sender, EventArgs e)
        {
            Form3 addNewVideoForm = new Form3();
            addNewVideoForm.Show();
        }

        private void videoListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                var video = (Video)selectedItem.Tag;

                //lblVideoInfo.Text = $"Video: {video.Description}\nAdded: {video.DateAdded}";
                //lblVideoName.Text = $"{video.Description}";
                //lblDes.Text = $"{video.Description}";
                lblVid.Text = $"{video.Description}";
                lblCreated.Text = $"Created Date: {video.DateAdded}";

                string videoId = GetYouTubeVideoId(video.Link);
                string thumbnailUrl = $"https://img.youtube.com/vi/{videoId}/default.jpg";

                pictureBox1.Load(thumbnailUrl);
                pictureBox1.Click += (s, ev) => Process.Start(new ProcessStartInfo { FileName = video.Link, UseShellExecute = true });
            }
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                var video = (Video)selectedItem.Tag;
                Form4 updateForm = new Form4(video);
                updateForm.Show();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (videoListView.SelectedItems.Count > 0)
            {
                var selectedItem = videoListView.SelectedItems[0];
                var video = (Video)selectedItem.Tag;

                if (MessageBox.Show("Are you sure you want to remove this video?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    video.IsDeleted = true;
                    WriteVideosToCsv(videoFilePath, videos);
                }
            }
        }

        private void Timer_Tick_1(object sender, EventArgs e)
        {
            LoadVideos();
            lblStatus.Text = $"There are {videos.Count(v => !v.IsDeleted)} saved videos. There are also {videos.Count(v => v.IsDeleted)} deleted videos.";
        }

        private void lblVideoName_Click(object sender, EventArgs e)
        {
            
        }
    }
    public class Video
    {
        public string Id { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public bool IsDeleted { get; set; }
    }
}

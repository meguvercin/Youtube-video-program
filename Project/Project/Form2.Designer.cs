namespace Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            txtBoxVideoAdmin = new TextBox();
            lblInformation = new Label();
            label1 = new Label();
            videoListView = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            ImageList1 = new ImageList(components);
            grpBoxSelected = new GroupBox();
            lblVid = new Label();
            lblDes = new Label();
            pictureBox1 = new PictureBox();
            lblCreatedDate = new Label();
            btnDelete = new Button();
            btnUptade = new Button();
            btnOpen = new Button();
            lblVideoName = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            btnAddNewVideo = new Button();
            lblStatus = new Label();
            lblVideoInfo = new Label();
            lblCreated = new Label();
            grpBoxSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxVideoAdmin
            // 
            txtBoxVideoAdmin.Location = new Point(1, 1);
            txtBoxVideoAdmin.Multiline = true;
            txtBoxVideoAdmin.Name = "txtBoxVideoAdmin";
            txtBoxVideoAdmin.Size = new Size(1849, 46);
            txtBoxVideoAdmin.TabIndex = 0;
            txtBoxVideoAdmin.Text = "Video Admin";
            // 
            // lblInformation
            // 
            lblInformation.BackColor = SystemColors.ActiveCaption;
            lblInformation.Location = new Point(12, 825);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(1849, 38);
            lblInformation.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 143);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 2;
            label1.Text = "Video Listview";
            // 
            // videoListView
            // 
            videoListView.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader1, columnHeader2 });
            videoListView.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            videoListView.FullRowSelect = true;
            videoListView.GridLines = true;
            videoListView.Location = new Point(12, 193);
            videoListView.Name = "videoListView";
            videoListView.Size = new Size(694, 572);
            videoListView.SmallImageList = ImageList1;
            videoListView.TabIndex = 3;
            videoListView.UseCompatibleStateImageBehavior = false;
            videoListView.View = View.Details;
            videoListView.SelectedIndexChanged += videoListView_SelectedIndexChanged_1;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Video Adı";
            columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Eklenme Tarihi";
            columnHeader2.Width = 220;
            // 
            // ImageList1
            // 
            ImageList1.ColorDepth = ColorDepth.Depth32Bit;
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "images.png");
            // 
            // grpBoxSelected
            // 
            grpBoxSelected.BackColor = Color.FromArgb(255, 224, 192);
            grpBoxSelected.Controls.Add(lblCreated);
            grpBoxSelected.Controls.Add(lblVid);
            grpBoxSelected.Controls.Add(lblDes);
            grpBoxSelected.Controls.Add(pictureBox1);
            grpBoxSelected.Controls.Add(lblCreatedDate);
            grpBoxSelected.Controls.Add(btnDelete);
            grpBoxSelected.Controls.Add(btnUptade);
            grpBoxSelected.Controls.Add(btnOpen);
            grpBoxSelected.Controls.Add(lblVideoName);
            grpBoxSelected.Location = new Point(859, 171);
            grpBoxSelected.Name = "grpBoxSelected";
            grpBoxSelected.Size = new Size(873, 594);
            grpBoxSelected.TabIndex = 4;
            grpBoxSelected.TabStop = false;
            grpBoxSelected.Text = "Selected Video Information";
            // 
            // lblVid
            // 
            lblVid.AutoSize = true;
            lblVid.BackColor = Color.White;
            lblVid.Location = new Point(291, 342);
            lblVid.Name = "lblVid";
            lblVid.Size = new Size(0, 25);
            lblVid.TabIndex = 10;
            // 
            // lblDes
            // 
            lblDes.AutoSize = true;
            lblDes.BackColor = Color.White;
            lblDes.Location = new Point(438, 342);
            lblDes.Name = "lblDes";
            lblDes.Size = new Size(0, 25);
            lblDes.TabIndex = 9;
            lblDes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(47, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(772, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.BackColor = Color.White;
            lblCreatedDate.Location = new Point(594, 481);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(0, 25);
            lblCreatedDate.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(448, 481);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUptade
            // 
            btnUptade.Location = new Point(291, 481);
            btnUptade.Name = "btnUptade";
            btnUptade.Size = new Size(112, 34);
            btnUptade.TabIndex = 6;
            btnUptade.Text = "Uptade";
            btnUptade.UseVisualStyleBackColor = true;
            btnUptade.Click += btnUptade_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(32, 485);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(112, 34);
            btnOpen.TabIndex = 5;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click_1;
            // 
            // lblVideoName
            // 
            lblVideoName.AutoSize = true;
            lblVideoName.BackColor = Color.White;
            lblVideoName.Location = new Point(6, 342);
            lblVideoName.Name = "lblVideoName";
            lblVideoName.Size = new Size(0, 25);
            lblVideoName.TabIndex = 5;
            lblVideoName.TextAlign = ContentAlignment.MiddleCenter;
            lblVideoName.Click += lblVideoName_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick_1;
            // 
            // btnAddNewVideo
            // 
            btnAddNewVideo.Location = new Point(1418, 116);
            btnAddNewVideo.Name = "btnAddNewVideo";
            btnAddNewVideo.Size = new Size(175, 34);
            btnAddNewVideo.TabIndex = 9;
            btnAddNewVideo.Text = "Add New Videos";
            btnAddNewVideo.UseVisualStyleBackColor = true;
            btnAddNewVideo.Click += btnAddNewVideo_Click_1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.FromArgb(255, 192, 128);
            lblStatus.Location = new Point(47, 50);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 9;
            // 
            // lblVideoInfo
            // 
            lblVideoInfo.AutoSize = true;
            lblVideoInfo.BackColor = Color.FromArgb(255, 192, 128);
            lblVideoInfo.Location = new Point(906, 780);
            lblVideoInfo.Name = "lblVideoInfo";
            lblVideoInfo.Size = new Size(0, 25);
            lblVideoInfo.TabIndex = 10;
            // 
            // lblCreated
            // 
            lblCreated.AutoSize = true;
            lblCreated.BackColor = Color.White;
            lblCreated.Location = new Point(638, 481);
            lblCreated.Name = "lblCreated";
            lblCreated.Size = new Size(0, 25);
            lblCreated.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1851, 940);
            Controls.Add(lblVideoInfo);
            Controls.Add(lblStatus);
            Controls.Add(btnAddNewVideo);
            Controls.Add(grpBoxSelected);
            Controls.Add(videoListView);
            Controls.Add(label1);
            Controls.Add(lblInformation);
            Controls.Add(txtBoxVideoAdmin);
            Name = "Form2";
            Text = "Admin Panel";
            Load += Form2_Load;
            grpBoxSelected.ResumeLayout(false);
            grpBoxSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxVideoAdmin;
        private Label lblInformation;
        private Label label1;
        private ListView videoListView;
        private GroupBox grpBoxSelected;
        private Label lblVideoName;
        private System.Windows.Forms.Timer Timer;
        private Label lblCreatedDate;
        private Button btnDelete;
        private Button btnUptade;
        private Button btnOpen;
        private PictureBox pictureBox1;
        private Button btnAddNewVideo;
        private Label lblStatus;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader2;
        private ImageList ImageList1;
        private Label lblVideoInfo;
        private Label lblDes;
        private Label lblVid;
        private Label lblCreated;
    }
}
namespace Project
{
    partial class Form4
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
            textBox1 = new TextBox();
            btnCancel = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtYouTubeId = new TextBox();
            txtYouTubeLink = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1549, 71);
            textBox1.TabIndex = 0;
            textBox1.Text = "Update Video";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1378, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Silver;
            richTextBox1.Location = new Point(218, 101);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1033, 463);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 241);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 3;
            label1.Text = "Youtube Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 330);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 4;
            label2.Text = "Youtube Link";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 429);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 5;
            label3.Text = "Youtube Describtion";
            // 
            // txtYouTubeId
            // 
            txtYouTubeId.Location = new Point(595, 241);
            txtYouTubeId.Name = "txtYouTubeId";
            txtYouTubeId.Size = new Size(546, 31);
            txtYouTubeId.TabIndex = 6;
            // 
            // txtYouTubeLink
            // 
            txtYouTubeLink.Location = new Point(595, 330);
            txtYouTubeLink.Name = "txtYouTubeLink";
            txtYouTubeLink.Size = new Size(546, 31);
            txtYouTubeLink.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(595, 429);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(546, 31);
            txtDescription.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(780, 504);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 659);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtYouTubeLink);
            Controls.Add(txtYouTubeId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(btnCancel);
            Controls.Add(textBox1);
            Name = "Form4";
            Text = "Video Update";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnCancel;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtYouTubeId;
        private TextBox txtYouTubeLink;
        private TextBox txtDescription;
        private Button btnSave;
    }
}
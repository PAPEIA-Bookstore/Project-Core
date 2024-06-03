namespace login_register
{
    partial class AuthorPage
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
            pictureBox1 = new PictureBox();
            authorNameLabel = new Label();
            label2 = new Label();
            profCover = new PictureBox();
            authorUsernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profCover).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // authorNameLabel
            // 
            authorNameLabel.AutoSize = true;
            authorNameLabel.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorNameLabel.ForeColor = Color.PapayaWhip;
            authorNameLabel.Location = new Point(149, 234);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new Size(138, 36);
            authorNameLabel.TabIndex = 2;
            authorNameLabel.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PapayaWhip;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(73, 60, 52);
            label2.Location = new Point(149, 313);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 4;
            label2.Text = "Author ✔";
            label2.Click += label2_Click;
            // 
            // profCover
            // 
            profCover.Image = Properties.Resources.profCover;
            profCover.Location = new Point(0, 0);
            profCover.Name = "profCover";
            profCover.Size = new Size(1089, 218);
            profCover.SizeMode = PictureBoxSizeMode.StretchImage;
            profCover.TabIndex = 5;
            profCover.TabStop = false;
            // 
            // authorUsernameLabel
            // 
            authorUsernameLabel.AutoSize = true;
            authorUsernameLabel.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorUsernameLabel.ForeColor = Color.PapayaWhip;
            authorUsernameLabel.Location = new Point(149, 270);
            authorUsernameLabel.Name = "authorUsernameLabel";
            authorUsernameLabel.Size = new Size(109, 23);
            authorUsernameLabel.TabIndex = 6;
            authorUsernameLabel.Text = "@username";
            // 
            // AuthorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1089, 605);
            Controls.Add(authorUsernameLabel);
            Controls.Add(profCover);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(authorNameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorPage";
            Text = "AuthorPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label authorNameLabel;
        private Label label2;
        private PictureBox profCover;
        private Label authorUsernameLabel;
    }
}
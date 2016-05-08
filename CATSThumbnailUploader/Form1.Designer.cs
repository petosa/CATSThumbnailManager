namespace CATSThumbnailUploader
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageSearchTextBox = new System.Windows.Forms.TextBox();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.oneImageButton = new System.Windows.Forms.Button();
            this.imageFolderButton = new System.Windows.Forms.Button();
            this.imageSearchButton = new System.Windows.Forms.Button();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.googleAccountTextBox = new System.Windows.Forms.TextBox();
            this.googlePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.videoSearchButton = new System.Windows.Forms.Button();
            this.videoSearchTextBox = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.setButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imagePanel.SuspendLayout();
            this.videoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(193, 336);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageSearchTextBox
            // 
            this.imageSearchTextBox.Location = new System.Drawing.Point(48, 71);
            this.imageSearchTextBox.Name = "imageSearchTextBox";
            this.imageSearchTextBox.Size = new System.Drawing.Size(148, 22);
            this.imageSearchTextBox.TabIndex = 1;
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.imageSearchButton);
            this.imagePanel.Controls.Add(this.oneImageButton);
            this.imagePanel.Controls.Add(this.imageFolderButton);
            this.imagePanel.Controls.Add(this.listView1);
            this.imagePanel.Controls.Add(this.imageSearchTextBox);
            this.imagePanel.Location = new System.Drawing.Point(12, 31);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(200, 435);
            this.imagePanel.TabIndex = 2;
            // 
            // oneImageButton
            // 
            this.oneImageButton.Location = new System.Drawing.Point(3, 3);
            this.oneImageButton.Name = "oneImageButton";
            this.oneImageButton.Size = new System.Drawing.Size(193, 26);
            this.oneImageButton.TabIndex = 3;
            this.oneImageButton.Text = "Select one image";
            this.oneImageButton.UseVisualStyleBackColor = true;
            // 
            // imageFolderButton
            // 
            this.imageFolderButton.Location = new System.Drawing.Point(3, 30);
            this.imageFolderButton.Name = "imageFolderButton";
            this.imageFolderButton.Size = new System.Drawing.Size(193, 26);
            this.imageFolderButton.TabIndex = 4;
            this.imageFolderButton.Text = "Select image folder";
            this.imageFolderButton.UseVisualStyleBackColor = true;
            // 
            // imageSearchButton
            // 
            this.imageSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageSearchButton.Location = new System.Drawing.Point(3, 71);
            this.imageSearchButton.Name = "imageSearchButton";
            this.imageSearchButton.Size = new System.Drawing.Size(39, 23);
            this.imageSearchButton.TabIndex = 5;
            this.imageSearchButton.Text = "Search";
            this.imageSearchButton.UseVisualStyleBackColor = true;
            // 
            // videoPanel
            // 
            this.videoPanel.Controls.Add(this.listView2);
            this.videoPanel.Controls.Add(this.videoSearchButton);
            this.videoPanel.Controls.Add(this.logInButton);
            this.videoPanel.Controls.Add(this.videoSearchTextBox);
            this.videoPanel.Controls.Add(this.label2);
            this.videoPanel.Controls.Add(this.label1);
            this.videoPanel.Controls.Add(this.googlePasswordTextBox);
            this.videoPanel.Controls.Add(this.googleAccountTextBox);
            this.videoPanel.Location = new System.Drawing.Point(343, 31);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(405, 435);
            this.videoPanel.TabIndex = 3;
            // 
            // googleAccountTextBox
            // 
            this.googleAccountTextBox.Location = new System.Drawing.Point(137, 6);
            this.googleAccountTextBox.Name = "googleAccountTextBox";
            this.googleAccountTextBox.Size = new System.Drawing.Size(171, 22);
            this.googleAccountTextBox.TabIndex = 0;
            // 
            // googlePasswordTextBox
            // 
            this.googlePasswordTextBox.Location = new System.Drawing.Point(137, 33);
            this.googlePasswordTextBox.Name = "googlePasswordTextBox";
            this.googlePasswordTextBox.PasswordChar = '•';
            this.googlePasswordTextBox.Size = new System.Drawing.Size(171, 22);
            this.googlePasswordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Google Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Google Password";
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(315, 6);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(76, 49);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            // 
            // videoSearchButton
            // 
            this.videoSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoSearchButton.Location = new System.Drawing.Point(6, 72);
            this.videoSearchButton.Name = "videoSearchButton";
            this.videoSearchButton.Size = new System.Drawing.Size(65, 23);
            this.videoSearchButton.TabIndex = 7;
            this.videoSearchButton.Text = "Search";
            this.videoSearchButton.UseVisualStyleBackColor = true;
            // 
            // videoSearchTextBox
            // 
            this.videoSearchTextBox.Location = new System.Drawing.Point(77, 72);
            this.videoSearchTextBox.Name = "videoSearchTextBox";
            this.videoSearchTextBox.Size = new System.Drawing.Size(325, 22);
            this.videoSearchTextBox.TabIndex = 6;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(6, 96);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(396, 336);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(219, 31);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(118, 132);
            this.setButton.TabIndex = 4;
            this.setButton.Text = "Set selected image as thumbnail for selected video";
            this.setButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(219, 184);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(118, 132);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset thumbnail for selected video";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // publishButton
            // 
            this.publishButton.Location = new System.Drawing.Point(219, 334);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(118, 132);
            this.publishButton.TabIndex = 6;
            this.publishButton.Text = "Publish changes to YouTube";
            this.publishButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Local image selector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "My uploads";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.videoPanel);
            this.Controls.Add(this.imagePanel);
            this.Name = "Form1";
            this.Text = "CATS Thumbnail Uploader";
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            this.videoPanel.ResumeLayout(false);
            this.videoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox imageSearchTextBox;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button imageSearchButton;
        private System.Windows.Forms.Button oneImageButton;
        private System.Windows.Forms.Button imageFolderButton;
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button videoSearchButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox videoSearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox googlePasswordTextBox;
        private System.Windows.Forms.TextBox googleAccountTextBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


﻿namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FirstImage_Box = new Emgu.CV.UI.ImageBox();
            this.SecondImage_Box = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rIOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rIOFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesWithWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picturesWithFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoRIOFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.someShitFuncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Threshold_Bar = new System.Windows.Forms.TrackBar();
            this.Threshold_lbl = new System.Windows.Forms.Label();
            this.Iteration_lbl = new System.Windows.Forms.Label();
            this.Iteration_Bar = new System.Windows.Forms.TrackBar();
            this.Pictures_cb = new System.Windows.Forms.ComboBox();
            this.PicturesRIO_lbl = new System.Windows.Forms.Label();
            this.TextOfPicture_lbl = new System.Windows.Forms.Label();
            this.Lang_cb = new System.Windows.Forms.CheckBox();
            this.Play_Buton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirstImage_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondImage_Box)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iteration_Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstImage_Box
            // 
            this.FirstImage_Box.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.FirstImage_Box.Location = new System.Drawing.Point(1, 109);
            this.FirstImage_Box.Name = "FirstImage_Box";
            this.FirstImage_Box.Size = new System.Drawing.Size(375, 339);
            this.FirstImage_Box.TabIndex = 2;
            this.FirstImage_Box.TabStop = false;
            // 
            // SecondImage_Box
            // 
            this.SecondImage_Box.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.SecondImage_Box.Location = new System.Drawing.Point(382, 109);
            this.SecondImage_Box.Name = "SecondImage_Box";
            this.SecondImage_Box.Size = new System.Drawing.Size(375, 339);
            this.SecondImage_Box.TabIndex = 3;
            this.SecondImage_Box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Image: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.rIOToolStripMenuItem,
            this.someShitFuncToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadVideoToolStripMenuItem,
            this.loadImageToolStripMenuItem1});
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadImageToolStripMenuItem.Text = "Load";
            // 
            // loadVideoToolStripMenuItem
            // 
            this.loadVideoToolStripMenuItem.Name = "loadVideoToolStripMenuItem";
            this.loadVideoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadVideoToolStripMenuItem.Text = "Load Video";
            this.loadVideoToolStripMenuItem.Click += new System.EventHandler(this.LoadVideoToolStripMenuItem_Click);
            // 
            // loadImageToolStripMenuItem1
            // 
            this.loadImageToolStripMenuItem1.Name = "loadImageToolStripMenuItem1";
            this.loadImageToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem1.Text = "Load Image";
            this.loadImageToolStripMenuItem1.Click += new System.EventHandler(this.loadImageToolStripMenuItem1_Click);
            // 
            // rIOToolStripMenuItem
            // 
            this.rIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rIOToolStripMenuItem1,
            this.rIOFaceToolStripMenuItem,
            this.imagesWithWordsToolStripMenuItem,
            this.picturesWithFaceToolStripMenuItem,
            this.videoRIOToolStripMenuItem,
            this.videoRIOFaceToolStripMenuItem});
            this.rIOToolStripMenuItem.Name = "rIOToolStripMenuItem";
            this.rIOToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.rIOToolStripMenuItem.Text = "Filtr";
            // 
            // rIOToolStripMenuItem1
            // 
            this.rIOToolStripMenuItem1.Name = "rIOToolStripMenuItem1";
            this.rIOToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.rIOToolStripMenuItem1.Text = "RIO Text";
            this.rIOToolStripMenuItem1.Click += new System.EventHandler(this.RIOToolStripMenuItem1_Click);
            // 
            // rIOFaceToolStripMenuItem
            // 
            this.rIOFaceToolStripMenuItem.Name = "rIOFaceToolStripMenuItem";
            this.rIOFaceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.rIOFaceToolStripMenuItem.Text = "RIO Face";
            this.rIOFaceToolStripMenuItem.Click += new System.EventHandler(this.rIOFaceToolStripMenuItem_Click);
            // 
            // imagesWithWordsToolStripMenuItem
            // 
            this.imagesWithWordsToolStripMenuItem.Name = "imagesWithWordsToolStripMenuItem";
            this.imagesWithWordsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.imagesWithWordsToolStripMenuItem.Text = "Pictures with words";
            this.imagesWithWordsToolStripMenuItem.Click += new System.EventHandler(this.ImagesWithWordsToolStripMenuItem_Click);
            // 
            // picturesWithFaceToolStripMenuItem
            // 
            this.picturesWithFaceToolStripMenuItem.Name = "picturesWithFaceToolStripMenuItem";
            this.picturesWithFaceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.picturesWithFaceToolStripMenuItem.Text = "Pictures with face";
            // 
            // videoRIOToolStripMenuItem
            // 
            this.videoRIOToolStripMenuItem.Name = "videoRIOToolStripMenuItem";
            this.videoRIOToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.videoRIOToolStripMenuItem.Text = "Video RIO(Text)";
            this.videoRIOToolStripMenuItem.Click += new System.EventHandler(this.VideoRIOToolStripMenuItem_Click);
            // 
            // videoRIOFaceToolStripMenuItem
            // 
            this.videoRIOFaceToolStripMenuItem.Name = "videoRIOFaceToolStripMenuItem";
            this.videoRIOFaceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.videoRIOFaceToolStripMenuItem.Text = "Video RIO(Face)";
            this.videoRIOFaceToolStripMenuItem.Click += new System.EventHandler(this.videoRIOFaceToolStripMenuItem_Click);
            // 
            // someShitFuncToolStripMenuItem
            // 
            this.someShitFuncToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainToolStripMenuItem,
            this.readFacesToolStripMenuItem});
            this.someShitFuncToolStripMenuItem.Name = "someShitFuncToolStripMenuItem";
            this.someShitFuncToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.someShitFuncToolStripMenuItem.Text = "Some Shit Func";
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trainToolStripMenuItem.Text = "Train";
            this.trainToolStripMenuItem.Click += new System.EventHandler(this.trainToolStripMenuItem_Click);
            // 
            // readFacesToolStripMenuItem
            // 
            this.readFacesToolStripMenuItem.Name = "readFacesToolStripMenuItem";
            this.readFacesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readFacesToolStripMenuItem.Text = "Read Faces";
            this.readFacesToolStripMenuItem.Click += new System.EventHandler(this.readFacesToolStripMenuItem_Click);
            // 
            // Threshold_Bar
            // 
            this.Threshold_Bar.LargeChange = 1;
            this.Threshold_Bar.Location = new System.Drawing.Point(6, 48);
            this.Threshold_Bar.Maximum = 255;
            this.Threshold_Bar.Name = "Threshold_Bar";
            this.Threshold_Bar.Size = new System.Drawing.Size(104, 45);
            this.Threshold_Bar.TabIndex = 7;
            this.Threshold_Bar.Value = 80;
            this.Threshold_Bar.Visible = false;
            this.Threshold_Bar.Scroll += new System.EventHandler(this.Threshold_Bar_Scroll);
            // 
            // Threshold_lbl
            // 
            this.Threshold_lbl.AutoSize = true;
            this.Threshold_lbl.Location = new System.Drawing.Point(12, 32);
            this.Threshold_lbl.Name = "Threshold_lbl";
            this.Threshold_lbl.Size = new System.Drawing.Size(75, 13);
            this.Threshold_lbl.TabIndex = 8;
            this.Threshold_lbl.Text = "Threshold: 80 ";
            this.Threshold_lbl.Visible = false;
            // 
            // Iteration_lbl
            // 
            this.Iteration_lbl.AutoSize = true;
            this.Iteration_lbl.Location = new System.Drawing.Point(112, 32);
            this.Iteration_lbl.Name = "Iteration_lbl";
            this.Iteration_lbl.Size = new System.Drawing.Size(60, 13);
            this.Iteration_lbl.TabIndex = 10;
            this.Iteration_lbl.Text = "Iteration: 1 ";
            this.Iteration_lbl.Visible = false;
            // 
            // Iteration_Bar
            // 
            this.Iteration_Bar.LargeChange = 1;
            this.Iteration_Bar.Location = new System.Drawing.Point(106, 48);
            this.Iteration_Bar.Maximum = 255;
            this.Iteration_Bar.Name = "Iteration_Bar";
            this.Iteration_Bar.Size = new System.Drawing.Size(104, 45);
            this.Iteration_Bar.TabIndex = 9;
            this.Iteration_Bar.TickFrequency = 3;
            this.Iteration_Bar.Value = 3;
            this.Iteration_Bar.Visible = false;
            this.Iteration_Bar.Scroll += new System.EventHandler(this.Iteration_Bar_Scroll);
            // 
            // Pictures_cb
            // 
            this.Pictures_cb.FormattingEnabled = true;
            this.Pictures_cb.Location = new System.Drawing.Point(231, 48);
            this.Pictures_cb.Name = "Pictures_cb";
            this.Pictures_cb.Size = new System.Drawing.Size(121, 21);
            this.Pictures_cb.TabIndex = 11;
            this.Pictures_cb.Visible = false;
            this.Pictures_cb.SelectedIndexChanged += new System.EventHandler(this.Pictures_cb_SelectedIndexChanged);
            // 
            // PicturesRIO_lbl
            // 
            this.PicturesRIO_lbl.AutoSize = true;
            this.PicturesRIO_lbl.Location = new System.Drawing.Point(230, 32);
            this.PicturesRIO_lbl.Name = "PicturesRIO_lbl";
            this.PicturesRIO_lbl.Size = new System.Drawing.Size(48, 13);
            this.PicturesRIO_lbl.TabIndex = 12;
            this.PicturesRIO_lbl.Text = "Pictures:";
            this.PicturesRIO_lbl.Visible = false;
            // 
            // TextOfPicture_lbl
            // 
            this.TextOfPicture_lbl.AutoSize = true;
            this.TextOfPicture_lbl.Location = new System.Drawing.Point(358, 51);
            this.TextOfPicture_lbl.Name = "TextOfPicture_lbl";
            this.TextOfPicture_lbl.Size = new System.Drawing.Size(34, 13);
            this.TextOfPicture_lbl.TabIndex = 13;
            this.TextOfPicture_lbl.Text = "Text: ";
            this.TextOfPicture_lbl.Visible = false;
            // 
            // Lang_cb
            // 
            this.Lang_cb.AutoSize = true;
            this.Lang_cb.Location = new System.Drawing.Point(361, 32);
            this.Lang_cb.Name = "Lang_cb";
            this.Lang_cb.Size = new System.Drawing.Size(106, 17);
            this.Lang_cb.TabIndex = 14;
            this.Lang_cb.Text = "on - rus, off - eng";
            this.Lang_cb.UseVisualStyleBackColor = true;
            this.Lang_cb.Visible = false;
            // 
            // Play_Buton
            // 
            this.Play_Buton.Location = new System.Drawing.Point(340, 70);
            this.Play_Buton.Name = "Play_Buton";
            this.Play_Buton.Size = new System.Drawing.Size(75, 23);
            this.Play_Buton.TabIndex = 15;
            this.Play_Buton.Text = "Play/Pause";
            this.Play_Buton.UseVisualStyleBackColor = true;
            this.Play_Buton.Visible = false;
            this.Play_Buton.Click += new System.EventHandler(this.Play_Buton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 451);
            this.Controls.Add(this.Play_Buton);
            this.Controls.Add(this.Lang_cb);
            this.Controls.Add(this.TextOfPicture_lbl);
            this.Controls.Add(this.PicturesRIO_lbl);
            this.Controls.Add(this.Pictures_cb);
            this.Controls.Add(this.Iteration_lbl);
            this.Controls.Add(this.Iteration_Bar);
            this.Controls.Add(this.Threshold_lbl);
            this.Controls.Add(this.Threshold_Bar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondImage_Box);
            this.Controls.Add(this.FirstImage_Box);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FirstImage_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondImage_Box)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iteration_Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox FirstImage_Box;
        private Emgu.CV.UI.ImageBox SecondImage_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rIOToolStripMenuItem;
        private System.Windows.Forms.TrackBar Threshold_Bar;
        private System.Windows.Forms.Label Threshold_lbl;
        private System.Windows.Forms.Label Iteration_lbl;
        private System.Windows.Forms.TrackBar Iteration_Bar;
        private System.Windows.Forms.ToolStripMenuItem rIOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imagesWithWordsToolStripMenuItem;
        private System.Windows.Forms.ComboBox Pictures_cb;
        private System.Windows.Forms.Label PicturesRIO_lbl;
        private System.Windows.Forms.Label TextOfPicture_lbl;
        private System.Windows.Forms.CheckBox Lang_cb;
        private System.Windows.Forms.ToolStripMenuItem loadVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoRIOToolStripMenuItem;
        private System.Windows.Forms.Button Play_Buton;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem videoRIOFaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picturesWithFaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rIOFaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem someShitFuncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFacesToolStripMenuItem;
    }
}


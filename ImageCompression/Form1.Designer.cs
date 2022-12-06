namespace LoselessImageCompression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_outputPath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_filesNumber = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmQualityCompressionLevel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmQualityCompressionLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(193, 117);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Select Output Path";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSelectOutputPath_Click);
            // 
            // label_outputPath
            // 
            this.label_outputPath.AutoSize = true;
            this.label_outputPath.Location = new System.Drawing.Point(20, 57);
            this.label_outputPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_outputPath.Name = "label_outputPath";
            this.label_outputPath.Size = new System.Drawing.Size(0, 16);
            this.label_outputPath.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Select Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // label_filesNumber
            // 
            this.label_filesNumber.AutoSize = true;
            this.label_filesNumber.Location = new System.Drawing.Point(20, 15);
            this.label_filesNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_filesNumber.Name = "label_filesNumber";
            this.label_filesNumber.Size = new System.Drawing.Size(25, 16);
            this.label_filesNumber.TabIndex = 7;
            this.label_filesNumber.Text = "0/0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(89, 15);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(373, 28);
            this.progressBar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quality Reduction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "%";
            // 
            // nmQualityCompressionLevel
            // 
            this.nmQualityCompressionLevel.Location = new System.Drawing.Point(23, 121);
            this.nmQualityCompressionLevel.Name = "nmQualityCompressionLevel";
            this.nmQualityCompressionLevel.Size = new System.Drawing.Size(50, 22);
            this.nmQualityCompressionLevel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 160);
            this.Controls.Add(this.nmQualityCompressionLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_outputPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_filesNumber);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Compression";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmQualityCompressionLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_outputPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_filesNumber;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmQualityCompressionLevel;
    }
}


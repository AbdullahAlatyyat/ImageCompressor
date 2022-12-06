using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace LoselessImageCompression
{
    public partial class Form1 : Form
    {
        public static string[] files = null;
        public static string[] allowedFileExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".tif", ".tiff", ".bmp" };
        public static int progressBarIncrement = 1;
        public static int currentFileProcessing = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void resetEverything()
        {
            files = null;
            progressBarIncrement = 1;
            currentFileProcessing = 1;

            label_filesNumber.Text = @"0\0";
            label_outputPath.Text = @"";
            progressBar.Value = 0;
        }

        private string getAllowedFileExtensions()
        {
            string result = "";
            foreach (var item in allowedFileExtensions)
            {
                result += "*" + item + ";";
            }
            return result;
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|" + getAllowedFileExtensions();
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileNames.Length == 0)
                    {
                        MessageBox.Show("you must choose atleast 1 file");
                    }
                    else
                    {
                        files = openFileDialog.FileNames;
                        foreach (var item in files)
                        {
                            var extension = Path.GetExtension(item);
                            if (!allowedFileExtensions.Contains(extension))
                            {
                                MessageBox.Show("1 or more files are not valid");
                                break;
                            }
                        }

                        label_filesNumber.Text = currentFileProcessing + "/" + files.Length;

                        progressBarIncrement = 100 / files.Length;
                        if (progressBarIncrement < 0)
                            progressBarIncrement = 1;
                    }
                }
            }
        }

        private bool ProcessFiles(int index)
        {
            try
            {
                var currentFile = files[index];
                var fileName = Path.GetFileName(currentFile);

                Bitmap myBitmap = new Bitmap(currentFile);

                ImageCodecInfo myImageCodecInfo = GetEncoder(ImageFormat.Jpeg);

                Encoder myEncoder = Encoder.Compression;
                Encoder qualityEncoder = Encoder.Quality;

                EncoderParameters myEncoderParameters = new EncoderParameters(2);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, (long)EncoderValue.CompressionLZW);
                myEncoderParameters.Param[0] = myEncoderParameter;

                EncoderParameter myEncoderParameterQuality = new EncoderParameter(qualityEncoder, 100 - long.Parse(nmQualityCompressionLevel.Text));
                myEncoderParameters.Param[1] = myEncoderParameterQuality;

                var outputFilePath = label_outputPath.Text + "\\out-" + fileName;
                myBitmap.Save(outputFilePath, myImageCodecInfo, myEncoderParameters);

                var oldFileInfo = new FileInfo(currentFile);
                var newFileInfo = new FileInfo(outputFilePath);
                if (oldFileInfo.Length < newFileInfo.Length)
                {
                    File.Delete(outputFilePath);
                    File.Copy(currentFile, outputFilePath);
                }

                if (index != files.Length - 1)
                {
                    progressBar.Increment(progressBarIncrement);

                    currentFileProcessing += 1;
                    label_filesNumber.Text = currentFileProcessing.ToString() + "/" + files.Length.ToString();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var errorProcessingFilesMessage = "some files couldn't be processed:- " + Environment.NewLine;
                var somethingWentWrongFlag = false;
                for (int i = 0; i < files.Length; i++)
                {
                    if (!ProcessFiles(i))
                    {
                        somethingWentWrongFlag = true;
                        errorProcessingFilesMessage += Path.GetFileName(files[i]) + Environment.NewLine;
                    }
                }

                if (somethingWentWrongFlag)
                {
                    errorProcessingFilesMessage += "and therefore were ignored";
                    MessageBox.Show(errorProcessingFilesMessage);
                }
                else
                    MessageBox.Show("Done");

                resetEverything();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(label_outputPath.Text))
            {
                MessageBox.Show("you must choose output Path");
                return false;
            }
            if (files == null)
            {
                MessageBox.Show("you must choose files to compress");
                return false;
            }
            if (String.IsNullOrWhiteSpace(nmQualityCompressionLevel.Text))
            {
                MessageBox.Show("you must choose quality compressionLevel from 0-100");
                return false;
            }
            try
            {
                var num = int.Parse(nmQualityCompressionLevel.Text);
                if (num > 100 || num < 0)
                {
                    MessageBox.Show("you must choose quality compressionLevel from 0-100");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("you must choose quality compressionLevel from 0-100");
                return false;
            }
            return true;
        }

        private void btnSelectOutputPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    label_outputPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nmQualityCompressionLevel.Text = "50";
        }
    }
}

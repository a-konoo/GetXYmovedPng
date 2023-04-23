using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace PngImagePosSlideMaker
{

    public partial class Form1 : Form
    {
        private Image bmp1 = null;
        private Image bmp2 = null;
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();

            this.toolStrip1.Enabled = true;
            this.toolStrip1.Items[0].Visible = true;
            this.toolStrip1.Items[0].Text = "toolstrip";
            // Create DataGridView's DataTable
            dataTable = new DataTable();
            dataTable.Columns.Add("FileName", typeof(string));
            dataTable.Columns.Add("translateOffsetX", typeof(double));
            dataTable.Columns.Add("translateOffsetY", typeof(double));
            dataTable.Columns.Add("SaveFileName", typeof(string));


            dataTable.Rows.Add("filename01.png",10.1d,20.2d,"renamefile01.png");
            dataTable.Rows.Add("filename02.png", 20.2d, 30.3d, "renamefile02.png");
            dataTable.Rows.Add("filename03.png", 40.4d, 50.5d, "renamefile03.png");
            dataTable.Rows.Add("filename04.png", 10.1d, 20.2d, "renamefile04.png");
            dataTable.Rows.Add("filename05.png", 20.2d, 30.3d, "renamefile05.png");
            dataTable.Rows.Add("filename06.png", 40.4d, 50.5d, "renamefile06.png");
            dataTable.Rows.Add("filename07.png", 10.1d, 20.2d, "renamefile07.png");
            dataTable.Rows.Add("filename08.png", 20.2d, 30.3d, "renamefile08.png");
            dataTable.Rows.Add("filename09.png", 40.4d, 50.5d, "renamefile09.png");
            dataTable.Rows.Add("filename10.png", 10.1d, 20.2d, "renamefile10.png");

            dataGridView1.DataSource = dataTable;
            AddFuncButtonsToDataGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileOpr opr = new FileOpr();
            
            var path = opr.ImageFileOpen();
            if (path == null) { return; }
            Image img1 = Image.FromFile(path);
            picBox1.Image = img1;
            picBox1.Width = img1.Width;
            picBox1.Height = img1.Height;
            bmp1 = img1;
            sLoadDir.Text = Path.GetDirectoryName(path);
            sLoadFileName.Text = Path.GetFileName(path);
            // default save dir
            sSaveDir.Text = Path.Combine(Path.GetDirectoryName(path), "trans");
            var ext = Path.GetExtension(path);
            var sFile = Path.GetFileNameWithoutExtension(path);
            var suffix = sSuffix.Text.Trim() == String.Empty ? "t" : sSuffix.Text.Trim();
            sSaveFileName.Text = sFile + suffix + ext;
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (bmp1 == null) { return; }

            var img2 = bmp1.Clone() as Image;

            // graphic object from outputImg.
            Image transferred = TransferImage(new Bitmap(bmp1.Width, bmp1.Height),
                img2,
                tDiffX.Text,
                tDiffY.Text);

            picBox2.Image = transferred;
            picBox2.Width = transferred.Width;
            picBox2.Height = transferred.Height;

            picBox2.Refresh();
        }

        private Image TransferImage(Bitmap outputImg, Image clonedImage, string dx, string dy)
        {
            using (var g = Graphics.FromImage(outputImg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

                // reset transform matrix
                g.ResetTransform();

                float.TryParse(dx.ToString(), out float px);
                float.TryParse(dy.ToString(), out float py);
                // draw image
                g.TranslateTransform(px, py, MatrixOrder.Append);
                g.DrawImage(clonedImage, new Rectangle(0, 0, 
                    clonedImage.Width * 1, clonedImage.Height * 1));
            }
            return outputImg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileOpr opr = new FileOpr();

            var path = opr.WorkFolderOpen();
            if (path == null) { return; }
            sSaveDir.Text = Path.GetDirectoryName(path);
        }

        private void tDiff_X_Leave(object sender, EventArgs e)
        {
            var txt = this.tDiffX.Text;
            Double.TryParse(this.tDiffX.Text, out Double x);
            this.tDiffX.Text = x.ToString();
        }

        private void tDiff_Y_Leave(object sender, EventArgs e)
        {
            var txt = this.tDiffY.Text;
            Double.TryParse(this.tDiffY.Text, out Double y);
            this.tDiffY.Text = y.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(sSaveDir.Text) || String.IsNullOrEmpty(sSaveFileName.Text))
            {
                MessageBox.Show("save out dir/filename is missing!");
                return;
            }
            Bitmap bmp = new Bitmap(this.picBox2.Image);
            var format = ImageFormat.Bmp;
            switch (Path.GetExtension(sSaveFileName.Text)?.ToLower())
            {
                case ".png":
                    format = ImageFormat.Png;
                    break;
                case ".bmp":
                    format = ImageFormat.Bmp;
                    break;
                case ".jpg":
                    format = ImageFormat.Jpeg;
                    break;
                default:
                    format = ImageFormat.Bmp;
                    break;
            }
            if (!Directory.Exists(sSaveDir.Text))
            {
                Directory.CreateDirectory(sSaveDir.Text);
            }
            bmp.Save(Path.Combine(sSaveDir.Text, Path.GetFileName(sSaveFileName.Text)),
                format);
            bmp.Dispose();
            MessageBox.Show("save complete");
        }

        private void gLoadBtn_Click(object sender, EventArgs e)
        {
            FileOpr opr = new FileOpr();

            var path = opr.WorkFolderOpen();
            if (path == null) { return; }
            gLoadDirPath.Text = path;

            gSaveDirPath.Text = Path.Combine(path, "trans");
        }

        private void gSaveBtn_Click(object sender, EventArgs e)
        {
            FileOpr opr = new FileOpr();

            var path = opr.WorkFolderOpen();
            if (path == null) { return; }
            gSaveDirPath.Text = path;
        }
        /// <summary>
        /// CSV Load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void csvLoad_Click(object sender, EventArgs e)
        {
            FileOpr opr = new FileOpr();
            var path = opr.CSVFileOpen();
            if (path == null) { return; }
            var readDataTable = new DataTable();
            try
            {
                using (TextFieldParser parser = new TextFieldParser(path, Encoding.UTF8))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(new string[] { "," });
                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.TrimWhiteSpace = true;


                    readDataTable.Columns.Add("FileName", typeof(string));
                    readDataTable.Columns.Add("translateOffsetX", typeof(double));
                    readDataTable.Columns.Add("translateOffsetY", typeof(double));
                    readDataTable.Columns.Add("SaveFileName", typeof(string));

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        if (fields.Length != 4)
                        {
                            MessageBox.Show($"{parser.LineNumber} has 4 fields row");
                            return;
                        }
                        Double.TryParse(fields[1], out Double diffX);
                        Double.TryParse(fields[2], out Double diffY);

                        var ext = Path.GetExtension(fields[3]);
                        var sFile = Path.GetFileNameWithoutExtension(fields[3]);
                        var suffix = gSuffix.Text.Trim() == String.Empty ? "t" : gSuffix.Text.Trim();
                        fields[3] = sFile + suffix + ext;

                        readDataTable.Rows.Add(fields[0], diffX, diffY, fields[3]);
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message},{ex.StackTrace.ToString()}");
            }
            dataTable = readDataTable;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dataTable;
            AddFuncButtonsToDataGridView();
            dataGridView1.Refresh();
        }

        /// <summary>
        /// Add ClicableButton to DataGridView 
        /// </summary>
        private void AddFuncButtonsToDataGridView()
        {
            // load button 
            DataGridViewButtonColumn loadBtnColumn = new DataGridViewButtonColumn();
            loadBtnColumn.Name = "ButtonLoad";
            loadBtnColumn.UseColumnTextForButtonValue = true;
            loadBtnColumn.Text = "4.load";
            dataGridView1.Columns.Add(loadBtnColumn);
            // image operate(transfer) & save button

            DataGridViewButtonColumn btnSaveColumn = new DataGridViewButtonColumn();
            btnSaveColumn.Name = "Transfer_Save";
            btnSaveColumn.UseColumnTextForButtonValue = true;
            btnSaveColumn.Text = "5.make";

            dataGridView1.Columns.Add(btnSaveColumn);

            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView1 = (DataGridView)sender;
            var columnIdx = e.ColumnIndex;
            var rowIdx = e.RowIndex;

            if (dataGridView1.Columns[columnIdx].Name == "ButtonLoad")
            {
                var loadDirPath = gLoadDirPath.Text.Trim();
                if (loadDirPath.Equals(String.Empty) || !Directory.Exists(loadDirPath))
                {
                    MessageBox.Show("input directory path is wrong");
                    return;
                }
                var row = dataGridView1.Rows[rowIdx];
                var filename = row.Cells["FileName"].Value as String;
                LoadImageAtThisRow(Path.Combine(loadDirPath, filename));
                return;
            }
            if (dataGridView1.Columns[columnIdx].Name == "Transfer_Save")
            {
                var stripMsg = String.Empty;
                var saveDirPath = gSaveDirPath.Text.Trim();
                if (saveDirPath.Equals(String.Empty))
                {
                    MessageBox.Show("output directory path is wrong");
                    return;
                }
                if (!Directory.Exists(saveDirPath))
                {
                    Directory.CreateDirectory(saveDirPath);
                    stripMsg += "directory created.";
                }
                var row = dataGridView1.Rows[rowIdx];
                var filename = row.Cells["SaveFileName"].Value as String;
                var dx = Convert.ToDouble(row.Cells["translateOffsetX"].Value);
                var dy = Convert.ToDouble(row.Cells["translateOffsetY"].Value);


                var msg = TransAndSaveAtRow(saveDirPath, filename,
                   dx.ToString(), dy.ToString());

                this.toolStrip1.Items[0].Text = $"{filename}...{stripMsg} {msg}";
                toolStrip1.Update();
                return;
            }
        }

        private void LoadImageAtThisRow(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("input file path is wrong.\r\n{path}");
                return;
            }
            Image img1 = Image.FromFile(path);
            picBox1.Image = img1;
            picBox1.Width = img1.Width;
            picBox1.Height = img1.Height;
            bmp1 = img1;
        }

        private string TransAndSaveAtRow(string path, string fileName, String dx, String dy)
        {
            Image img = picBox1.Image;
            if (bmp1 == null) { return "image not loaded!"; }

            var img2 = bmp1.Clone() as Image;

            var transferred = TransferImage(new Bitmap(img.Width, img.Height), img2, dx, dy);
            picBox2.Image = transferred;
            picBox2.Width = transferred.Width;
            picBox2.Height = transferred.Height;

            picBox2.Refresh();

            Bitmap bmp = new Bitmap(this.picBox2.Image);
            var format = ImageFormat.Bmp;
            switch (Path.GetExtension(fileName)?.ToLower())
            {
                case ".png":
                    format = ImageFormat.Png;
                    break;
                case ".bmp":
                    format = ImageFormat.Bmp;
                    break;
                case ".jpg":
                    format = ImageFormat.Jpeg;
                    break;
                default:
                    format = ImageFormat.Bmp;
                    break;
            }
            // writable check
            var writePath = Path.Combine(path, Path.GetFileName(fileName));
            if (!isWritableFile(writePath)) {
                return "not writable path:" + writePath;
            }
            File.Delete(writePath);
            bmp.Save(writePath,format);
            bmp.Dispose();
            return "trasferred image make and saved";
        }


        bool isWritableFile(string filePath)
        {
            try
            {
                using (FileStream fp = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

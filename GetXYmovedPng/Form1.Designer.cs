namespace PngImagePosSlideMaker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.sLoadFileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.translate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gLoadDirPath = new System.Windows.Forms.TextBox();
            this.gSaveDirPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.sSuffix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tDiffY = new System.Windows.Forms.TextBox();
            this.tDiffX = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sSaveFileName = new System.Windows.Forms.TextBox();
            this.sSaveDir = new System.Windows.Forms.TextBox();
            this.sLoadDir = new System.Windows.Forms.TextBox();
            this.gSaveBtn = new System.Windows.Forms.Button();
            this.gLoadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.csvLoad = new System.Windows.Forms.Button();
            this.gSuffix = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sLoadFileName
            // 
            this.sLoadFileName.Location = new System.Drawing.Point(30, 47);
            this.sLoadFileName.Name = "sLoadFileName";
            this.sLoadFileName.Size = new System.Drawing.Size(148, 19);
            this.sLoadFileName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "1. img load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox1
            // 
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Location = new System.Drawing.Point(30, 133);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(177, 129);
            this.picBox1.TabIndex = 3;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox2.Location = new System.Drawing.Point(293, 133);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(177, 129);
            this.picBox2.TabIndex = 4;
            this.picBox2.TabStop = false;
            // 
            // translate
            // 
            this.translate.Location = new System.Drawing.Point(602, 43);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(75, 23);
            this.translate.TabIndex = 5;
            this.translate.Text = "3. translate";
            this.translate.UseVisualStyleBackColor = true;
            this.translate.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(687, 136);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gLoadDirPath
            // 
            this.gLoadDirPath.Location = new System.Drawing.Point(65, 33);
            this.gLoadDirPath.Name = "gLoadDirPath";
            this.gLoadDirPath.Size = new System.Drawing.Size(480, 19);
            this.gLoadDirPath.TabIndex = 8;
            // 
            // gSaveDirPath
            // 
            this.gSaveDirPath.Location = new System.Drawing.Point(65, 58);
            this.gSaveDirPath.Name = "gSaveDirPath";
            this.gSaveDirPath.Size = new System.Drawing.Size(480, 19);
            this.gSaveDirPath.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sSuffix);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tDiffY);
            this.panel1.Controls.Add(this.tDiffX);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.sSaveFileName);
            this.panel1.Controls.Add(this.sSaveDir);
            this.panel1.Controls.Add(this.sLoadDir);
            this.panel1.Controls.Add(this.sLoadFileName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.translate);
            this.panel1.Location = new System.Drawing.Point(30, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 127);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "suffix";
            // 
            // sSuffix
            // 
            this.sSuffix.Location = new System.Drawing.Point(303, 48);
            this.sSuffix.MaxLength = 3;
            this.sSuffix.Name = "sSuffix";
            this.sSuffix.Size = new System.Drawing.Size(63, 19);
            this.sSuffix.TabIndex = 3;
            this.sSuffix.Text = "t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "single";
            // 
            // tDiffY
            // 
            this.tDiffY.Location = new System.Drawing.Point(491, 48);
            this.tDiffY.Name = "tDiffY";
            this.tDiffY.Size = new System.Drawing.Size(100, 19);
            this.tDiffY.TabIndex = 7;
            this.tDiffY.Leave += new System.EventHandler(this.tDiff_Y_Leave);
            // 
            // tDiffX
            // 
            this.tDiffX.Location = new System.Drawing.Point(385, 48);
            this.tDiffX.Name = "tDiffX";
            this.tDiffX.Size = new System.Drawing.Size(100, 19);
            this.tDiffX.TabIndex = 6;
            this.tDiffX.Leave += new System.EventHandler(this.tDiff_X_Leave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(602, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "4.save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "2. savePath";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sSaveFileName
            // 
            this.sSaveFileName.Location = new System.Drawing.Point(29, 100);
            this.sSaveFileName.Name = "sSaveFileName";
            this.sSaveFileName.Size = new System.Drawing.Size(148, 19);
            this.sSaveFileName.TabIndex = 5;
            // 
            // sSaveDir
            // 
            this.sSaveDir.Location = new System.Drawing.Point(30, 76);
            this.sSaveDir.Name = "sSaveDir";
            this.sSaveDir.Size = new System.Drawing.Size(349, 19);
            this.sSaveDir.TabIndex = 4;
            // 
            // sLoadDir
            // 
            this.sLoadDir.Location = new System.Drawing.Point(30, 22);
            this.sLoadDir.Name = "sLoadDir";
            this.sLoadDir.Size = new System.Drawing.Size(349, 19);
            this.sLoadDir.TabIndex = 1;
            // 
            // gSaveBtn
            // 
            this.gSaveBtn.Location = new System.Drawing.Point(551, 56);
            this.gSaveBtn.Name = "gSaveBtn";
            this.gSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.gSaveBtn.TabIndex = 11;
            this.gSaveBtn.Text = "2.saveDir";
            this.gSaveBtn.UseVisualStyleBackColor = true;
            this.gSaveBtn.Click += new System.EventHandler(this.gSaveBtn_Click);
            // 
            // gLoadBtn
            // 
            this.gLoadBtn.Location = new System.Drawing.Point(551, 29);
            this.gLoadBtn.Name = "gLoadBtn";
            this.gLoadBtn.Size = new System.Drawing.Size(75, 23);
            this.gLoadBtn.TabIndex = 14;
            this.gLoadBtn.Text = "1.loadDir";
            this.gLoadBtn.UseVisualStyleBackColor = true;
            this.gLoadBtn.Click += new System.EventHandler(this.gLoadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "->";
            // 
            // csvLoad
            // 
            this.csvLoad.Location = new System.Drawing.Point(645, 29);
            this.csvLoad.Name = "csvLoad";
            this.csvLoad.Size = new System.Drawing.Size(75, 23);
            this.csvLoad.TabIndex = 16;
            this.csvLoad.Text = "3.csvLoad";
            this.csvLoad.UseVisualStyleBackColor = true;
            this.csvLoad.Click += new System.EventHandler(this.csvLoad_Click);
            // 
            // gSuffix
            // 
            this.gSuffix.Location = new System.Drawing.Point(103, 83);
            this.gSuffix.MaxLength = 3;
            this.gSuffix.Name = "gSuffix";
            this.gSuffix.Size = new System.Drawing.Size(63, 19);
            this.gSuffix.TabIndex = 16;
            this.gSuffix.Text = "t";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.csvLoad);
            this.panel2.Controls.Add(this.gSaveBtn);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.gSuffix);
            this.panel2.Controls.Add(this.gLoadBtn);
            this.panel2.Controls.Add(this.gSaveDirPath);
            this.panel2.Controls.Add(this.gLoadDirPath);
            this.panel2.Location = new System.Drawing.Point(30, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 255);
            this.panel2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "csv based";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "suffix";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 617);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(868, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 642);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sLoadFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Button translate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox gLoadDirPath;
        private System.Windows.Forms.TextBox gSaveDirPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sSaveFileName;
        private System.Windows.Forms.TextBox sSaveDir;
        private System.Windows.Forms.TextBox sLoadDir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button gSaveBtn;
        private System.Windows.Forms.Button gLoadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tDiffY;
        private System.Windows.Forms.TextBox tDiffX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button csvLoad;
        private System.Windows.Forms.TextBox sSuffix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gSuffix;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}


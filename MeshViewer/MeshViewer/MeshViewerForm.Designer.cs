namespace MeshViewer
{
    partial class MeshViewer
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
            this.vsbFocalLength = new System.Windows.Forms.VScrollBar();
            this.vsbXT = new System.Windows.Forms.VScrollBar();
            this.vsbZT = new System.Windows.Forms.VScrollBar();
            this.lblFocal = new System.Windows.Forms.Label();
            this.lblZAxis = new System.Windows.Forms.Label();
            this.lblXAxisT = new System.Windows.Forms.Label();
            this.lblFocalValue = new System.Windows.Forms.Label();
            this.lblZValueT = new System.Windows.Forms.Label();
            this.lblMatrixDisplay = new System.Windows.Forms.Label();
            this.lblXValueT = new System.Windows.Forms.Label();
            this.btnShowPoints = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblYValueT = new System.Windows.Forms.Label();
            this.lblYAxisT = new System.Windows.Forms.Label();
            this.vsbYT = new System.Windows.Forms.VScrollBar();
            this.gbRotation = new System.Windows.Forms.GroupBox();
            this.gbScale = new System.Windows.Forms.GroupBox();
            this.gbPerspective = new System.Windows.Forms.GroupBox();
            this.vsbXR = new System.Windows.Forms.VScrollBar();
            this.vsbYR = new System.Windows.Forms.VScrollBar();
            this.vsbZR = new System.Windows.Forms.VScrollBar();
            this.vsbXS = new System.Windows.Forms.VScrollBar();
            this.vsbYS = new System.Windows.Forms.VScrollBar();
            this.vsbZS = new System.Windows.Forms.VScrollBar();
            this.lblXAxisR = new System.Windows.Forms.Label();
            this.lblXValueR = new System.Windows.Forms.Label();
            this.lblYValueR = new System.Windows.Forms.Label();
            this.lblYAxisR = new System.Windows.Forms.Label();
            this.lblZValueR = new System.Windows.Forms.Label();
            this.lblZAxisR = new System.Windows.Forms.Label();
            this.lblXValueS = new System.Windows.Forms.Label();
            this.lblXAxisS = new System.Windows.Forms.Label();
            this.lblYValueS = new System.Windows.Forms.Label();
            this.lblYAxisS = new System.Windows.Forms.Label();
            this.lblZValueS = new System.Windows.Forms.Label();
            this.lblZAxisS = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbRotation.SuspendLayout();
            this.gbScale.SuspendLayout();
            this.gbPerspective.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsbFocalLength
            // 
            this.vsbFocalLength.Location = new System.Drawing.Point(27, 61);
            this.vsbFocalLength.Maximum = 900;
            this.vsbFocalLength.Minimum = 10;
            this.vsbFocalLength.Name = "vsbFocalLength";
            this.vsbFocalLength.Size = new System.Drawing.Size(30, 120);
            this.vsbFocalLength.TabIndex = 0;
            this.vsbFocalLength.Value = 800;
            this.vsbFocalLength.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbFocalLength_Scroll);
            // 
            // vsbXT
            // 
            this.vsbXT.Location = new System.Drawing.Point(17, 48);
            this.vsbXT.Maximum = 500;
            this.vsbXT.Name = "vsbXT";
            this.vsbXT.Size = new System.Drawing.Size(30, 120);
            this.vsbXT.TabIndex = 2;
            this.vsbXT.Value = 100;
            this.vsbXT.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbX_Scroll);
            // 
            // vsbZT
            // 
            this.vsbZT.Location = new System.Drawing.Point(129, 48);
            this.vsbZT.Maximum = 800;
            this.vsbZT.Minimum = 20;
            this.vsbZT.Name = "vsbZT";
            this.vsbZT.Size = new System.Drawing.Size(30, 120);
            this.vsbZT.TabIndex = 4;
            this.vsbZT.Value = 400;
            this.vsbZT.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbZ_Scroll);
            // 
            // lblFocal
            // 
            this.lblFocal.AutoSize = true;
            this.lblFocal.Location = new System.Drawing.Point(14, 24);
            this.lblFocal.Name = "lblFocal";
            this.lblFocal.Size = new System.Drawing.Size(69, 13);
            this.lblFocal.TabIndex = 3;
            this.lblFocal.Text = "Focal Length";
            this.lblFocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZAxis
            // 
            this.lblZAxis.AutoSize = true;
            this.lblZAxis.Location = new System.Drawing.Point(126, 24);
            this.lblZAxis.Name = "lblZAxis";
            this.lblZAxis.Size = new System.Drawing.Size(14, 13);
            this.lblZAxis.TabIndex = 4;
            this.lblZAxis.Text = "Z";
            this.lblZAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblXAxisT
            // 
            this.lblXAxisT.AutoSize = true;
            this.lblXAxisT.Location = new System.Drawing.Point(14, 24);
            this.lblXAxisT.Name = "lblXAxisT";
            this.lblXAxisT.Size = new System.Drawing.Size(14, 13);
            this.lblXAxisT.TabIndex = 5;
            this.lblXAxisT.Text = "X";
            this.lblXAxisT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFocalValue
            // 
            this.lblFocalValue.AutoSize = true;
            this.lblFocalValue.Location = new System.Drawing.Point(35, 48);
            this.lblFocalValue.Name = "lblFocalValue";
            this.lblFocalValue.Size = new System.Drawing.Size(13, 13);
            this.lblFocalValue.TabIndex = 6;
            this.lblFocalValue.Text = "0";
            this.lblFocalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZValueT
            // 
            this.lblZValueT.AutoSize = true;
            this.lblZValueT.Location = new System.Drawing.Point(146, 24);
            this.lblZValueT.Name = "lblZValueT";
            this.lblZValueT.Size = new System.Drawing.Size(13, 13);
            this.lblZValueT.TabIndex = 7;
            this.lblZValueT.Text = "0";
            this.lblZValueT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatrixDisplay
            // 
            this.lblMatrixDisplay.AutoSize = true;
            this.lblMatrixDisplay.Location = new System.Drawing.Point(12, 504);
            this.lblMatrixDisplay.Name = "lblMatrixDisplay";
            this.lblMatrixDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblMatrixDisplay.TabIndex = 8;
            this.lblMatrixDisplay.Text = "Matrix";
            // 
            // lblXValueT
            // 
            this.lblXValueT.AutoSize = true;
            this.lblXValueT.Location = new System.Drawing.Point(32, 24);
            this.lblXValueT.Name = "lblXValueT";
            this.lblXValueT.Size = new System.Drawing.Size(13, 13);
            this.lblXValueT.TabIndex = 9;
            this.lblXValueT.Text = "0";
            this.lblXValueT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowPoints
            // 
            this.btnShowPoints.Location = new System.Drawing.Point(12, 478);
            this.btnShowPoints.Name = "btnShowPoints";
            this.btnShowPoints.Size = new System.Drawing.Size(75, 23);
            this.btnShowPoints.TabIndex = 10;
            this.btnShowPoints.Text = "Show points";
            this.btnShowPoints.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblYValueT);
            this.groupBox1.Controls.Add(this.lblXValueT);
            this.groupBox1.Controls.Add(this.lblZValueT);
            this.groupBox1.Controls.Add(this.lblYAxisT);
            this.groupBox1.Controls.Add(this.lblZAxis);
            this.groupBox1.Controls.Add(this.vsbXT);
            this.groupBox1.Controls.Add(this.vsbYT);
            this.groupBox1.Controls.Add(this.vsbZT);
            this.groupBox1.Controls.Add(this.lblXAxisT);
            this.groupBox1.Location = new System.Drawing.Point(592, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 180);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translation";
            // 
            // lblYValueT
            // 
            this.lblYValueT.AutoSize = true;
            this.lblYValueT.Location = new System.Drawing.Point(88, 24);
            this.lblYValueT.Name = "lblYValueT";
            this.lblYValueT.Size = new System.Drawing.Size(13, 13);
            this.lblYValueT.TabIndex = 12;
            this.lblYValueT.Text = "0";
            this.lblYValueT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYAxisT
            // 
            this.lblYAxisT.AutoSize = true;
            this.lblYAxisT.Location = new System.Drawing.Point(70, 24);
            this.lblYAxisT.Name = "lblYAxisT";
            this.lblYAxisT.Size = new System.Drawing.Size(14, 13);
            this.lblYAxisT.TabIndex = 11;
            this.lblYAxisT.Text = "Y";
            this.lblYAxisT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsbYT
            // 
            this.vsbYT.Location = new System.Drawing.Point(71, 48);
            this.vsbYT.Maximum = 500;
            this.vsbYT.Minimum = 10;
            this.vsbYT.Name = "vsbYT";
            this.vsbYT.Size = new System.Drawing.Size(30, 120);
            this.vsbYT.TabIndex = 10;
            this.vsbYT.Value = 100;
            this.vsbYT.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbY_Scroll);
            // 
            // gbRotation
            // 
            this.gbRotation.Controls.Add(this.lblZValueR);
            this.gbRotation.Controls.Add(this.lblZAxisR);
            this.gbRotation.Controls.Add(this.lblYValueR);
            this.gbRotation.Controls.Add(this.lblYAxisR);
            this.gbRotation.Controls.Add(this.vsbXR);
            this.gbRotation.Controls.Add(this.vsbYR);
            this.gbRotation.Controls.Add(this.vsbZR);
            this.gbRotation.Controls.Add(this.lblXValueR);
            this.gbRotation.Controls.Add(this.lblXAxisR);
            this.gbRotation.Location = new System.Drawing.Point(592, 224);
            this.gbRotation.Name = "gbRotation";
            this.gbRotation.Size = new System.Drawing.Size(180, 180);
            this.gbRotation.TabIndex = 13;
            this.gbRotation.TabStop = false;
            this.gbRotation.Text = "Rotation";
            // 
            // gbScale
            // 
            this.gbScale.Controls.Add(this.lblZValueS);
            this.gbScale.Controls.Add(this.lblZAxisS);
            this.gbScale.Controls.Add(this.lblYValueS);
            this.gbScale.Controls.Add(this.lblYAxisS);
            this.gbScale.Controls.Add(this.lblXValueS);
            this.gbScale.Controls.Add(this.vsbXS);
            this.gbScale.Controls.Add(this.lblXAxisS);
            this.gbScale.Controls.Add(this.vsbYS);
            this.gbScale.Controls.Add(this.vsbZS);
            this.gbScale.Location = new System.Drawing.Point(592, 410);
            this.gbScale.Name = "gbScale";
            this.gbScale.Size = new System.Drawing.Size(180, 180);
            this.gbScale.TabIndex = 14;
            this.gbScale.TabStop = false;
            this.gbScale.Text = "Scale";
            // 
            // gbPerspective
            // 
            this.gbPerspective.Controls.Add(this.vsbFocalLength);
            this.gbPerspective.Controls.Add(this.lblFocal);
            this.gbPerspective.Controls.Add(this.lblFocalValue);
            this.gbPerspective.Location = new System.Drawing.Point(497, 397);
            this.gbPerspective.Name = "gbPerspective";
            this.gbPerspective.Size = new System.Drawing.Size(89, 193);
            this.gbPerspective.TabIndex = 15;
            this.gbPerspective.TabStop = false;
            this.gbPerspective.Text = "Perspective";
            this.gbPerspective.Enter += new System.EventHandler(this.gbPerspective_Enter);
            // 
            // vsbXR
            // 
            this.vsbXR.Location = new System.Drawing.Point(17, 44);
            this.vsbXR.Maximum = 369;
            this.vsbXR.Name = "vsbXR";
            this.vsbXR.Size = new System.Drawing.Size(30, 120);
            this.vsbXR.TabIndex = 16;
            this.vsbXR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbXR_Scroll);
            // 
            // vsbYR
            // 
            this.vsbYR.Location = new System.Drawing.Point(71, 44);
            this.vsbYR.Maximum = 369;
            this.vsbYR.Name = "vsbYR";
            this.vsbYR.Size = new System.Drawing.Size(30, 120);
            this.vsbYR.TabIndex = 17;
            this.vsbYR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbYR_Scroll);
            // 
            // vsbZR
            // 
            this.vsbZR.Location = new System.Drawing.Point(129, 44);
            this.vsbZR.Maximum = 369;
            this.vsbZR.Name = "vsbZR";
            this.vsbZR.Size = new System.Drawing.Size(30, 120);
            this.vsbZR.TabIndex = 18;
            this.vsbZR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbZR_Scroll);
            // 
            // vsbXS
            // 
            this.vsbXS.Location = new System.Drawing.Point(17, 48);
            this.vsbXS.Maximum = 1000;
            this.vsbXS.Minimum = 1;
            this.vsbXS.Name = "vsbXS";
            this.vsbXS.Size = new System.Drawing.Size(30, 120);
            this.vsbXS.TabIndex = 19;
            this.vsbXS.Value = 100;
            this.vsbXS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbXS_Scroll);
            // 
            // vsbYS
            // 
            this.vsbYS.Location = new System.Drawing.Point(73, 48);
            this.vsbYS.Maximum = 1000;
            this.vsbYS.Minimum = 1;
            this.vsbYS.Name = "vsbYS";
            this.vsbYS.Size = new System.Drawing.Size(30, 120);
            this.vsbYS.TabIndex = 20;
            this.vsbYS.Value = 100;
            this.vsbYS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbYS_Scroll);
            // 
            // vsbZS
            // 
            this.vsbZS.Location = new System.Drawing.Point(129, 48);
            this.vsbZS.Maximum = 1000;
            this.vsbZS.Minimum = 1;
            this.vsbZS.Name = "vsbZS";
            this.vsbZS.Size = new System.Drawing.Size(30, 120);
            this.vsbZS.TabIndex = 21;
            this.vsbZS.Value = 100;
            this.vsbZS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbZS_Scroll);
            // 
            // lblXAxisR
            // 
            this.lblXAxisR.AutoSize = true;
            this.lblXAxisR.Location = new System.Drawing.Point(14, 18);
            this.lblXAxisR.Name = "lblXAxisR";
            this.lblXAxisR.Size = new System.Drawing.Size(14, 13);
            this.lblXAxisR.TabIndex = 25;
            this.lblXAxisR.Text = "X";
            // 
            // lblXValueR
            // 
            this.lblXValueR.AutoSize = true;
            this.lblXValueR.Location = new System.Drawing.Point(32, 18);
            this.lblXValueR.Name = "lblXValueR";
            this.lblXValueR.Size = new System.Drawing.Size(13, 13);
            this.lblXValueR.TabIndex = 24;
            this.lblXValueR.Text = "0";
            // 
            // lblYValueR
            // 
            this.lblYValueR.AutoSize = true;
            this.lblYValueR.Location = new System.Drawing.Point(86, 16);
            this.lblYValueR.Name = "lblYValueR";
            this.lblYValueR.Size = new System.Drawing.Size(13, 13);
            this.lblYValueR.TabIndex = 26;
            this.lblYValueR.Text = "0";
            // 
            // lblYAxisR
            // 
            this.lblYAxisR.AutoSize = true;
            this.lblYAxisR.Location = new System.Drawing.Point(68, 16);
            this.lblYAxisR.Name = "lblYAxisR";
            this.lblYAxisR.Size = new System.Drawing.Size(14, 13);
            this.lblYAxisR.TabIndex = 27;
            this.lblYAxisR.Text = "Y";
            // 
            // lblZValueR
            // 
            this.lblZValueR.AutoSize = true;
            this.lblZValueR.Location = new System.Drawing.Point(144, 16);
            this.lblZValueR.Name = "lblZValueR";
            this.lblZValueR.Size = new System.Drawing.Size(13, 13);
            this.lblZValueR.TabIndex = 28;
            this.lblZValueR.Text = "0";
            // 
            // lblZAxisR
            // 
            this.lblZAxisR.AutoSize = true;
            this.lblZAxisR.Location = new System.Drawing.Point(126, 16);
            this.lblZAxisR.Name = "lblZAxisR";
            this.lblZAxisR.Size = new System.Drawing.Size(14, 13);
            this.lblZAxisR.TabIndex = 29;
            this.lblZAxisR.Text = "Z";
            // 
            // lblXValueS
            // 
            this.lblXValueS.AutoSize = true;
            this.lblXValueS.Location = new System.Drawing.Point(32, 25);
            this.lblXValueS.Name = "lblXValueS";
            this.lblXValueS.Size = new System.Drawing.Size(13, 13);
            this.lblXValueS.TabIndex = 26;
            this.lblXValueS.Text = "0";
            // 
            // lblXAxisS
            // 
            this.lblXAxisS.AutoSize = true;
            this.lblXAxisS.Location = new System.Drawing.Point(14, 25);
            this.lblXAxisS.Name = "lblXAxisS";
            this.lblXAxisS.Size = new System.Drawing.Size(14, 13);
            this.lblXAxisS.TabIndex = 27;
            this.lblXAxisS.Text = "X";
            // 
            // lblYValueS
            // 
            this.lblYValueS.AutoSize = true;
            this.lblYValueS.Location = new System.Drawing.Point(88, 25);
            this.lblYValueS.Name = "lblYValueS";
            this.lblYValueS.Size = new System.Drawing.Size(13, 13);
            this.lblYValueS.TabIndex = 28;
            this.lblYValueS.Text = "0";
            // 
            // lblYAxisS
            // 
            this.lblYAxisS.AutoSize = true;
            this.lblYAxisS.Location = new System.Drawing.Point(70, 25);
            this.lblYAxisS.Name = "lblYAxisS";
            this.lblYAxisS.Size = new System.Drawing.Size(14, 13);
            this.lblYAxisS.TabIndex = 29;
            this.lblYAxisS.Text = "X";
            // 
            // lblZValueS
            // 
            this.lblZValueS.AutoSize = true;
            this.lblZValueS.Location = new System.Drawing.Point(144, 25);
            this.lblZValueS.Name = "lblZValueS";
            this.lblZValueS.Size = new System.Drawing.Size(13, 13);
            this.lblZValueS.TabIndex = 30;
            this.lblZValueS.Text = "0";
            // 
            // lblZAxisS
            // 
            this.lblZAxisS.AutoSize = true;
            this.lblZAxisS.Location = new System.Drawing.Point(126, 25);
            this.lblZAxisS.Name = "lblZAxisS";
            this.lblZAxisS.Size = new System.Drawing.Size(14, 13);
            this.lblZAxisS.TabIndex = 31;
            this.lblZAxisS.Text = "X";
            // 
            // MeshViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.gbPerspective);
            this.Controls.Add(this.gbScale);
            this.Controls.Add(this.gbRotation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowPoints);
            this.Controls.Add(this.lblMatrixDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MeshViewer";
            this.Text = "Mesh Viewer";
            this.Load += new System.EventHandler(this.MeshViewer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MeshViewer_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRotation.ResumeLayout(false);
            this.gbRotation.PerformLayout();
            this.gbScale.ResumeLayout(false);
            this.gbScale.PerformLayout();
            this.gbPerspective.ResumeLayout(false);
            this.gbPerspective.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vsbFocalLength;
        private System.Windows.Forms.VScrollBar vsbXT;
        private System.Windows.Forms.VScrollBar vsbZT;
        private System.Windows.Forms.Label lblFocal;
        private System.Windows.Forms.Label lblZAxis;
        private System.Windows.Forms.Label lblXAxisT;
        private System.Windows.Forms.Label lblFocalValue;
        private System.Windows.Forms.Label lblZValueT;
        private System.Windows.Forms.Label lblMatrixDisplay;
        private System.Windows.Forms.Label lblXValueT;
        private System.Windows.Forms.Button btnShowPoints;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblYValueT;
        private System.Windows.Forms.Label lblYAxisT;
        private System.Windows.Forms.VScrollBar vsbYT;
        private System.Windows.Forms.GroupBox gbRotation;
        private System.Windows.Forms.GroupBox gbScale;
        private System.Windows.Forms.GroupBox gbPerspective;
        private System.Windows.Forms.Label lblZValueR;
        private System.Windows.Forms.Label lblZAxisR;
        private System.Windows.Forms.Label lblYValueR;
        private System.Windows.Forms.Label lblYAxisR;
        private System.Windows.Forms.VScrollBar vsbXR;
        private System.Windows.Forms.VScrollBar vsbYR;
        private System.Windows.Forms.VScrollBar vsbZR;
        private System.Windows.Forms.Label lblXValueR;
        private System.Windows.Forms.Label lblXAxisR;
        private System.Windows.Forms.Label lblZValueS;
        private System.Windows.Forms.Label lblZAxisS;
        private System.Windows.Forms.Label lblYValueS;
        private System.Windows.Forms.Label lblYAxisS;
        private System.Windows.Forms.Label lblXValueS;
        private System.Windows.Forms.VScrollBar vsbXS;
        private System.Windows.Forms.Label lblXAxisS;
        private System.Windows.Forms.VScrollBar vsbYS;
        private System.Windows.Forms.VScrollBar vsbZS;
    }
}


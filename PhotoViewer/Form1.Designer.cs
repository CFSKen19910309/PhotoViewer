namespace PhotoViewer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Common = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox_SavePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_SaveImage = new System.Windows.Forms.Button();
            this.Button_OpenImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_SaveType = new System.Windows.Forms.ComboBox();
            this.Button_FitImage = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel_MouseOnPictureBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel_MouseOnImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel_Directory = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel_ImageName = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel_Status = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage_Common.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.AllowDrop = true;
            this.SplitContainer.Panel1.Controls.Add(this.PictureBox);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.TabControl);
            this.SplitContainer.Size = new System.Drawing.Size(587, 427);
            this.SplitContainer.SplitterDistance = 299;
            this.SplitContainer.SplitterWidth = 3;
            this.SplitContainer.TabIndex = 0;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(583, 295);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage_Common);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(583, 121);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage_Common
            // 
            this.tabPage_Common.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_Common.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Common.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Common.Name = "tabPage_Common";
            this.tabPage_Common.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Common.Size = new System.Drawing.Size(575, 95);
            this.tabPage_Common.TabIndex = 0;
            this.tabPage_Common.Text = "Common";
            this.tabPage_Common.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.21494F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.31512F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.10811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.54054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel1.Controls.Add(this.TextBox_SavePath, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_SaveImage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_OpenImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_SaveType, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button_FitImage, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(571, 91);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TextBox_SavePath
            // 
            this.TextBox_SavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_SavePath.Location = new System.Drawing.Point(316, 2);
            this.TextBox_SavePath.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_SavePath.Multiline = true;
            this.TextBox_SavePath.Name = "TextBox_SavePath";
            this.TextBox_SavePath.ReadOnly = true;
            this.TextBox_SavePath.Size = new System.Drawing.Size(253, 41);
            this.TextBox_SavePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(252, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Save Path :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button_SaveImage
            // 
            this.Button_SaveImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SaveImage.Location = new System.Drawing.Point(59, 2);
            this.Button_SaveImage.Margin = new System.Windows.Forms.Padding(2);
            this.Button_SaveImage.Name = "Button_SaveImage";
            this.tableLayoutPanel1.SetRowSpan(this.Button_SaveImage, 2);
            this.Button_SaveImage.Size = new System.Drawing.Size(69, 87);
            this.Button_SaveImage.TabIndex = 1;
            this.Button_SaveImage.Text = "Save Image";
            this.Button_SaveImage.UseVisualStyleBackColor = true;
            this.Button_SaveImage.Click += new System.EventHandler(this.Button_SaveImage_Click);
            // 
            // Button_OpenImage
            // 
            this.Button_OpenImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_OpenImage.Location = new System.Drawing.Point(2, 2);
            this.Button_OpenImage.Margin = new System.Windows.Forms.Padding(2);
            this.Button_OpenImage.Name = "Button_OpenImage";
            this.tableLayoutPanel1.SetRowSpan(this.Button_OpenImage, 2);
            this.Button_OpenImage.Size = new System.Drawing.Size(53, 87);
            this.Button_OpenImage.TabIndex = 0;
            this.Button_OpenImage.Text = "Open Image";
            this.Button_OpenImage.UseVisualStyleBackColor = true;
            this.Button_OpenImage.Click += new System.EventHandler(this.Button_OpenImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(252, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save Type :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox_SaveType
            // 
            this.ComboBox_SaveType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_SaveType.DropDownHeight = 200;
            this.ComboBox_SaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_SaveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_SaveType.FormattingEnabled = true;
            this.ComboBox_SaveType.IntegralHeight = false;
            this.ComboBox_SaveType.ItemHeight = 13;
            this.ComboBox_SaveType.Location = new System.Drawing.Point(316, 47);
            this.ComboBox_SaveType.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_SaveType.Name = "ComboBox_SaveType";
            this.ComboBox_SaveType.Size = new System.Drawing.Size(253, 21);
            this.ComboBox_SaveType.TabIndex = 4;
            // 
            // Button_FitImage
            // 
            this.Button_FitImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_FitImage.Location = new System.Drawing.Point(133, 3);
            this.Button_FitImage.Name = "Button_FitImage";
            this.tableLayoutPanel1.SetRowSpan(this.Button_FitImage, 2);
            this.Button_FitImage.Size = new System.Drawing.Size(114, 85);
            this.Button_FitImage.TabIndex = 5;
            this.Button_FitImage.Text = "Image Fit";
            this.Button_FitImage.UseVisualStyleBackColor = true;
            this.Button_FitImage.Click += new System.EventHandler(this.Button_FitImage_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(575, 95);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel_MouseOnPictureBox,
            this.ToolStripStatusLabel_MouseOnImage,
            this.ToolStripStatusLabel_Directory,
            this.ToolStripStatusLabel_ImageName,
            this.ToolStripStatusLabel_Status});
            this.StatusStrip.Location = new System.Drawing.Point(0, 405);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.StatusStrip.Size = new System.Drawing.Size(587, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel_MouseOnPictureBox
            // 
            this.ToolStripStatusLabel_MouseOnPictureBox.Name = "ToolStripStatusLabel_MouseOnPictureBox";
            this.ToolStripStatusLabel_MouseOnPictureBox.Size = new System.Drawing.Size(121, 17);
            this.ToolStripStatusLabel_MouseOnPictureBox.Text = "MouseOnPictureBox :";
            // 
            // ToolStripStatusLabel_MouseOnImage
            // 
            this.ToolStripStatusLabel_MouseOnImage.Name = "ToolStripStatusLabel_MouseOnImage";
            this.ToolStripStatusLabel_MouseOnImage.Size = new System.Drawing.Size(98, 17);
            this.ToolStripStatusLabel_MouseOnImage.Text = "MouseOnImage :";
            // 
            // ToolStripStatusLabel_Directory
            // 
            this.ToolStripStatusLabel_Directory.Name = "ToolStripStatusLabel_Directory";
            this.ToolStripStatusLabel_Directory.Size = new System.Drawing.Size(61, 17);
            this.ToolStripStatusLabel_Directory.Text = "Directory :";
            // 
            // ToolStripStatusLabel_ImageName
            // 
            this.ToolStripStatusLabel_ImageName.Name = "ToolStripStatusLabel_ImageName";
            this.ToolStripStatusLabel_ImageName.Size = new System.Drawing.Size(78, 17);
            this.ToolStripStatusLabel_ImageName.Text = "ImageName :";
            // 
            // ToolStripStatusLabel_Status
            // 
            this.ToolStripStatusLabel_Status.Name = "ToolStripStatusLabel_Status";
            this.ToolStripStatusLabel_Status.Size = new System.Drawing.Size(45, 17);
            this.ToolStripStatusLabel_Status.Text = "Status :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 427);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.SplitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage_Common.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage_Common;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_Directory;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_ImageName;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_Status;
        private System.Windows.Forms.Button Button_OpenImage;
        private System.Windows.Forms.Button Button_SaveImage;
        private System.Windows.Forms.TextBox TextBox_SavePath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_SaveType;
        private System.Windows.Forms.Button Button_FitImage;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_MouseOnPictureBox;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_MouseOnImage;
    }
}



namespace drawing_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmptyCanvas = new ReaLTaiizor.Controls.Panel();
            this.SaveFileLabel = new ReaLTaiizor.Controls.NightLabel();
            this.show_ptx_Label = new ReaLTaiizor.Controls.CrownLabel();
            this.savefile_btn = new ReaLTaiizor.Controls.Button();
            this.thickness_TrackBar = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.thickness_Numeric = new ReaLTaiizor.Controls.CrownNumeric();
            this.eraser_btn = new ReaLTaiizor.Controls.Button();
            this.pen_btn = new ReaLTaiizor.Controls.Button();
            this.labelClearAll = new ReaLTaiizor.Controls.NightLabel();
            this.clear_btn = new ReaLTaiizor.Controls.Button();
            this.crownDockPanel1 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            this.crownDockPanel2 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            this.crownDockPanel3 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            this.SavePicFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Canva = new System.Windows.Forms.PictureBox();
            this.roundButton20 = new drawing_app.RoundButton();
            this.roundButton19 = new drawing_app.RoundButton();
            this.roundButton18 = new drawing_app.RoundButton();
            this.roundButton17 = new drawing_app.RoundButton();
            this.roundButton16 = new drawing_app.RoundButton();
            this.roundButton15 = new drawing_app.RoundButton();
            this.roundButton14 = new drawing_app.RoundButton();
            this.roundButton13 = new drawing_app.RoundButton();
            this.roundButton12 = new drawing_app.RoundButton();
            this.roundButton11 = new drawing_app.RoundButton();
            this.roundButton10 = new drawing_app.RoundButton();
            this.roundButton9 = new drawing_app.RoundButton();
            this.roundButton8 = new drawing_app.RoundButton();
            this.roundButton7 = new drawing_app.RoundButton();
            this.roundButton6 = new drawing_app.RoundButton();
            this.roundButton5 = new drawing_app.RoundButton();
            this.roundButton4 = new drawing_app.RoundButton();
            this.roundButton3 = new drawing_app.RoundButton();
            this.roundButton2 = new drawing_app.RoundButton();
            this.roundButton1 = new drawing_app.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.EmptyCanvas);
            this.panel1.Controls.Add(this.SaveFileLabel);
            this.panel1.Controls.Add(this.show_ptx_Label);
            this.panel1.Controls.Add(this.savefile_btn);
            this.panel1.Controls.Add(this.thickness_TrackBar);
            this.panel1.Controls.Add(this.crownLabel1);
            this.panel1.Controls.Add(this.thickness_Numeric);
            this.panel1.Controls.Add(this.roundButton20);
            this.panel1.Controls.Add(this.roundButton19);
            this.panel1.Controls.Add(this.roundButton18);
            this.panel1.Controls.Add(this.roundButton17);
            this.panel1.Controls.Add(this.roundButton16);
            this.panel1.Controls.Add(this.roundButton15);
            this.panel1.Controls.Add(this.roundButton14);
            this.panel1.Controls.Add(this.roundButton13);
            this.panel1.Controls.Add(this.roundButton12);
            this.panel1.Controls.Add(this.roundButton11);
            this.panel1.Controls.Add(this.roundButton10);
            this.panel1.Controls.Add(this.roundButton9);
            this.panel1.Controls.Add(this.roundButton8);
            this.panel1.Controls.Add(this.roundButton7);
            this.panel1.Controls.Add(this.roundButton6);
            this.panel1.Controls.Add(this.roundButton5);
            this.panel1.Controls.Add(this.roundButton4);
            this.panel1.Controls.Add(this.roundButton3);
            this.panel1.Controls.Add(this.roundButton2);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Controls.Add(this.eraser_btn);
            this.panel1.Controls.Add(this.pen_btn);
            this.panel1.Controls.Add(this.labelClearAll);
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.crownDockPanel1);
            this.panel1.Controls.Add(this.crownDockPanel2);
            this.panel1.Controls.Add(this.crownDockPanel3);
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(1613, 292);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::drawing_app.Properties.Resources.logo_icon__used_;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // EmptyCanvas
            // 
            this.EmptyCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.EmptyCanvas.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.EmptyCanvas.Location = new System.Drawing.Point(0, 174);
            this.EmptyCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmptyCanvas.Name = "EmptyCanvas";
            this.EmptyCanvas.Padding = new System.Windows.Forms.Padding(5);
            this.EmptyCanvas.Size = new System.Drawing.Size(1493, 779);
            this.EmptyCanvas.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.EmptyCanvas.TabIndex = 1;
            this.EmptyCanvas.Text = "panel2";
            // 
            // SaveFileLabel
            // 
            this.SaveFileLabel.AutoSize = true;
            this.SaveFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveFileLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SaveFileLabel.ForeColor = System.Drawing.Color.White;
            this.SaveFileLabel.Location = new System.Drawing.Point(101, 146);
            this.SaveFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SaveFileLabel.Name = "SaveFileLabel";
            this.SaveFileLabel.Size = new System.Drawing.Size(72, 19);
            this.SaveFileLabel.TabIndex = 44;
            this.SaveFileLabel.Text = "Save File";
            // 
            // show_ptx_Label
            // 
            this.show_ptx_Label.AutoSize = true;
            this.show_ptx_Label.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.show_ptx_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.show_ptx_Label.Location = new System.Drawing.Point(839, 150);
            this.show_ptx_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.show_ptx_Label.Name = "show_ptx_Label";
            this.show_ptx_Label.Size = new System.Drawing.Size(0, 21);
            this.show_ptx_Label.TabIndex = 42;
            // 
            // savefile_btn
            // 
            this.savefile_btn.BackColor = System.Drawing.Color.Transparent;
            this.savefile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savefile_btn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.savefile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.savefile_btn.Image = ((System.Drawing.Image)(resources.GetObject("savefile_btn.Image")));
            this.savefile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savefile_btn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.savefile_btn.Location = new System.Drawing.Point(101, 61);
            this.savefile_btn.Margin = new System.Windows.Forms.Padding(4);
            this.savefile_btn.Name = "savefile_btn";
            this.savefile_btn.PressedColor = System.Drawing.Color.Gray;
            this.savefile_btn.Size = new System.Drawing.Size(81, 82);
            this.savefile_btn.TabIndex = 1;
            this.savefile_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.savefile_btn.Click += new System.EventHandler(this.savefile_btn_Click);
            // 
            // thickness_TrackBar
            // 
            this.thickness_TrackBar.BackColor = System.Drawing.Color.Silver;
            this.thickness_TrackBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.thickness_TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thickness_TrackBar.DrawValueString = false;
            this.thickness_TrackBar.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.thickness_TrackBar.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.thickness_TrackBar.JumpToMouse = false;
            this.thickness_TrackBar.Location = new System.Drawing.Point(461, 97);
            this.thickness_TrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.thickness_TrackBar.Maximum = 100;
            this.thickness_TrackBar.Minimum = 0;
            this.thickness_TrackBar.MinimumSize = new System.Drawing.Size(63, 28);
            this.thickness_TrackBar.Name = "thickness_TrackBar";
            this.thickness_TrackBar.Size = new System.Drawing.Size(300, 28);
            this.thickness_TrackBar.TabIndex = 13;
            this.thickness_TrackBar.Text = "dungeonTrackBar1";
            this.thickness_TrackBar.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.thickness_TrackBar.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.thickness_TrackBar.Value = 5;
            this.thickness_TrackBar.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            this.thickness_TrackBar.ValueToSet = 5F;
            this.thickness_TrackBar.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.dungeonTrackBar1_ValueChanged);
            // 
            // crownLabel1
            // 
            this.crownLabel1.AutoSize = true;
            this.crownLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel1.Location = new System.Drawing.Point(697, 140);
            this.crownLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crownLabel1.Name = "crownLabel1";
            this.crownLabel1.Size = new System.Drawing.Size(35, 21);
            this.crownLabel1.TabIndex = 14;
            this.crownLabel1.Text = "ptx";
            // 
            // thickness_Numeric
            // 
            this.thickness_Numeric.Location = new System.Drawing.Point(569, 140);
            this.thickness_Numeric.Margin = new System.Windows.Forms.Padding(4);
            this.thickness_Numeric.Name = "thickness_Numeric";
            this.thickness_Numeric.Size = new System.Drawing.Size(120, 25);
            this.thickness_Numeric.TabIndex = 1;
            this.thickness_Numeric.ValueChanged += new System.EventHandler(this.thickness_Numeric_ValueChanged);
            // 
            // eraser_btn
            // 
            this.eraser_btn.BackColor = System.Drawing.Color.Transparent;
            this.eraser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraser_btn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.eraser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.eraser_btn.Image = ((System.Drawing.Image)(resources.GetObject("eraser_btn.Image")));
            this.eraser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eraser_btn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.eraser_btn.Location = new System.Drawing.Point(366, 78);
            this.eraser_btn.Margin = new System.Windows.Forms.Padding(4);
            this.eraser_btn.Name = "eraser_btn";
            this.eraser_btn.PressedColor = System.Drawing.Color.Gray;
            this.eraser_btn.Size = new System.Drawing.Size(75, 70);
            this.eraser_btn.TabIndex = 15;
            this.eraser_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.eraser_btn.Click += new System.EventHandler(this.eraser_btn_Click);
            // 
            // pen_btn
            // 
            this.pen_btn.BackColor = System.Drawing.Color.Transparent;
            this.pen_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pen_btn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pen_btn.Image = ((System.Drawing.Image)(resources.GetObject("pen_btn.Image")));
            this.pen_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pen_btn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pen_btn.Location = new System.Drawing.Point(270, 78);
            this.pen_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pen_btn.Name = "pen_btn";
            this.pen_btn.PressedColor = System.Drawing.Color.Gray;
            this.pen_btn.Size = new System.Drawing.Size(72, 68);
            this.pen_btn.TabIndex = 11;
            this.pen_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.pen_btn.Click += new System.EventHandler(this.pen_btn_Click);
            // 
            // labelClearAll
            // 
            this.labelClearAll.AutoSize = true;
            this.labelClearAll.BackColor = System.Drawing.Color.Transparent;
            this.labelClearAll.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelClearAll.ForeColor = System.Drawing.Color.White;
            this.labelClearAll.Location = new System.Drawing.Point(12, 147);
            this.labelClearAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClearAll.Name = "labelClearAll";
            this.labelClearAll.Size = new System.Drawing.Size(69, 19);
            this.labelClearAll.TabIndex = 9;
            this.labelClearAll.Text = "Clear All";
            this.labelClearAll.Click += new System.EventHandler(this.nightLabel5_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Transparent;
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear_btn.Image = ((System.Drawing.Image)(resources.GetObject("clear_btn.Image")));
            this.clear_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear_btn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.clear_btn.Location = new System.Drawing.Point(12, 61);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(4);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.PressedColor = System.Drawing.Color.Gray;
            this.clear_btn.Size = new System.Drawing.Size(81, 85);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // crownDockPanel1
            // 
            this.crownDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.crownDockPanel1.Location = new System.Drawing.Point(0, 55);
            this.crownDockPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.crownDockPanel1.Name = "crownDockPanel1";
            this.crownDockPanel1.Size = new System.Drawing.Size(203, 155);
            this.crownDockPanel1.TabIndex = 1;
            // 
            // crownDockPanel2
            // 
            this.crownDockPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.crownDockPanel2.Location = new System.Drawing.Point(232, 55);
            this.crownDockPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.crownDockPanel2.Name = "crownDockPanel2";
            this.crownDockPanel2.Size = new System.Drawing.Size(583, 130);
            this.crownDockPanel2.TabIndex = 10;
            // 
            // crownDockPanel3
            // 
            this.crownDockPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.crownDockPanel3.Location = new System.Drawing.Point(847, 52);
            this.crownDockPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.crownDockPanel3.Name = "crownDockPanel3";
            this.crownDockPanel3.Size = new System.Drawing.Size(439, 130);
            this.crownDockPanel3.TabIndex = 18;
            // 
            // Canva
            // 
            this.Canva.BackColor = System.Drawing.Color.White;
            this.Canva.Location = new System.Drawing.Point(1, 182);
            this.Canva.Margin = new System.Windows.Forms.Padding(4);
            this.Canva.Name = "Canva";
            this.Canva.Size = new System.Drawing.Size(1285, 768);
            this.Canva.TabIndex = 1;
            this.Canva.TabStop = false;
            this.Canva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseDown);
            this.Canva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseMove);
            this.Canva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseUp);
            // 
            // roundButton20
            // 
            this.roundButton20.BackColor = System.Drawing.Color.Black;
            this.roundButton20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton20.BackgroundImage")));
            this.roundButton20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton20.Image = ((System.Drawing.Image)(resources.GetObject("roundButton20.Image")));
            this.roundButton20.Location = new System.Drawing.Point(1192, 109);
            this.roundButton20.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton20.Name = "roundButton20";
            this.roundButton20.Size = new System.Drawing.Size(33, 32);
            this.roundButton20.TabIndex = 37;
            this.roundButton20.UseVisualStyleBackColor = false;
            this.roundButton20.Click += new System.EventHandler(this.roundButton20_Click);
            // 
            // roundButton19
            // 
            this.roundButton19.BackColor = System.Drawing.Color.Black;
            this.roundButton19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton19.BackgroundImage")));
            this.roundButton19.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton19.Image = ((System.Drawing.Image)(resources.GetObject("roundButton19.Image")));
            this.roundButton19.Location = new System.Drawing.Point(1233, 111);
            this.roundButton19.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton19.Name = "roundButton19";
            this.roundButton19.Size = new System.Drawing.Size(33, 32);
            this.roundButton19.TabIndex = 36;
            this.roundButton19.UseVisualStyleBackColor = false;
            this.roundButton19.Click += new System.EventHandler(this.roundButton19_Click);
            // 
            // roundButton18
            // 
            this.roundButton18.BackColor = System.Drawing.Color.Black;
            this.roundButton18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton18.BackgroundImage")));
            this.roundButton18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton18.Image = ((System.Drawing.Image)(resources.GetObject("roundButton18.Image")));
            this.roundButton18.Location = new System.Drawing.Point(863, 109);
            this.roundButton18.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton18.Name = "roundButton18";
            this.roundButton18.Size = new System.Drawing.Size(33, 32);
            this.roundButton18.TabIndex = 35;
            this.roundButton18.UseVisualStyleBackColor = false;
            this.roundButton18.Click += new System.EventHandler(this.roundButton18_Click);
            // 
            // roundButton17
            // 
            this.roundButton17.BackColor = System.Drawing.Color.Black;
            this.roundButton17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton17.BackgroundImage")));
            this.roundButton17.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton17.Image = ((System.Drawing.Image)(resources.GetObject("roundButton17.Image")));
            this.roundButton17.Location = new System.Drawing.Point(905, 109);
            this.roundButton17.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton17.Name = "roundButton17";
            this.roundButton17.Size = new System.Drawing.Size(33, 32);
            this.roundButton17.TabIndex = 34;
            this.roundButton17.UseVisualStyleBackColor = false;
            this.roundButton17.Click += new System.EventHandler(this.roundButton17_Click);
            // 
            // roundButton16
            // 
            this.roundButton16.BackColor = System.Drawing.Color.Black;
            this.roundButton16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton16.BackgroundImage")));
            this.roundButton16.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton16.Image = ((System.Drawing.Image)(resources.GetObject("roundButton16.Image")));
            this.roundButton16.Location = new System.Drawing.Point(947, 109);
            this.roundButton16.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton16.Name = "roundButton16";
            this.roundButton16.Size = new System.Drawing.Size(33, 32);
            this.roundButton16.TabIndex = 33;
            this.roundButton16.UseVisualStyleBackColor = false;
            this.roundButton16.Click += new System.EventHandler(this.roundButton16_Click);
            // 
            // roundButton15
            // 
            this.roundButton15.BackColor = System.Drawing.Color.Black;
            this.roundButton15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton15.BackgroundImage")));
            this.roundButton15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton15.Image = ((System.Drawing.Image)(resources.GetObject("roundButton15.Image")));
            this.roundButton15.Location = new System.Drawing.Point(987, 109);
            this.roundButton15.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton15.Name = "roundButton15";
            this.roundButton15.Size = new System.Drawing.Size(33, 32);
            this.roundButton15.TabIndex = 32;
            this.roundButton15.UseVisualStyleBackColor = false;
            this.roundButton15.Click += new System.EventHandler(this.roundButton15_Click);
            // 
            // roundButton14
            // 
            this.roundButton14.BackColor = System.Drawing.Color.Black;
            this.roundButton14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton14.BackgroundImage")));
            this.roundButton14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton14.Image = ((System.Drawing.Image)(resources.GetObject("roundButton14.Image")));
            this.roundButton14.Location = new System.Drawing.Point(1028, 109);
            this.roundButton14.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton14.Name = "roundButton14";
            this.roundButton14.Size = new System.Drawing.Size(33, 32);
            this.roundButton14.TabIndex = 31;
            this.roundButton14.UseVisualStyleBackColor = false;
            this.roundButton14.Click += new System.EventHandler(this.roundButton14_Click);
            // 
            // roundButton13
            // 
            this.roundButton13.BackColor = System.Drawing.Color.Black;
            this.roundButton13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton13.BackgroundImage")));
            this.roundButton13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton13.Image = ((System.Drawing.Image)(resources.GetObject("roundButton13.Image")));
            this.roundButton13.Location = new System.Drawing.Point(1069, 109);
            this.roundButton13.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton13.Name = "roundButton13";
            this.roundButton13.Size = new System.Drawing.Size(33, 32);
            this.roundButton13.TabIndex = 30;
            this.roundButton13.UseVisualStyleBackColor = false;
            this.roundButton13.Click += new System.EventHandler(this.roundButton13_Click);
            // 
            // roundButton12
            // 
            this.roundButton12.BackColor = System.Drawing.Color.DimGray;
            this.roundButton12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton12.BackgroundImage")));
            this.roundButton12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.roundButton12.Image = ((System.Drawing.Image)(resources.GetObject("roundButton12.Image")));
            this.roundButton12.Location = new System.Drawing.Point(905, 66);
            this.roundButton12.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton12.Name = "roundButton12";
            this.roundButton12.Size = new System.Drawing.Size(33, 32);
            this.roundButton12.TabIndex = 29;
            this.roundButton12.UseVisualStyleBackColor = false;
            this.roundButton12.Click += new System.EventHandler(this.roundButton12_Click);
            // 
            // roundButton11
            // 
            this.roundButton11.BackColor = System.Drawing.Color.Black;
            this.roundButton11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton11.BackgroundImage")));
            this.roundButton11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton11.Image = ((System.Drawing.Image)(resources.GetObject("roundButton11.Image")));
            this.roundButton11.Location = new System.Drawing.Point(947, 66);
            this.roundButton11.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton11.Name = "roundButton11";
            this.roundButton11.Size = new System.Drawing.Size(33, 32);
            this.roundButton11.TabIndex = 28;
            this.roundButton11.UseVisualStyleBackColor = false;
            this.roundButton11.Click += new System.EventHandler(this.roundButton11_Click);
            // 
            // roundButton10
            // 
            this.roundButton10.BackColor = System.Drawing.Color.Black;
            this.roundButton10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton10.BackgroundImage")));
            this.roundButton10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton10.Image = ((System.Drawing.Image)(resources.GetObject("roundButton10.Image")));
            this.roundButton10.Location = new System.Drawing.Point(987, 66);
            this.roundButton10.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.Size = new System.Drawing.Size(33, 32);
            this.roundButton10.TabIndex = 27;
            this.roundButton10.UseVisualStyleBackColor = false;
            this.roundButton10.Click += new System.EventHandler(this.roundButton10_Click);
            // 
            // roundButton9
            // 
            this.roundButton9.BackColor = System.Drawing.Color.Black;
            this.roundButton9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton9.BackgroundImage")));
            this.roundButton9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton9.Image = ((System.Drawing.Image)(resources.GetObject("roundButton9.Image")));
            this.roundButton9.Location = new System.Drawing.Point(1028, 66);
            this.roundButton9.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton9.Name = "roundButton9";
            this.roundButton9.Size = new System.Drawing.Size(33, 32);
            this.roundButton9.TabIndex = 26;
            this.roundButton9.UseVisualStyleBackColor = false;
            this.roundButton9.Click += new System.EventHandler(this.roundButton9_Click);
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.Color.Black;
            this.roundButton8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton8.BackgroundImage")));
            this.roundButton8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton8.Image = ((System.Drawing.Image)(resources.GetObject("roundButton8.Image")));
            this.roundButton8.Location = new System.Drawing.Point(1069, 66);
            this.roundButton8.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(33, 32);
            this.roundButton8.TabIndex = 25;
            this.roundButton8.UseVisualStyleBackColor = false;
            this.roundButton8.Click += new System.EventHandler(this.roundButton8_Click);
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.Black;
            this.roundButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton7.BackgroundImage")));
            this.roundButton7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton7.Image = ((System.Drawing.Image)(resources.GetObject("roundButton7.Image")));
            this.roundButton7.Location = new System.Drawing.Point(1109, 66);
            this.roundButton7.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(33, 32);
            this.roundButton7.TabIndex = 24;
            this.roundButton7.UseVisualStyleBackColor = false;
            this.roundButton7.Click += new System.EventHandler(this.roundButton7_Click);
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.Black;
            this.roundButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton6.BackgroundImage")));
            this.roundButton6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.Image = ((System.Drawing.Image)(resources.GetObject("roundButton6.Image")));
            this.roundButton6.Location = new System.Drawing.Point(1151, 66);
            this.roundButton6.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(33, 32);
            this.roundButton6.TabIndex = 23;
            this.roundButton6.UseVisualStyleBackColor = false;
            this.roundButton6.Click += new System.EventHandler(this.roundButton6_Click);
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.Black;
            this.roundButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton5.BackgroundImage")));
            this.roundButton5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton5.Image = ((System.Drawing.Image)(resources.GetObject("roundButton5.Image")));
            this.roundButton5.Location = new System.Drawing.Point(1192, 66);
            this.roundButton5.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(33, 32);
            this.roundButton5.TabIndex = 22;
            this.roundButton5.UseVisualStyleBackColor = false;
            this.roundButton5.Click += new System.EventHandler(this.roundButton5_Click);
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.Black;
            this.roundButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton4.BackgroundImage")));
            this.roundButton4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Image = ((System.Drawing.Image)(resources.GetObject("roundButton4.Image")));
            this.roundButton4.Location = new System.Drawing.Point(1233, 66);
            this.roundButton4.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(33, 32);
            this.roundButton4.TabIndex = 21;
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.Black;
            this.roundButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton3.BackgroundImage")));
            this.roundButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Image = ((System.Drawing.Image)(resources.GetObject("roundButton3.Image")));
            this.roundButton3.Location = new System.Drawing.Point(1109, 109);
            this.roundButton3.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(33, 32);
            this.roundButton3.TabIndex = 20;
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Black;
            this.roundButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton2.BackgroundImage")));
            this.roundButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Image = ((System.Drawing.Image)(resources.GetObject("roundButton2.Image")));
            this.roundButton2.Location = new System.Drawing.Point(1151, 109);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(33, 32);
            this.roundButton2.TabIndex = 19;
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Black;
            this.roundButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton1.BackgroundImage")));
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Image = ((System.Drawing.Image)(resources.GetObject("roundButton1.Image")));
            this.roundButton1.Location = new System.Drawing.Point(863, 66);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(33, 32);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 952);
            this.Controls.Add(this.Canva);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1301, 991);
            this.MinimumSize = new System.Drawing.Size(1301, 991);
            this.Name = "Form1";
            this.Text = "Easy Drawing APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.Button savefile_btn;
        private ReaLTaiizor.Controls.NightLabel labelClearAll;
        private ReaLTaiizor.Controls.Button clear_btn;
        private ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel1;
        private ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel2;
        private ReaLTaiizor.Controls.Button pen_btn;
        private ReaLTaiizor.Controls.DungeonTrackBar thickness_TrackBar;
        private ReaLTaiizor.Controls.CrownNumeric thickness_Numeric;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.Button eraser_btn;
        private ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel3;
        private RoundButton roundButton1;
        private RoundButton roundButton12;
        private RoundButton roundButton11;
        private RoundButton roundButton10;
        private RoundButton roundButton9;
        private RoundButton roundButton8;
        private RoundButton roundButton7;
        private RoundButton roundButton6;
        private RoundButton roundButton5;
        private RoundButton roundButton4;
        private RoundButton roundButton3;
        private RoundButton roundButton2;
        private RoundButton roundButton18;
        private RoundButton roundButton17;
        private RoundButton roundButton16;
        private RoundButton roundButton15;
        private RoundButton roundButton14;
        private RoundButton roundButton13;
        private RoundButton roundButton20;
        private RoundButton roundButton19;
        private ReaLTaiizor.Controls.CrownLabel show_ptx_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightLabel SaveFileLabel;
        private System.Windows.Forms.SaveFileDialog SavePicFileDialog;
        private ReaLTaiizor.Controls.Panel EmptyCanvas;
        private System.Windows.Forms.PictureBox Canva;
    }
}


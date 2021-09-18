
namespace QR_Code_generator
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
            this.qrcode_picbox_url = new System.Windows.Forms.PictureBox();
            this.size_label = new System.Windows.Forms.Label();
            this.three_hundred_px_btn = new System.Windows.Forms.Button();
            this.two_hundred_px_btn = new System.Windows.Forms.Button();
            this.one_hundred_px_btn = new System.Windows.Forms.Button();
            this.custom_label = new System.Windows.Forms.Label();
            this.custom_numberic_text = new System.Windows.Forms.NumericUpDown();
            this.px_label = new System.Windows.Forms.Label();
            this.save_as_label = new System.Windows.Forms.Label();
            this.SavingFiles_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.save_svgFile_linkLabel = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.save_pngFile_linkLabel = new System.Windows.Forms.LinkLabel();
            this.save_gifFile_linkLabel = new System.Windows.Forms.LinkLabel();
            this.save_jpgFile_linkLabel = new System.Windows.Forms.LinkLabel();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.TextTabPage = new MetroFramework.Controls.MetroTabPage();
            this.OK_button_text = new System.Windows.Forms.Button();
            this.generate_text_btn = new System.Windows.Forms.Button();
            this.enterText_textbox = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.qr_code_picbox_text = new System.Windows.Forms.PictureBox();
            this.warning_label_text = new System.Windows.Forms.Label();
            this.URL_TabPage = new MetroFramework.Controls.MetroTabPage();
            this.OK_button_url = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.custom_numberic_url = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.generate_url_btn = new System.Windows.Forms.Button();
            this.enter_url_textbox = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.warning_label_url = new System.Windows.Forms.Label();
            this.fifty_px_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrcode_picbox_url)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custom_numberic_text)).BeginInit();
            this.SavingFiles_panel.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TextTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qr_code_picbox_text)).BeginInit();
            this.URL_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custom_numberic_url)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // qrcode_picbox_url
            // 
            this.qrcode_picbox_url.BackColor = System.Drawing.Color.White;
            this.qrcode_picbox_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrcode_picbox_url.Location = new System.Drawing.Point(473, 202);
            this.qrcode_picbox_url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qrcode_picbox_url.Name = "qrcode_picbox_url";
            this.qrcode_picbox_url.Size = new System.Drawing.Size(587, 477);
            this.qrcode_picbox_url.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.qrcode_picbox_url.TabIndex = 0;
            this.qrcode_picbox_url.TabStop = false;
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.size_label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.size_label.Location = new System.Drawing.Point(479, 135);
            this.size_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(86, 29);
            this.size_label.TabIndex = 2;
            this.size_label.Text = "Size：";
            // 
            // three_hundred_px_btn
            // 
            this.three_hundred_px_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three_hundred_px_btn.Location = new System.Drawing.Point(767, 191);
            this.three_hundred_px_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.three_hundred_px_btn.Name = "three_hundred_px_btn";
            this.three_hundred_px_btn.Size = new System.Drawing.Size(89, 51);
            this.three_hundred_px_btn.TabIndex = 6;
            this.three_hundred_px_btn.Text = "300px";
            this.three_hundred_px_btn.UseVisualStyleBackColor = true;
            this.three_hundred_px_btn.Click += new System.EventHandler(this.three_hundred_px_btn_Click);
            // 
            // two_hundred_px_btn
            // 
            this.two_hundred_px_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_hundred_px_btn.Location = new System.Drawing.Point(669, 191);
            this.two_hundred_px_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.two_hundred_px_btn.Name = "two_hundred_px_btn";
            this.two_hundred_px_btn.Size = new System.Drawing.Size(89, 51);
            this.two_hundred_px_btn.TabIndex = 7;
            this.two_hundred_px_btn.Text = "200px";
            this.two_hundred_px_btn.UseVisualStyleBackColor = true;
            this.two_hundred_px_btn.Click += new System.EventHandler(this.two_hundred_px_btn_Click);
            // 
            // one_hundred_px_btn
            // 
            this.one_hundred_px_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_hundred_px_btn.Location = new System.Drawing.Point(563, 191);
            this.one_hundred_px_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.one_hundred_px_btn.Name = "one_hundred_px_btn";
            this.one_hundred_px_btn.Size = new System.Drawing.Size(99, 51);
            this.one_hundred_px_btn.TabIndex = 8;
            this.one_hundred_px_btn.Text = "100px";
            this.one_hundred_px_btn.UseVisualStyleBackColor = true;
            this.one_hundred_px_btn.Click += new System.EventHandler(this.one_hundred_px_btn_Click);
            // 
            // custom_label
            // 
            this.custom_label.AutoSize = true;
            this.custom_label.BackColor = System.Drawing.Color.White;
            this.custom_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.custom_label.Location = new System.Drawing.Point(853, 108);
            this.custom_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.custom_label.Name = "custom_label";
            this.custom_label.Size = new System.Drawing.Size(86, 22);
            this.custom_label.TabIndex = 9;
            this.custom_label.Text = "custom:";
            // 
            // custom_numberic_text
            // 
            this.custom_numberic_text.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_numberic_text.Location = new System.Drawing.Point(859, 151);
            this.custom_numberic_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.custom_numberic_text.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.custom_numberic_text.Name = "custom_numberic_text";
            this.custom_numberic_text.Size = new System.Drawing.Size(160, 29);
            this.custom_numberic_text.TabIndex = 10;
            // 
            // px_label
            // 
            this.px_label.AutoSize = true;
            this.px_label.BackColor = System.Drawing.Color.White;
            this.px_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.px_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.px_label.Location = new System.Drawing.Point(955, 154);
            this.px_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.px_label.Name = "px_label";
            this.px_label.Size = new System.Drawing.Size(30, 22);
            this.px_label.TabIndex = 11;
            this.px_label.Text = "px";
            // 
            // save_as_label
            // 
            this.save_as_label.AutoSize = true;
            this.save_as_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_as_label.ForeColor = System.Drawing.Color.Black;
            this.save_as_label.Location = new System.Drawing.Point(4, 21);
            this.save_as_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.save_as_label.Name = "save_as_label";
            this.save_as_label.Size = new System.Drawing.Size(114, 24);
            this.save_as_label.TabIndex = 12;
            this.save_as_label.Text = "Save as：";
            // 
            // SavingFiles_panel
            // 
            this.SavingFiles_panel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SavingFiles_panel.Controls.Add(this.label7);
            this.SavingFiles_panel.Controls.Add(this.save_svgFile_linkLabel);
            this.SavingFiles_panel.Controls.Add(this.label6);
            this.SavingFiles_panel.Controls.Add(this.label5);
            this.SavingFiles_panel.Controls.Add(this.save_pngFile_linkLabel);
            this.SavingFiles_panel.Controls.Add(this.save_gifFile_linkLabel);
            this.SavingFiles_panel.Controls.Add(this.save_jpgFile_linkLabel);
            this.SavingFiles_panel.Controls.Add(this.save_as_label);
            this.SavingFiles_panel.Location = new System.Drawing.Point(479, 749);
            this.SavingFiles_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SavingFiles_panel.Name = "SavingFiles_panel";
            this.SavingFiles_panel.Size = new System.Drawing.Size(588, 68);
            this.SavingFiles_panel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(423, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "|";
            // 
            // save_svgFile_linkLabel
            // 
            this.save_svgFile_linkLabel.AutoSize = true;
            this.save_svgFile_linkLabel.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_svgFile_linkLabel.LinkColor = System.Drawing.Color.MidnightBlue;
            this.save_svgFile_linkLabel.Location = new System.Drawing.Point(440, 12);
            this.save_svgFile_linkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.save_svgFile_linkLabel.Name = "save_svgFile_linkLabel";
            this.save_svgFile_linkLabel.Size = new System.Drawing.Size(70, 33);
            this.save_svgFile_linkLabel.TabIndex = 19;
            this.save_svgFile_linkLabel.TabStop = true;
            this.save_svgFile_linkLabel.Text = "SVG";
            this.save_svgFile_linkLabel.Click += new System.EventHandler(this.save_svgFile_linkLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(335, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(229, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "|";
            // 
            // save_pngFile_linkLabel
            // 
            this.save_pngFile_linkLabel.AutoSize = true;
            this.save_pngFile_linkLabel.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_pngFile_linkLabel.LinkColor = System.Drawing.Color.MidnightBlue;
            this.save_pngFile_linkLabel.Location = new System.Drawing.Point(141, 12);
            this.save_pngFile_linkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.save_pngFile_linkLabel.Name = "save_pngFile_linkLabel";
            this.save_pngFile_linkLabel.Size = new System.Drawing.Size(72, 33);
            this.save_pngFile_linkLabel.TabIndex = 16;
            this.save_pngFile_linkLabel.TabStop = true;
            this.save_pngFile_linkLabel.Text = "PNG";
            this.save_pngFile_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.save_pngFile_linkLabel_LinkClicked);
            this.save_pngFile_linkLabel.Click += new System.EventHandler(this.save_pngFile_linkLabel_Click);
            // 
            // save_gifFile_linkLabel
            // 
            this.save_gifFile_linkLabel.AutoSize = true;
            this.save_gifFile_linkLabel.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_gifFile_linkLabel.LinkColor = System.Drawing.Color.MidnightBlue;
            this.save_gifFile_linkLabel.Location = new System.Drawing.Point(352, 12);
            this.save_gifFile_linkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.save_gifFile_linkLabel.Name = "save_gifFile_linkLabel";
            this.save_gifFile_linkLabel.Size = new System.Drawing.Size(60, 33);
            this.save_gifFile_linkLabel.TabIndex = 15;
            this.save_gifFile_linkLabel.TabStop = true;
            this.save_gifFile_linkLabel.Text = "GIF";
            this.save_gifFile_linkLabel.Click += new System.EventHandler(this.save_gifFile_linkLabel_Click);
            // 
            // save_jpgFile_linkLabel
            // 
            this.save_jpgFile_linkLabel.AutoSize = true;
            this.save_jpgFile_linkLabel.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_jpgFile_linkLabel.LinkColor = System.Drawing.Color.MidnightBlue;
            this.save_jpgFile_linkLabel.Location = new System.Drawing.Point(252, 11);
            this.save_jpgFile_linkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.save_jpgFile_linkLabel.Name = "save_jpgFile_linkLabel";
            this.save_jpgFile_linkLabel.Size = new System.Drawing.Size(68, 33);
            this.save_jpgFile_linkLabel.TabIndex = 14;
            this.save_jpgFile_linkLabel.TabStop = true;
            this.save_jpgFile_linkLabel.Text = "JPG";
            this.save_jpgFile_linkLabel.Click += new System.EventHandler(this.save_jpgFile_linkLabel_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TextTabPage);
            this.TabControl.Controls.Add(this.URL_TabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1109, 858);
            this.TabControl.Style = MetroFramework.MetroColorStyle.Green;
            this.TabControl.TabIndex = 15;
            this.TabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabControl.UseSelectable = true;
            // 
            // TextTabPage
            // 
            this.TextTabPage.Controls.Add(this.OK_button_text);
            this.TextTabPage.Controls.Add(this.px_label);
            this.TextTabPage.Controls.Add(this.custom_numberic_text);
            this.TextTabPage.Controls.Add(this.custom_label);
            this.TextTabPage.Controls.Add(this.generate_text_btn);
            this.TextTabPage.Controls.Add(this.enterText_textbox);
            this.TextTabPage.Controls.Add(this.label8);
            this.TextTabPage.Controls.Add(this.panel1);
            this.TextTabPage.Controls.Add(this.panel3);
            this.TextTabPage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTabPage.HorizontalScrollbarBarColor = true;
            this.TextTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.TextTabPage.HorizontalScrollbarSize = 12;
            this.TextTabPage.Location = new System.Drawing.Point(4, 38);
            this.TextTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextTabPage.Name = "TextTabPage";
            this.TextTabPage.Size = new System.Drawing.Size(1101, 816);
            this.TextTabPage.Style = MetroFramework.MetroColorStyle.Silver;
            this.TextTabPage.TabIndex = 0;
            this.TextTabPage.Text = "Text";
            this.TextTabPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextTabPage.VerticalScrollbarBarColor = true;
            this.TextTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.TextTabPage.VerticalScrollbarSize = 13;
            // 
            // OK_button_text
            // 
            this.OK_button_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_button_text.Location = new System.Drawing.Point(1027, 148);
            this.OK_button_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OK_button_text.Name = "OK_button_text";
            this.OK_button_text.Size = new System.Drawing.Size(56, 44);
            this.OK_button_text.TabIndex = 16;
            this.OK_button_text.Text = "OK";
            this.OK_button_text.UseVisualStyleBackColor = true;
            this.OK_button_text.Click += new System.EventHandler(this.OK_button_text_Click);
            // 
            // generate_text_btn
            // 
            this.generate_text_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_text_btn.Location = new System.Drawing.Point(17, 391);
            this.generate_text_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generate_text_btn.Name = "generate_text_btn";
            this.generate_text_btn.Size = new System.Drawing.Size(125, 51);
            this.generate_text_btn.TabIndex = 16;
            this.generate_text_btn.Text = "Generate";
            this.generate_text_btn.UseVisualStyleBackColor = true;
            this.generate_text_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // enterText_textbox
            // 
            // 
            // 
            // 
            this.enterText_textbox.CustomButton.Image = null;
            this.enterText_textbox.CustomButton.Location = new System.Drawing.Point(560, 1);
            this.enterText_textbox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterText_textbox.CustomButton.Name = "";
            this.enterText_textbox.CustomButton.Size = new System.Drawing.Size(36, 34);
            this.enterText_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.enterText_textbox.CustomButton.TabIndex = 1;
            this.enterText_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.enterText_textbox.CustomButton.UseSelectable = true;
            this.enterText_textbox.CustomButton.Visible = false;
            this.enterText_textbox.Lines = new string[0];
            this.enterText_textbox.Location = new System.Drawing.Point(17, 355);
            this.enterText_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterText_textbox.MaxLength = 32767;
            this.enterText_textbox.Name = "enterText_textbox";
            this.enterText_textbox.PasswordChar = '\0';
            this.enterText_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.enterText_textbox.SelectedText = "";
            this.enterText_textbox.SelectionLength = 0;
            this.enterText_textbox.SelectionStart = 0;
            this.enterText_textbox.ShortcutsEnabled = true;
            this.enterText_textbox.Size = new System.Drawing.Size(448, 29);
            this.enterText_textbox.TabIndex = 17;
            this.enterText_textbox.UseSelectable = true;
            this.enterText_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.enterText_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enter the Text：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 816);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.qr_code_picbox_text);
            this.panel3.Controls.Add(this.warning_label_text);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(472, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 816);
            this.panel3.TabIndex = 21;
            // 
            // qr_code_picbox_text
            // 
            this.qr_code_picbox_text.BackColor = System.Drawing.Color.White;
            this.qr_code_picbox_text.Location = new System.Drawing.Point(4, 202);
            this.qr_code_picbox_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qr_code_picbox_text.Name = "qr_code_picbox_text";
            this.qr_code_picbox_text.Size = new System.Drawing.Size(609, 491);
            this.qr_code_picbox_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.qr_code_picbox_text.TabIndex = 27;
            this.qr_code_picbox_text.TabStop = false;
            // 
            // warning_label_text
            // 
            this.warning_label_text.AutoSize = true;
            this.warning_label_text.BackColor = System.Drawing.Color.Transparent;
            this.warning_label_text.Dock = System.Windows.Forms.DockStyle.Right;
            this.warning_label_text.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_label_text.ForeColor = System.Drawing.Color.Firebrick;
            this.warning_label_text.Location = new System.Drawing.Point(629, 0);
            this.warning_label_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning_label_text.Name = "warning_label_text";
            this.warning_label_text.Size = new System.Drawing.Size(0, 23);
            this.warning_label_text.TabIndex = 25;
            // 
            // URL_TabPage
            // 
            this.URL_TabPage.Controls.Add(this.OK_button_url);
            this.URL_TabPage.Controls.Add(this.label1);
            this.URL_TabPage.Controls.Add(this.custom_numberic_url);
            this.URL_TabPage.Controls.Add(this.label2);
            this.URL_TabPage.Controls.Add(this.generate_url_btn);
            this.URL_TabPage.Controls.Add(this.enter_url_textbox);
            this.URL_TabPage.Controls.Add(this.label9);
            this.URL_TabPage.Controls.Add(this.qrcode_picbox_url);
            this.URL_TabPage.Controls.Add(this.panel4);
            this.URL_TabPage.Controls.Add(this.panel6);
            this.URL_TabPage.HorizontalScrollbarBarColor = true;
            this.URL_TabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.URL_TabPage.HorizontalScrollbarSize = 12;
            this.URL_TabPage.Location = new System.Drawing.Point(4, 38);
            this.URL_TabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.URL_TabPage.Name = "URL_TabPage";
            this.URL_TabPage.Size = new System.Drawing.Size(1101, 816);
            this.URL_TabPage.TabIndex = 1;
            this.URL_TabPage.Text = "URL";
            this.URL_TabPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.URL_TabPage.VerticalScrollbarBarColor = true;
            this.URL_TabPage.VerticalScrollbarHighlightOnWheel = false;
            this.URL_TabPage.VerticalScrollbarSize = 13;
            // 
            // OK_button_url
            // 
            this.OK_button_url.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_button_url.Location = new System.Drawing.Point(1027, 148);
            this.OK_button_url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OK_button_url.Name = "OK_button_url";
            this.OK_button_url.Size = new System.Drawing.Size(56, 44);
            this.OK_button_url.TabIndex = 23;
            this.OK_button_url.Text = "OK";
            this.OK_button_url.UseVisualStyleBackColor = true;
            this.OK_button_url.Click += new System.EventHandler(this.ok_url_btn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(955, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "px";
            // 
            // custom_numberic_url
            // 
            this.custom_numberic_url.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_numberic_url.Location = new System.Drawing.Point(859, 151);
            this.custom_numberic_url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.custom_numberic_url.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.custom_numberic_url.Name = "custom_numberic_url";
            this.custom_numberic_url.Size = new System.Drawing.Size(160, 29);
            this.custom_numberic_url.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(853, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "custom:";
            // 
            // generate_url_btn
            // 
            this.generate_url_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_url_btn.Location = new System.Drawing.Point(17, 391);
            this.generate_url_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generate_url_btn.Name = "generate_url_btn";
            this.generate_url_btn.Size = new System.Drawing.Size(125, 51);
            this.generate_url_btn.TabIndex = 19;
            this.generate_url_btn.Text = "Generate";
            this.generate_url_btn.UseVisualStyleBackColor = true;
            this.generate_url_btn.Click += new System.EventHandler(this.generate_url_btn_Click);
            // 
            // enter_url_textbox
            // 
            // 
            // 
            // 
            this.enter_url_textbox.CustomButton.Image = null;
            this.enter_url_textbox.CustomButton.Location = new System.Drawing.Point(560, 1);
            this.enter_url_textbox.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.enter_url_textbox.CustomButton.Name = "";
            this.enter_url_textbox.CustomButton.Size = new System.Drawing.Size(36, 34);
            this.enter_url_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.enter_url_textbox.CustomButton.TabIndex = 1;
            this.enter_url_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.enter_url_textbox.CustomButton.UseSelectable = true;
            this.enter_url_textbox.CustomButton.Visible = false;
            this.enter_url_textbox.Lines = new string[0];
            this.enter_url_textbox.Location = new System.Drawing.Point(17, 355);
            this.enter_url_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enter_url_textbox.MaxLength = 32767;
            this.enter_url_textbox.Name = "enter_url_textbox";
            this.enter_url_textbox.PasswordChar = '\0';
            this.enter_url_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.enter_url_textbox.SelectedText = "";
            this.enter_url_textbox.SelectionLength = 0;
            this.enter_url_textbox.SelectionStart = 0;
            this.enter_url_textbox.ShortcutsEnabled = true;
            this.enter_url_textbox.Size = new System.Drawing.Size(448, 29);
            this.enter_url_textbox.TabIndex = 18;
            this.enter_url_textbox.UseSelectable = true;
            this.enter_url_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.enter_url_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(11, 302);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Enter the URL：";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 816);
            this.panel4.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.warning_label_url);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1101, 816);
            this.panel6.TabIndex = 27;
            // 
            // warning_label_url
            // 
            this.warning_label_url.AutoSize = true;
            this.warning_label_url.BackColor = System.Drawing.Color.Transparent;
            this.warning_label_url.Dock = System.Windows.Forms.DockStyle.Right;
            this.warning_label_url.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_label_url.ForeColor = System.Drawing.Color.DarkRed;
            this.warning_label_url.Location = new System.Drawing.Point(1101, 0);
            this.warning_label_url.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning_label_url.Name = "warning_label_url";
            this.warning_label_url.Size = new System.Drawing.Size(0, 23);
            this.warning_label_url.TabIndex = 24;
            // 
            // fifty_px_btn
            // 
            this.fifty_px_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifty_px_btn.Location = new System.Drawing.Point(479, 191);
            this.fifty_px_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fifty_px_btn.Name = "fifty_px_btn";
            this.fifty_px_btn.Size = new System.Drawing.Size(76, 51);
            this.fifty_px_btn.TabIndex = 3;
            this.fifty_px_btn.Text = "50px";
            this.fifty_px_btn.UseVisualStyleBackColor = true;
            this.fifty_px_btn.Click += new System.EventHandler(this.fifty_px_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1109, 858);
            this.Controls.Add(this.one_hundred_px_btn);
            this.Controls.Add(this.two_hundred_px_btn);
            this.Controls.Add(this.three_hundred_px_btn);
            this.Controls.Add(this.fifty_px_btn);
            this.Controls.Add(this.size_label);
            this.Controls.Add(this.SavingFiles_panel);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1125, 897);
            this.MinimumSize = new System.Drawing.Size(1125, 897);
            this.Name = "Form1";
            this.Text = "QR Code generator";
            ((System.ComponentModel.ISupportInitialize)(this.qrcode_picbox_url)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custom_numberic_text)).EndInit();
            this.SavingFiles_panel.ResumeLayout(false);
            this.SavingFiles_panel.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.TextTabPage.ResumeLayout(false);
            this.TextTabPage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qr_code_picbox_text)).EndInit();
            this.URL_TabPage.ResumeLayout(false);
            this.URL_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custom_numberic_url)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qrcode_picbox_url;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Button three_hundred_px_btn;
        private System.Windows.Forms.Button two_hundred_px_btn;
        private System.Windows.Forms.Button one_hundred_px_btn;
        private System.Windows.Forms.Label custom_label;
        private System.Windows.Forms.NumericUpDown custom_numberic_text;
        private System.Windows.Forms.Label px_label;
        private System.Windows.Forms.Label save_as_label;
        private System.Windows.Forms.Panel SavingFiles_panel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel save_svgFile_linkLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel save_pngFile_linkLabel;
        private System.Windows.Forms.LinkLabel save_gifFile_linkLabel;
        private System.Windows.Forms.LinkLabel save_jpgFile_linkLabel;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage TextTabPage;
        private MetroFramework.Controls.MetroTabPage URL_TabPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button generate_text_btn;
        private MetroFramework.Controls.MetroTextBox enterText_textbox;
        private MetroFramework.Controls.MetroTextBox enter_url_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button generate_url_btn;
        private System.Windows.Forms.Button OK_button_text;
        private System.Windows.Forms.Button OK_button_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown custom_numberic_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label warning_label_url;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button fifty_px_btn;
        private System.Windows.Forms.Label warning_label_text;
        private System.Windows.Forms.PictureBox qr_code_picbox_text;
    }
}



namespace Logo_Quiz
{
    partial class GameBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.label_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_name = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel_rb = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_answer = new System.Windows.Forms.FlowLayoutPanel();
            this.EditedLogos = new System.Windows.Forms.ImageList(this.components);
            this.panel_result = new System.Windows.Forms.Panel();
            this.pictureBox_checkstat = new System.Windows.Forms.PictureBox();
            this.button_check = new System.Windows.Forms.Button();
            this.button_skip = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_prog = new System.Windows.Forms.Label();
            this.OriginalLogos = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_checkstat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.Color.Lime;
            this.label_timer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_timer.Location = new System.Drawing.Point(499, 15);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(0, 25);
            this.label_timer.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(13, 15);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 19);
            this.label_name.TabIndex = 4;
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.Color.White;
            this.label_score.Location = new System.Drawing.Point(901, 15);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(0, 19);
            this.label_score.TabIndex = 5;
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Location = new System.Drawing.Point(375, 59);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(250, 250);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 46;
            this.pictureBox_logo.TabStop = false;
            // 
            // flowLayoutPanel_rb
            // 
            this.flowLayoutPanel_rb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel_rb.AutoSize = true;
            this.flowLayoutPanel_rb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_rb.Location = new System.Drawing.Point(23, 529);
            this.flowLayoutPanel_rb.Name = "flowLayoutPanel_rb";
            this.flowLayoutPanel_rb.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel_rb.TabIndex = 47;
            this.flowLayoutPanel_rb.AutoSizeChanged += new System.EventHandler(this.Panel_updater);
            this.flowLayoutPanel_rb.SizeChanged += new System.EventHandler(this.Panel_updater);
            // 
            // flowLayoutPanel_answer
            // 
            this.flowLayoutPanel_answer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel_answer.AutoSize = true;
            this.flowLayoutPanel_answer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_answer.Location = new System.Drawing.Point(105, 388);
            this.flowLayoutPanel_answer.Name = "flowLayoutPanel_answer";
            this.flowLayoutPanel_answer.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel_answer.TabIndex = 47;
            this.flowLayoutPanel_answer.AutoSizeChanged += new System.EventHandler(this.Panel_updater);
            this.flowLayoutPanel_answer.SizeChanged += new System.EventHandler(this.Panel_updater);
            // 
            // EditedLogos
            // 
            this.EditedLogos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("EditedLogos.ImageStream")));
            this.EditedLogos.TransparentColor = System.Drawing.Color.Transparent;
            this.EditedLogos.Images.SetKeyName(0, "adidas.png");
            this.EditedLogos.Images.SetKeyName(1, "adobe.png");
            this.EditedLogos.Images.SetKeyName(2, "aliexpress.png");
            this.EditedLogos.Images.SetKeyName(3, "amazon.png");
            this.EditedLogos.Images.SetKeyName(4, "amd.png");
            this.EditedLogos.Images.SetKeyName(5, "amg.png");
            this.EditedLogos.Images.SetKeyName(6, "android.png");
            this.EditedLogos.Images.SetKeyName(7, "apple.png");
            this.EditedLogos.Images.SetKeyName(8, "ariel.png");
            this.EditedLogos.Images.SetKeyName(9, "asus.png");
            this.EditedLogos.Images.SetKeyName(10, "audi.png");
            this.EditedLogos.Images.SetKeyName(11, "avast.png");
            this.EditedLogos.Images.SetKeyName(12, "avg.png");
            this.EditedLogos.Images.SetKeyName(13, "axa.png");
            this.EditedLogos.Images.SetKeyName(14, "beko.png");
            this.EditedLogos.Images.SetKeyName(15, "bentley.png");
            this.EditedLogos.Images.SetKeyName(16, "bic.png");
            this.EditedLogos.Images.SetKeyName(17, "bitcoin.png");
            this.EditedLogos.Images.SetKeyName(18, "bmw.png");
            this.EditedLogos.Images.SetKeyName(19, "boomerang.png");
            this.EditedLogos.Images.SetKeyName(20, "bosh.png");
            this.EditedLogos.Images.SetKeyName(21, "bugatti.png");
            this.EditedLogos.Images.SetKeyName(22, "cadillac.png");
            this.EditedLogos.Images.SetKeyName(23, "candy.png");
            this.EditedLogos.Images.SetKeyName(24, "canon.png");
            this.EditedLogos.Images.SetKeyName(25, "capcom.png");
            this.EditedLogos.Images.SetKeyName(26, "carrefour.png");
            this.EditedLogos.Images.SetKeyName(27, "casio.png");
            this.EditedLogos.Images.SetKeyName(28, "cheetos.png");
            this.EditedLogos.Images.SetKeyName(29, "chevrolet.png");
            this.EditedLogos.Images.SetKeyName(30, "cisco.png");
            this.EditedLogos.Images.SetKeyName(31, "citroen.png");
            this.EditedLogos.Images.SetKeyName(32, "cocacola.png");
            this.EditedLogos.Images.SetKeyName(33, "colgate.png");
            this.EditedLogos.Images.SetKeyName(34, "compaq.png");
            this.EditedLogos.Images.SetKeyName(35, "corvette.png");
            this.EditedLogos.Images.SetKeyName(36, "dell.png");
            this.EditedLogos.Images.SetKeyName(37, "dodge.png");
            this.EditedLogos.Images.SetKeyName(38, "dolby.png");
            this.EditedLogos.Images.SetKeyName(39, "doritos.png");
            this.EditedLogos.Images.SetKeyName(40, "dove.png");
            this.EditedLogos.Images.SetKeyName(41, "dreamworks.png");
            this.EditedLogos.Images.SetKeyName(42, "dropbox.png");
            this.EditedLogos.Images.SetKeyName(43, "dvd.png");
            this.EditedLogos.Images.SetKeyName(44, "ebay.png");
            this.EditedLogos.Images.SetKeyName(45, "epson.png");
            this.EditedLogos.Images.SetKeyName(46, "facebook.png");
            this.EditedLogos.Images.SetKeyName(47, "fanta.png");
            this.EditedLogos.Images.SetKeyName(48, "fiat.png");
            this.EditedLogos.Images.SetKeyName(49, "fila.png");
            this.EditedLogos.Images.SetKeyName(50, "firefox.png");
            this.EditedLogos.Images.SetKeyName(51, "ford.png");
            this.EditedLogos.Images.SetKeyName(52, "gmail.png");
            this.EditedLogos.Images.SetKeyName(53, "google.png");
            this.EditedLogos.Images.SetKeyName(54, "gucci.png");
            this.EditedLogos.Images.SetKeyName(55, "honda.png");
            this.EditedLogos.Images.SetKeyName(56, "hp.png");
            this.EditedLogos.Images.SetKeyName(57, "huawei.png");
            this.EditedLogos.Images.SetKeyName(58, "hyundai.png");
            this.EditedLogos.Images.SetKeyName(59, "ikea.png");
            this.EditedLogos.Images.SetKeyName(60, "infiniti.png");
            this.EditedLogos.Images.SetKeyName(61, "instagram.png");
            this.EditedLogos.Images.SetKeyName(62, "intel.png");
            this.EditedLogos.Images.SetKeyName(63, "isuzu.png");
            this.EditedLogos.Images.SetKeyName(64, "iveco.png");
            this.EditedLogos.Images.SetKeyName(65, "jaguar.png");
            this.EditedLogos.Images.SetKeyName(66, "java.png");
            this.EditedLogos.Images.SetKeyName(67, "jeep.png");
            this.EditedLogos.Images.SetKeyName(68, "kfc.png");
            this.EditedLogos.Images.SetKeyName(69, "kia.png");
            this.EditedLogos.Images.SetKeyName(70, "kinder.png");
            this.EditedLogos.Images.SetKeyName(71, "kingston.png");
            this.EditedLogos.Images.SetKeyName(72, "kitkat.png");
            this.EditedLogos.Images.SetKeyName(73, "knorr.png");
            this.EditedLogos.Images.SetKeyName(74, "koenigsegg.png");
            this.EditedLogos.Images.SetKeyName(75, "konami.png");
            this.EditedLogos.Images.SetKeyName(76, "lacoste.png");
            this.EditedLogos.Images.SetKeyName(77, "lamborghini.png");
            this.EditedLogos.Images.SetKeyName(78, "lego.png");
            this.EditedLogos.Images.SetKeyName(79, "lenovo.png");
            this.EditedLogos.Images.SetKeyName(80, "lexus.png");
            this.EditedLogos.Images.SetKeyName(81, "lg.png");
            this.EditedLogos.Images.SetKeyName(82, "lidl.png");
            this.EditedLogos.Images.SetKeyName(83, "linkedin.png");
            this.EditedLogos.Images.SetKeyName(84, "linux.png");
            this.EditedLogos.Images.SetKeyName(85, "lion.png");
            this.EditedLogos.Images.SetKeyName(86, "lotus.png");
            this.EditedLogos.Images.SetKeyName(87, "marlboro.png");
            this.EditedLogos.Images.SetKeyName(88, "maybach.png");
            this.EditedLogos.Images.SetKeyName(89, "mazda.png");
            this.EditedLogos.Images.SetKeyName(90, "mcdonalds.png");
            this.EditedLogos.Images.SetKeyName(91, "mclaren.png");
            this.EditedLogos.Images.SetKeyName(92, "mentos.png");
            this.EditedLogos.Images.SetKeyName(93, "mercedes.png");
            this.EditedLogos.Images.SetKeyName(94, "messenger.png");
            this.EditedLogos.Images.SetKeyName(95, "microsoft.png");
            this.EditedLogos.Images.SetKeyName(96, "milka.png");
            this.EditedLogos.Images.SetKeyName(97, "mini.png");
            this.EditedLogos.Images.SetKeyName(98, "mitsubishi.png");
            this.EditedLogos.Images.SetKeyName(99, "mlb.png");
            this.EditedLogos.Images.SetKeyName(100, "mms.png");
            this.EditedLogos.Images.SetKeyName(101, "monopoly.png");
            this.EditedLogos.Images.SetKeyName(102, "motorola.png");
            this.EditedLogos.Images.SetKeyName(103, "movistar.png");
            this.EditedLogos.Images.SetKeyName(104, "msn.png");
            this.EditedLogos.Images.SetKeyName(105, "mustang.png");
            this.EditedLogos.Images.SetKeyName(106, "nasa.png");
            this.EditedLogos.Images.SetKeyName(107, "nba.png");
            this.EditedLogos.Images.SetKeyName(108, "nerf.png");
            this.EditedLogos.Images.SetKeyName(109, "nescafe.png");
            this.EditedLogos.Images.SetKeyName(110, "nesquik.png");
            this.EditedLogos.Images.SetKeyName(111, "nestle.png");
            this.EditedLogos.Images.SetKeyName(112, "netflix.png");
            this.EditedLogos.Images.SetKeyName(113, "nike.png");
            this.EditedLogos.Images.SetKeyName(114, "nintendo.png");
            this.EditedLogos.Images.SetKeyName(115, "nissan.png");
            this.EditedLogos.Images.SetKeyName(116, "nivea.png");
            this.EditedLogos.Images.SetKeyName(117, "nokia.png");
            this.EditedLogos.Images.SetKeyName(118, "nutella.png");
            this.EditedLogos.Images.SetKeyName(119, "nvidia.png");
            this.EditedLogos.Images.SetKeyName(120, "office.png");
            this.EditedLogos.Images.SetKeyName(121, "opel.png");
            this.EditedLogos.Images.SetKeyName(122, "opera.png");
            this.EditedLogos.Images.SetKeyName(123, "orange.png");
            this.EditedLogos.Images.SetKeyName(124, "oreo.png");
            this.EditedLogos.Images.SetKeyName(125, "pagani.png");
            this.EditedLogos.Images.SetKeyName(126, "paypal.png");
            this.EditedLogos.Images.SetKeyName(127, "pepsi.png");
            this.EditedLogos.Images.SetKeyName(128, "peugeot.png");
            this.EditedLogos.Images.SetKeyName(129, "photoshop.png");
            this.EditedLogos.Images.SetKeyName(130, "pizzahut.png");
            this.EditedLogos.Images.SetKeyName(131, "playstation.png");
            this.EditedLogos.Images.SetKeyName(132, "pontiac.png");
            this.EditedLogos.Images.SetKeyName(133, "porsche.png");
            this.EditedLogos.Images.SetKeyName(134, "pringles.png");
            this.EditedLogos.Images.SetKeyName(135, "psp.png");
            this.EditedLogos.Images.SetKeyName(136, "puma.png");
            this.EditedLogos.Images.SetKeyName(137, "ram.png");
            this.EditedLogos.Images.SetKeyName(138, "redbull.png");
            this.EditedLogos.Images.SetKeyName(139, "reebok.png");
            this.EditedLogos.Images.SetKeyName(140, "renault.png");
            this.EditedLogos.Images.SetKeyName(141, "rolex.png");
            this.EditedLogos.Images.SetKeyName(142, "rovio.png");
            this.EditedLogos.Images.SetKeyName(143, "samsung.png");
            this.EditedLogos.Images.SetKeyName(144, "sandisk.png");
            this.EditedLogos.Images.SetKeyName(145, "seat.png");
            this.EditedLogos.Images.SetKeyName(146, "sega.png");
            this.EditedLogos.Images.SetKeyName(147, "shazam.png");
            this.EditedLogos.Images.SetKeyName(148, "shell.png");
            this.EditedLogos.Images.SetKeyName(149, "siemens.png");
            this.EditedLogos.Images.SetKeyName(150, "skittles.png");
            this.EditedLogos.Images.SetKeyName(151, "skoda.png");
            this.EditedLogos.Images.SetKeyName(152, "skype.png");
            this.EditedLogos.Images.SetKeyName(153, "snapchat.png");
            this.EditedLogos.Images.SetKeyName(154, "snickers.png");
            this.EditedLogos.Images.SetKeyName(155, "sony.png");
            this.EditedLogos.Images.SetKeyName(156, "soundcloud.png");
            this.EditedLogos.Images.SetKeyName(157, "spotify.png");
            this.EditedLogos.Images.SetKeyName(158, "sprite.png");
            this.EditedLogos.Images.SetKeyName(159, "starbucks.png");
            this.EditedLogos.Images.SetKeyName(160, "steam.png");
            this.EditedLogos.Images.SetKeyName(161, "subaru.png");
            this.EditedLogos.Images.SetKeyName(162, "subway.png");
            this.EditedLogos.Images.SetKeyName(163, "suzuki.png");
            this.EditedLogos.Images.SetKeyName(164, "tesla.png");
            this.EditedLogos.Images.SetKeyName(165, "tiktok.png");
            this.EditedLogos.Images.SetKeyName(166, "toshiba.png");
            this.EditedLogos.Images.SetKeyName(167, "total.png");
            this.EditedLogos.Images.SetKeyName(168, "toyota.png");
            this.EditedLogos.Images.SetKeyName(169, "twitch.png");
            this.EditedLogos.Images.SetKeyName(170, "twitter.png");
            this.EditedLogos.Images.SetKeyName(171, "ubisoft.png");
            this.EditedLogos.Images.SetKeyName(172, "ubuntu.png");
            this.EditedLogos.Images.SetKeyName(173, "umbro.png");
            this.EditedLogos.Images.SetKeyName(174, "unicef.png");
            this.EditedLogos.Images.SetKeyName(175, "vaio.png");
            this.EditedLogos.Images.SetKeyName(176, "vevo.png");
            this.EditedLogos.Images.SetKeyName(177, "viber.png");
            this.EditedLogos.Images.SetKeyName(178, "visa.png");
            this.EditedLogos.Images.SetKeyName(179, "vodafone.png");
            this.EditedLogos.Images.SetKeyName(180, "volkswagen.png");
            this.EditedLogos.Images.SetKeyName(181, "volvo.png");
            this.EditedLogos.Images.SetKeyName(182, "waze.png");
            this.EditedLogos.Images.SetKeyName(183, "whirlpool.png");
            this.EditedLogos.Images.SetKeyName(184, "wikipedia.png");
            this.EditedLogos.Images.SetKeyName(185, "windows.png");
            this.EditedLogos.Images.SetKeyName(186, "wish.png");
            this.EditedLogos.Images.SetKeyName(187, "xbox.png");
            this.EditedLogos.Images.SetKeyName(188, "yahoo.png");
            this.EditedLogos.Images.SetKeyName(189, "yamaha.png");
            // 
            // panel_result
            // 
            this.panel_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_result.Location = new System.Drawing.Point(0, 0);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(1000, 660);
            this.panel_result.TabIndex = 48;
            // 
            // pictureBox_checkstat
            // 
            this.pictureBox_checkstat.Location = new System.Drawing.Point(470, 394);
            this.pictureBox_checkstat.Name = "pictureBox_checkstat";
            this.pictureBox_checkstat.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_checkstat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_checkstat.TabIndex = 52;
            this.pictureBox_checkstat.TabStop = false;
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.button_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_check.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.ForeColor = System.Drawing.Color.Black;
            this.button_check.Image = ((System.Drawing.Image)(resources.GetObject("button_check.Image")));
            this.button_check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_check.Location = new System.Drawing.Point(421, 576);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(157, 55);
            this.button_check.TabIndex = 49;
            this.button_check.Text = "Check";
            this.button_check.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_skip
            // 
            this.button_skip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.button_skip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_skip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.button_skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_skip.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_skip.ForeColor = System.Drawing.Color.Black;
            this.button_skip.Image = ((System.Drawing.Image)(resources.GetObject("button_skip.Image")));
            this.button_skip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_skip.Location = new System.Drawing.Point(276, 576);
            this.button_skip.Name = "button_skip";
            this.button_skip.Size = new System.Drawing.Size(132, 55);
            this.button_skip.TabIndex = 50;
            this.button_skip.Text = "Skip";
            this.button_skip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_skip.UseVisualStyleBackColor = false;
            this.button_skip.Click += new System.EventHandler(this.button_skip_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.button_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_next.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.Color.Black;
            this.button_next.Image = ((System.Drawing.Image)(resources.GetObject("button_next.Image")));
            this.button_next.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_next.Location = new System.Drawing.Point(593, 576);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(138, 55);
            this.button_next.TabIndex = 51;
            this.button_next.Text = "Next";
            this.button_next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label_prog
            // 
            this.label_prog.AutoSize = true;
            this.label_prog.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prog.ForeColor = System.Drawing.Color.White;
            this.label_prog.Location = new System.Drawing.Point(462, 532);
            this.label_prog.Name = "label_prog";
            this.label_prog.Size = new System.Drawing.Size(0, 32);
            this.label_prog.TabIndex = 5;
            this.label_prog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OriginalLogos
            // 
            this.OriginalLogos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("OriginalLogos.ImageStream")));
            this.OriginalLogos.TransparentColor = System.Drawing.Color.Transparent;
            this.OriginalLogos.Images.SetKeyName(0, "adidas.png");
            this.OriginalLogos.Images.SetKeyName(1, "adobe.png");
            this.OriginalLogos.Images.SetKeyName(2, "aliexpress.png");
            this.OriginalLogos.Images.SetKeyName(3, "amazon.png");
            this.OriginalLogos.Images.SetKeyName(4, "amd.png");
            this.OriginalLogos.Images.SetKeyName(5, "amg.png");
            this.OriginalLogos.Images.SetKeyName(6, "ariel.png");
            this.OriginalLogos.Images.SetKeyName(7, "asus.png");
            this.OriginalLogos.Images.SetKeyName(8, "audi.png");
            this.OriginalLogos.Images.SetKeyName(9, "avast.png");
            this.OriginalLogos.Images.SetKeyName(10, "avg.png");
            this.OriginalLogos.Images.SetKeyName(11, "axa.png");
            this.OriginalLogos.Images.SetKeyName(12, "beko.png");
            this.OriginalLogos.Images.SetKeyName(13, "bentley.png");
            this.OriginalLogos.Images.SetKeyName(14, "bic.png");
            this.OriginalLogos.Images.SetKeyName(15, "bitcoin.png");
            this.OriginalLogos.Images.SetKeyName(16, "bmw.png");
            this.OriginalLogos.Images.SetKeyName(17, "boomerang.png");
            this.OriginalLogos.Images.SetKeyName(18, "bosh.png");
            this.OriginalLogos.Images.SetKeyName(19, "bugatti.png");
            this.OriginalLogos.Images.SetKeyName(20, "cadillac.png");
            this.OriginalLogos.Images.SetKeyName(21, "candy.png");
            this.OriginalLogos.Images.SetKeyName(22, "canon.png");
            this.OriginalLogos.Images.SetKeyName(23, "capcom.png");
            this.OriginalLogos.Images.SetKeyName(24, "carrefour.png");
            this.OriginalLogos.Images.SetKeyName(25, "casio.png");
            this.OriginalLogos.Images.SetKeyName(26, "cheetos.png");
            this.OriginalLogos.Images.SetKeyName(27, "chevrolet.png");
            this.OriginalLogos.Images.SetKeyName(28, "cisco.png");
            this.OriginalLogos.Images.SetKeyName(29, "citroen.png");
            this.OriginalLogos.Images.SetKeyName(30, "cocacola.png");
            this.OriginalLogos.Images.SetKeyName(31, "colgate.png");
            this.OriginalLogos.Images.SetKeyName(32, "compaq.png");
            this.OriginalLogos.Images.SetKeyName(33, "corvette.png");
            this.OriginalLogos.Images.SetKeyName(34, "dell.png");
            this.OriginalLogos.Images.SetKeyName(35, "dodge.png");
            this.OriginalLogos.Images.SetKeyName(36, "dolby.png");
            this.OriginalLogos.Images.SetKeyName(37, "doritos.png");
            this.OriginalLogos.Images.SetKeyName(38, "dove.png");
            this.OriginalLogos.Images.SetKeyName(39, "dreamworks.png");
            this.OriginalLogos.Images.SetKeyName(40, "dropbox.png");
            this.OriginalLogos.Images.SetKeyName(41, "dvd.png");
            this.OriginalLogos.Images.SetKeyName(42, "ebay.png");
            this.OriginalLogos.Images.SetKeyName(43, "epson.png");
            this.OriginalLogos.Images.SetKeyName(44, "fanta.png");
            this.OriginalLogos.Images.SetKeyName(45, "fiat.png");
            this.OriginalLogos.Images.SetKeyName(46, "fila.png");
            this.OriginalLogos.Images.SetKeyName(47, "ford.png");
            this.OriginalLogos.Images.SetKeyName(48, "google.png");
            this.OriginalLogos.Images.SetKeyName(49, "gucci.png");
            this.OriginalLogos.Images.SetKeyName(50, "honda.png");
            this.OriginalLogos.Images.SetKeyName(51, "hp.png");
            this.OriginalLogos.Images.SetKeyName(52, "huawei.png");
            this.OriginalLogos.Images.SetKeyName(53, "hyundai.png");
            this.OriginalLogos.Images.SetKeyName(54, "ikea.png");
            this.OriginalLogos.Images.SetKeyName(55, "infiniti.png");
            this.OriginalLogos.Images.SetKeyName(56, "instagram.png");
            this.OriginalLogos.Images.SetKeyName(57, "intel.png");
            this.OriginalLogos.Images.SetKeyName(58, "isuzu.png");
            this.OriginalLogos.Images.SetKeyName(59, "iveco.png");
            this.OriginalLogos.Images.SetKeyName(60, "jaguar.png");
            this.OriginalLogos.Images.SetKeyName(61, "java.png");
            this.OriginalLogos.Images.SetKeyName(62, "jeep.png");
            this.OriginalLogos.Images.SetKeyName(63, "kfc.png");
            this.OriginalLogos.Images.SetKeyName(64, "kia.png");
            this.OriginalLogos.Images.SetKeyName(65, "kinder.png");
            this.OriginalLogos.Images.SetKeyName(66, "kingston.png");
            this.OriginalLogos.Images.SetKeyName(67, "kitkat.png");
            this.OriginalLogos.Images.SetKeyName(68, "knorr.png");
            this.OriginalLogos.Images.SetKeyName(69, "koenigsegg.png");
            this.OriginalLogos.Images.SetKeyName(70, "konami.png");
            this.OriginalLogos.Images.SetKeyName(71, "lacoste.png");
            this.OriginalLogos.Images.SetKeyName(72, "lamborghini.png");
            this.OriginalLogos.Images.SetKeyName(73, "lego.png");
            this.OriginalLogos.Images.SetKeyName(74, "lenovo.png");
            this.OriginalLogos.Images.SetKeyName(75, "lexus.png");
            this.OriginalLogos.Images.SetKeyName(76, "lg.png");
            this.OriginalLogos.Images.SetKeyName(77, "lidl.png");
            this.OriginalLogos.Images.SetKeyName(78, "linkedin.png");
            this.OriginalLogos.Images.SetKeyName(79, "lion.png");
            this.OriginalLogos.Images.SetKeyName(80, "lotus.png");
            this.OriginalLogos.Images.SetKeyName(81, "marlboro.png");
            this.OriginalLogos.Images.SetKeyName(82, "maybach.png");
            this.OriginalLogos.Images.SetKeyName(83, "mazda.png");
            this.OriginalLogos.Images.SetKeyName(84, "mclaren.png");
            this.OriginalLogos.Images.SetKeyName(85, "mentos.png");
            this.OriginalLogos.Images.SetKeyName(86, "mercedes.png");
            this.OriginalLogos.Images.SetKeyName(87, "microsoft.png");
            this.OriginalLogos.Images.SetKeyName(88, "milka.png");
            this.OriginalLogos.Images.SetKeyName(89, "mini.png");
            this.OriginalLogos.Images.SetKeyName(90, "mitsubishi.png");
            this.OriginalLogos.Images.SetKeyName(91, "mlb.png");
            this.OriginalLogos.Images.SetKeyName(92, "mms.png");
            this.OriginalLogos.Images.SetKeyName(93, "monopoly.png");
            this.OriginalLogos.Images.SetKeyName(94, "motorola.png");
            this.OriginalLogos.Images.SetKeyName(95, "movistar.png");
            this.OriginalLogos.Images.SetKeyName(96, "msn.png");
            this.OriginalLogos.Images.SetKeyName(97, "nasa.png");
            this.OriginalLogos.Images.SetKeyName(98, "nba.png");
            this.OriginalLogos.Images.SetKeyName(99, "nerf.png");
            this.OriginalLogos.Images.SetKeyName(100, "nescafe.png");
            this.OriginalLogos.Images.SetKeyName(101, "nesquik.png");
            this.OriginalLogos.Images.SetKeyName(102, "nestle.png");
            this.OriginalLogos.Images.SetKeyName(103, "netflix.png");
            this.OriginalLogos.Images.SetKeyName(104, "nintendo.png");
            this.OriginalLogos.Images.SetKeyName(105, "nissan.png");
            this.OriginalLogos.Images.SetKeyName(106, "nivea.png");
            this.OriginalLogos.Images.SetKeyName(107, "nokia.png");
            this.OriginalLogos.Images.SetKeyName(108, "nutella.png");
            this.OriginalLogos.Images.SetKeyName(109, "nvidia.png");
            this.OriginalLogos.Images.SetKeyName(110, "office.png");
            this.OriginalLogos.Images.SetKeyName(111, "opel.png");
            this.OriginalLogos.Images.SetKeyName(112, "orange.png");
            this.OriginalLogos.Images.SetKeyName(113, "oreo.png");
            this.OriginalLogos.Images.SetKeyName(114, "pagani.png");
            this.OriginalLogos.Images.SetKeyName(115, "paypal.png");
            this.OriginalLogos.Images.SetKeyName(116, "pepsi.png");
            this.OriginalLogos.Images.SetKeyName(117, "peugeot.png");
            this.OriginalLogos.Images.SetKeyName(118, "pizzahut.png");
            this.OriginalLogos.Images.SetKeyName(119, "pontiac.png");
            this.OriginalLogos.Images.SetKeyName(120, "porsche.png");
            this.OriginalLogos.Images.SetKeyName(121, "pringles.png");
            this.OriginalLogos.Images.SetKeyName(122, "psp.png");
            this.OriginalLogos.Images.SetKeyName(123, "puma.png");
            this.OriginalLogos.Images.SetKeyName(124, "ram.png");
            this.OriginalLogos.Images.SetKeyName(125, "redbull.png");
            this.OriginalLogos.Images.SetKeyName(126, "reebok.png");
            this.OriginalLogos.Images.SetKeyName(127, "renault.png");
            this.OriginalLogos.Images.SetKeyName(128, "rolex.png");
            this.OriginalLogos.Images.SetKeyName(129, "rovio.png");
            this.OriginalLogos.Images.SetKeyName(130, "samsung.png");
            this.OriginalLogos.Images.SetKeyName(131, "sandisk.png");
            this.OriginalLogos.Images.SetKeyName(132, "seat.png");
            this.OriginalLogos.Images.SetKeyName(133, "sega.png");
            this.OriginalLogos.Images.SetKeyName(134, "shazam.png");
            this.OriginalLogos.Images.SetKeyName(135, "siemens.png");
            this.OriginalLogos.Images.SetKeyName(136, "skittles.png");
            this.OriginalLogos.Images.SetKeyName(137, "skoda.png");
            this.OriginalLogos.Images.SetKeyName(138, "skype.png");
            this.OriginalLogos.Images.SetKeyName(139, "snickers.png");
            this.OriginalLogos.Images.SetKeyName(140, "sony.png");
            this.OriginalLogos.Images.SetKeyName(141, "soundcloud.png");
            this.OriginalLogos.Images.SetKeyName(142, "spotify.png");
            this.OriginalLogos.Images.SetKeyName(143, "sprite.png");
            this.OriginalLogos.Images.SetKeyName(144, "steam.png");
            this.OriginalLogos.Images.SetKeyName(145, "subaru.png");
            this.OriginalLogos.Images.SetKeyName(146, "subway.png");
            this.OriginalLogos.Images.SetKeyName(147, "suzuki.png");
            this.OriginalLogos.Images.SetKeyName(148, "tesla.png");
            this.OriginalLogos.Images.SetKeyName(149, "tiktok.png");
            this.OriginalLogos.Images.SetKeyName(150, "toshiba.png");
            this.OriginalLogos.Images.SetKeyName(151, "total.png");
            this.OriginalLogos.Images.SetKeyName(152, "toyota.png");
            this.OriginalLogos.Images.SetKeyName(153, "twitch.png");
            this.OriginalLogos.Images.SetKeyName(154, "ubisoft.png");
            this.OriginalLogos.Images.SetKeyName(155, "ubuntu.png");
            this.OriginalLogos.Images.SetKeyName(156, "umbro.png");
            this.OriginalLogos.Images.SetKeyName(157, "unicef.png");
            this.OriginalLogos.Images.SetKeyName(158, "vaio.png");
            this.OriginalLogos.Images.SetKeyName(159, "vevo.png");
            this.OriginalLogos.Images.SetKeyName(160, "visa.png");
            this.OriginalLogos.Images.SetKeyName(161, "vodafone.png");
            this.OriginalLogos.Images.SetKeyName(162, "volvo.png");
            this.OriginalLogos.Images.SetKeyName(163, "waze.png");
            this.OriginalLogos.Images.SetKeyName(164, "whirlpool.png");
            this.OriginalLogos.Images.SetKeyName(165, "wikipedia.png");
            this.OriginalLogos.Images.SetKeyName(166, "windows.png");
            this.OriginalLogos.Images.SetKeyName(167, "wish.png");
            this.OriginalLogos.Images.SetKeyName(168, "xbox.png");
            this.OriginalLogos.Images.SetKeyName(169, "yahoo.png");
            this.OriginalLogos.Images.SetKeyName(170, "yamaha.png");
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_checkstat);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.button_skip);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.flowLayoutPanel_answer);
            this.Controls.Add(this.flowLayoutPanel_rb);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label_prog);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.panel_result);
            this.Name = "GameBoard";
            this.Size = new System.Drawing.Size(1000, 660);
            this.Load += new System.EventHandler(this.GameBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_checkstat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_rb;
        private System.Windows.Forms.ImageList EditedLogos;
        private System.Windows.Forms.Panel panel_result;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_answer;
        private System.Windows.Forms.PictureBox pictureBox_checkstat;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_skip;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_prog;
        private System.Windows.Forms.ImageList OriginalLogos;
    }
}

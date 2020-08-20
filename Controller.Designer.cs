namespace RunescapeLauncher
{
    partial class Controller
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListBoxClients = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonStartClients = new System.Windows.Forms.Button();
            this.buttonShowAllTitlebars = new System.Windows.Forms.Button();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonRestartClient = new System.Windows.Forms.Button();
            this.buttonCommitConfig = new System.Windows.Forms.Button();
            this.buttonShowTitleBar = new System.Windows.Forms.Button();
            this.buttonResizeClient = new System.Windows.Forms.Button();
            this.buttonClientOffset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numberBoxLaunchPositionX = new System.Windows.Forms.NumericUpDown();
            this.numberBoxLaunchPositionY = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberBoxWindowWidth = new System.Windows.Forms.NumericUpDown();
            this.numberBoxWindowY = new System.Windows.Forms.NumericUpDown();
            this.numberBoxHeight = new System.Windows.Forms.NumericUpDown();
            this.numberBoxWindowX = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numberBoxClientHeight = new System.Windows.Forms.NumericUpDown();
            this.numberBoxClientOffsetX = new System.Windows.Forms.NumericUpDown();
            this.numberBoxClientOffsetY = new System.Windows.Forms.NumericUpDown();
            this.numberBoxClientWidth = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTipMultiGPU = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxLaunchPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxLaunchPositionY)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxWindowWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxWindowY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxWindowX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxClientHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxClientOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxClientOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxClientWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListBoxClients);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(839, 875);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 0;
            // 
            // ListBoxClients
            // 
            this.ListBoxClients.FormattingEnabled = true;
            this.ListBoxClients.Location = new System.Drawing.Point(3, 3);
            this.ListBoxClients.Name = "ListBoxClients";
            this.ListBoxClients.Size = new System.Drawing.Size(277, 862);
            this.ListBoxClients.TabIndex = 0;
            this.ListBoxClients.SelectedIndexChanged += new System.EventHandler(this.ListBoxClients_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonShutdown);
            this.groupBox5.Controls.Add(this.buttonStartClients);
            this.groupBox5.Controls.Add(this.buttonShowAllTitlebars);
            this.groupBox5.Controls.Add(this.buttonSaveConfig);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(13, 667);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(531, 203);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controller controls";
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShutdown.Location = new System.Drawing.Point(349, 144);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(176, 52);
            this.buttonShutdown.TabIndex = 15;
            this.buttonShutdown.Text = "Shutdown";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonStartClients
            // 
            this.buttonStartClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartClients.Location = new System.Drawing.Point(13, 144);
            this.buttonStartClients.Name = "buttonStartClients";
            this.buttonStartClients.Size = new System.Drawing.Size(194, 52);
            this.buttonStartClients.TabIndex = 13;
            this.buttonStartClients.Text = "Start Clients";
            this.buttonStartClients.UseVisualStyleBackColor = true;
            this.buttonStartClients.Click += new System.EventHandler(this.buttonStartClients_Click);
            // 
            // buttonShowAllTitlebars
            // 
            this.buttonShowAllTitlebars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAllTitlebars.Location = new System.Drawing.Point(13, 28);
            this.buttonShowAllTitlebars.Name = "buttonShowAllTitlebars";
            this.buttonShowAllTitlebars.Size = new System.Drawing.Size(194, 52);
            this.buttonShowAllTitlebars.TabIndex = 12;
            this.buttonShowAllTitlebars.Text = "Show All Titlebars";
            this.buttonShowAllTitlebars.UseVisualStyleBackColor = true;
            this.buttonShowAllTitlebars.Click += new System.EventHandler(this.buttonShowAllTitlebars_Click);
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveConfig.Location = new System.Drawing.Point(13, 86);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(194, 52);
            this.buttonSaveConfig.TabIndex = 14;
            this.buttonSaveConfig.Text = "Save Configs To File";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonUpdateConfigToFile_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonRestartClient);
            this.groupBox4.Controls.Add(this.buttonCommitConfig);
            this.groupBox4.Controls.Add(this.buttonShowTitleBar);
            this.groupBox4.Controls.Add(this.buttonResizeClient);
            this.groupBox4.Controls.Add(this.buttonClientOffset);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 489);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(531, 172);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client Controls";
            // 
            // buttonRestartClient
            // 
            this.buttonRestartClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestartClient.Location = new System.Drawing.Point(394, 114);
            this.buttonRestartClient.Name = "buttonRestartClient";
            this.buttonRestartClient.Size = new System.Drawing.Size(131, 52);
            this.buttonRestartClient.TabIndex = 11;
            this.buttonRestartClient.Text = "Restart Client";
            this.buttonRestartClient.UseVisualStyleBackColor = true;
            this.buttonRestartClient.Click += new System.EventHandler(this.buttonRestartClient_Click);
            // 
            // buttonCommitConfig
            // 
            this.buttonCommitConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCommitConfig.Location = new System.Drawing.Point(148, 99);
            this.buttonCommitConfig.Name = "buttonCommitConfig";
            this.buttonCommitConfig.Size = new System.Drawing.Size(145, 65);
            this.buttonCommitConfig.TabIndex = 24;
            this.buttonCommitConfig.Text = "Save Config \r\n(Soft Save)";
            this.buttonCommitConfig.UseVisualStyleBackColor = true;
            this.buttonCommitConfig.Click += new System.EventHandler(this.buttonUpdateConfigInMemory_Click);
            // 
            // buttonShowTitleBar
            // 
            this.buttonShowTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowTitleBar.Location = new System.Drawing.Point(16, 99);
            this.buttonShowTitleBar.Name = "buttonShowTitleBar";
            this.buttonShowTitleBar.Size = new System.Drawing.Size(126, 65);
            this.buttonShowTitleBar.TabIndex = 10;
            this.buttonShowTitleBar.Text = "Show Titlebar";
            this.buttonShowTitleBar.UseVisualStyleBackColor = true;
            this.buttonShowTitleBar.Click += new System.EventHandler(this.buttonShowTitlebar_Click);
            // 
            // buttonResizeClient
            // 
            this.buttonResizeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResizeClient.Location = new System.Drawing.Point(148, 28);
            this.buttonResizeClient.Name = "buttonResizeClient";
            this.buttonResizeClient.Size = new System.Drawing.Size(145, 65);
            this.buttonResizeClient.TabIndex = 9;
            this.buttonResizeClient.Text = "Resize Client";
            this.buttonResizeClient.UseVisualStyleBackColor = true;
            this.buttonResizeClient.Click += new System.EventHandler(this.buttonResizeClient_Click);
            // 
            // buttonClientOffset
            // 
            this.buttonClientOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientOffset.Location = new System.Drawing.Point(16, 28);
            this.buttonClientOffset.Name = "buttonClientOffset";
            this.buttonClientOffset.Size = new System.Drawing.Size(126, 65);
            this.buttonClientOffset.TabIndex = 8;
            this.buttonClientOffset.Text = "Offset Client";
            this.buttonClientOffset.UseVisualStyleBackColor = true;
            this.buttonClientOffset.Click += new System.EventHandler(this.buttonClientOffset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.numberBoxLaunchPositionX);
            this.groupBox3.Controls.Add(this.numberBoxLaunchPositionY);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 112);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Multi GPU Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Launch Position X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Launch Position Y:";
            // 
            // numberBoxLaunchPositionX
            // 
            this.numberBoxLaunchPositionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxLaunchPositionX.Location = new System.Drawing.Point(196, 32);
            this.numberBoxLaunchPositionX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxLaunchPositionX.Name = "numberBoxLaunchPositionX";
            this.numberBoxLaunchPositionX.Size = new System.Drawing.Size(209, 29);
            this.numberBoxLaunchPositionX.TabIndex = 4;
            // 
            // numberBoxLaunchPositionY
            // 
            this.numberBoxLaunchPositionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxLaunchPositionY.Location = new System.Drawing.Point(196, 67);
            this.numberBoxLaunchPositionY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxLaunchPositionY.Name = "numberBoxLaunchPositionY";
            this.numberBoxLaunchPositionY.Size = new System.Drawing.Size(209, 29);
            this.numberBoxLaunchPositionY.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numberBoxWindowWidth);
            this.groupBox2.Controls.Add(this.numberBoxWindowY);
            this.groupBox2.Controls.Add(this.numberBoxHeight);
            this.groupBox2.Controls.Add(this.numberBoxWindowX);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 178);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Window Size and Positions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Width: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Window X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Window Y:";
            // 
            // numberBoxWindowWidth
            // 
            this.numberBoxWindowWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxWindowWidth.Location = new System.Drawing.Point(196, 25);
            this.numberBoxWindowWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxWindowWidth.Name = "numberBoxWindowWidth";
            this.numberBoxWindowWidth.Size = new System.Drawing.Size(209, 29);
            this.numberBoxWindowWidth.TabIndex = 0;
            // 
            // numberBoxWindowY
            // 
            this.numberBoxWindowY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxWindowY.Location = new System.Drawing.Point(196, 131);
            this.numberBoxWindowY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxWindowY.Name = "numberBoxWindowY";
            this.numberBoxWindowY.Size = new System.Drawing.Size(209, 29);
            this.numberBoxWindowY.TabIndex = 3;
            // 
            // numberBoxHeight
            // 
            this.numberBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxHeight.Location = new System.Drawing.Point(196, 60);
            this.numberBoxHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxHeight.Name = "numberBoxHeight";
            this.numberBoxHeight.Size = new System.Drawing.Size(209, 29);
            this.numberBoxHeight.TabIndex = 1;
            // 
            // numberBoxWindowX
            // 
            this.numberBoxWindowX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxWindowX.Location = new System.Drawing.Point(196, 96);
            this.numberBoxWindowX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxWindowX.Name = "numberBoxWindowX";
            this.numberBoxWindowX.Size = new System.Drawing.Size(209, 29);
            this.numberBoxWindowX.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numberBoxClientHeight);
            this.groupBox1.Controls.Add(this.numberBoxClientOffsetX);
            this.groupBox1.Controls.Add(this.numberBoxClientOffsetY);
            this.groupBox1.Controls.Add(this.numberBoxClientWidth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 178);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Size and Positions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Client Offset X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Client Offset Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Client Width:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Client Height:";
            // 
            // numberBoxClientHeight
            // 
            this.numberBoxClientHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxClientHeight.Location = new System.Drawing.Point(196, 137);
            this.numberBoxClientHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxClientHeight.Name = "numberBoxClientHeight";
            this.numberBoxClientHeight.Size = new System.Drawing.Size(209, 29);
            this.numberBoxClientHeight.TabIndex = 7;
            // 
            // numberBoxClientOffsetX
            // 
            this.numberBoxClientOffsetX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxClientOffsetX.Location = new System.Drawing.Point(196, 32);
            this.numberBoxClientOffsetX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxClientOffsetX.Name = "numberBoxClientOffsetX";
            this.numberBoxClientOffsetX.Size = new System.Drawing.Size(209, 29);
            this.numberBoxClientOffsetX.TabIndex = 4;
            // 
            // numberBoxClientOffsetY
            // 
            this.numberBoxClientOffsetY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxClientOffsetY.Location = new System.Drawing.Point(196, 67);
            this.numberBoxClientOffsetY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxClientOffsetY.Name = "numberBoxClientOffsetY";
            this.numberBoxClientOffsetY.Size = new System.Drawing.Size(209, 29);
            this.numberBoxClientOffsetY.TabIndex = 5;
            // 
            // numberBoxClientWidth
            // 
            this.numberBoxClientWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxClientWidth.Location = new System.Drawing.Point(196, 102);
            this.numberBoxClientWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxClientWidth.Name = "numberBoxClientWidth";
            this.numberBoxClientWidth.Size = new System.Drawing.Size(209, 29);
            this.numberBoxClientWidth.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show Titlebar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 875);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Controller";
            this.Text = "Controller";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxLaunchPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxLaunchPositionY)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxWindowWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxWindowY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxWindowX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxClientHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxClientOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxClientOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxClientWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox ListBoxClients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClientOffset;
        private System.Windows.Forms.Button buttonResizeClient;
        private System.Windows.Forms.Button buttonRestartClient;
        private System.Windows.Forms.Button buttonShowTitleBar;
        private System.Windows.Forms.Button buttonStartClients;
        private System.Windows.Forms.NumericUpDown numberBoxClientOffsetY;
        private System.Windows.Forms.NumericUpDown numberBoxClientOffsetX;
        private System.Windows.Forms.NumericUpDown numberBoxWindowY;
        private System.Windows.Forms.NumericUpDown numberBoxWindowX;
        private System.Windows.Forms.NumericUpDown numberBoxHeight;
        private System.Windows.Forms.NumericUpDown numberBoxWindowWidth;
        private System.Windows.Forms.NumericUpDown numberBoxClientHeight;
        private System.Windows.Forms.NumericUpDown numberBoxClientWidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonShowAllTitlebars;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numberBoxLaunchPositionX;
        private System.Windows.Forms.NumericUpDown numberBoxLaunchPositionY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCommitConfig;
        private System.Windows.Forms.ToolTip toolTipMultiGPU;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}
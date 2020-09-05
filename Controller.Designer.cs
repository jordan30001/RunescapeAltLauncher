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
            this.buttonBatchAddClient = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonStartClients = new System.Windows.Forms.Button();
            this.buttonShowAllTitlebars = new System.Windows.Forms.Button();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonFitClientToWindow = new System.Windows.Forms.Button();
            this.buttonRestartClient = new System.Windows.Forms.Button();
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
            this.numberBoxWindowHeight = new System.Windows.Forms.NumericUpDown();
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
            this.button2 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxWindowHeight)).BeginInit();
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
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.ListBoxClients);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1242, 633);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // ListBoxClients
            // 
            this.ListBoxClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxClients.FormattingEnabled = true;
            this.ListBoxClients.ItemHeight = 29;
            this.ListBoxClients.Location = new System.Drawing.Point(4, 3);
            this.ListBoxClients.Margin = new System.Windows.Forms.Padding(4);
            this.ListBoxClients.Name = "ListBoxClients";
            this.ListBoxClients.Size = new System.Drawing.Size(401, 613);
            this.ListBoxClients.TabIndex = 0;
            this.ListBoxClients.SelectedIndexChanged += new System.EventHandler(this.ListBoxClients_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.buttonBatchAddClient);
            this.groupBox5.Controls.Add(this.buttonAddClient);
            this.groupBox5.Controls.Add(this.buttonShutdown);
            this.groupBox5.Controls.Add(this.buttonStartClients);
            this.groupBox5.Controls.Add(this.buttonShowAllTitlebars);
            this.groupBox5.Controls.Add(this.buttonSaveConfig);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(18, 580);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(748, 462);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controller controls";
            // 
            // buttonBatchAddClient
            // 
            this.buttonBatchAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatchAddClient.Location = new System.Drawing.Point(18, 106);
            this.buttonBatchAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBatchAddClient.Name = "buttonBatchAddClient";
            this.buttonBatchAddClient.Size = new System.Drawing.Size(259, 64);
            this.buttonBatchAddClient.TabIndex = 17;
            this.buttonBatchAddClient.Text = "Batch Add Client";
            this.buttonBatchAddClient.UseVisualStyleBackColor = true;
            this.buttonBatchAddClient.Click += new System.EventHandler(this.buttonBatchAddClient_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClient.Location = new System.Drawing.Point(18, 34);
            this.buttonAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(259, 64);
            this.buttonAddClient.TabIndex = 16;
            this.buttonAddClient.Text = "Add Client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShutdown.Location = new System.Drawing.Point(466, 391);
            this.buttonShutdown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(235, 64);
            this.buttonShutdown.TabIndex = 15;
            this.buttonShutdown.Text = "Shutdown";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonStartClients
            // 
            this.buttonStartClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartClients.Location = new System.Drawing.Point(18, 391);
            this.buttonStartClients.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartClients.Name = "buttonStartClients";
            this.buttonStartClients.Size = new System.Drawing.Size(259, 64);
            this.buttonStartClients.TabIndex = 13;
            this.buttonStartClients.Text = "Start Clients";
            this.buttonStartClients.UseVisualStyleBackColor = true;
            this.buttonStartClients.Click += new System.EventHandler(this.buttonStartClients_Click);
            // 
            // buttonShowAllTitlebars
            // 
            this.buttonShowAllTitlebars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAllTitlebars.Location = new System.Drawing.Point(18, 249);
            this.buttonShowAllTitlebars.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowAllTitlebars.Name = "buttonShowAllTitlebars";
            this.buttonShowAllTitlebars.Size = new System.Drawing.Size(259, 64);
            this.buttonShowAllTitlebars.TabIndex = 12;
            this.buttonShowAllTitlebars.Text = "Show All Titlebars";
            this.buttonShowAllTitlebars.UseVisualStyleBackColor = true;
            this.buttonShowAllTitlebars.Click += new System.EventHandler(this.buttonShowAllTitlebars_Click);
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveConfig.Location = new System.Drawing.Point(18, 320);
            this.buttonSaveConfig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(259, 64);
            this.buttonSaveConfig.TabIndex = 14;
            this.buttonSaveConfig.Text = "Save Configs To File";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonUpdateConfigToFile_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonFitClientToWindow);
            this.groupBox4.Controls.Add(this.buttonRestartClient);
            this.groupBox4.Controls.Add(this.buttonShowTitleBar);
            this.groupBox4.Controls.Add(this.buttonResizeClient);
            this.groupBox4.Controls.Add(this.buttonClientOffset);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 360);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(748, 212);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client Controls";
            // 
            // buttonFitClientToWindow
            // 
            this.buttonFitClientToWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFitClientToWindow.Location = new System.Drawing.Point(197, 122);
            this.buttonFitClientToWindow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFitClientToWindow.Name = "buttonFitClientToWindow";
            this.buttonFitClientToWindow.Size = new System.Drawing.Size(194, 80);
            this.buttonFitClientToWindow.TabIndex = 12;
            this.buttonFitClientToWindow.Text = "Fit Client To Window";
            this.buttonFitClientToWindow.UseVisualStyleBackColor = true;
            this.buttonFitClientToWindow.Click += new System.EventHandler(this.buttonFitClientToWindow_Click);
            // 
            // buttonRestartClient
            // 
            this.buttonRestartClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestartClient.Location = new System.Drawing.Point(564, 140);
            this.buttonRestartClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestartClient.Name = "buttonRestartClient";
            this.buttonRestartClient.Size = new System.Drawing.Size(174, 64);
            this.buttonRestartClient.TabIndex = 11;
            this.buttonRestartClient.Text = "Restart Client";
            this.buttonRestartClient.UseVisualStyleBackColor = true;
            this.buttonRestartClient.Click += new System.EventHandler(this.buttonRestartClient_Click);
            // 
            // buttonShowTitleBar
            // 
            this.buttonShowTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowTitleBar.Location = new System.Drawing.Point(21, 122);
            this.buttonShowTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowTitleBar.Name = "buttonShowTitleBar";
            this.buttonShowTitleBar.Size = new System.Drawing.Size(168, 80);
            this.buttonShowTitleBar.TabIndex = 10;
            this.buttonShowTitleBar.Text = "Show Titlebar";
            this.buttonShowTitleBar.UseVisualStyleBackColor = true;
            this.buttonShowTitleBar.Click += new System.EventHandler(this.buttonShowTitlebar_Click);
            // 
            // buttonResizeClient
            // 
            this.buttonResizeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResizeClient.Location = new System.Drawing.Point(197, 34);
            this.buttonResizeClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResizeClient.Name = "buttonResizeClient";
            this.buttonResizeClient.Size = new System.Drawing.Size(194, 80);
            this.buttonResizeClient.TabIndex = 9;
            this.buttonResizeClient.Text = "Resize Client";
            this.buttonResizeClient.UseVisualStyleBackColor = true;
            this.buttonResizeClient.Click += new System.EventHandler(this.buttonResizeClient_Click);
            // 
            // buttonClientOffset
            // 
            this.buttonClientOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientOffset.Location = new System.Drawing.Point(21, 34);
            this.buttonClientOffset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClientOffset.Name = "buttonClientOffset";
            this.buttonClientOffset.Size = new System.Drawing.Size(168, 80);
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
            this.groupBox3.Location = new System.Drawing.Point(18, 274);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(748, 78);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Multi GPU Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Launch Position X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(380, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Launch Position Y:";
            // 
            // numberBoxLaunchPositionX
            // 
            this.numberBoxLaunchPositionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxLaunchPositionX.Location = new System.Drawing.Point(232, 37);
            this.numberBoxLaunchPositionX.Margin = new System.Windows.Forms.Padding(4);
            this.numberBoxLaunchPositionX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxLaunchPositionX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numberBoxLaunchPositionX.Name = "numberBoxLaunchPositionX";
            this.numberBoxLaunchPositionX.Size = new System.Drawing.Size(139, 34);
            this.numberBoxLaunchPositionX.TabIndex = 4;
            // 
            // numberBoxLaunchPositionY
            // 
            this.numberBoxLaunchPositionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxLaunchPositionY.Location = new System.Drawing.Point(599, 39);
            this.numberBoxLaunchPositionY.Margin = new System.Windows.Forms.Padding(4);
            this.numberBoxLaunchPositionY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxLaunchPositionY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numberBoxLaunchPositionY.Name = "numberBoxLaunchPositionY";
            this.numberBoxLaunchPositionY.Size = new System.Drawing.Size(139, 34);
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
            this.groupBox2.Controls.Add(this.numberBoxWindowHeight);
            this.groupBox2.Controls.Add(this.numberBoxWindowX);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(748, 126);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Window Size and Positions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Width: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Window X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Window Y:";
            // 
            // numberBoxWindowWidth
            // 
            this.numberBoxWindowWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxWindowWidth.Location = new System.Drawing.Point(110, 35);
            this.numberBoxWindowWidth.Margin = new System.Windows.Forms.Padding(4);
            this.numberBoxWindowWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxWindowWidth.Name = "numberBoxWindowWidth";
            this.numberBoxWindowWidth.Size = new System.Drawing.Size(130, 34);
            this.numberBoxWindowWidth.TabIndex = 0;
            // 
            // numberBoxWindowY
            // 
            this.numberBoxWindowY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxWindowY.Location = new System.Drawing.Point(396, 79);
            this.numberBoxWindowY.Margin = new System.Windows.Forms.Padding(4);
            this.numberBoxWindowY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxWindowY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numberBoxWindowY.Name = "numberBoxWindowY";
            this.numberBoxWindowY.Size = new System.Drawing.Size(130, 34);
            this.numberBoxWindowY.TabIndex = 3;
            // 
            // numberBoxWindowHeight
            // 
            this.numberBoxWindowHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxWindowHeight.Location = new System.Drawing.Point(110, 79);
            this.numberBoxWindowHeight.Margin = new System.Windows.Forms.Padding(4);
            this.numberBoxWindowHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxWindowHeight.Name = "numberBoxWindowHeight";
            this.numberBoxWindowHeight.Size = new System.Drawing.Size(130, 34);
            this.numberBoxWindowHeight.TabIndex = 1;
            // 
            // numberBoxWindowX
            // 
            this.numberBoxWindowX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxWindowX.Location = new System.Drawing.Point(396, 35);
            this.numberBoxWindowX.Margin = new System.Windows.Forms.Padding(4);
            this.numberBoxWindowX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxWindowX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numberBoxWindowX.Name = "numberBoxWindowX";
            this.numberBoxWindowX.Size = new System.Drawing.Size(130, 34);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(748, 128);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Size and Positions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Client Offset X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Client Offset Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Client Width:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(359, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Client Height:";
            // 
            // numberBoxClientHeight
            // 
            this.numberBoxClientHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxClientHeight.Location = new System.Drawing.Point(523, 82);
            this.numberBoxClientHeight.Margin = new System.Windows.Forms.Padding(4);
            this.numberBoxClientHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxClientHeight.Name = "numberBoxClientHeight";
            this.numberBoxClientHeight.Size = new System.Drawing.Size(148, 34);
            this.numberBoxClientHeight.TabIndex = 7;
            // 
            // numberBoxClientOffsetX
            // 
            this.numberBoxClientOffsetX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxClientOffsetX.Location = new System.Drawing.Point(197, 39);
            this.numberBoxClientOffsetX.Margin = new System.Windows.Forms.Padding(4);
            this.numberBoxClientOffsetX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxClientOffsetX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numberBoxClientOffsetX.Name = "numberBoxClientOffsetX";
            this.numberBoxClientOffsetX.Size = new System.Drawing.Size(148, 34);
            this.numberBoxClientOffsetX.TabIndex = 4;
            // 
            // numberBoxClientOffsetY
            // 
            this.numberBoxClientOffsetY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxClientOffsetY.Location = new System.Drawing.Point(197, 82);
            this.numberBoxClientOffsetY.Margin = new System.Windows.Forms.Padding(4);
            this.numberBoxClientOffsetY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxClientOffsetY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numberBoxClientOffsetY.Name = "numberBoxClientOffsetY";
            this.numberBoxClientOffsetY.Size = new System.Drawing.Size(148, 34);
            this.numberBoxClientOffsetY.TabIndex = 5;
            // 
            // numberBoxClientWidth
            // 
            this.numberBoxClientWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxClientWidth.Location = new System.Drawing.Point(523, 39);
            this.numberBoxClientWidth.Margin = new System.Windows.Forms.Padding(4);
            this.numberBoxClientWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxClientWidth.Name = "numberBoxClientWidth";
            this.numberBoxClientWidth.Size = new System.Drawing.Size(148, 34);
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(285, 249);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 64);
            this.button2.TabIndex = 18;
            this.button2.Text = "Fit All Clients To Window";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonFitAllClientsToWindow_Click);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(400, 400);
            this.ClientSize = new System.Drawing.Size(1242, 633);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxWindowHeight)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numberBoxWindowHeight;
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
        private System.Windows.Forms.ToolTip toolTipMultiGPU;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonBatchAddClient;
        private System.Windows.Forms.Button buttonFitClientToWindow;
        private System.Windows.Forms.Button button2;
    }
}
namespace LabiryntFrontend
{
    partial class GbMaze
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
            this.panelTools = new System.Windows.Forms.Panel();
            this.isRandom = new System.Windows.Forms.CheckBox();
            this.seedInput = new System.Windows.Forms.TextBox();
            this.rowsInput = new System.Windows.Forms.TextBox();
            this.colsInput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelEditor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.algorithmsPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.algorithm2Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.algorithm3Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.algorithm1Button = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.algorithmsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTools.Controls.Add(this.isRandom);
            this.panelTools.Controls.Add(this.seedInput);
            this.panelTools.Controls.Add(this.rowsInput);
            this.panelTools.Controls.Add(this.colsInput);
            this.panelTools.Controls.Add(this.pictureBox2);
            this.panelTools.Controls.Add(this.buttonStart);
            this.panelTools.Controls.Add(this.button7);
            this.panelTools.Controls.Add(this.button6);
            this.panelTools.Controls.Add(this.button5);
            this.panelTools.Controls.Add(this.button4);
            this.panelTools.Controls.Add(this.button2);
            this.panelTools.Controls.Add(this.button1);
            this.panelTools.Controls.Add(this.button3);
            this.panelTools.Location = new System.Drawing.Point(0, 0);
            this.panelTools.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1899, 130);
            this.panelTools.TabIndex = 0;
            // 
            // isRandom
            // 
            this.isRandom.AutoSize = true;
            this.isRandom.Location = new System.Drawing.Point(952, 78);
            this.isRandom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isRandom.Name = "isRandom";
            this.isRandom.Size = new System.Drawing.Size(143, 29);
            this.isRandom.TabIndex = 5;
            this.isRandom.Text = "random seed";
            this.isRandom.UseVisualStyleBackColor = true;
            this.isRandom.CheckedChanged += new System.EventHandler(this.isRandom_CheckedChanged);
            // 
            // seedInput
            // 
            this.seedInput.Location = new System.Drawing.Point(952, 26);
            this.seedInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seedInput.Name = "seedInput";
            this.seedInput.PlaceholderText = "seed";
            this.seedInput.Size = new System.Drawing.Size(138, 31);
            this.seedInput.TabIndex = 4;
            this.seedInput.TextChanged += new System.EventHandler(this.seedInput_TextChanged);
            // 
            // rowsInput
            // 
            this.rowsInput.Location = new System.Drawing.Point(328, 78);
            this.rowsInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rowsInput.Name = "rowsInput";
            this.rowsInput.PlaceholderText = "rows";
            this.rowsInput.Size = new System.Drawing.Size(91, 31);
            this.rowsInput.TabIndex = 3;
            this.rowsInput.TextChanged += new System.EventHandler(this.colsInput_TextChanged);
            // 
            // colsInput
            // 
            this.colsInput.Location = new System.Drawing.Point(328, 24);
            this.colsInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colsInput.Name = "colsInput";
            this.colsInput.PlaceholderText = "cols";
            this.colsInput.Size = new System.Drawing.Size(91, 31);
            this.colsInput.TabIndex = 2;
            this.colsInput.TextChanged += new System.EventHandler(this.colsInput_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LabiryntFrontend.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(18, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Image = global::LabiryntFrontend.Properties.Resources.playButton;
            this.buttonStart.Location = new System.Drawing.Point(1797, 36);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(63, 58);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(1449, 21);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 90);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Image = global::LabiryntFrontend.Properties.Resources.generate;
            this.button6.Location = new System.Drawing.Point(1101, 26);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 90);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = global::LabiryntFrontend.Properties.Resources.removeAll;
            this.button5.Location = new System.Drawing.Point(854, 24);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 90);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::LabiryntFrontend.Properties.Resources.addAll;
            this.button4.Location = new System.Drawing.Point(754, 26);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 90);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::LabiryntFrontend.Properties.Resources.removeWall;
            this.button2.Location = new System.Drawing.Point(642, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 90);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::LabiryntFrontend.Properties.Resources.addWall;
            this.button1.Location = new System.Drawing.Point(543, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::LabiryntFrontend.Properties.Resources.size2;
            this.button3.Location = new System.Drawing.Point(430, 24);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 90);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelEditor
            // 
            this.panelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditor.AutoScroll = true;
            this.panelEditor.BackColor = System.Drawing.Color.Transparent;
            this.panelEditor.Controls.Add(this.pictureBox1);
            this.panelEditor.Location = new System.Drawing.Point(0, 135);
            this.panelEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(1888, 886);
            this.panelEditor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // algorithmsPanel
            // 
            this.algorithmsPanel.BackColor = System.Drawing.Color.Transparent;
            this.algorithmsPanel.Controls.Add(this.backButton);
            this.algorithmsPanel.Controls.Add(this.panel3);
            this.algorithmsPanel.Controls.Add(this.panel2);
            this.algorithmsPanel.Controls.Add(this.panel1);
            this.algorithmsPanel.Location = new System.Drawing.Point(0, 135);
            this.algorithmsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.algorithmsPanel.Name = "algorithmsPanel";
            this.algorithmsPanel.Size = new System.Drawing.Size(1894, 888);
            this.algorithmsPanel.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::LabiryntFrontend.Properties.Resources.backButton;
            this.backButton.Location = new System.Drawing.Point(12, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(64, 62);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.algorithm2Button);
            this.panel3.Location = new System.Drawing.Point(723, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 741);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LabiryntFrontend.Properties.Resources.algorithmIMG1;
            this.pictureBox4.Location = new System.Drawing.Point(33, 105);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(405, 268);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label2.Location = new System.Drawing.Point(57, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 112);
            this.label2.TabIndex = 2;
            this.label2.Text = "INNY 2";
            // 
            // algorithm2Button
            // 
            this.algorithm2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.algorithm2Button.BackgroundImage = global::LabiryntFrontend.Properties.Resources.startButton1;
            this.algorithm2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.algorithm2Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.algorithm2Button.FlatAppearance.BorderSize = 3;
            this.algorithm2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algorithm2Button.ForeColor = System.Drawing.Color.Transparent;
            this.algorithm2Button.Location = new System.Drawing.Point(123, 608);
            this.algorithm2Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.algorithm2Button.Name = "algorithm2Button";
            this.algorithm2Button.Size = new System.Drawing.Size(225, 100);
            this.algorithm2Button.TabIndex = 2;
            this.algorithm2Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.algorithm2Button.UseVisualStyleBackColor = false;
            this.algorithm2Button.Click += new System.EventHandler(this.algorithm2Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.algorithm3Button);
            this.panel2.Location = new System.Drawing.Point(1335, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 741);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LabiryntFrontend.Properties.Resources.algorithmIMG1;
            this.pictureBox5.Location = new System.Drawing.Point(38, 105);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(405, 268);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label3.Location = new System.Drawing.Point(57, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 112);
            this.label3.TabIndex = 3;
            this.label3.Text = "INNY 3";
            // 
            // algorithm3Button
            // 
            this.algorithm3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.algorithm3Button.BackgroundImage = global::LabiryntFrontend.Properties.Resources.startButton1;
            this.algorithm3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.algorithm3Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.algorithm3Button.FlatAppearance.BorderSize = 3;
            this.algorithm3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algorithm3Button.ForeColor = System.Drawing.Color.Transparent;
            this.algorithm3Button.Location = new System.Drawing.Point(129, 608);
            this.algorithm3Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.algorithm3Button.Name = "algorithm3Button";
            this.algorithm3Button.Size = new System.Drawing.Size(225, 100);
            this.algorithm3Button.TabIndex = 3;
            this.algorithm3Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.algorithm3Button.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.algorithm1Button);
            this.panel1.Location = new System.Drawing.Point(105, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 741);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(34, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "tu opis algorytmu";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LabiryntFrontend.Properties.Resources.algorithmIMG1;
            this.pictureBox3.Location = new System.Drawing.Point(34, 105);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(405, 268);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(129, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "DFS";
            // 
            // algorithm1Button
            // 
            this.algorithm1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.algorithm1Button.BackgroundImage = global::LabiryntFrontend.Properties.Resources.startButton1;
            this.algorithm1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.algorithm1Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.algorithm1Button.FlatAppearance.BorderSize = 3;
            this.algorithm1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algorithm1Button.ForeColor = System.Drawing.Color.Transparent;
            this.algorithm1Button.Location = new System.Drawing.Point(110, 608);
            this.algorithm1Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.algorithm1Button.Name = "algorithm1Button";
            this.algorithm1Button.Size = new System.Drawing.Size(225, 100);
            this.algorithm1Button.TabIndex = 0;
            this.algorithm1Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.algorithm1Button.UseVisualStyleBackColor = false;
            this.algorithm1Button.Click += new System.EventHandler(this.algorithm1Button_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panelTools);
            this.mainPanel.Controls.Add(this.algorithmsPanel);
            this.mainPanel.Controls.Add(this.panelEditor);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1894, 1023);
            this.mainPanel.TabIndex = 1;
            // 
            // GbMaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1896, 1022);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GbMaze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GbMaze";
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelEditor.ResumeLayout(false);
            this.panelEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.algorithmsPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTools;
        private Button button3;
        private Panel panelEditor;
        private Button buttonStart;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox rowsInput;
        private TextBox colsInput;
        private PictureBox pictureBox2;
        private TextBox seedInput;
        private Panel algorithmsPanel;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button algorithm1Button;
        private Label label2;
        private Button algorithm2Button;
        private Label label3;
        private Button algorithm3Button;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label4;
        private CheckBox isRandom;
        private Panel mainPanel;
        private Button backButton;
    }
}
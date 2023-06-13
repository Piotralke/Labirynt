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
            panelTools = new Panel();
            button5 = new Button();
            openMazeAsFileButton = new Button();
            button4 = new Button();
            saveMazeAsFileButton = new Button();
            addEntryButton = new Button();
            exitXInput = new TextBox();
            startXInput = new TextBox();
            exitYInput = new TextBox();
            startYInput = new TextBox();
            button1 = new Button();
            label4 = new Label();
            exitList = new ListView();
            isRandom = new CheckBox();
            seedInput = new TextBox();
            rowsInput = new TextBox();
            colsInput = new TextBox();
            pictureBox2 = new PictureBox();
            buttonStart = new Button();
            saveMazeAsPNG = new Button();
            button6 = new Button();
            button3 = new Button();
            panelEditor = new Panel();
            pictureBox1 = new PictureBox();
            algorithmsPanel = new Panel();
            stepWork = new CheckBox();
            backButton = new Button();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            algorithm2Button = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            algorithm1Button = new Button();
            mainPanel = new Panel();
            stepWorkPanel = new Panel();
            label3 = new Label();
            trackBar1 = new TrackBar();
            visualizationPicture = new PictureBox();
            panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            algorithmsPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            mainPanel.SuspendLayout();
            stepWorkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visualizationPicture).BeginInit();
            SuspendLayout();
            // 
            // panelTools
            // 
            panelTools.BackColor = Color.WhiteSmoke;
            panelTools.Controls.Add(button5);
            panelTools.Controls.Add(openMazeAsFileButton);
            panelTools.Controls.Add(button4);
            panelTools.Controls.Add(saveMazeAsFileButton);
            panelTools.Controls.Add(addEntryButton);
            panelTools.Controls.Add(exitXInput);
            panelTools.Controls.Add(startXInput);
            panelTools.Controls.Add(exitYInput);
            panelTools.Controls.Add(startYInput);
            panelTools.Controls.Add(button1);
            panelTools.Controls.Add(label4);
            panelTools.Controls.Add(exitList);
            panelTools.Controls.Add(isRandom);
            panelTools.Controls.Add(seedInput);
            panelTools.Controls.Add(rowsInput);
            panelTools.Controls.Add(colsInput);
            panelTools.Controls.Add(pictureBox2);
            panelTools.Controls.Add(buttonStart);
            panelTools.Controls.Add(saveMazeAsPNG);
            panelTools.Controls.Add(button6);
            panelTools.Controls.Add(button3);
            panelTools.Location = new Point(0, 0);
            panelTools.Margin = new Padding(3, 3, 0, 3);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(1266, 87);
            panelTools.TabIndex = 0;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.openDB;
            button5.Location = new Point(937, 45);
            button5.Name = "button5";
            button5.Size = new Size(38, 35);
            button5.TabIndex = 19;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // openMazeAsFileButton
            // 
            openMazeAsFileButton.Image = Properties.Resources.openFileButton;
            openMazeAsFileButton.Location = new Point(961, 9);
            openMazeAsFileButton.Name = "openMazeAsFileButton";
            openMazeAsFileButton.Size = new Size(38, 35);
            openMazeAsFileButton.TabIndex = 19;
            openMazeAsFileButton.UseVisualStyleBackColor = true;
            openMazeAsFileButton.Click += openMazeAsFileButton_Click;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.saveDB;
            button4.Location = new Point(892, 45);
            button4.Name = "button4";
            button4.Size = new Size(39, 35);
            button4.TabIndex = 18;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // saveMazeAsFileButton
            // 
            saveMazeAsFileButton.Image = Properties.Resources.saveFileButton;
            saveMazeAsFileButton.Location = new Point(916, 9);
            saveMazeAsFileButton.Name = "saveMazeAsFileButton";
            saveMazeAsFileButton.Size = new Size(39, 35);
            saveMazeAsFileButton.TabIndex = 18;
            saveMazeAsFileButton.UseVisualStyleBackColor = true;
            saveMazeAsFileButton.Click += saveMazeAsFileButton_Click;
            // 
            // addEntryButton
            // 
            addEntryButton.Location = new Point(630, 15);
            addEntryButton.Margin = new Padding(2);
            addEntryButton.Name = "addEntryButton";
            addEntryButton.Size = new Size(60, 60);
            addEntryButton.TabIndex = 19;
            addEntryButton.Text = "Dodaj wejście";
            addEntryButton.UseVisualStyleBackColor = true;
            addEntryButton.Click += addEntryButton_Click;
            // 
            // exitXInput
            // 
            exitXInput.Location = new Point(694, 17);
            exitXInput.Margin = new Padding(2);
            exitXInput.Name = "exitXInput";
            exitXInput.PlaceholderText = "Pozycja wyjścia x";
            exitXInput.Size = new Size(107, 23);
            exitXInput.TabIndex = 16;
            exitXInput.TextChanged += exitXInput_TextChanged;
            // 
            // startXInput
            // 
            startXInput.Location = new Point(519, 17);
            startXInput.Margin = new Padding(2);
            startXInput.Name = "startXInput";
            startXInput.PlaceholderText = "Pozycja startowa x";
            startXInput.Size = new Size(107, 23);
            startXInput.TabIndex = 14;
            startXInput.TextChanged += startXInput_TextChanged;
            // 
            // exitYInput
            // 
            exitYInput.Location = new Point(694, 52);
            exitYInput.Margin = new Padding(2);
            exitYInput.Name = "exitYInput";
            exitYInput.PlaceholderText = "Pozycja wyjścia y";
            exitYInput.Size = new Size(107, 23);
            exitYInput.TabIndex = 17;
            exitYInput.TextChanged += exitXInput_TextChanged;
            // 
            // startYInput
            // 
            startYInput.Location = new Point(519, 52);
            startYInput.Margin = new Padding(2);
            startYInput.Name = "startYInput";
            startYInput.PlaceholderText = "Pozycja startowa y";
            startYInput.Size = new Size(107, 23);
            startYInput.TabIndex = 15;
            startYInput.TextChanged += startXInput_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(805, 16);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 20;
            button1.Text = "Dodaj wyjście";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1038, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 11;
            label4.Text = "Wyjścia z labiryntu";
            // 
            // exitList
            // 
            exitList.Location = new Point(1001, 17);
            exitList.Margin = new Padding(2);
            exitList.Name = "exitList";
            exitList.Size = new Size(169, 60);
            exitList.TabIndex = 10;
            exitList.UseCompatibleStateImageBehavior = false;
            exitList.View = View.Details;
            exitList.MouseDoubleClick += exitList_MouseDoubleClick;
            // 
            // isRandom
            // 
            isRandom.AutoSize = true;
            isRandom.Location = new Point(353, 54);
            isRandom.Name = "isRandom";
            isRandom.Size = new Size(95, 19);
            isRandom.TabIndex = 5;
            isRandom.Text = "random seed";
            isRandom.UseVisualStyleBackColor = true;
            isRandom.CheckedChanged += isRandom_CheckedChanged;
            // 
            // seedInput
            // 
            seedInput.Location = new Point(353, 17);
            seedInput.Name = "seedInput";
            seedInput.PlaceholderText = "seed";
            seedInput.Size = new Size(93, 23);
            seedInput.TabIndex = 4;
            seedInput.TextChanged += seedInput_TextChanged;
            // 
            // rowsInput
            // 
            rowsInput.Location = new Point(219, 52);
            rowsInput.Name = "rowsInput";
            rowsInput.PlaceholderText = "rows";
            rowsInput.Size = new Size(62, 23);
            rowsInput.TabIndex = 3;
            rowsInput.TextChanged += colsInput_TextChanged;
            // 
            // colsInput
            // 
            colsInput.Location = new Point(219, 16);
            colsInput.Name = "colsInput";
            colsInput.PlaceholderText = "cols";
            colsInput.Size = new Size(62, 23);
            colsInput.TabIndex = 2;
            colsInput.TextChanged += colsInput_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Transparent;
            buttonStart.FlatAppearance.BorderColor = Color.WhiteSmoke;
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatAppearance.MouseDownBackColor = Color.Silver;
            buttonStart.FlatAppearance.MouseOverBackColor = Color.Silver;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Image = Properties.Resources.playButton;
            buttonStart.Location = new Point(1198, 24);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(42, 39);
            buttonStart.TabIndex = 0;
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // saveMazeAsPNG
            // 
            saveMazeAsPNG.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            saveMazeAsPNG.Image = Properties.Resources.saveIMGButton;
            saveMazeAsPNG.Location = new Point(871, 8);
            saveMazeAsPNG.Name = "saveMazeAsPNG";
            saveMazeAsPNG.Size = new Size(39, 36);
            saveMazeAsPNG.TabIndex = 0;
            saveMazeAsPNG.UseVisualStyleBackColor = true;
            saveMazeAsPNG.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Image = Properties.Resources.generate;
            button6.Location = new Point(454, 16);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.size2;
            button3.Location = new Point(287, 16);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panelEditor
            // 
            panelEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelEditor.AutoScroll = true;
            panelEditor.BackColor = Color.Transparent;
            panelEditor.Controls.Add(pictureBox1);
            panelEditor.Location = new Point(0, 90);
            panelEditor.Name = "panelEditor";
            panelEditor.Size = new Size(1259, 591);
            panelEditor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(8, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(891, 485);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // algorithmsPanel
            // 
            algorithmsPanel.BackColor = Color.Transparent;
            algorithmsPanel.Controls.Add(stepWork);
            algorithmsPanel.Controls.Add(backButton);
            algorithmsPanel.Controls.Add(panel3);
            algorithmsPanel.Controls.Add(panel1);
            algorithmsPanel.Location = new Point(0, 90);
            algorithmsPanel.Name = "algorithmsPanel";
            algorithmsPanel.Size = new Size(1263, 592);
            algorithmsPanel.TabIndex = 1;
            // 
            // stepWork
            // 
            stepWork.AutoSize = true;
            stepWork.Location = new Point(38, 94);
            stepWork.Name = "stepWork";
            stepWork.Size = new Size(103, 19);
            stepWork.TabIndex = 3;
            stepWork.Text = "Praca krokowa";
            stepWork.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            backButton.FlatAppearance.BorderColor = Color.DarkSlateGray;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            backButton.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Image = Properties.Resources.backButton;
            backButton.Location = new Point(8, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(43, 41);
            backButton.TabIndex = 2;
            backButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(66, 111, 111);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(algorithm2Button);
            panel3.Location = new Point(699, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 494);
            panel3.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.algorithmIMG1;
            pictureBox4.Location = new Point(22, 70);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(270, 179);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(181, 196, 196);
            label2.Location = new Point(82, 9);
            label2.Name = "label2";
            label2.Size = new Size(137, 75);
            label2.TabIndex = 2;
            label2.Text = "BFS";
            // 
            // algorithm2Button
            // 
            algorithm2Button.BackColor = Color.FromArgb(66, 111, 111);
            algorithm2Button.BackgroundImage = Properties.Resources.startButton1;
            algorithm2Button.BackgroundImageLayout = ImageLayout.Zoom;
            algorithm2Button.FlatAppearance.BorderColor = Color.FromArgb(181, 196, 196);
            algorithm2Button.FlatAppearance.BorderSize = 3;
            algorithm2Button.FlatStyle = FlatStyle.Flat;
            algorithm2Button.ForeColor = Color.Transparent;
            algorithm2Button.Location = new Point(82, 405);
            algorithm2Button.Name = "algorithm2Button";
            algorithm2Button.Size = new Size(150, 67);
            algorithm2Button.TabIndex = 2;
            algorithm2Button.TextImageRelation = TextImageRelation.TextBeforeImage;
            algorithm2Button.UseVisualStyleBackColor = false;
            algorithm2Button.Click += algorithm2Button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 111, 111);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(algorithm1Button);
            panel1.Location = new Point(287, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 494);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.algorithmIMG1;
            pictureBox3.Location = new Point(23, 70);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(270, 179);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(181, 196, 196);
            label1.Location = new Point(86, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 75);
            label1.TabIndex = 1;
            label1.Text = "DFS";
            // 
            // algorithm1Button
            // 
            algorithm1Button.BackColor = Color.FromArgb(66, 111, 111);
            algorithm1Button.BackgroundImage = Properties.Resources.startButton1;
            algorithm1Button.BackgroundImageLayout = ImageLayout.Zoom;
            algorithm1Button.FlatAppearance.BorderColor = Color.FromArgb(181, 196, 196);
            algorithm1Button.FlatAppearance.BorderSize = 3;
            algorithm1Button.FlatStyle = FlatStyle.Flat;
            algorithm1Button.ForeColor = Color.Transparent;
            algorithm1Button.Location = new Point(73, 405);
            algorithm1Button.Name = "algorithm1Button";
            algorithm1Button.Size = new Size(150, 67);
            algorithm1Button.TabIndex = 0;
            algorithm1Button.TextImageRelation = TextImageRelation.TextBeforeImage;
            algorithm1Button.UseVisualStyleBackColor = false;
            algorithm1Button.Click += algorithm1Button_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panelEditor);
            mainPanel.Controls.Add(panelTools);
            mainPanel.Controls.Add(algorithmsPanel);
            mainPanel.Controls.Add(stepWorkPanel);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(0, 3, 0, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1263, 682);
            mainPanel.TabIndex = 1;
            // 
            // stepWorkPanel
            // 
            stepWorkPanel.AutoScroll = true;
            stepWorkPanel.BackColor = Color.DarkSlateGray;
            stepWorkPanel.Controls.Add(label3);
            stepWorkPanel.Controls.Add(trackBar1);
            stepWorkPanel.Controls.Add(visualizationPicture);
            stepWorkPanel.Location = new Point(3, 90);
            stepWorkPanel.Name = "stepWorkPanel";
            stepWorkPanel.Size = new Size(1249, 579);
            stepWorkPanel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 13);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 2;
            label3.Text = "Odstęp między iteracjami";
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(156, 6);
            trackBar1.Maximum = 20;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(269, 45);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // visualizationPicture
            // 
            visualizationPicture.BackColor = Color.Transparent;
            visualizationPicture.Location = new Point(9, 48);
            visualizationPicture.Name = "visualizationPicture";
            visualizationPicture.Size = new Size(1228, 515);
            visualizationPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            visualizationPicture.TabIndex = 0;
            visualizationPicture.TabStop = false;
            visualizationPicture.WaitOnLoad = true;
            // 
            // GbMaze
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1264, 681);
            Controls.Add(mainPanel);
            Name = "GbMaze";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GbMaze";
            panelTools.ResumeLayout(false);
            panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelEditor.ResumeLayout(false);
            panelEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            algorithmsPanel.ResumeLayout(false);
            algorithmsPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            mainPanel.ResumeLayout(false);
            stepWorkPanel.ResumeLayout(false);
            stepWorkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)visualizationPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTools;
        private Button button3;
        private Panel panelEditor;
        private Button buttonStart;
        private Button saveMazeAsPNG;
        private Button button6;
        private PictureBox pictureBox1;
        private TextBox rowsInput;
        private TextBox colsInput;
        private PictureBox pictureBox2;
        private TextBox seedInput;
        private Panel algorithmsPanel;
        private Panel panel3;
        private Panel panel1;
        private Button algorithm1Button;
        private Label label2;
        private Button algorithm2Button;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private CheckBox isRandom;
        private Panel mainPanel;
        private Button backButton;
        private Button button1;
        private Label label4;
        private ListView exitList;
        private TextBox exitXInput;
        private TextBox startXInput;
        private TextBox exitYInput;
        private TextBox startYInput;
        private Button addEntryButton;
        private Button openMazeAsFileButton;
        private Button saveMazeAsFileButton;
        private CheckBox stepWork;
        private Panel stepWorkPanel;
        private PictureBox visualizationPicture;
        private TrackBar trackBar1;
        private Label label3;
        private Button button5;
        private Button button4;
    }
}
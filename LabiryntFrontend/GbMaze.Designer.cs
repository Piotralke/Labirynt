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
            rowsInput = new TextBox();
            colsInput = new TextBox();
            pictureBox2 = new PictureBox();
            buttonStart = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            panelMenu = new Panel();
            buttonEditor = new Button();
            panelEditor = new Panel();
            pictureBox1 = new PictureBox();
            button8 = new Button();
            panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelMenu.SuspendLayout();
            panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTools
            // 
            panelTools.BackColor = Color.WhiteSmoke;
            panelTools.Controls.Add(rowsInput);
            panelTools.Controls.Add(colsInput);
            panelTools.Controls.Add(pictureBox2);
            panelTools.Controls.Add(buttonStart);
            panelTools.Controls.Add(button7);
            panelTools.Controls.Add(button6);
            panelTools.Controls.Add(button5);
            panelTools.Controls.Add(button4);
            panelTools.Controls.Add(button2);
            panelTools.Controls.Add(button1);
            panelTools.Controls.Add(button3);
            panelTools.Location = new Point(0, 0);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(1266, 87);
            panelTools.TabIndex = 0;
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
            buttonStart.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(1181, 15);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(60, 60);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(865, 15);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Image = Properties.Resources.generate;
            button6.Location = new Point(799, 15);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = Properties.Resources.removeAll;
            button5.Location = new Point(702, 15);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = Properties.Resources.addAll;
            button4.Location = new Point(636, 15);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.removeWall;
            button2.Location = new Point(501, 15);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.addWall;
            button1.Location = new Point(435, 15);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // panelMenu
            // 
            panelMenu.BackColor = Color.WhiteSmoke;
            panelMenu.Controls.Add(buttonEditor);
            panelMenu.Location = new Point(0, 87);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 594);
            panelMenu.TabIndex = 1;
            // 
            // buttonEditor
            // 
            buttonEditor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditor.Location = new Point(0, 6);
            buttonEditor.Name = "buttonEditor";
            buttonEditor.Size = new Size(200, 77);
            buttonEditor.TabIndex = 0;
            buttonEditor.Text = "Edytor";
            buttonEditor.UseVisualStyleBackColor = true;
            // 
            // panelEditor
            // 
            panelEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelEditor.AutoScroll = true;
            panelEditor.BackColor = Color.Transparent;
            panelEditor.Controls.Add(button8);
            panelEditor.Controls.Add(pictureBox1);
            panelEditor.Location = new Point(206, 93);
            panelEditor.Name = "panelEditor";
            panelEditor.Size = new Size(1046, 576);
            panelEditor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(994, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // button8
            // 
            button8.Location = new Point(181, 544);
            button8.Name = "button8";
            button8.Size = new Size(75, 58);
            button8.TabIndex = 1;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // GbMaze
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelEditor);
            Controls.Add(panelMenu);
            Controls.Add(panelTools);
            Name = "GbMaze";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GbMaze";
            panelTools.ResumeLayout(false);
            panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelMenu.ResumeLayout(false);
            panelEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTools;
        private Panel panelMenu;
        private Button button3;
        private Button buttonEditor;
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
        private Button button8;
    }
}
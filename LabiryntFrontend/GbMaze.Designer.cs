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
            button8 = new Button();
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
            panelTools.SuspendLayout();
            panelMenu.SuspendLayout();
            panelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTools
            // 
            panelTools.BackColor = Color.WhiteSmoke;
            panelTools.Controls.Add(button8);
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
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(1181, 15);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 0;
            button8.Text = "START";
            button8.UseVisualStyleBackColor = true;
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
            button6.Location = new Point(799, 15);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(702, 15);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(636, 15);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(418, 15);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 0;
            button2.Text = "Usuń";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(352, 15);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(230, 15);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 0;
            button3.Text = "Rozmiar";
            button3.UseVisualStyleBackColor = true;
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
            buttonEditor.Click += buttonEditor_Click;
            // 
            // panelEditor
            // 
            panelEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelEditor.BackColor = Color.Transparent;
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
            pictureBox1.Size = new Size(1011, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
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
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
namespace LabiryntFrontend
{
    partial class parametrForm
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
            this.startYInput = new System.Windows.Forms.TextBox();
            this.startXInput = new System.Windows.Forms.TextBox();
            this.exitList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.exitXInput = new System.Windows.Forms.TextBox();
            this.exitYInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startYInput
            // 
            this.startYInput.Location = new System.Drawing.Point(87, 131);
            this.startYInput.Name = "startYInput";
            this.startYInput.PlaceholderText = "Pozycja startowa y";
            this.startYInput.Size = new System.Drawing.Size(227, 31);
            this.startYInput.TabIndex = 0;
            // 
            // startXInput
            // 
            this.startXInput.Location = new System.Drawing.Point(87, 84);
            this.startXInput.Name = "startXInput";
            this.startXInput.PlaceholderText = "Pozycja startowa x";
            this.startXInput.Size = new System.Drawing.Size(227, 31);
            this.startXInput.TabIndex = 0;
            // 
            // exitList
            // 
            this.exitList.Location = new System.Drawing.Point(87, 212);
            this.exitList.Name = "exitList";
            this.exitList.Size = new System.Drawing.Size(227, 259);
            this.exitList.TabIndex = 1;
            this.exitList.UseCompatibleStateImageBehavior = false;
            this.exitList.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wyjścia z labiryntu";
            // 
            // exitXInput
            // 
            this.exitXInput.Location = new System.Drawing.Point(424, 84);
            this.exitXInput.Name = "exitXInput";
            this.exitXInput.PlaceholderText = "Pozycja wyjścia x";
            this.exitXInput.Size = new System.Drawing.Size(227, 31);
            this.exitXInput.TabIndex = 0;
            // 
            // exitYInput
            // 
            this.exitYInput.Location = new System.Drawing.Point(424, 131);
            this.exitYInput.Name = "exitYInput";
            this.exitYInput.PlaceholderText = "Pozycja wyjścia y";
            this.exitYInput.Size = new System.Drawing.Size(227, 31);
            this.exitYInput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj wyjście";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(599, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Zatwierdź";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // parametrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitList);
            this.Controls.Add(this.exitXInput);
            this.Controls.Add(this.startXInput);
            this.Controls.Add(this.exitYInput);
            this.Controls.Add(this.startYInput);
            this.MaximizeBox = false;
            this.Name = "parametrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parametrForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox startYInput;
        private TextBox startXInput;
        private ListView exitList;
        private Label label1;
        private TextBox exitXInput;
        private TextBox exitYInput;
        private Button button1;
        private Button button2;
    }
}
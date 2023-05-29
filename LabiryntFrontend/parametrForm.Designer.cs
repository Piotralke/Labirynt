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
            startYInput = new TextBox();
            startXInput = new TextBox();
            exitList = new ListView();
            label1 = new Label();
            exitXInput = new TextBox();
            exitYInput = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // startYInput
            // 
            startYInput.Location = new Point(61, 79);
            startYInput.Margin = new Padding(2, 2, 2, 2);
            startYInput.Name = "startYInput";
            startYInput.PlaceholderText = "Pozycja startowa y";
            startYInput.Size = new Size(160, 23);
            startYInput.TabIndex = 0;
            // 
            // startXInput
            // 
            startXInput.Location = new Point(61, 50);
            startXInput.Margin = new Padding(2, 2, 2, 2);
            startXInput.Name = "startXInput";
            startXInput.PlaceholderText = "Pozycja startowa x";
            startXInput.Size = new Size(160, 23);
            startXInput.TabIndex = 0;
            // 
            // exitList
            // 
            exitList.Location = new Point(61, 127);
            exitList.Margin = new Padding(2, 2, 2, 2);
            exitList.Name = "exitList";
            exitList.Size = new Size(160, 157);
            exitList.TabIndex = 1;
            exitList.UseCompatibleStateImageBehavior = false;
            exitList.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 111);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Wyjścia z labiryntu";
            // 
            // exitXInput
            // 
            exitXInput.Location = new Point(297, 50);
            exitXInput.Margin = new Padding(2, 2, 2, 2);
            exitXInput.Name = "exitXInput";
            exitXInput.PlaceholderText = "Pozycja wyjścia x";
            exitXInput.Size = new Size(160, 23);
            exitXInput.TabIndex = 0;
            // 
            // exitYInput
            // 
            exitYInput.Location = new Point(297, 79);
            exitYInput.Margin = new Padding(2, 2, 2, 2);
            exitYInput.Name = "exitYInput";
            exitYInput.PlaceholderText = "Pozycja wyjścia y";
            exitYInput.Size = new Size(160, 23);
            exitYInput.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(312, 111);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(122, 20);
            button1.TabIndex = 3;
            button1.Text = "Dodaj wyjście";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(419, 262);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 4;
            button2.Text = "Zatwierdź";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // parametrForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 303);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(exitList);
            Controls.Add(exitXInput);
            Controls.Add(startXInput);
            Controls.Add(exitYInput);
            Controls.Add(startYInput);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "parametrForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "parametrForm";
            ResumeLayout(false);
            PerformLayout();
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
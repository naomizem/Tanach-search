namespace PL_Tanach
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1327, 282);
            button1.Name = "button1";
            button1.Size = new Size(335, 100);
            button1.TabIndex = 0;
            button1.Text = "GetLoction";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.AccessibleRole = AccessibleRole.Sound;
            textBox1.Location = new Point(1327, 126);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 53);
            textBox1.TabIndex = 1;
            textBox1.Text = "Enter word";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.AccessibleRole = AccessibleRole.Sound;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(130, 126);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1033, 496);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(1327, 413);
            button2.Name = "button2";
            button2.Size = new Size(335, 100);
            button2.TabIndex = 3;
            button2.Text = "GetExcatLoction";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1327, 537);
            button3.Name = "button3";
            button3.Size = new Size(335, 100);
            button3.TabIndex = 4;
            button3.Text = "GetInitials";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1848, 770);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
    }
}

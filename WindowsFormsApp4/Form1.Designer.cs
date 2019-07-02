namespace WindowsFormsApp4
{
    partial class Form1
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
            this.yolla = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.text = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.profileImg = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.individuals = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // yolla
            // 
            this.yolla.Location = new System.Drawing.Point(738, 309);
            this.yolla.Name = "yolla";
            this.yolla.Size = new System.Drawing.Size(86, 57);
            this.yolla.TabIndex = 0;
            this.yolla.Text = "Yolla";
            this.yolla.UseVisualStyleBackColor = true;
            this.yolla.Click += new System.EventHandler(this.yolla_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(233, 326);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(462, 68);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text.Location = new System.Drawing.Point(346, 12);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(59, 24);
            this.text.TabIndex = 4;
            this.text.Text = "selim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profileImg
            // 
            this.profileImg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.profileImg.Location = new System.Drawing.Point(242, 12);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(60, 62);
            this.profileImg.TabIndex = 6;
            this.profileImg.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(233, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(462, 196);
            this.listBox1.TabIndex = 8;
            // 
            // individuals
            // 
            this.individuals.FormattingEnabled = true;
            this.individuals.ItemHeight = 16;
            this.individuals.Location = new System.Drawing.Point(12, 21);
            this.individuals.Name = "individuals";
            this.individuals.Size = new System.Drawing.Size(193, 356);
            this.individuals.TabIndex = 9;
            this.individuals.Click += new System.EventHandler(this.individuals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 413);
            this.Controls.Add(this.individuals);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.profileImg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.yolla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yolla;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox profileImg;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox individuals;
    }
}


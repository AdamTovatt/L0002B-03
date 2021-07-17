
namespace PersonalIdentityValidator
{
    partial class Form1
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
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.SurnameTextbox = new System.Windows.Forms.TextBox();
            this.PersonalIdentityNumberTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.PersonalIdentityNumberLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(225, 57);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(361, 39);
            this.FirstNameTextbox.TabIndex = 0;
            // 
            // SurnameTextbox
            // 
            this.SurnameTextbox.Location = new System.Drawing.Point(225, 130);
            this.SurnameTextbox.Name = "SurnameTextbox";
            this.SurnameTextbox.Size = new System.Drawing.Size(361, 39);
            this.SurnameTextbox.TabIndex = 1;
            // 
            // PersonalIdentityNumberTextbox
            // 
            this.PersonalIdentityNumberTextbox.Location = new System.Drawing.Point(225, 202);
            this.PersonalIdentityNumberTextbox.Name = "PersonalIdentityNumberTextbox";
            this.PersonalIdentityNumberTextbox.Size = new System.Drawing.Size(361, 39);
            this.PersonalIdentityNumberTextbox.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(38, 60);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(114, 32);
            this.FirstNameLabel.TabIndex = 3;
            this.FirstNameLabel.Text = "Förnamn:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(38, 133);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(129, 32);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Efternamn:";
            // 
            // PersonalIdentityNumberLabel
            // 
            this.PersonalIdentityNumberLabel.AutoSize = true;
            this.PersonalIdentityNumberLabel.Location = new System.Drawing.Point(38, 205);
            this.PersonalIdentityNumberLabel.Name = "PersonalIdentityNumberLabel";
            this.PersonalIdentityNumberLabel.Size = new System.Drawing.Size(181, 32);
            this.PersonalIdentityNumberLabel.TabIndex = 5;
            this.PersonalIdentityNumberLabel.Text = "Personnummer:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(38, 318);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(548, 216);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 594);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PersonalIdentityNumberLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.PersonalIdentityNumberTextbox);
            this.Controls.Add(this.SurnameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Name = "Form1";
            this.Text = "Personlig information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.TextBox SurnameTextbox;
        private System.Windows.Forms.TextBox PersonalIdentityNumberTextbox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label PersonalIdentityNumberLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


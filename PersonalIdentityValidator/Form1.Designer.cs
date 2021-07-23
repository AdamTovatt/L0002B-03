
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
            this.OutputTextbox = new System.Windows.Forms.RichTextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(121, 27);
            this.FirstNameTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(196, 23);
            this.FirstNameTextbox.TabIndex = 0;
            // 
            // SurnameTextbox
            // 
            this.SurnameTextbox.Location = new System.Drawing.Point(121, 61);
            this.SurnameTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SurnameTextbox.Name = "SurnameTextbox";
            this.SurnameTextbox.Size = new System.Drawing.Size(196, 23);
            this.SurnameTextbox.TabIndex = 1;
            // 
            // PersonalIdentityNumberTextbox
            // 
            this.PersonalIdentityNumberTextbox.Location = new System.Drawing.Point(121, 95);
            this.PersonalIdentityNumberTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PersonalIdentityNumberTextbox.Name = "PersonalIdentityNumberTextbox";
            this.PersonalIdentityNumberTextbox.Size = new System.Drawing.Size(196, 23);
            this.PersonalIdentityNumberTextbox.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(20, 28);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(58, 15);
            this.FirstNameLabel.TabIndex = 3;
            this.FirstNameLabel.Text = "Förnamn:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(20, 62);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(65, 15);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Efternamn:";
            // 
            // PersonalIdentityNumberLabel
            // 
            this.PersonalIdentityNumberLabel.AutoSize = true;
            this.PersonalIdentityNumberLabel.Location = new System.Drawing.Point(20, 96);
            this.PersonalIdentityNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PersonalIdentityNumberLabel.Name = "PersonalIdentityNumberLabel";
            this.PersonalIdentityNumberLabel.Size = new System.Drawing.Size(92, 15);
            this.PersonalIdentityNumberLabel.TabIndex = 5;
            this.PersonalIdentityNumberLabel.Text = "Personnummer:";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(20, 168);
            this.OutputTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(297, 84);
            this.OutputTextbox.TabIndex = 6;
            this.OutputTextbox.Text = "";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(20, 131);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(297, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Ok";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 278);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.PersonalIdentityNumberLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.PersonalIdentityNumberTextbox);
            this.Controls.Add(this.SurnameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private System.Windows.Forms.RichTextBox OutputTextbox;
        private System.Windows.Forms.Button SubmitButton;
    }
}


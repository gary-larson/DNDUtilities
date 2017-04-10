namespace UICharacterCreation
{
    partial class backstory
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
            this.backstoryTextBox = new System.Windows.Forms.TextBox();
            this.submitBackstoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backstoryTextBox
            // 
            this.backstoryTextBox.Location = new System.Drawing.Point(12, 12);
            this.backstoryTextBox.Multiline = true;
            this.backstoryTextBox.Name = "backstoryTextBox";
            this.backstoryTextBox.Size = new System.Drawing.Size(460, 408);
            this.backstoryTextBox.TabIndex = 0;
            // 
            // submitBackstoryButton
            // 
            this.submitBackstoryButton.Location = new System.Drawing.Point(397, 426);
            this.submitBackstoryButton.Name = "submitBackstoryButton";
            this.submitBackstoryButton.Size = new System.Drawing.Size(75, 23);
            this.submitBackstoryButton.TabIndex = 1;
            this.submitBackstoryButton.Text = "Submit";
            this.submitBackstoryButton.UseVisualStyleBackColor = true;
            this.submitBackstoryButton.Click += new System.EventHandler(this.submitBackstoryButton_Click);
            // 
            // backstory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.submitBackstoryButton);
            this.Controls.Add(this.backstoryTextBox);
            this.Name = "backstory";
            this.Text = "Character Backstory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox backstoryTextBox;
        private System.Windows.Forms.Button submitBackstoryButton;
    }
}
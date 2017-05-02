namespace UICharacterCreation
{
    partial class viewSelector
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
            this.characterList = new System.Windows.Forms.ComboBox();
            this.viewCharacterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // characterList
            // 
            this.characterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterList.FormattingEnabled = true;
            this.characterList.Location = new System.Drawing.Point(70, 62);
            this.characterList.Name = "characterList";
            this.characterList.Size = new System.Drawing.Size(121, 21);
            this.characterList.TabIndex = 0;
            // 
            // viewCharacterButton
            // 
            this.viewCharacterButton.Location = new System.Drawing.Point(88, 145);
            this.viewCharacterButton.Name = "viewCharacterButton";
            this.viewCharacterButton.Size = new System.Drawing.Size(75, 23);
            this.viewCharacterButton.TabIndex = 1;
            this.viewCharacterButton.Text = "View!";
            this.viewCharacterButton.UseVisualStyleBackColor = true;
            this.viewCharacterButton.Click += new System.EventHandler(this.viewCharacterButton_Click);
            // 
            // viewSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.viewCharacterButton);
            this.Controls.Add(this.characterList);
            this.Name = "viewSelector";
            this.Text = "viewSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox characterList;
        private System.Windows.Forms.Button viewCharacterButton;
    }
}
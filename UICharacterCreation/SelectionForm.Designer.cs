namespace UICharacterCreation
{
    partial class SelectionForm
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
            this.selectedFunction = new System.Windows.Forms.ComboBox();
            this.CreationButton = new System.Windows.Forms.Button();
            this.DirectiveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectedFunction
            // 
            this.selectedFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedFunction.FormattingEnabled = true;
            this.selectedFunction.Items.AddRange(new object[] {
            "New Character",
            "Edit Character",
            "View Character"});
            this.selectedFunction.Location = new System.Drawing.Point(57, 65);
            this.selectedFunction.Name = "selectedFunction";
            this.selectedFunction.Size = new System.Drawing.Size(121, 21);
            this.selectedFunction.TabIndex = 0;
            // 
            // CreationButton
            // 
            this.CreationButton.Location = new System.Drawing.Point(57, 103);
            this.CreationButton.Name = "CreationButton";
            this.CreationButton.Size = new System.Drawing.Size(121, 23);
            this.CreationButton.TabIndex = 1;
            this.CreationButton.Text = "Begin!";
            this.CreationButton.UseVisualStyleBackColor = true;
            this.CreationButton.Click += new System.EventHandler(this.CreationButton_Click);
            // 
            // DirectiveLabel
            // 
            this.DirectiveLabel.AutoSize = true;
            this.DirectiveLabel.Location = new System.Drawing.Point(54, 26);
            this.DirectiveLabel.Name = "DirectiveLabel";
            this.DirectiveLabel.Size = new System.Drawing.Size(138, 13);
            this.DirectiveLabel.TabIndex = 2;
            this.DirectiveLabel.Text = "What would you like to Do?";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.DirectiveLabel);
            this.Controls.Add(this.CreationButton);
            this.Controls.Add(this.selectedFunction);
            this.Name = "SelectionForm";
            this.Text = "DNDUtilities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectedFunction;
        private System.Windows.Forms.Button CreationButton;
        private System.Windows.Forms.Label DirectiveLabel;
    }
}


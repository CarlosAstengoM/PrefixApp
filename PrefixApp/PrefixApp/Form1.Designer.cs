namespace PrefixApp
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
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.prefixButton = new System.Windows.Forms.Button();
            this.suffixBtn = new System.Windows.Forms.Button();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(16, 13);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(341, 23);
            this.folderTextBox.TabIndex = 0;
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(16, 62);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(210, 23);
            this.prefixTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(330, 13);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(27, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // prefixButton
            // 
            this.prefixButton.Location = new System.Drawing.Point(247, 62);
            this.prefixButton.Name = "prefixButton";
            this.prefixButton.Size = new System.Drawing.Size(116, 23);
            this.prefixButton.TabIndex = 3;
            this.prefixButton.Text = "Add Prefix";
            this.prefixButton.UseVisualStyleBackColor = true;
            this.prefixButton.Click += new System.EventHandler(this.prefixButton_Click);
            // 
            // suffixBtn
            // 
            this.suffixBtn.Location = new System.Drawing.Point(247, 91);
            this.suffixBtn.Name = "suffixBtn";
            this.suffixBtn.Size = new System.Drawing.Size(116, 23);
            this.suffixBtn.TabIndex = 5;
            this.suffixBtn.Text = "Add Suffix";
            this.suffixBtn.UseVisualStyleBackColor = true;
            this.suffixBtn.Click += new System.EventHandler(this.suffixBtn_Click);
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Location = new System.Drawing.Point(16, 91);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(210, 23);
            this.suffixTextBox.TabIndex = 4;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(16, 130);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(107, 23);
            this.searchTextBox.TabIndex = 6;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(129, 129);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(116, 23);
            this.replaceButton.TabIndex = 7;
            this.replaceButton.Text = "Replace With";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(251, 129);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(107, 23);
            this.replaceTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 176);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.suffixBtn);
            this.Controls.Add(this.suffixTextBox);
            this.Controls.Add(this.prefixButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.folderTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox folderTextBox;
        private TextBox prefixTextBox;
        private Button browseButton;
        private Button prefixButton;
        private Button suffixBtn;
        private TextBox suffixTextBox;
        private TextBox searchTextBox;
        private Button replaceButton;
        private TextBox replaceTextBox;
    }
}
namespace MasterManagementTool
{
    partial class MasterSelectionForm
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
            this.AuthorMasterButton = new System.Windows.Forms.Button();
            this.GenreMasterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthorMasterButton
            // 
            this.AuthorMasterButton.Location = new System.Drawing.Point(65, 53);
            this.AuthorMasterButton.Name = "AuthorMasterButton";
            this.AuthorMasterButton.Size = new System.Drawing.Size(100, 30);
            this.AuthorMasterButton.TabIndex = 0;
            this.AuthorMasterButton.Text = "著者マスタ";
            this.AuthorMasterButton.UseVisualStyleBackColor = true;
            this.AuthorMasterButton.Click += new System.EventHandler(this.AuthorMasterButton_Click);
            // 
            // GenreMasterButton
            // 
            this.GenreMasterButton.Location = new System.Drawing.Point(65, 121);
            this.GenreMasterButton.Name = "GenreMasterButton";
            this.GenreMasterButton.Size = new System.Drawing.Size(100, 30);
            this.GenreMasterButton.TabIndex = 1;
            this.GenreMasterButton.Text = "ジャンルマスタ";
            this.GenreMasterButton.UseVisualStyleBackColor = true;
            this.GenreMasterButton.Click += new System.EventHandler(this.GenreMasterButton_Click);
            // 
            // MasterSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.GenreMasterButton);
            this.Controls.Add(this.AuthorMasterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "マスタ選択";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AuthorMasterButton;
        private System.Windows.Forms.Button GenreMasterButton;
    }
}


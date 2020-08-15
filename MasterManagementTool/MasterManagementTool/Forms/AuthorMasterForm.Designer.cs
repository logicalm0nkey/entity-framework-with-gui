namespace MasterManagementTool.Forms
{
    partial class AuthorMasterForm
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
            this.AuthorOperationTabControl = new System.Windows.Forms.TabControl();
            this.RegisterTab = new System.Windows.Forms.TabPage();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.NameTextBoxOfRegister = new System.Windows.Forms.TextBox();
            this.NameLabelOfRegister = new System.Windows.Forms.Label();
            this.UpdateTab = new System.Windows.Forms.TabPage();
            this.IdComboBoxOfUpdate = new System.Windows.Forms.ComboBox();
            this.IdLabelOfUpdate = new System.Windows.Forms.Label();
            this.NameLabelOfUpdate = new System.Windows.Forms.Label();
            this.NameTextBoxOfUpdate = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteTab = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NameTextBoxOfDelete = new System.Windows.Forms.TextBox();
            this.NameLabelOfDelete = new System.Windows.Forms.Label();
            this.IdComboBoxOfDelete = new System.Windows.Forms.ComboBox();
            this.IdLabelOfDelete = new System.Windows.Forms.Label();
            this.AuthorOperationTabControl.SuspendLayout();
            this.RegisterTab.SuspendLayout();
            this.UpdateTab.SuspendLayout();
            this.DeleteTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorOperationTabControl
            // 
            this.AuthorOperationTabControl.Controls.Add(this.RegisterTab);
            this.AuthorOperationTabControl.Controls.Add(this.UpdateTab);
            this.AuthorOperationTabControl.Controls.Add(this.DeleteTab);
            this.AuthorOperationTabControl.Location = new System.Drawing.Point(13, 12);
            this.AuthorOperationTabControl.Name = "AuthorOperationTabControl";
            this.AuthorOperationTabControl.SelectedIndex = 2;
            this.AuthorOperationTabControl.Size = new System.Drawing.Size(260, 237);
            this.AuthorOperationTabControl.TabIndex = 0;
            // 
            // RegisterTab
            // 
            this.RegisterTab.Controls.Add(this.RegisterButton);
            this.RegisterTab.Controls.Add(this.NameTextBoxOfRegister);
            this.RegisterTab.Controls.Add(this.NameLabelOfRegister);
            this.RegisterTab.Location = new System.Drawing.Point(4, 24);
            this.RegisterTab.Name = "RegisterTab";
            this.RegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterTab.Size = new System.Drawing.Size(252, 209);
            this.RegisterTab.TabIndex = 0;
            this.RegisterTab.Text = "登録";
            this.RegisterTab.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(143, 160);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 25);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "登録";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // NameTextBoxOfRegister
            // 
            this.NameTextBoxOfRegister.Location = new System.Drawing.Point(22, 41);
            this.NameTextBoxOfRegister.Name = "NameTextBoxOfRegister";
            this.NameTextBoxOfRegister.Size = new System.Drawing.Size(200, 23);
            this.NameTextBoxOfRegister.TabIndex = 1;
            // 
            // NameLabelOfRegister
            // 
            this.NameLabelOfRegister.AutoSize = true;
            this.NameLabelOfRegister.Location = new System.Drawing.Point(22, 23);
            this.NameLabelOfRegister.Name = "NameLabelOfRegister";
            this.NameLabelOfRegister.Size = new System.Drawing.Size(31, 15);
            this.NameLabelOfRegister.TabIndex = 0;
            this.NameLabelOfRegister.Text = "名前";
            // 
            // UpdateTab
            // 
            this.UpdateTab.Controls.Add(this.IdComboBoxOfUpdate);
            this.UpdateTab.Controls.Add(this.IdLabelOfUpdate);
            this.UpdateTab.Controls.Add(this.NameLabelOfUpdate);
            this.UpdateTab.Controls.Add(this.NameTextBoxOfUpdate);
            this.UpdateTab.Controls.Add(this.UpdateButton);
            this.UpdateTab.Location = new System.Drawing.Point(4, 24);
            this.UpdateTab.Name = "UpdateTab";
            this.UpdateTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTab.Size = new System.Drawing.Size(252, 209);
            this.UpdateTab.TabIndex = 1;
            this.UpdateTab.Text = "更新";
            this.UpdateTab.UseVisualStyleBackColor = true;
            // 
            // IdComboBoxOfUpdate
            // 
            this.IdComboBoxOfUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdComboBoxOfUpdate.FormattingEnabled = true;
            this.IdComboBoxOfUpdate.Location = new System.Drawing.Point(23, 39);
            this.IdComboBoxOfUpdate.Name = "IdComboBoxOfUpdate";
            this.IdComboBoxOfUpdate.Size = new System.Drawing.Size(200, 23);
            this.IdComboBoxOfUpdate.TabIndex = 3;
            // 
            // IdLabelOfUpdate
            // 
            this.IdLabelOfUpdate.AutoSize = true;
            this.IdLabelOfUpdate.Location = new System.Drawing.Point(23, 21);
            this.IdLabelOfUpdate.Name = "IdLabelOfUpdate";
            this.IdLabelOfUpdate.Size = new System.Drawing.Size(18, 15);
            this.IdLabelOfUpdate.TabIndex = 3;
            this.IdLabelOfUpdate.Text = "ID";
            // 
            // NameLabelOfUpdate
            // 
            this.NameLabelOfUpdate.AutoSize = true;
            this.NameLabelOfUpdate.Location = new System.Drawing.Point(23, 79);
            this.NameLabelOfUpdate.Name = "NameLabelOfUpdate";
            this.NameLabelOfUpdate.Size = new System.Drawing.Size(31, 15);
            this.NameLabelOfUpdate.TabIndex = 0;
            this.NameLabelOfUpdate.Text = "名前";
            // 
            // NameTextBoxOfUpdate
            // 
            this.NameTextBoxOfUpdate.Location = new System.Drawing.Point(23, 97);
            this.NameTextBoxOfUpdate.Name = "NameTextBoxOfUpdate";
            this.NameTextBoxOfUpdate.Size = new System.Drawing.Size(200, 23);
            this.NameTextBoxOfUpdate.TabIndex = 4;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(145, 161);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 25);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "更新";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteTab
            // 
            this.DeleteTab.Controls.Add(this.DeleteButton);
            this.DeleteTab.Controls.Add(this.NameTextBoxOfDelete);
            this.DeleteTab.Controls.Add(this.NameLabelOfDelete);
            this.DeleteTab.Controls.Add(this.IdComboBoxOfDelete);
            this.DeleteTab.Controls.Add(this.IdLabelOfDelete);
            this.DeleteTab.Location = new System.Drawing.Point(4, 24);
            this.DeleteTab.Name = "DeleteTab";
            this.DeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteTab.Size = new System.Drawing.Size(252, 209);
            this.DeleteTab.TabIndex = 2;
            this.DeleteTab.Text = "削除";
            this.DeleteTab.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(145, 161);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 25);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // NameTextBoxOfDelete
            // 
            this.NameTextBoxOfDelete.Location = new System.Drawing.Point(23, 97);
            this.NameTextBoxOfDelete.Name = "NameTextBoxOfDelete";
            this.NameTextBoxOfDelete.ReadOnly = true;
            this.NameTextBoxOfDelete.Size = new System.Drawing.Size(200, 23);
            this.NameTextBoxOfDelete.TabIndex = 7;
            // 
            // NameLabelOfDelete
            // 
            this.NameLabelOfDelete.AutoSize = true;
            this.NameLabelOfDelete.Location = new System.Drawing.Point(23, 79);
            this.NameLabelOfDelete.Name = "NameLabelOfDelete";
            this.NameLabelOfDelete.Size = new System.Drawing.Size(31, 15);
            this.NameLabelOfDelete.TabIndex = 0;
            this.NameLabelOfDelete.Text = "名前";
            // 
            // IdComboBoxOfDelete
            // 
            this.IdComboBoxOfDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdComboBoxOfDelete.FormattingEnabled = true;
            this.IdComboBoxOfDelete.Location = new System.Drawing.Point(23, 39);
            this.IdComboBoxOfDelete.Name = "IdComboBoxOfDelete";
            this.IdComboBoxOfDelete.Size = new System.Drawing.Size(200, 23);
            this.IdComboBoxOfDelete.TabIndex = 6;
            // 
            // IdLabelOfDelete
            // 
            this.IdLabelOfDelete.AutoSize = true;
            this.IdLabelOfDelete.Location = new System.Drawing.Point(23, 21);
            this.IdLabelOfDelete.Name = "IdLabelOfDelete";
            this.IdLabelOfDelete.Size = new System.Drawing.Size(18, 15);
            this.IdLabelOfDelete.TabIndex = 3;
            this.IdLabelOfDelete.Text = "ID";
            // 
            // AuthorMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AuthorOperationTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "著者マスタ";
            this.Load += new System.EventHandler(this.AuthorMasterForm_Load);
            this.AuthorOperationTabControl.ResumeLayout(false);
            this.RegisterTab.ResumeLayout(false);
            this.RegisterTab.PerformLayout();
            this.UpdateTab.ResumeLayout(false);
            this.UpdateTab.PerformLayout();
            this.DeleteTab.ResumeLayout(false);
            this.DeleteTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AuthorOperationTabControl;
        private System.Windows.Forms.TabPage RegisterTab;
        private System.Windows.Forms.TabPage UpdateTab;
        private System.Windows.Forms.TabPage DeleteTab;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox NameTextBoxOfRegister;
        private System.Windows.Forms.Label NameLabelOfRegister;
        private System.Windows.Forms.Label NameLabelOfUpdate;
        private System.Windows.Forms.TextBox NameTextBoxOfUpdate;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label IdLabelOfUpdate;
        private System.Windows.Forms.ComboBox IdComboBoxOfUpdate;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox NameTextBoxOfDelete;
        private System.Windows.Forms.Label NameLabelOfDelete;
        private System.Windows.Forms.ComboBox IdComboBoxOfDelete;
        private System.Windows.Forms.Label IdLabelOfDelete;
    }
}
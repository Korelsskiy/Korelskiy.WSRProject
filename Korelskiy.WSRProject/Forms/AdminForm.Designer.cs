
namespace Korelskiy.WSRProject
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeLabel = new System.Windows.Forms.Label();
            this.selectOfficeComboBox = new System.Windows.Forms.ComboBox();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.changeRoleButton = new System.Windows.Forms.Button();
            this.loginControlButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(907, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Location = new System.Drawing.Point(53, 70);
            this.officeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(63, 25);
            this.officeLabel.TabIndex = 1;
            this.officeLabel.Text = "Office";
            // 
            // selectOfficeComboBox
            // 
            this.selectOfficeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectOfficeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectOfficeComboBox.FormattingEnabled = true;
            this.selectOfficeComboBox.Items.AddRange(new object[] {
            "All Offices"});
            this.selectOfficeComboBox.Location = new System.Drawing.Point(189, 62);
            this.selectOfficeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectOfficeComboBox.Name = "selectOfficeComboBox";
            this.selectOfficeComboBox.Size = new System.Drawing.Size(216, 33);
            this.selectOfficeComboBox.TabIndex = 2;
            this.selectOfficeComboBox.SelectedIndexChanged += new System.EventHandler(this.selectOfficeComboBox_SelectedIndexChanged);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(58, 120);
            this.usersDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usersDataGridView.MultiSelect = false;
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(805, 329);
            this.usersDataGridView.TabIndex = 3;
            // 
            // changeRoleButton
            // 
            this.changeRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeRoleButton.Location = new System.Drawing.Point(58, 486);
            this.changeRoleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeRoleButton.Name = "changeRoleButton";
            this.changeRoleButton.Size = new System.Drawing.Size(328, 69);
            this.changeRoleButton.TabIndex = 4;
            this.changeRoleButton.Text = "Change Role";
            this.changeRoleButton.UseVisualStyleBackColor = true;
            this.changeRoleButton.Click += new System.EventHandler(this.changeRoleButton_Click);
            // 
            // loginControlButton
            // 
            this.loginControlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginControlButton.Location = new System.Drawing.Point(545, 486);
            this.loginControlButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginControlButton.Name = "loginControlButton";
            this.loginControlButton.Size = new System.Drawing.Size(318, 69);
            this.loginControlButton.TabIndex = 5;
            this.loginControlButton.Text = "Enable/DisableLogin";
            this.loginControlButton.UseVisualStyleBackColor = true;
            this.loginControlButton.Click += new System.EventHandler(this.loginControlButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 620);
            this.Controls.Add(this.loginControlButton);
            this.Controls.Add(this.changeRoleButton);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.selectOfficeComboBox);
            this.Controls.Add(this.officeLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "AMONIC Airlines Automation System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Shown += new System.EventHandler(this.AdminForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.ComboBox selectOfficeComboBox;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Button changeRoleButton;
        private System.Windows.Forms.Button loginControlButton;
    }
}
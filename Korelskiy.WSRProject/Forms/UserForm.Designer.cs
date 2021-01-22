
namespace Korelskiy.WSRProject
{
    partial class UserForm
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeTextLabel = new System.Windows.Forms.Label();
            this.timeSpentLabel = new System.Windows.Forms.Label();
            this.numberOfCrashesLabel = new System.Windows.Forms.Label();
            this.userFormDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFormDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // welcomeTextLabel
            // 
            this.welcomeTextLabel.AutoSize = true;
            this.welcomeTextLabel.Location = new System.Drawing.Point(46, 64);
            this.welcomeTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeTextLabel.Name = "welcomeTextLabel";
            this.welcomeTextLabel.Size = new System.Drawing.Size(0, 25);
            this.welcomeTextLabel.TabIndex = 2;
            // 
            // timeSpentLabel
            // 
            this.timeSpentLabel.AutoSize = true;
            this.timeSpentLabel.Location = new System.Drawing.Point(278, 127);
            this.timeSpentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeSpentLabel.Name = "timeSpentLabel";
            this.timeSpentLabel.Size = new System.Drawing.Size(0, 25);
            this.timeSpentLabel.TabIndex = 3;
            // 
            // numberOfCrashesLabel
            // 
            this.numberOfCrashesLabel.AutoSize = true;
            this.numberOfCrashesLabel.Location = new System.Drawing.Point(664, 127);
            this.numberOfCrashesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfCrashesLabel.Name = "numberOfCrashesLabel";
            this.numberOfCrashesLabel.Size = new System.Drawing.Size(0, 25);
            this.numberOfCrashesLabel.TabIndex = 4;
            // 
            // userFormDataGridView
            // 
            this.userFormDataGridView.AllowUserToAddRows = false;
            this.userFormDataGridView.AllowUserToDeleteRows = false;
            this.userFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userFormDataGridView.Location = new System.Drawing.Point(42, 205);
            this.userFormDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userFormDataGridView.Name = "userFormDataGridView";
            this.userFormDataGridView.ReadOnly = true;
            this.userFormDataGridView.RowHeadersWidth = 51;
            this.userFormDataGridView.RowTemplate.Height = 24;
            this.userFormDataGridView.Size = new System.Drawing.Size(1122, 456);
            this.userFormDataGridView.TabIndex = 5;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.userFormDataGridView);
            this.Controls.Add(this.numberOfCrashesLabel);
            this.Controls.Add(this.timeSpentLabel);
            this.Controls.Add(this.welcomeTextLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserForm";
            this.Text = "AMONIC Airlines Automation System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFormDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeTextLabel;
        private System.Windows.Forms.Label timeSpentLabel;
        private System.Windows.Forms.Label numberOfCrashesLabel;
        private System.Windows.Forms.DataGridView userFormDataGridView;
    }
}
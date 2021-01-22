
namespace Korelskiy.WSRProject
{
    partial class EditRoleForm
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
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.selectOfficeComboBox = new System.Windows.Forms.ComboBox();
            this.officeLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.userRadioButton = new System.Windows.Forms.RadioButton();
            this.administratorRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(258, 238);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(378, 30);
            this.lastNameTextBox.TabIndex = 11;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(138, 242);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(103, 25);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(258, 136);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(378, 30);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(138, 136);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(103, 25);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "First name";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(258, 55);
            this.emailAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(378, 30);
            this.emailAddressTextBox.TabIndex = 7;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(110, 55);
            this.emailAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(135, 25);
            this.emailAddressLabel.TabIndex = 6;
            this.emailAddressLabel.Text = "Email address";
            // 
            // selectOfficeComboBox
            // 
            this.selectOfficeComboBox.FormattingEnabled = true;
            this.selectOfficeComboBox.Location = new System.Drawing.Point(258, 331);
            this.selectOfficeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectOfficeComboBox.Name = "selectOfficeComboBox";
            this.selectOfficeComboBox.Size = new System.Drawing.Size(378, 33);
            this.selectOfficeComboBox.TabIndex = 13;
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Location = new System.Drawing.Point(180, 336);
            this.officeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(63, 25);
            this.officeLabel.TabIndex = 12;
            this.officeLabel.Text = "Office";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(165, 456);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(51, 25);
            this.roleLabel.TabIndex = 14;
            this.roleLabel.Text = "Role";
            // 
            // userRadioButton
            // 
            this.userRadioButton.AutoSize = true;
            this.userRadioButton.Location = new System.Drawing.Point(321, 456);
            this.userRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Size = new System.Drawing.Size(74, 29);
            this.userRadioButton.TabIndex = 15;
            this.userRadioButton.TabStop = true;
            this.userRadioButton.Text = "User";
            this.userRadioButton.UseVisualStyleBackColor = true;
            this.userRadioButton.CheckedChanged += new System.EventHandler(this.userRadioButton_CheckedChanged);
            // 
            // administratorRadioButton
            // 
            this.administratorRadioButton.AutoSize = true;
            this.administratorRadioButton.Location = new System.Drawing.Point(321, 498);
            this.administratorRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.administratorRadioButton.Name = "administratorRadioButton";
            this.administratorRadioButton.Size = new System.Drawing.Size(147, 29);
            this.administratorRadioButton.TabIndex = 16;
            this.administratorRadioButton.TabStop = true;
            this.administratorRadioButton.Text = "Administrator";
            this.administratorRadioButton.UseVisualStyleBackColor = true;
            this.administratorRadioButton.CheckedChanged += new System.EventHandler(this.administratorRadioButton_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(394, 592);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(216, 56);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(158, 592);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(216, 56);
            this.applyButton.TabIndex = 17;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // EditRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 703);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.administratorRadioButton);
            this.Controls.Add(this.userRadioButton);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.selectOfficeComboBox);
            this.Controls.Add(this.officeLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.emailAddressLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditRoleForm";
            this.Text = "Edit Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.ComboBox selectOfficeComboBox;
        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.RadioButton userRadioButton;
        private System.Windows.Forms.RadioButton administratorRadioButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
    }
}
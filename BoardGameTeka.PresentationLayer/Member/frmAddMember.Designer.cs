namespace BoardGameTeka.PresentationLayer.Member
{
    partial class frmAddMember
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
            this.comboBoxMembershipType = new System.Windows.Forms.ComboBox();
            this.labelMembershipType = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMembershipType
            // 
            this.comboBoxMembershipType.FormattingEnabled = true;
            this.comboBoxMembershipType.Location = new System.Drawing.Point(146, 32);
            this.comboBoxMembershipType.Name = "comboBoxMembershipType";
            this.comboBoxMembershipType.Size = new System.Drawing.Size(176, 21);
            this.comboBoxMembershipType.TabIndex = 41;
            // 
            // labelMembershipType
            // 
            this.labelMembershipType.AutoSize = true;
            this.labelMembershipType.Location = new System.Drawing.Point(29, 35);
            this.labelMembershipType.Name = "labelMembershipType";
            this.labelMembershipType.Size = new System.Drawing.Size(93, 13);
            this.labelMembershipType.TabIndex = 40;
            this.labelMembershipType.Text = "Membership type :";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(146, 59);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(176, 20);
            this.textBoxPhoneNumber.TabIndex = 36;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(146, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(283, 20);
            this.textBoxName.TabIndex = 35;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(29, 62);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(82, 13);
            this.labelPhoneNumber.TabIndex = 32;
            this.labelPhoneNumber.Text = "Phone number :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 31;
            this.labelName.Text = "Name :";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(354, 94);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddMember.Location = new System.Drawing.Point(146, 94);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(115, 23);
            this.buttonAddMember.TabIndex = 29;
            this.buttonAddMember.Text = "Add member";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            // 
            // frmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 142);
            this.Controls.Add(this.comboBoxMembershipType);
            this.Controls.Add(this.labelMembershipType);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddMember);
            this.Name = "frmAddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddMember";
            this.Load += new System.EventHandler(this.frmAddMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMembershipType;
        private System.Windows.Forms.Label labelMembershipType;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddMember;
    }
}
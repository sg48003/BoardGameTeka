namespace BoardGameTeka.PresentationLayer
{
    partial class frmMainWindow
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
            this.newRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewActiveRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBoardGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBoardGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRentalToolStripMenuItem,
            this.boardGamesToolStripMenuItem,
            this.membersToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newRentalToolStripMenuItem
            // 
            this.newRentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewActiveRentalsToolStripMenuItem,
            this.addRentalToolStripMenuItem});
            this.newRentalToolStripMenuItem.Name = "newRentalToolStripMenuItem";
            this.newRentalToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.newRentalToolStripMenuItem.Text = "Rentals";
            // 
            // viewActiveRentalsToolStripMenuItem
            // 
            this.viewActiveRentalsToolStripMenuItem.Name = "viewActiveRentalsToolStripMenuItem";
            this.viewActiveRentalsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewActiveRentalsToolStripMenuItem.Text = "View active rentals";
            this.viewActiveRentalsToolStripMenuItem.Click += new System.EventHandler(this.viewActiveRentalsToolStripMenuItem_Click);
            // 
            // addRentalToolStripMenuItem
            // 
            this.addRentalToolStripMenuItem.Name = "addRentalToolStripMenuItem";
            this.addRentalToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addRentalToolStripMenuItem.Text = "Add rental";
            this.addRentalToolStripMenuItem.Click += new System.EventHandler(this.addRentalToolStripMenuItem_Click);
            // 
            // boardGamesToolStripMenuItem
            // 
            this.boardGamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBoardGamesToolStripMenuItem,
            this.addBoardGameToolStripMenuItem});
            this.boardGamesToolStripMenuItem.Name = "boardGamesToolStripMenuItem";
            this.boardGamesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.boardGamesToolStripMenuItem.Text = "Board games";
            // 
            // viewBoardGamesToolStripMenuItem
            // 
            this.viewBoardGamesToolStripMenuItem.Name = "viewBoardGamesToolStripMenuItem";
            this.viewBoardGamesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewBoardGamesToolStripMenuItem.Text = "View board games";
            this.viewBoardGamesToolStripMenuItem.Click += new System.EventHandler(this.viewBoardGamesToolStripMenuItem_Click);
            // 
            // addBoardGameToolStripMenuItem
            // 
            this.addBoardGameToolStripMenuItem.Name = "addBoardGameToolStripMenuItem";
            this.addBoardGameToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addBoardGameToolStripMenuItem.Text = "Add board game";
            this.addBoardGameToolStripMenuItem.Click += new System.EventHandler(this.addBoardGameToolStripMenuItem_Click);
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMembersToolStripMenuItem,
            this.addMemberToolStripMenuItem});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // viewMembersToolStripMenuItem
            // 
            this.viewMembersToolStripMenuItem.Name = "viewMembersToolStripMenuItem";
            this.viewMembersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewMembersToolStripMenuItem.Text = "View members";
            this.viewMembersToolStripMenuItem.Click += new System.EventHandler(this.viewMembersToolStripMenuItem_Click);
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addMemberToolStripMenuItem.Text = "Add member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeesToolStripMenuItem,
            this.addEmployeeToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.viewEmployeesToolStripMenuItem.Text = "View employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeesToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 401);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainWindow_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boardGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBoardGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBoardGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewActiveRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalToolStripMenuItem;
    }
}
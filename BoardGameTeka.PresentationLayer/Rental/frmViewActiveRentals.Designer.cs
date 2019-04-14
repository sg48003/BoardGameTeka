namespace BoardGameTeka.PresentationLayer.Rental
{
    partial class frmViewActiveRentals
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
            this.components = new System.ComponentModel.Container();
            this.buttonAddRental = new System.Windows.Forms.Button();
            this.dataGridViewActiveRentals = new System.Windows.Forms.DataGridView();
            this.rentalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardGamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeRentalViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonReturnRental = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveRentals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeRentalViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddRental
            // 
            this.buttonAddRental.Location = new System.Drawing.Point(374, 198);
            this.buttonAddRental.Name = "buttonAddRental";
            this.buttonAddRental.Size = new System.Drawing.Size(155, 23);
            this.buttonAddRental.TabIndex = 15;
            this.buttonAddRental.Text = "Add rental";
            this.buttonAddRental.UseVisualStyleBackColor = true;
            this.buttonAddRental.Click += new System.EventHandler(this.buttonAddRental_Click);
            // 
            // dataGridViewActiveRentals
            // 
            this.dataGridViewActiveRentals.AllowUserToAddRows = false;
            this.dataGridViewActiveRentals.AllowUserToDeleteRows = false;
            this.dataGridViewActiveRentals.AutoGenerateColumns = false;
            this.dataGridViewActiveRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActiveRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveRentals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalIdDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.boardGamesDataGridViewTextBoxColumn,
            this.employeeUsernameDataGridViewTextBoxColumn,
            this.dateRentedDataGridViewTextBoxColumn});
            this.dataGridViewActiveRentals.DataSource = this.activeRentalViewBindingSource;
            this.dataGridViewActiveRentals.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewActiveRentals.Name = "dataGridViewActiveRentals";
            this.dataGridViewActiveRentals.ReadOnly = true;
            this.dataGridViewActiveRentals.Size = new System.Drawing.Size(668, 180);
            this.dataGridViewActiveRentals.TabIndex = 14;
            // 
            // rentalIdDataGridViewTextBoxColumn
            // 
            this.rentalIdDataGridViewTextBoxColumn.DataPropertyName = "RentalId";
            this.rentalIdDataGridViewTextBoxColumn.HeaderText = "RentalId";
            this.rentalIdDataGridViewTextBoxColumn.Name = "rentalIdDataGridViewTextBoxColumn";
            this.rentalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentalIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "Member";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boardGamesDataGridViewTextBoxColumn
            // 
            this.boardGamesDataGridViewTextBoxColumn.DataPropertyName = "BoardGames";
            this.boardGamesDataGridViewTextBoxColumn.HeaderText = "Board games";
            this.boardGamesDataGridViewTextBoxColumn.Name = "boardGamesDataGridViewTextBoxColumn";
            this.boardGamesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeUsernameDataGridViewTextBoxColumn
            // 
            this.employeeUsernameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeUsername";
            this.employeeUsernameDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeUsernameDataGridViewTextBoxColumn.Name = "employeeUsernameDataGridViewTextBoxColumn";
            this.employeeUsernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateRentedDataGridViewTextBoxColumn
            // 
            this.dateRentedDataGridViewTextBoxColumn.DataPropertyName = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.HeaderText = "Date rented";
            this.dateRentedDataGridViewTextBoxColumn.Name = "dateRentedDataGridViewTextBoxColumn";
            this.dateRentedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeRentalViewBindingSource
            // 
            this.activeRentalViewBindingSource.DataSource = typeof(BoardGameTeka.PresentationLayer.Rental.ActiveRentalView);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(568, 198);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(112, 23);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonReturnRental
            // 
            this.buttonReturnRental.Location = new System.Drawing.Point(12, 198);
            this.buttonReturnRental.Name = "buttonReturnRental";
            this.buttonReturnRental.Size = new System.Drawing.Size(155, 23);
            this.buttonReturnRental.TabIndex = 16;
            this.buttonReturnRental.Text = "Return rental";
            this.buttonReturnRental.UseVisualStyleBackColor = true;
            this.buttonReturnRental.Click += new System.EventHandler(this.buttonReturnRental_Click);
            // 
            // frmViewActiveRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 242);
            this.Controls.Add(this.buttonReturnRental);
            this.Controls.Add(this.buttonAddRental);
            this.Controls.Add(this.dataGridViewActiveRentals);
            this.Controls.Add(this.buttonClose);
            this.Name = "frmViewActiveRentals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmViewActiveRentals";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveRentals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeRentalViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddRental;
        private System.Windows.Forms.DataGridView dataGridViewActiveRentals;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardGamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource activeRentalViewBindingSource;
        private System.Windows.Forms.Button buttonReturnRental;
    }
}
namespace BoardGameTeka.PresentationLayer.Member
{
    partial class frmRentalHistory
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
            this.dataGridViewRentalHistory = new System.Windows.Forms.DataGridView();
            this.rentalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalHistoryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentalHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalHistoryViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRentalHistory
            // 
            this.dataGridViewRentalHistory.AllowUserToAddRows = false;
            this.dataGridViewRentalHistory.AllowUserToDeleteRows = false;
            this.dataGridViewRentalHistory.AutoGenerateColumns = false;
            this.dataGridViewRentalHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRentalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewRentalHistory.DataSource = this.rentalHistoryViewBindingSource;
            this.dataGridViewRentalHistory.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRentalHistory.Name = "dataGridViewRentalHistory";
            this.dataGridViewRentalHistory.ReadOnly = true;
            this.dataGridViewRentalHistory.Size = new System.Drawing.Size(651, 195);
            this.dataGridViewRentalHistory.TabIndex = 0;
            // 
            // rentalIdDataGridViewTextBoxColumn
            // 
            this.rentalIdDataGridViewTextBoxColumn.DataPropertyName = "RentalId";
            this.rentalIdDataGridViewTextBoxColumn.HeaderText = "RentalId";
            this.rentalIdDataGridViewTextBoxColumn.Name = "rentalIdDataGridViewTextBoxColumn";
            this.rentalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentalIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BoardGames";
            this.dataGridViewTextBoxColumn1.HeaderText = "Board games";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeUsername";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateRented";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date rented";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateReturned";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date returned";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // rentalHistoryViewBindingSource
            // 
            this.rentalHistoryViewBindingSource.DataSource = typeof(BoardGameTeka.PresentationLayer.Member.RentalHistoryView);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(577, 213);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(86, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // frmRentalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 242);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewRentalHistory);
            this.Name = "frmRentalHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRentalHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentalHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalHistoryViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRentalHistory;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.BindingSource rentalHistoryViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
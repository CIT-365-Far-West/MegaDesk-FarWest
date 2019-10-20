namespace MegaDesk_Cotterell
{
    partial class ViewAllQuotes
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(592, 621);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(290, 137);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Done";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.QuoteDate,
            this.DeskWidth,
            this.DeskDepth,
            this.NumDrawers,
            this.SurfaceMaterial,
            this.PriceQuote});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1424, 600);
            this.dataGridView1.TabIndex = 3;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 10;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 90;
            // 
            // QuoteDate
            // 
            this.QuoteDate.HeaderText = "Quote Date";
            this.QuoteDate.MinimumWidth = 10;
            this.QuoteDate.Name = "QuoteDate";
            this.QuoteDate.ReadOnly = true;
            this.QuoteDate.Width = 90;
            // 
            // DeskWidth
            // 
            this.DeskWidth.HeaderText = "Desk Width";
            this.DeskWidth.MinimumWidth = 10;
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.ReadOnly = true;
            this.DeskWidth.Width = 90;
            // 
            // DeskDepth
            // 
            this.DeskDepth.HeaderText = "Desk Depth";
            this.DeskDepth.MinimumWidth = 10;
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.ReadOnly = true;
            this.DeskDepth.Width = 90;
            // 
            // NumDrawers
            // 
            this.NumDrawers.HeaderText = "Number of Drawers";
            this.NumDrawers.MinimumWidth = 10;
            this.NumDrawers.Name = "NumDrawers";
            this.NumDrawers.ReadOnly = true;
            this.NumDrawers.Width = 90;
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.HeaderText = "Surface Material";
            this.SurfaceMaterial.MinimumWidth = 10;
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.ReadOnly = true;
            this.SurfaceMaterial.Width = 90;
            // 
            // PriceQuote
            // 
            this.PriceQuote.HeaderText = "Price Quote";
            this.PriceQuote.MinimumWidth = 10;
            this.PriceQuote.Name = "PriceQuote";
            this.PriceQuote.ReadOnly = true;
            this.PriceQuote.Width = 90;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 771);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancelButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceQuote;
    }
}
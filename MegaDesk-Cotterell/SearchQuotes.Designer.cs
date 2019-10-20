namespace MegaDesk_Cotterell
{
    partial class SearchQuotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surfaceMaterialCmbo = new System.Windows.Forms.ComboBox();
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
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(612, 627);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(240, 115);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "&OK";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Surface Material";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.QuoteDate,
            this.DeskWidth,
            this.DeskDepth,
            this.NumDrawers,
            this.SurfaceMaterial,
            this.PriceQuote});
            this.dataGridView1.Location = new System.Drawing.Point(20, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1406, 500);
            this.dataGridView1.TabIndex = 3;
            // 
            // surfaceMaterialCmbo
            // 
            this.surfaceMaterialCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterialCmbo.DropDownWidth = 92;
            this.surfaceMaterialCmbo.FormattingEnabled = true;
            this.surfaceMaterialCmbo.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.surfaceMaterialCmbo.Location = new System.Drawing.Point(260, 25);
            this.surfaceMaterialCmbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surfaceMaterialCmbo.Name = "surfaceMaterialCmbo";
            this.surfaceMaterialCmbo.Size = new System.Drawing.Size(182, 33);
            this.surfaceMaterialCmbo.Sorted = true;
            this.surfaceMaterialCmbo.TabIndex = 13;
            this.surfaceMaterialCmbo.SelectedValueChanged += new System.EventHandler(this.surfaceMaterialCmbo_SelectedValueChanged);
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
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 771);
            this.Controls.Add(this.surfaceMaterialCmbo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox surfaceMaterialCmbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceQuote;
    }
}
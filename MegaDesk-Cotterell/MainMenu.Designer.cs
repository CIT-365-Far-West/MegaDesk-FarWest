namespace MegaDesk_Cotterell
{
    partial class MainMenu
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.quoteButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // quoteButton
            // 
            this.quoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteButton.Location = new System.Drawing.Point(62, 42);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(176, 57);
            this.quoteButton.TabIndex = 0;
            this.quoteButton.Text = "Add New Quote";
            this.quoteButton.UseVisualStyleBackColor = true;
            this.quoteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(62, 115);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(176, 57);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "View Quotes";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(62, 188);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(176, 57);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search Quotes";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(62, 263);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(176, 57);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.quoteButton);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button quoteButton;
    }
}


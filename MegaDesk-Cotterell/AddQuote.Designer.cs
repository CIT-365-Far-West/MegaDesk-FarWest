namespace MegaDesk_Cotterell
{
    partial class AddQuote
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.deskWidthBox = new System.Windows.Forms.TextBox();
            this.deskDepthBox = new System.Windows.Forms.TextBox();
            this.numDrawersBox = new System.Windows.Forms.TextBox();
            this.surfaceBox = new System.Windows.Forms.TextBox();
            this.rushBox = new System.Windows.Forms.TextBox();
            this.firstNameL = new System.Windows.Forms.Label();
            this.lastNameL = new System.Windows.Forms.Label();
            this.deskWidthL = new System.Windows.Forms.Label();
            this.deskDepthL = new System.Windows.Forms.Label();
            this.numDrawersL = new System.Windows.Forms.Label();
            this.surfaceL = new System.Windows.Forms.Label();
            this.rushDaysL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(139, 276);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(145, 71);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(313, 276);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(145, 71);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(318, 36);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(150, 20);
            this.firstNameBox.TabIndex = 2;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(318, 66);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(150, 20);
            this.lastNameBox.TabIndex = 3;
            // 
            // deskWidthBox
            // 
            this.deskWidthBox.Location = new System.Drawing.Point(318, 96);
            this.deskWidthBox.Name = "deskWidthBox";
            this.deskWidthBox.Size = new System.Drawing.Size(150, 20);
            this.deskWidthBox.TabIndex = 4;
            this.deskWidthBox.Validating += new System.ComponentModel.CancelEventHandler(this.deskWidthBox_Validating);
            // 
            // deskDepthBox
            // 
            this.deskDepthBox.Location = new System.Drawing.Point(318, 126);
            this.deskDepthBox.Name = "deskDepthBox";
            this.deskDepthBox.Size = new System.Drawing.Size(150, 20);
            this.deskDepthBox.TabIndex = 5;
            this.deskDepthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deskDepthBox_KeyPress);
            // 
            // numDrawersBox
            // 
            this.numDrawersBox.Location = new System.Drawing.Point(318, 156);
            this.numDrawersBox.Name = "numDrawersBox";
            this.numDrawersBox.Size = new System.Drawing.Size(150, 20);
            this.numDrawersBox.TabIndex = 6;
            // 
            // surfaceBox
            // 
            this.surfaceBox.Location = new System.Drawing.Point(318, 186);
            this.surfaceBox.Name = "surfaceBox";
            this.surfaceBox.Size = new System.Drawing.Size(150, 20);
            this.surfaceBox.TabIndex = 7;
            // 
            // rushBox
            // 
            this.rushBox.Location = new System.Drawing.Point(318, 216);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(150, 20);
            this.rushBox.TabIndex = 8;
            // 
            // firstNameL
            // 
            this.firstNameL.AutoSize = true;
            this.firstNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameL.Location = new System.Drawing.Point(130, 36);
            this.firstNameL.Name = "firstNameL";
            this.firstNameL.Size = new System.Drawing.Size(86, 20);
            this.firstNameL.TabIndex = 9;
            this.firstNameL.Text = "First Name";
            // 
            // lastNameL
            // 
            this.lastNameL.AutoSize = true;
            this.lastNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameL.Location = new System.Drawing.Point(130, 66);
            this.lastNameL.Name = "lastNameL";
            this.lastNameL.Size = new System.Drawing.Size(86, 20);
            this.lastNameL.TabIndex = 10;
            this.lastNameL.Text = "Last Name";
            // 
            // deskWidthL
            // 
            this.deskWidthL.AutoSize = true;
            this.deskWidthL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthL.Location = new System.Drawing.Point(130, 96);
            this.deskWidthL.Name = "deskWidthL";
            this.deskWidthL.Size = new System.Drawing.Size(91, 20);
            this.deskWidthL.TabIndex = 11;
            this.deskWidthL.Text = "Desk Width";
            // 
            // deskDepthL
            // 
            this.deskDepthL.AutoSize = true;
            this.deskDepthL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthL.Location = new System.Drawing.Point(130, 126);
            this.deskDepthL.Name = "deskDepthL";
            this.deskDepthL.Size = new System.Drawing.Size(94, 20);
            this.deskDepthL.TabIndex = 12;
            this.deskDepthL.Text = "Desk Depth";
            // 
            // numDrawersL
            // 
            this.numDrawersL.AutoSize = true;
            this.numDrawersL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersL.Location = new System.Drawing.Point(130, 156);
            this.numDrawersL.Name = "numDrawersL";
            this.numDrawersL.Size = new System.Drawing.Size(146, 20);
            this.numDrawersL.TabIndex = 13;
            this.numDrawersL.Text = "Number of Drawers";
            // 
            // surfaceL
            // 
            this.surfaceL.AutoSize = true;
            this.surfaceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceL.Location = new System.Drawing.Point(130, 186);
            this.surfaceL.Name = "surfaceL";
            this.surfaceL.Size = new System.Drawing.Size(125, 20);
            this.surfaceL.TabIndex = 14;
            this.surfaceL.Text = "Surface Material";
            // 
            // rushDaysL
            // 
            this.rushDaysL.AutoSize = true;
            this.rushDaysL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDaysL.Location = new System.Drawing.Point(130, 216);
            this.rushDaysL.Name = "rushDaysL";
            this.rushDaysL.Size = new System.Drawing.Size(87, 20);
            this.rushDaysL.TabIndex = 15;
            this.rushDaysL.Text = "Rush Days";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.rushDaysL);
            this.Controls.Add(this.surfaceL);
            this.Controls.Add(this.numDrawersL);
            this.Controls.Add(this.deskDepthL);
            this.Controls.Add(this.deskWidthL);
            this.Controls.Add(this.lastNameL);
            this.Controls.Add(this.firstNameL);
            this.Controls.Add(this.rushBox);
            this.Controls.Add(this.surfaceBox);
            this.Controls.Add(this.numDrawersBox);
            this.Controls.Add(this.deskDepthBox);
            this.Controls.Add(this.deskWidthBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox deskWidthBox;
        private System.Windows.Forms.TextBox deskDepthBox;
        private System.Windows.Forms.TextBox numDrawersBox;
        private System.Windows.Forms.TextBox surfaceBox;
        private System.Windows.Forms.TextBox rushBox;
        private System.Windows.Forms.Label firstNameL;
        private System.Windows.Forms.Label lastNameL;
        private System.Windows.Forms.Label deskWidthL;
        private System.Windows.Forms.Label deskDepthL;
        private System.Windows.Forms.Label numDrawersL;
        private System.Windows.Forms.Label surfaceL;
        private System.Windows.Forms.Label rushDaysL;
    }
}
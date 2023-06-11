namespace gestionBancaireClient
{
    partial class CompteHistorique
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
            this.idCmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.movementGrid = new System.Windows.Forms.DataGridView();
            this.operationsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movementGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // idCmbBox
            // 
            this.idCmbBox.FormattingEnabled = true;
            this.idCmbBox.Location = new System.Drawing.Point(208, 54);
            this.idCmbBox.Name = "idCmbBox";
            this.idCmbBox.Size = new System.Drawing.Size(243, 28);
            this.idCmbBox.TabIndex = 4;
            this.idCmbBox.SelectedIndexChanged += new System.EventHandler(this.idCmbBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "id";
            // 
            // movementGrid
            // 
            this.movementGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movementGrid.Location = new System.Drawing.Point(72, 115);
            this.movementGrid.Name = "movementGrid";
            this.movementGrid.RowHeadersWidth = 62;
            this.movementGrid.RowTemplate.Height = 28;
            this.movementGrid.Size = new System.Drawing.Size(778, 348);
            this.movementGrid.TabIndex = 5;
            // 
            // operationsBtn
            // 
            this.operationsBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.operationsBtn.Location = new System.Drawing.Point(705, 40);
            this.operationsBtn.Name = "operationsBtn";
            this.operationsBtn.Size = new System.Drawing.Size(145, 54);
            this.operationsBtn.TabIndex = 6;
            this.operationsBtn.Text = "Operations";
            this.operationsBtn.UseVisualStyleBackColor = false;
            this.operationsBtn.Click += new System.EventHandler(this.operationsBtn_Click);
            // 
            // CompteHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 519);
            this.Controls.Add(this.operationsBtn);
            this.Controls.Add(this.movementGrid);
            this.Controls.Add(this.idCmbBox);
            this.Controls.Add(this.label2);
            this.Name = "CompteHistorique";
            this.Text = "compteHostorique";
            this.Load += new System.EventHandler(this.CompteHistorique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movementGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox idCmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView movementGrid;
        private System.Windows.Forms.Button operationsBtn;
    }
}
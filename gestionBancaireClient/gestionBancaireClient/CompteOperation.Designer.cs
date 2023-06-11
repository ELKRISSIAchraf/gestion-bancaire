namespace gestionBancaireClient
{
    partial class CompteOperation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idCmbBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.debitRb = new System.Windows.Forms.RadioButton();
            this.creditRb = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.montantTxtBox = new System.Windows.Forms.TextBox();
            this.virementRb = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.operationGb = new System.Windows.Forms.GroupBox();
            this.benefTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.operationGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compte :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "id";
            // 
            // idCmbBox
            // 
            this.idCmbBox.FormattingEnabled = true;
            this.idCmbBox.Location = new System.Drawing.Point(491, 116);
            this.idCmbBox.Name = "idCmbBox";
            this.idCmbBox.Size = new System.Drawing.Size(245, 28);
            this.idCmbBox.TabIndex = 2;
            this.idCmbBox.SelectedIndexChanged += new System.EventHandler(this.idCmbBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "nom";
            // 
            // nomLbl
            // 
            this.nomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLbl.Location = new System.Drawing.Point(486, 176);
            this.nomLbl.Name = "nomLbl";
            this.nomLbl.Size = new System.Drawing.Size(250, 29);
            this.nomLbl.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 47);
            this.label5.TabIndex = 5;
            this.label5.Text = "Operation :";
            // 
            // debitRb
            // 
            this.debitRb.AutoSize = true;
            this.debitRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitRb.Location = new System.Drawing.Point(6, 15);
            this.debitRb.Name = "debitRb";
            this.debitRb.Size = new System.Drawing.Size(95, 33);
            this.debitRb.TabIndex = 6;
            this.debitRb.TabStop = true;
            this.debitRb.Text = "Débit";
            this.debitRb.UseVisualStyleBackColor = true;
            // 
            // creditRb
            // 
            this.creditRb.AutoSize = true;
            this.creditRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditRb.Location = new System.Drawing.Point(135, 15);
            this.creditRb.Name = "creditRb";
            this.creditRb.Size = new System.Drawing.Size(103, 33);
            this.creditRb.TabIndex = 7;
            this.creditRb.TabStop = true;
            this.creditRb.Text = "Crédit";
            this.creditRb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "montant";
            // 
            // montantTxtBox
            // 
            this.montantTxtBox.Location = new System.Drawing.Point(491, 421);
            this.montantTxtBox.Name = "montantTxtBox";
            this.montantTxtBox.Size = new System.Drawing.Size(245, 26);
            this.montantTxtBox.TabIndex = 10;
            // 
            // virementRb
            // 
            this.virementRb.AutoSize = true;
            this.virementRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virementRb.Location = new System.Drawing.Point(269, 15);
            this.virementRb.Name = "virementRb";
            this.virementRb.Size = new System.Drawing.Size(134, 33);
            this.virementRb.TabIndex = 11;
            this.virementRb.TabStop = true;
            this.virementRb.Text = "Virement";
            this.virementRb.UseVisualStyleBackColor = true;
            this.virementRb.CheckedChanged += new System.EventHandler(this.virementRb_CheckedChanged);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.okBtn.Location = new System.Drawing.Point(399, 549);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(153, 69);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // operationGb
            // 
            this.operationGb.Controls.Add(this.debitRb);
            this.operationGb.Controls.Add(this.creditRb);
            this.operationGb.Controls.Add(this.virementRb);
            this.operationGb.Location = new System.Drawing.Point(314, 343);
            this.operationGb.Name = "operationGb";
            this.operationGb.Size = new System.Drawing.Size(422, 60);
            this.operationGb.TabIndex = 13;
            this.operationGb.TabStop = false;
            // 
            // benefTxtBox
            // 
            this.benefTxtBox.Enabled = false;
            this.benefTxtBox.Location = new System.Drawing.Point(491, 464);
            this.benefTxtBox.Name = "benefTxtBox";
            this.benefTxtBox.Size = new System.Drawing.Size(245, 26);
            this.benefTxtBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "bénéficiaire id";
            // 
            // CompteOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 621);
            this.Controls.Add(this.benefTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.operationGb);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.montantTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nomLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idCmbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompteOperation";
            this.Text = "compteOperation";
            this.Load += new System.EventHandler(this.CompteOperation_Load);
            this.operationGb.ResumeLayout(false);
            this.operationGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox idCmbBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nomLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton debitRb;
        private System.Windows.Forms.RadioButton creditRb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox montantTxtBox;
        private System.Windows.Forms.RadioButton virementRb;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.GroupBox operationGb;
        private System.Windows.Forms.TextBox benefTxtBox;
        private System.Windows.Forms.Label label4;
    }
}


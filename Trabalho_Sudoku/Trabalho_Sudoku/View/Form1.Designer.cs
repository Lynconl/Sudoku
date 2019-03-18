namespace Trabalho_Sudoku
{
    partial class FormPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.bttnGerar = new System.Windows.Forms.Button();
            this.lblAssinatura = new System.Windows.Forms.Label();
            this.comboBxNivel = new System.Windows.Forms.ComboBox();
            this.dataGridViewJogo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnGerar
            // 
            this.bttnGerar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bttnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnGerar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGerar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttnGerar.Location = new System.Drawing.Point(317, 12);
            this.bttnGerar.Name = "bttnGerar";
            this.bttnGerar.Size = new System.Drawing.Size(146, 30);
            this.bttnGerar.TabIndex = 0;
            this.bttnGerar.Text = "Iniciar";
            this.bttnGerar.UseVisualStyleBackColor = false;
            this.bttnGerar.Click += new System.EventHandler(this.bttnGerar_Click);
            // 
            // lblAssinatura
            // 
            this.lblAssinatura.AutoSize = true;
            this.lblAssinatura.BackColor = System.Drawing.Color.Transparent;
            this.lblAssinatura.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssinatura.ForeColor = System.Drawing.Color.White;
            this.lblAssinatura.Location = new System.Drawing.Point(12, 517);
            this.lblAssinatura.Name = "lblAssinatura";
            this.lblAssinatura.Size = new System.Drawing.Size(378, 20);
            this.lblAssinatura.TabIndex = 86;
            this.lblAssinatura.Text = "Desenvolvido por: Lynconl F Assunção - Lucas Prado";
            // 
            // comboBxNivel
            // 
            this.comboBxNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBxNivel.FormattingEnabled = true;
            this.comboBxNivel.Items.AddRange(new object[] {
            "Iniciante",
            "Regular",
            "Avançado"});
            this.comboBxNivel.Location = new System.Drawing.Point(12, 12);
            this.comboBxNivel.Name = "comboBxNivel";
            this.comboBxNivel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBxNivel.Size = new System.Drawing.Size(267, 31);
            this.comboBxNivel.TabIndex = 87;
            this.comboBxNivel.Text = "Escolha um nível";
            // 
            // dataGridViewJogo
            // 
            this.dataGridViewJogo.AllowUserToAddRows = false;
            this.dataGridViewJogo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewJogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewJogo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewJogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewJogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewJogo.ColumnHeadersVisible = false;
            this.dataGridViewJogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJogo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewJogo.EnableHeadersVisualStyles = false;
            this.dataGridViewJogo.Location = new System.Drawing.Point(10, 53);
            this.dataGridViewJogo.Name = "dataGridViewJogo";
            this.dataGridViewJogo.RowHeadersVisible = false;
            this.dataGridViewJogo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewJogo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewJogo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewJogo.RowTemplate.DividerHeight = 2;
            this.dataGridViewJogo.RowTemplate.Height = 50;
            this.dataGridViewJogo.Size = new System.Drawing.Size(453, 455);
            this.dataGridViewJogo.TabIndex = 90;
            this.dataGridViewJogo.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DividerWidth = 2;
            this.Column1.HeaderText = "Column1";
            this.Column1.MaxInputLength = 1;
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DividerWidth = 2;
            this.Column2.HeaderText = "Column2";
            this.Column2.MaxInputLength = 1;
            this.Column2.MinimumWidth = 50;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.DividerWidth = 2;
            this.Column3.HeaderText = "Column3";
            this.Column3.MaxInputLength = 1;
            this.Column3.MinimumWidth = 50;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DividerWidth = 2;
            this.Column4.HeaderText = "Column4";
            this.Column4.MaxInputLength = 1;
            this.Column4.MinimumWidth = 50;
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DividerWidth = 2;
            this.Column5.HeaderText = "Column5";
            this.Column5.MaxInputLength = 1;
            this.Column5.MinimumWidth = 50;
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DividerWidth = 2;
            this.Column6.HeaderText = "Column6";
            this.Column6.MaxInputLength = 1;
            this.Column6.MinimumWidth = 50;
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DividerWidth = 2;
            this.Column7.HeaderText = "Column7";
            this.Column7.MaxInputLength = 1;
            this.Column7.MinimumWidth = 50;
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DividerWidth = 2;
            this.Column8.HeaderText = "Column8";
            this.Column8.MaxInputLength = 1;
            this.Column8.MinimumWidth = 50;
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.DividerWidth = 2;
            this.Column9.HeaderText = "Column9";
            this.Column9.MaxInputLength = 1;
            this.Column9.MinimumWidth = 50;
            this.Column9.Name = "Column9";
            this.Column9.Width = 50;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(471, 544);
            this.Controls.Add(this.dataGridViewJogo);
            this.Controls.Add(this.comboBxNivel);
            this.Controls.Add(this.lblAssinatura);
            this.Controls.Add(this.bttnGerar);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "GERAR SUDOKU";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnGerar;
        private System.Windows.Forms.Label lblAssinatura;
        private System.Windows.Forms.ComboBox comboBxNivel;
        private System.Windows.Forms.DataGridView dataGridViewJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}


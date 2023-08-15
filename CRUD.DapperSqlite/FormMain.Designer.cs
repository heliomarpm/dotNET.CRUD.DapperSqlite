namespace CRUD.DapperSqlite
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            lblRCount = new Label();
            panel3 = new Panel();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnIncluir = new Button();
            dtgDados = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDados).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblRCount);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(2, 523);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 75);
            panel2.TabIndex = 0;
            // 
            // lblRCount
            // 
            lblRCount.AutoSize = true;
            lblRCount.Location = new Point(23, 28);
            lblRCount.Name = "lblRCount";
            lblRCount.Size = new Size(109, 20);
            lblRCount.TabIndex = 1;
            lblRCount.Text = "Qtd. registros:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExcluir);
            panel3.Controls.Add(btnAlterar);
            panel3.Controls.Add(btnIncluir);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(547, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(478, 75);
            panel3.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(339, 15);
            btnExcluir.Margin = new Padding(4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(126, 46);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(178, 15);
            btnAlterar.Margin = new Padding(4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(126, 46);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(44, 15);
            btnIncluir.Margin = new Padding(4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(126, 46);
            btnIncluir.TabIndex = 0;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // dtgDados
            // 
            dtgDados.AllowUserToAddRows = false;
            dtgDados.AllowUserToDeleteRows = false;
            dtgDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDados.Dock = DockStyle.Fill;
            dtgDados.Location = new Point(2, 2);
            dtgDados.Margin = new Padding(4);
            dtgDados.Name = "dtgDados";
            dtgDados.ReadOnly = true;
            dtgDados.RowTemplate.Height = 25;
            dtgDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDados.Size = new Size(1025, 521);
            dtgDados.TabIndex = 1;
            dtgDados.CellContentClick += dtgDados_CellContentClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 600);
            Controls.Add(dtgDados);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormMain";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnIncluir;
        private DataGridView dtgDados;
        private Label lblRCount;
    }
}
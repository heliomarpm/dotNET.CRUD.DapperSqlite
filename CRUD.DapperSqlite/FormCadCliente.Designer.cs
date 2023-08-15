namespace CRUD.DapperSqlite
{
    partial class FormCadCliente
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
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtCidade = new TextBox();
            label5 = new Label();
            txtUF = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // txtId
            // 
            txtId.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(117, 16);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(135, 27);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 62);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(47, 85);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(427, 26);
            txtNome.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 123);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 0;
            label3.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(47, 146);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(124, 26);
            txtTelefone.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 123);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 0;
            label4.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(189, 146);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(239, 26);
            txtCidade.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 123);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 0;
            label5.Text = "UF";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(434, 146);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(40, 26);
            txtUF.TabIndex = 4;
            txtUF.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SpringGreen;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(262, 216);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(240, 51);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(12, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(240, 51);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCadCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 279);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtUF);
            Controls.Add(label5);
            Controls.Add(txtCidade);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FormCadCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormCadCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtCidade;
        private Label label5;
        private TextBox txtUF;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}
namespace SenacFoods
{
    partial class FrmComandaCad
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
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnAdicionar = new Button();
            txtTitulo = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 66);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(569, 428);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comanda";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(137, 166);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(373, 33);
            comboBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(188, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(322, 33);
            comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 165);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 10;
            label3.Text = "Cardápio:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 211);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(529, 141);
            dataGridView1.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AccessibleName = "btnBana";
            btnAdicionar.BackColor = Color.FromArgb(255, 255, 128);
            btnAdicionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(517, 162);
            btnAdicionar.Margin = new Padding(4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(41, 41);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "+";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(33, 65);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(525, 33);
            txtTitulo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 118);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 5;
            label4.Text = "Mesa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 40);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 3;
            label2.Text = "Nome do cliente";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.MediumAquamarine;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(294, 360);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(166, 49);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(120, 361);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 49);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(-20, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 57);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 6;
            label1.Text = "Comanda";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Century Gothic", 20F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(562, 7);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(45, 41);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 507);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComandaCad";
            Text = "FrmComandaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTitulo;
        private Label label4;
        private Label label2;
        private Button btnSalvar;
        private Button btnCancelar;
        private Panel panel1;
        private Label label1;
        private Button btnFechar;
        private Button btnAdicionar;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label3;
        private DataGridView dataGridView1;
    }
}
namespace SenacFoods
{
    partial class FrmPrincipal
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
            btnUsuario = new Button();
            btnPedido = new Button();
            btnComanda = new Button();
            btnCardapio = new Button();
            button6 = new Button();
            btnFechar = new Button();
            btnMInimizar = new Button();
            lblMensagem = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUsuario);
            groupBox1.Controls.Add(btnPedido);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCardapio);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(60, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.LightPink;
            btnUsuario.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.Black;
            btnUsuario.Location = new Point(477, 51);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(116, 106);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuários";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.LightSeaGreen;
            btnPedido.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedido.ForeColor = Color.Black;
            btnPedido.Location = new Point(327, 51);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(130, 106);
            btnPedido.TabIndex = 0;
            btnPedido.Text = "Pedido Cozinha";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.MediumAquamarine;
            btnComanda.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btnComanda.FlatAppearance.BorderSize = 0;
            btnComanda.FlatStyle = FlatStyle.Flat;
            btnComanda.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComanda.ForeColor = Color.Black;
            btnComanda.Location = new Point(172, 51);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(139, 106);
            btnComanda.TabIndex = 0;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.FromArgb(255, 192, 128);
            btnCardapio.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btnCardapio.FlatAppearance.BorderSize = 0;
            btnCardapio.FlatStyle = FlatStyle.Flat;
            btnCardapio.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCardapio.ForeColor = Color.Black;
            btnCardapio.Location = new Point(30, 51);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(122, 106);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // button6
            // 
            button6.Location = new Point(24, 305);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 2;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
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
            btnFechar.Location = new Point(719, 2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(52, 32);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMInimizar
            // 
            btnMInimizar.BackColor = Color.Black;
            btnMInimizar.FlatAppearance.BorderSize = 0;
            btnMInimizar.FlatAppearance.MouseDownBackColor = Color.White;
            btnMInimizar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMInimizar.FlatStyle = FlatStyle.Flat;
            btnMInimizar.Font = new Font("Century Gothic", 25F);
            btnMInimizar.ForeColor = Color.White;
            btnMInimizar.Location = new Point(614, -1);
            btnMInimizar.Name = "btnMInimizar";
            btnMInimizar.Size = new Size(52, 32);
            btnMInimizar.TabIndex = 3;
            btnMInimizar.Text = "-";
            btnMInimizar.UseVisualStyleBackColor = false;
            btnMInimizar.Click += btnMInimizar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 20F);
            lblMensagem.ForeColor = SystemColors.ButtonFace;
            lblMensagem.Location = new Point(246, 2);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(178, 37);
            lblMensagem.TabIndex = 4;
            lblMensagem.Text = "lblMensagem";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(776, 278);
            Controls.Add(lblMensagem);
            Controls.Add(btnMInimizar);
            Controls.Add(btnFechar);
            Controls.Add(button6);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCardapio;
        private Button btnUsuario;
        private Button btnPedido;
        private Button btnComanda;
        private Button button6;
        private Button btnFechar;
        private Button btnMInimizar;
        private Label lblMensagem;
    }
}
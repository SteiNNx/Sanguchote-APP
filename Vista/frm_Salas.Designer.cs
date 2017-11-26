namespace Vista
{
    partial class frm_Salas
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
            this.cbb_sala = new System.Windows.Forms.ComboBox();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_pedidos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FrankRuehl", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sala";
            // 
            // cbb_sala
            // 
            this.cbb_sala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sala.FormattingEnabled = true;
            this.cbb_sala.Location = new System.Drawing.Point(110, 53);
            this.cbb_sala.Name = "cbb_sala";
            this.cbb_sala.Size = new System.Drawing.Size(140, 21);
            this.cbb_sala.TabIndex = 6;
            // 
            // btn_pedido
            // 
            this.btn_pedido.Location = new System.Drawing.Point(63, 112);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(140, 23);
            this.btn_pedido.TabIndex = 7;
            this.btn_pedido.Text = "Nuevo Pedido";
            this.btn_pedido.UseVisualStyleBackColor = true;
            this.btn_pedido.Click += new System.EventHandler(this.btn_pedido_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_pedidos);
            this.groupBox1.Location = new System.Drawing.Point(256, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 255);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido";
            // 
            // dgv_pedidos
            // 
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.Location = new System.Drawing.Point(6, 19);
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.Size = new System.Drawing.Size(470, 230);
            this.dgv_pedidos.TabIndex = 0;
            // 
            // frm_Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(750, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_pedido);
            this.Controls.Add(this.cbb_sala);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Salas";
            this.Text = "frm_Salas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_sala;
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_pedidos;
    }
}
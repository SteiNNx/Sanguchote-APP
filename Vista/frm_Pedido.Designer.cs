﻿namespace Vista
{
    partial class frm_Pedido
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_producto = new System.Windows.Forms.ComboBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_pedido = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ccb_cantidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.pb_producto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FrankRuehl", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("FrankRuehl", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("FrankRuehl", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock";
            // 
            // cbb_producto
            // 
            this.cbb_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_producto.FormattingEnabled = true;
            this.cbb_producto.Location = new System.Drawing.Point(113, 34);
            this.cbb_producto.Name = "cbb_producto";
            this.cbb_producto.Size = new System.Drawing.Size(140, 21);
            this.cbb_producto.TabIndex = 5;
            this.cbb_producto.SelectedIndexChanged += new System.EventHandler(this.cbb_producto_SelectedIndexChanged);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("FrankRuehl", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(110, 69);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(50, 17);
            this.lbl_precio.TabIndex = 6;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("FrankRuehl", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(110, 99);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(43, 17);
            this.lbl_stock.TabIndex = 7;
            this.lbl_stock.Text = "stock";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_pedido);
            this.groupBox1.Location = new System.Drawing.Point(280, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 215);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido";
            // 
            // dgv_pedido
            // 
            this.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedido.Location = new System.Drawing.Point(6, 19);
            this.dgv_pedido.Name = "dgv_pedido";
            this.dgv_pedido.Size = new System.Drawing.Size(442, 187);
            this.dgv_pedido.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(116)))), ((int)(((byte)(10)))));
            this.btn_agregar.Location = new System.Drawing.Point(29, 259);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(80, 30);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(116)))), ((int)(((byte)(10)))));
            this.btn_finalizar.Location = new System.Drawing.Point(652, 259);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(80, 30);
            this.btn_finalizar.TabIndex = 11;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("FrankRuehl", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad";
            // 
            // ccb_cantidad
            // 
            this.ccb_cantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_cantidad.FormattingEnabled = true;
            this.ccb_cantidad.Location = new System.Drawing.Point(113, 129);
            this.ccb_cantidad.Name = "ccb_cantidad";
            this.ccb_cantidad.Size = new System.Drawing.Size(140, 21);
            this.ccb_cantidad.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("FrankRuehl", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio Pedido: ";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("FrankRuehl", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(146, 239);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(107, 17);
            this.lbl_total.TabIndex = 15;
            this.lbl_total.Text = "Precio Pedido: ";
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Font = new System.Drawing.Font("FrankRuehl", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(283, 268);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(0, 17);
            this.lbl_mensaje.TabIndex = 16;
            // 
            // pb_producto
            // 
            this.pb_producto.Location = new System.Drawing.Point(139, 156);
            this.pb_producto.Name = "pb_producto";
            this.pb_producto.Size = new System.Drawing.Size(88, 80);
            this.pb_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_producto.TabIndex = 17;
            this.pb_producto.TabStop = false;
            // 
            // frm_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(750, 301);
            this.Controls.Add(this.pb_producto);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ccb_cantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.cbb_producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Pedido";
            this.Text = "Pedido";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_producto;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_pedido;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ccb_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.PictureBox pb_producto;
    }
}
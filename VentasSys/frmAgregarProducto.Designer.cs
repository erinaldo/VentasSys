﻿namespace VentasSys
{
    partial class frmAgregarProducto
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.chkAlquiler = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonto_Alquiler = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Producto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 53);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(139, 79);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(192, 21);
            this.cboCategoria.TabIndex = 3;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(139, 131);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCosto.MaxLength = 8;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(81, 22);
            this.txtCosto.TabIndex = 5;
            this.txtCosto.Text = "0.00";
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(139, 157);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.MaxLength = 8;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(81, 22);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.Text = "0.00";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio Público:";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(139, 322);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(2);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 17);
            this.chkActivo.TabIndex = 8;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(140, 380);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 35);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(139, 183);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.MaxLength = 5;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(81, 22);
            this.txtStock.TabIndex = 31;
            this.txtStock.Text = "0";
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Stock:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboProveedor);
            this.groupBox1.Controls.Add(this.chkAlquiler);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMonto_Alquiler);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMedida);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 352);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Proveedor:";
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(139, 104);
            this.cboProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(192, 21);
            this.cboProveedor.TabIndex = 41;
            // 
            // chkAlquiler
            // 
            this.chkAlquiler.AutoSize = true;
            this.chkAlquiler.Location = new System.Drawing.Point(139, 265);
            this.chkAlquiler.Name = "chkAlquiler";
            this.chkAlquiler.Size = new System.Drawing.Size(41, 17);
            this.chkAlquiler.TabIndex = 39;
            this.chkAlquiler.Text = "No";
            this.chkAlquiler.UseVisualStyleBackColor = true;
            this.chkAlquiler.CheckedChanged += new System.EventHandler(this.chkAlquiler_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 264);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Alquiler:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Monto Alquiler:";
            // 
            // txtMonto_Alquiler
            // 
            this.txtMonto_Alquiler.Enabled = false;
            this.txtMonto_Alquiler.Location = new System.Drawing.Point(139, 287);
            this.txtMonto_Alquiler.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto_Alquiler.MaxLength = 8;
            this.txtMonto_Alquiler.Name = "txtMonto_Alquiler";
            this.txtMonto_Alquiler.Size = new System.Drawing.Size(81, 22);
            this.txtMonto_Alquiler.TabIndex = 37;
            this.txtMonto_Alquiler.Text = "0.00";
            this.txtMonto_Alquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(139, 235);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeso.MaxLength = 5;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(81, 22);
            this.txtPeso.TabIndex = 35;
            this.txtPeso.Text = "0.00";
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Peso: (Kg)";
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(139, 209);
            this.txtMedida.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedida.MaxLength = 5;
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(81, 22);
            this.txtMedida.TabIndex = 33;
            this.txtMedida.Text = "0.00";
            this.txtMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedida_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Medida:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Codigo del Producto:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(139, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(192, 22);
            this.txtCodigo.TabIndex = 43;
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAlquiler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonto_Alquiler;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}
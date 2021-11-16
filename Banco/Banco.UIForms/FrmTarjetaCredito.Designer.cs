
namespace Banco.UIForms
{
    partial class FrmTarjetaCredito
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstTarjetas = new System.Windows.Forms.ListBox();
            this._cmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this._cmbPeriodo = new System.Windows.Forms.ComboBox();
            this._txtLimite = new System.Windows.Forms.TextBox();
            this._txtNroPlastico = new System.Windows.Forms.TextBox();
            this._btnCalcular = new System.Windows.Forms.Button();
            this._btnAlta = new System.Windows.Forms.Button();
            this._txtCantidad = new System.Windows.Forms.TextBox();
            this._txtPromedio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario Tarjeta de Crédito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Período de Cierre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de plástico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Límite de compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reporte Tarjetas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad plásticos emitidos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Límite promedio";
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.ItemHeight = 21;
            this.lstTarjetas.Location = new System.Drawing.Point(29, 72);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(326, 235);
            this.lstTarjetas.TabIndex = 91;
            // 
            // _cmbTipoTarjeta
            // 
            this._cmbTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbTipoTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmbTipoTarjeta.FormattingEnabled = true;
            this._cmbTipoTarjeta.Location = new System.Drawing.Point(174, 72);
            this._cmbTipoTarjeta.Name = "_cmbTipoTarjeta";
            this._cmbTipoTarjeta.Size = new System.Drawing.Size(176, 29);
            this._cmbTipoTarjeta.TabIndex = 0;
            // 
            // _cmbPeriodo
            // 
            this._cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPeriodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmbPeriodo.FormattingEnabled = true;
            this._cmbPeriodo.Location = new System.Drawing.Point(174, 128);
            this._cmbPeriodo.Name = "_cmbPeriodo";
            this._cmbPeriodo.Size = new System.Drawing.Size(176, 29);
            this._cmbPeriodo.TabIndex = 1;
            // 
            // _txtLimite
            // 
            this._txtLimite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLimite.Location = new System.Drawing.Point(174, 190);
            this._txtLimite.Name = "_txtLimite";
            this._txtLimite.Size = new System.Drawing.Size(176, 29);
            this._txtLimite.TabIndex = 2;
            // 
            // _txtNroPlastico
            // 
            this._txtNroPlastico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNroPlastico.Location = new System.Drawing.Point(174, 325);
            this._txtNroPlastico.Name = "_txtNroPlastico";
            this._txtNroPlastico.ReadOnly = true;
            this._txtNroPlastico.Size = new System.Drawing.Size(176, 29);
            this._txtNroPlastico.TabIndex = 90;
            // 
            // _btnCalcular
            // 
            this._btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCalcular.Location = new System.Drawing.Point(15, 245);
            this._btnCalcular.Name = "_btnCalcular";
            this._btnCalcular.Size = new System.Drawing.Size(335, 46);
            this._btnCalcular.TabIndex = 3;
            this._btnCalcular.Text = "CALCULAR";
            this._btnCalcular.UseVisualStyleBackColor = true;
            this._btnCalcular.Click += new System.EventHandler(this._btnCalcular_Click);
            // 
            // _btnAlta
            // 
            this._btnAlta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAlta.Location = new System.Drawing.Point(15, 374);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(335, 45);
            this._btnAlta.TabIndex = 4;
            this._btnAlta.Text = "ALTA";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _txtCantidad
            // 
            this._txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCantidad.Location = new System.Drawing.Point(255, 328);
            this._txtCantidad.Name = "_txtCantidad";
            this._txtCantidad.ReadOnly = true;
            this._txtCantidad.Size = new System.Drawing.Size(100, 29);
            this._txtCantidad.TabIndex = 92;
            // 
            // _txtPromedio
            // 
            this._txtPromedio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPromedio.Location = new System.Drawing.Point(255, 374);
            this._txtPromedio.Name = "_txtPromedio";
            this._txtPromedio.ReadOnly = true;
            this._txtPromedio.Size = new System.Drawing.Size(100, 29);
            this._txtPromedio.TabIndex = 93;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._btnAlta);
            this.panel1.Controls.Add(this._btnCalcular);
            this.panel1.Controls.Add(this._txtNroPlastico);
            this.panel1.Controls.Add(this._txtLimite);
            this.panel1.Controls.Add(this._cmbPeriodo);
            this.panel1.Controls.Add(this._cmbTipoTarjeta);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 436);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._txtPromedio);
            this.panel2.Controls.Add(this._txtCantidad);
            this.panel2.Controls.Add(this.lstTarjetas);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(396, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 436);
            this.panel2.TabIndex = 19;
            // 
            // FrmTarjetaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTarjetaCredito";
            this.Text = "Decaedro SRL";
            this.Load += new System.EventHandler(this.FrmTarjetaCredito_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstTarjetas;
        private System.Windows.Forms.ComboBox _cmbTipoTarjeta;
        private System.Windows.Forms.ComboBox _cmbPeriodo;
        private System.Windows.Forms.TextBox _txtLimite;
        private System.Windows.Forms.TextBox _txtNroPlastico;
        private System.Windows.Forms.Button _btnCalcular;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.TextBox _txtCantidad;
        private System.Windows.Forms.TextBox _txtPromedio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
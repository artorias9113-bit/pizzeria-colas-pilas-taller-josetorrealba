namespace laboratoriPizzeriaCampusExpress
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstPedidos;
        private System.Windows.Forms.ListBox lstBitacora;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblContador;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	this.txtCliente = new System.Windows.Forms.TextBox();
        	this.btnNuevoPedido = new System.Windows.Forms.Button();
        	this.btnEntregar = new System.Windows.Forms.Button();
        	this.btnDeshacer = new System.Windows.Forms.Button();
        	this.btnLimpiar = new System.Windows.Forms.Button();
        	this.lstPedidos = new System.Windows.Forms.ListBox();
        	this.lstBitacora = new System.Windows.Forms.ListBox();
        	this.lblEstado = new System.Windows.Forms.Label();
        	this.lblContador = new System.Windows.Forms.Label();
        	this.Btnpremiun = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.lstPremiun = new System.Windows.Forms.ListBox();
        	this.SuspendLayout();
        	// 
        	// txtCliente
        	// 
        	this.txtCliente.Location = new System.Drawing.Point(12, 12);
        	this.txtCliente.Name = "txtCliente";
        	this.txtCliente.Size = new System.Drawing.Size(200, 20);
        	this.txtCliente.TabIndex = 0;
        	// 
        	// btnNuevoPedido
        	// 
        	this.btnNuevoPedido.Location = new System.Drawing.Point(220, 10);
        	this.btnNuevoPedido.Name = "btnNuevoPedido";
        	this.btnNuevoPedido.Size = new System.Drawing.Size(100, 23);
        	this.btnNuevoPedido.TabIndex = 1;
        	this.btnNuevoPedido.Text = "Nuevo Pedido";
        	this.btnNuevoPedido.UseVisualStyleBackColor = true;
        	this.btnNuevoPedido.Click += new System.EventHandler(this.BtnNuevoPedido_Click);
        	// 
        	// btnEntregar
        	// 
        	this.btnEntregar.Location = new System.Drawing.Point(326, 10);
        	this.btnEntregar.Name = "btnEntregar";
        	this.btnEntregar.Size = new System.Drawing.Size(100, 23);
        	this.btnEntregar.TabIndex = 2;
        	this.btnEntregar.Text = "Entregar";
        	this.btnEntregar.UseVisualStyleBackColor = true;
        	this.btnEntregar.Click += new System.EventHandler(this.BtnEntregar_Click);
        	// 
        	// btnDeshacer
        	// 
        	this.btnDeshacer.Location = new System.Drawing.Point(432, 10);
        	this.btnDeshacer.Name = "btnDeshacer";
        	this.btnDeshacer.Size = new System.Drawing.Size(100, 23);
        	this.btnDeshacer.TabIndex = 3;
        	this.btnDeshacer.Text = "Deshacer";
        	this.btnDeshacer.UseVisualStyleBackColor = true;
        	this.btnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
        	// 
        	// btnLimpiar
        	// 
        	this.btnLimpiar.Location = new System.Drawing.Point(538, 10);
        	this.btnLimpiar.Name = "btnLimpiar";
        	this.btnLimpiar.Size = new System.Drawing.Size(100, 23);
        	this.btnLimpiar.TabIndex = 4;
        	this.btnLimpiar.Text = "Limpiar todo";
        	this.btnLimpiar.UseVisualStyleBackColor = true;
        	this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
        	// 
        	// lstPedidos
        	// 
        	this.lstPedidos.FormattingEnabled = true;
        	this.lstPedidos.Location = new System.Drawing.Point(12, 50);
        	this.lstPedidos.Name = "lstPedidos";
        	this.lstPedidos.Size = new System.Drawing.Size(184, 238);
        	this.lstPedidos.TabIndex = 5;
        	// 
        	// lstBitacora
        	// 
        	this.lstBitacora.FormattingEnabled = true;
        	this.lstBitacora.Location = new System.Drawing.Point(432, 50);
        	this.lstBitacora.Name = "lstBitacora";
        	this.lstBitacora.Size = new System.Drawing.Size(206, 238);
        	this.lstBitacora.TabIndex = 6;
        	// 
        	// lblEstado
        	// 
        	this.lblEstado.AutoSize = true;
        	this.lblEstado.Location = new System.Drawing.Point(12, 315);
        	this.lblEstado.Name = "lblEstado";
        	this.lblEstado.Size = new System.Drawing.Size(91, 13);
        	this.lblEstado.TabIndex = 7;
        	this.lblEstado.Text = "Listo para trabajar";
        	// 
        	// lblContador
        	// 
        	this.lblContador.AutoSize = true;
        	this.lblContador.Location = new System.Drawing.Point(25, 338);
        	this.lblContador.Name = "lblContador";
        	this.lblContador.Size = new System.Drawing.Size(56, 13);
        	this.lblContador.TabIndex = 8;
        	this.lblContador.Text = "pedidos: 0";
        	// 
        	// Btnpremiun
        	// 
        	this.Btnpremiun.Location = new System.Drawing.Point(326, 305);
        	this.Btnpremiun.Name = "Btnpremiun";
        	this.Btnpremiun.Size = new System.Drawing.Size(93, 23);
        	this.Btnpremiun.TabIndex = 9;
        	this.Btnpremiun.Text = "cliente premiun";
        	this.Btnpremiun.UseVisualStyleBackColor = true;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(92, 338);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(100, 23);
        	this.label1.TabIndex = 10;
        	this.label1.Text = "premiun: 0";
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(162, 338);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(100, 23);
        	this.label2.TabIndex = 11;
        	this.label2.Text = "bitacora: 0";
        	// 
        	// lstPremiun
        	// 
        	this.lstPremiun.FormattingEnabled = true;
        	this.lstPremiun.Location = new System.Drawing.Point(202, 50);
        	this.lstPremiun.Name = "lstPremiun";
        	this.lstPremiun.Size = new System.Drawing.Size(232, 238);
        	this.lstPremiun.TabIndex = 12;
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(650, 370);
        	this.Controls.Add(this.lstPremiun);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.Btnpremiun);
        	this.Controls.Add(this.lblContador);
        	this.Controls.Add(this.lblEstado);
        	this.Controls.Add(this.lstBitacora);
        	this.Controls.Add(this.lstPedidos);
        	this.Controls.Add(this.btnLimpiar);
        	this.Controls.Add(this.btnDeshacer);
        	this.Controls.Add(this.btnEntregar);
        	this.Controls.Add(this.btnNuevoPedido);
        	this.Controls.Add(this.txtCliente);
        	this.Name = "MainForm";
        	this.Text = "Pizzería Campus Express";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ListBox lstPremiun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnpremiun;
    }
}
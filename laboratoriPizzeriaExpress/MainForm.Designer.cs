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
        	this.txtCliente.Location = new System.Drawing.Point(16, 15);
        	this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
        	this.txtCliente.Name = "txtCliente";
        	this.txtCliente.Size = new System.Drawing.Size(265, 22);
        	this.txtCliente.TabIndex = 0;
        	// 
        	// btnNuevoPedido
        	// 
        	this.btnNuevoPedido.Location = new System.Drawing.Point(293, 12);
        	this.btnNuevoPedido.Margin = new System.Windows.Forms.Padding(4);
        	this.btnNuevoPedido.Name = "btnNuevoPedido";
        	this.btnNuevoPedido.Size = new System.Drawing.Size(133, 28);
        	this.btnNuevoPedido.TabIndex = 1;
        	this.btnNuevoPedido.Text = "Nuevo Pedido";
        	this.btnNuevoPedido.UseVisualStyleBackColor = true;
        	this.btnNuevoPedido.Click += new System.EventHandler(this.BtnNuevoPedido_Click);
        	// 
        	// btnEntregar
        	// 
        	this.btnEntregar.Location = new System.Drawing.Point(435, 12);
        	this.btnEntregar.Margin = new System.Windows.Forms.Padding(4);
        	this.btnEntregar.Name = "btnEntregar";
        	this.btnEntregar.Size = new System.Drawing.Size(133, 28);
        	this.btnEntregar.TabIndex = 2;
        	this.btnEntregar.Text = "Entregar";
        	this.btnEntregar.UseVisualStyleBackColor = true;
        	this.btnEntregar.Click += new System.EventHandler(this.BtnEntregar_Click);
        	// 
        	// btnDeshacer
        	// 
        	this.btnDeshacer.Location = new System.Drawing.Point(576, 12);
        	this.btnDeshacer.Margin = new System.Windows.Forms.Padding(4);
        	this.btnDeshacer.Name = "btnDeshacer";
        	this.btnDeshacer.Size = new System.Drawing.Size(133, 28);
        	this.btnDeshacer.TabIndex = 3;
        	this.btnDeshacer.Text = "Deshacer";
        	this.btnDeshacer.UseVisualStyleBackColor = true;
        	this.btnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
        	// 
        	// btnLimpiar
        	// 
        	this.btnLimpiar.Location = new System.Drawing.Point(717, 12);
        	this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
        	this.btnLimpiar.Name = "btnLimpiar";
        	this.btnLimpiar.Size = new System.Drawing.Size(133, 28);
        	this.btnLimpiar.TabIndex = 4;
        	this.btnLimpiar.Text = "Limpiar todo";
        	this.btnLimpiar.UseVisualStyleBackColor = true;
        	this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
        	// 
        	// lstPedidos
        	// 
        	this.lstPedidos.FormattingEnabled = true;
        	this.lstPedidos.ItemHeight = 16;
        	this.lstPedidos.Location = new System.Drawing.Point(16, 62);
        	this.lstPedidos.Margin = new System.Windows.Forms.Padding(4);
        	this.lstPedidos.Name = "lstPedidos";
        	this.lstPedidos.Size = new System.Drawing.Size(244, 292);
        	this.lstPedidos.TabIndex = 5;
        	// 
        	// lstBitacora
        	// 
        	this.lstBitacora.FormattingEnabled = true;
        	this.lstBitacora.ItemHeight = 16;
        	this.lstBitacora.Location = new System.Drawing.Point(576, 62);
        	this.lstBitacora.Margin = new System.Windows.Forms.Padding(4);
        	this.lstBitacora.Name = "lstBitacora";
        	this.lstBitacora.Size = new System.Drawing.Size(273, 292);
        	this.lstBitacora.TabIndex = 6;
        	// 
        	// lblEstado
        	// 
        	this.lblEstado.AutoSize = true;
        	this.lblEstado.Location = new System.Drawing.Point(16, 388);
        	this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblEstado.Name = "lblEstado";
        	this.lblEstado.Size = new System.Drawing.Size(124, 17);
        	this.lblEstado.TabIndex = 7;
        	this.lblEstado.Text = "Listo para trabajar";
        	// 
        	// lblContador
        	// 
        	this.lblContador.AutoSize = true;
        	this.lblContador.Location = new System.Drawing.Point(33, 416);
        	this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblContador.Name = "lblContador";
        	this.lblContador.Size = new System.Drawing.Size(74, 17);
        	this.lblContador.TabIndex = 8;
        	this.lblContador.Text = "pedidos: 0";
        	// 
        	// Btnpremiun
        	// 
        	this.Btnpremiun.Location = new System.Drawing.Point(435, 375);
        	this.Btnpremiun.Margin = new System.Windows.Forms.Padding(4);
        	this.Btnpremiun.Name = "Btnpremiun";
        	this.Btnpremiun.Size = new System.Drawing.Size(124, 28);
        	this.Btnpremiun.TabIndex = 9;
        	this.Btnpremiun.Text = "cliente premiun";
        	this.Btnpremiun.UseVisualStyleBackColor = true;
        	this.Btnpremiun.Click += new System.EventHandler(this.BtnpremiunClick);
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(123, 416);
        	this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(133, 28);
        	this.label1.TabIndex = 10;
        	this.label1.Text = "premiun: 0";
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(216, 416);
        	this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(133, 28);
        	this.label2.TabIndex = 11;
        	this.label2.Text = "bitacora: 0";
        	// 
        	// lstPremiun
        	// 
        	this.lstPremiun.FormattingEnabled = true;
        	this.lstPremiun.ItemHeight = 16;
        	this.lstPremiun.Location = new System.Drawing.Point(269, 62);
        	this.lstPremiun.Margin = new System.Windows.Forms.Padding(4);
        	this.lstPremiun.Name = "lstPremiun";
        	this.lstPremiun.Size = new System.Drawing.Size(308, 292);
        	this.lstPremiun.TabIndex = 12;
        	this.lstPremiun.SelectedIndexChanged += new System.EventHandler(this.LstPremiunSelectedIndexChanged);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(867, 455);
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
        	this.Margin = new System.Windows.Forms.Padding(4);
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
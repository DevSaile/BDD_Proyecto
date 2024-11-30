namespace Variedades_Man_s_Style
{
    partial class frmCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_txtProductos = new System.Windows.Forms.Panel();
            this.Label_Productos = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvVerClientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BuscarCliente = new System.Windows.Forms.TextBox();
            this.PanelControlesEmpleados = new System.Windows.Forms.Panel();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnDesactivarEmpleado = new System.Windows.Forms.Button();
            this.panelDatosEmpleados = new System.Windows.Forms.Panel();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchTimer_Tick_Tick = new System.Windows.Forms.Timer(this.components);
            this.Panel_txtProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerClientes)).BeginInit();
            this.PanelControlesEmpleados.SuspendLayout();
            this.panelDatosEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_txtProductos
            // 
            this.Panel_txtProductos.BackColor = System.Drawing.Color.Black;
            this.Panel_txtProductos.Controls.Add(this.Label_Productos);
            this.Panel_txtProductos.Controls.Add(this.button2);
            this.Panel_txtProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_txtProductos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_txtProductos.Location = new System.Drawing.Point(0, 0);
            this.Panel_txtProductos.Name = "Panel_txtProductos";
            this.Panel_txtProductos.Size = new System.Drawing.Size(1016, 44);
            this.Panel_txtProductos.TabIndex = 94;
            // 
            // Label_Productos
            // 
            this.Label_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Productos.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_Productos.Location = new System.Drawing.Point(420, 0);
            this.Label_Productos.Name = "Label_Productos";
            this.Label_Productos.Size = new System.Drawing.Size(180, 41);
            this.Label_Productos.TabIndex = 2;
            this.Label_Productos.Text = "Clientes Existentes";
            this.Label_Productos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvVerClientes
            // 
            this.dgvVerClientes.AllowUserToAddRows = false;
            this.dgvVerClientes.AllowUserToDeleteRows = false;
            this.dgvVerClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerClientes.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvVerClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvVerClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVerClientes.ColumnHeadersHeight = 30;
            this.dgvVerClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerClientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVerClientes.EnableHeadersVisualStyles = false;
            this.dgvVerClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVerClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvVerClientes.MultiSelect = false;
            this.dgvVerClientes.Name = "dgvVerClientes";
            this.dgvVerClientes.ReadOnly = true;
            this.dgvVerClientes.RowHeadersVisible = false;
            this.dgvVerClientes.RowHeadersWidth = 51;
            this.dgvVerClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerClientes.Size = new System.Drawing.Size(716, 412);
            this.dgvVerClientes.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 109;
            this.label3.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(123, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 5);
            this.label2.TabIndex = 108;
            // 
            // txt_BuscarCliente
            // 
            this.txt_BuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_BuscarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_BuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BuscarCliente.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarCliente.Location = new System.Drawing.Point(123, 21);
            this.txt_BuscarCliente.Multiline = true;
            this.txt_BuscarCliente.Name = "txt_BuscarCliente";
            this.txt_BuscarCliente.Size = new System.Drawing.Size(244, 34);
            this.txt_BuscarCliente.TabIndex = 107;
            this.txt_BuscarCliente.TextChanged += new System.EventHandler(this.txt_BuscarCliente_TextChanged);
            // 
            // PanelControlesEmpleados
            // 
            this.PanelControlesEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelControlesEmpleados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelControlesEmpleados.Controls.Add(this.btnActualizarEmpleado);
            this.PanelControlesEmpleados.Controls.Add(this.dgvVerClientes);
            this.PanelControlesEmpleados.Controls.Add(this.btnAgregarEmpleado);
            this.PanelControlesEmpleados.Controls.Add(this.btnDesactivarEmpleado);
            this.PanelControlesEmpleados.Location = new System.Drawing.Point(0, 130);
            this.PanelControlesEmpleados.Name = "PanelControlesEmpleados";
            this.PanelControlesEmpleados.Size = new System.Drawing.Size(1016, 412);
            this.PanelControlesEmpleados.TabIndex = 110;
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.LimeGreen;
            this.btnActualizarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarEmpleado.FlatAppearance.BorderSize = 2;
            this.btnActualizarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(783, 228);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(170, 46);
            this.btnActualizarEmpleado.TabIndex = 112;
            this.btnActualizarEmpleado.Text = "Actualizar";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarEmpleado.FlatAppearance.BorderSize = 2;
            this.btnAgregarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(783, 92);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(170, 46);
            this.btnAgregarEmpleado.TabIndex = 113;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnDesactivarEmpleado
            // 
            this.btnDesactivarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesactivarEmpleado.BackColor = System.Drawing.Color.Red;
            this.btnDesactivarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDesactivarEmpleado.FlatAppearance.BorderSize = 2;
            this.btnDesactivarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnDesactivarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivarEmpleado.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarEmpleado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDesactivarEmpleado.Location = new System.Drawing.Point(783, 162);
            this.btnDesactivarEmpleado.Name = "btnDesactivarEmpleado";
            this.btnDesactivarEmpleado.Size = new System.Drawing.Size(170, 46);
            this.btnDesactivarEmpleado.TabIndex = 111;
            this.btnDesactivarEmpleado.Text = "Remover";
            this.btnDesactivarEmpleado.UseVisualStyleBackColor = false;
            // 
            // panelDatosEmpleados
            // 
            this.panelDatosEmpleados.BackColor = System.Drawing.Color.AliceBlue;
            this.panelDatosEmpleados.Controls.Add(this.txtNombreCliente);
            this.panelDatosEmpleados.Controls.Add(this.label1);
            this.panelDatosEmpleados.Controls.Add(this.label4);
            this.panelDatosEmpleados.Controls.Add(this.txt_BuscarCliente);
            this.panelDatosEmpleados.Controls.Add(this.label2);
            this.panelDatosEmpleados.Controls.Add(this.label3);
            this.panelDatosEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatosEmpleados.Location = new System.Drawing.Point(0, 44);
            this.panelDatosEmpleados.Name = "panelDatosEmpleados";
            this.panelDatosEmpleados.Size = new System.Drawing.Size(1016, 80);
            this.panelDatosEmpleados.TabIndex = 111;
            this.panelDatosEmpleados.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDatosEmpleados_Paint);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNombreCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(546, 21);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(339, 34);
            this.txtNombreCliente.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(546, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 5);
            this.label1.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 112;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(-3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1019, 10);
            this.label5.TabIndex = 112;
            // 
            // SearchTimer_Tick_Tick
            // 
            this.SearchTimer_Tick_Tick.Tick += new System.EventHandler(this.SearchTimer_Tick_Tick_Tick);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 542);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelDatosEmpleados);
            this.Controls.Add(this.PanelControlesEmpleados);
            this.Controls.Add(this.Panel_txtProductos);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.Panel_txtProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerClientes)).EndInit();
            this.PanelControlesEmpleados.ResumeLayout(false);
            this.panelDatosEmpleados.ResumeLayout(false);
            this.panelDatosEmpleados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_txtProductos;
        private System.Windows.Forms.Label Label_Productos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvVerClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BuscarCliente;
        private System.Windows.Forms.Panel PanelControlesEmpleados;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnDesactivarEmpleado;
        private System.Windows.Forms.Panel panelDatosEmpleados;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer SearchTimer_Tick_Tick;
    }
}
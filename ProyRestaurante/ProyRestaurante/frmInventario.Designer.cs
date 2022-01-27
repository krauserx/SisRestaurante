namespace ProyRestaurante
{
    partial class frmInventario
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
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVencimiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDINVENTARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNGREDIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENCIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPROVEEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLINVENTARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDRestaurantesDataSet = new ProyRestaurante.BDRestaurantesDataSet();
            this.btnAct = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarNu = new System.Windows.Forms.Button();
            this.tBL_INVENTARIOTableAdapter = new ProyRestaurante.BDRestaurantesDataSetTableAdapters.TBL_INVENTARIOTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVENTARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDRestaurantesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(698, 393);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(160, 26);
            this.txtIdent.TabIndex = 96;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(662, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 22);
            this.label13.TabIndex = 94;
            this.label13.Text = "ID de Inventario a eliminar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInventario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVencimiento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Location = new System.Drawing.Point(194, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 290);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Visible = false;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(244, 145);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(148, 28);
            this.cmbProveedor.TabIndex = 79;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Image = global::ProyRestaurante.Properties.Resources.inventario;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(209, 206);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(227, 39);
            this.btnActualizar.TabIndex = 78;
            this.btnActualizar.Text = "Actualizar Inventario";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(477, 197);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(136, 26);
            this.txtIdentificacion.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ProyRestaurante.Properties.Resources.plataforma;
            this.pictureBox1.Location = new System.Drawing.Point(477, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 75;
            this.label5.Text = "ID Usuario";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SkyBlue;
            this.btnVolver.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Image = global::ProyRestaurante.Properties.Resources.atras;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.Location = new System.Drawing.Point(413, 21);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(46, 41);
            this.btnVolver.TabIndex = 74;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnInsertar.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertar.Image = global::ProyRestaurante.Properties.Resources.inventario;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.Location = new System.Drawing.Point(265, 206);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(114, 39);
            this.btnInsertar.TabIndex = 73;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ingrediente";
            // 
            // txtInventario
            // 
            this.txtInventario.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventario.Location = new System.Drawing.Point(244, 23);
            this.txtInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(148, 30);
            this.txtInventario.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 55;
            this.label6.Text = "Vencimiento";
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimiento.Location = new System.Drawing.Point(244, 63);
            this.txtVencimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(148, 30);
            this.txtVencimiento.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 57;
            this.label7.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 22);
            this.label9.TabIndex = 59;
            this.label9.Text = "ID Proveedor";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(244, 103);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(148, 30);
            this.txtMarca.TabIndex = 58;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDINVENTARIODataGridViewTextBoxColumn,
            this.iNGREDIENTEDataGridViewTextBoxColumn,
            this.vENCIMIENTODataGridViewTextBoxColumn,
            this.mARCADataGridViewTextBoxColumn,
            this.iDPROVEEDORDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tBLINVENTARIOBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(134, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(804, 290);
            this.dataGridView2.TabIndex = 90;
            // 
            // iDINVENTARIODataGridViewTextBoxColumn
            // 
            this.iDINVENTARIODataGridViewTextBoxColumn.DataPropertyName = "ID_INVENTARIO";
            this.iDINVENTARIODataGridViewTextBoxColumn.HeaderText = "ID_INVENTARIO";
            this.iDINVENTARIODataGridViewTextBoxColumn.Name = "iDINVENTARIODataGridViewTextBoxColumn";
            this.iDINVENTARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDINVENTARIODataGridViewTextBoxColumn.Width = 169;
            // 
            // iNGREDIENTEDataGridViewTextBoxColumn
            // 
            this.iNGREDIENTEDataGridViewTextBoxColumn.DataPropertyName = "INGREDIENTE";
            this.iNGREDIENTEDataGridViewTextBoxColumn.HeaderText = "INGREDIENTE";
            this.iNGREDIENTEDataGridViewTextBoxColumn.Name = "iNGREDIENTEDataGridViewTextBoxColumn";
            this.iNGREDIENTEDataGridViewTextBoxColumn.Width = 156;
            // 
            // vENCIMIENTODataGridViewTextBoxColumn
            // 
            this.vENCIMIENTODataGridViewTextBoxColumn.DataPropertyName = "VENCIMIENTO";
            this.vENCIMIENTODataGridViewTextBoxColumn.HeaderText = "VENCIMIENTO";
            this.vENCIMIENTODataGridViewTextBoxColumn.Name = "vENCIMIENTODataGridViewTextBoxColumn";
            this.vENCIMIENTODataGridViewTextBoxColumn.Width = 155;
            // 
            // mARCADataGridViewTextBoxColumn
            // 
            this.mARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA";
            this.mARCADataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.mARCADataGridViewTextBoxColumn.Name = "mARCADataGridViewTextBoxColumn";
            this.mARCADataGridViewTextBoxColumn.Width = 103;
            // 
            // iDPROVEEDORDataGridViewTextBoxColumn
            // 
            this.iDPROVEEDORDataGridViewTextBoxColumn.DataPropertyName = "ID_PROVEEDOR";
            this.iDPROVEEDORDataGridViewTextBoxColumn.HeaderText = "ID_PROVEEDOR";
            this.iDPROVEEDORDataGridViewTextBoxColumn.Name = "iDPROVEEDORDataGridViewTextBoxColumn";
            this.iDPROVEEDORDataGridViewTextBoxColumn.Width = 174;
            // 
            // tBLINVENTARIOBindingSource
            // 
            this.tBLINVENTARIOBindingSource.DataMember = "TBL_INVENTARIO";
            this.tBLINVENTARIOBindingSource.DataSource = this.bDRestaurantesDataSet;
            // 
            // bDRestaurantesDataSet
            // 
            this.bDRestaurantesDataSet.DataSetName = "BDRestaurantesDataSet";
            this.bDRestaurantesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAct.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAct.Image = global::ProyRestaurante.Properties.Resources.inventario;
            this.btnAct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAct.Location = new System.Drawing.Point(403, 427);
            this.btnAct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(226, 52);
            this.btnAct.TabIndex = 97;
            this.btnAct.Text = "Actualizar Inventario";
            this.btnAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::ProyRestaurante.Properties.Resources.plataforma;
            this.pictureBox2.Location = new System.Drawing.Point(878, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Image = global::ProyRestaurante.Properties.Resources.inventario;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(666, 427);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 52);
            this.btnEliminar.TabIndex = 92;
            this.btnEliminar.Text = "Eliminar Registro";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarNu
            // 
            this.btnAgregarNu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAgregarNu.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarNu.Image = global::ProyRestaurante.Properties.Resources.inventario;
            this.btnAgregarNu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNu.Location = new System.Drawing.Point(86, 427);
            this.btnAgregarNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarNu.Name = "btnAgregarNu";
            this.btnAgregarNu.Size = new System.Drawing.Size(241, 52);
            this.btnAgregarNu.TabIndex = 91;
            this.btnAgregarNu.Text = "Agregar Nuevo Registro";
            this.btnAgregarNu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNu.UseVisualStyleBackColor = false;
            this.btnAgregarNu.Click += new System.EventHandler(this.btnAgregarNu_Click);
            // 
            // tBL_INVENTARIOTableAdapter
            // 
            this.tBL_INVENTARIOTableAdapter.ClearBeforeFill = true;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 491);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarNu);
            this.Controls.Add(this.dataGridView2);
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVENTARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDRestaurantesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVencimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarNu;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private BDRestaurantesDataSet bDRestaurantesDataSet;
        private System.Windows.Forms.BindingSource tBLINVENTARIOBindingSource;
        private BDRestaurantesDataSetTableAdapters.TBL_INVENTARIOTableAdapter tBL_INVENTARIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDINVENTARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNGREDIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENCIMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROVEEDORDataGridViewTextBoxColumn;
    }
}
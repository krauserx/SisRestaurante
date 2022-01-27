namespace ProyRestaurante
{
    partial class frmMesas
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
            this.btnAct = new System.Windows.Forms.Button();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSucur = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarNu = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDMESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSUCURSALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAPACIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLMESASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDRestaurantesDataSet = new ProyRestaurante.BDRestaurantesDataSet();
            this.tBL_MESASTableAdapter = new ProyRestaurante.BDRestaurantesDataSetTableAdapters.TBL_MESASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMESASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDRestaurantesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAct.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAct.Image = global::ProyRestaurante.Properties.Resources.mesa;
            this.btnAct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAct.Location = new System.Drawing.Point(287, 400);
            this.btnAct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(192, 52);
            this.btnAct.TabIndex = 105;
            this.btnAct.Text = "Actualizar Mesa";
            this.btnAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(522, 356);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(160, 26);
            this.txtIdent.TabIndex = 104;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::ProyRestaurante.Properties.Resources.plataforma;
            this.pictureBox2.Location = new System.Drawing.Point(721, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(487, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 22);
            this.label13.TabIndex = 102;
            this.label13.Text = "ID de Inventario a eliminar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSucur);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCapacidad);
            this.groupBox1.Location = new System.Drawing.Point(78, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 246);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Visible = false;
            // 
            // cmbSucur
            // 
            this.cmbSucur.FormattingEnabled = true;
            this.cmbSucur.Location = new System.Drawing.Point(231, 83);
            this.cmbSucur.Name = "cmbSucur";
            this.cmbSucur.Size = new System.Drawing.Size(148, 28);
            this.cmbSucur.TabIndex = 79;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Image = global::ProyRestaurante.Properties.Resources.mesa;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(209, 166);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(192, 39);
            this.btnActualizar.TabIndex = 78;
            this.btnActualizar.Text = "Actualizar Mesa";
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
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 75;
            this.label5.Text = "ID Mesa";
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
            this.btnInsertar.Image = global::ProyRestaurante.Properties.Resources.mesa;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.Location = new System.Drawing.Point(251, 166);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(114, 39);
            this.btnInsertar.TabIndex = 73;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 57;
            this.label7.Text = "Capacidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 22);
            this.label9.TabIndex = 59;
            this.label9.Text = "ID Sucursal";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Location = new System.Drawing.Point(231, 41);
            this.txtCapacidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(148, 30);
            this.txtCapacidad.TabIndex = 58;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Image = global::ProyRestaurante.Properties.Resources.mesa;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(522, 400);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 52);
            this.btnEliminar.TabIndex = 100;
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
            this.btnAgregarNu.Image = global::ProyRestaurante.Properties.Resources.mesa;
            this.btnAgregarNu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNu.Location = new System.Drawing.Point(15, 400);
            this.btnAgregarNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarNu.Name = "btnAgregarNu";
            this.btnAgregarNu.Size = new System.Drawing.Size(227, 52);
            this.btnAgregarNu.TabIndex = 99;
            this.btnAgregarNu.Text = "Agregar Nuevo Mesa";
            this.btnAgregarNu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNu.UseVisualStyleBackColor = false;
            this.btnAgregarNu.Click += new System.EventHandler(this.btnAgregarNu_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMESADataGridViewTextBoxColumn,
            this.iDSUCURSALDataGridViewTextBoxColumn,
            this.cAPACIDADDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tBLMESASBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(240, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(442, 274);
            this.dataGridView2.TabIndex = 98;
            // 
            // iDMESADataGridViewTextBoxColumn
            // 
            this.iDMESADataGridViewTextBoxColumn.DataPropertyName = "ID_MESA";
            this.iDMESADataGridViewTextBoxColumn.HeaderText = "ID_MESA";
            this.iDMESADataGridViewTextBoxColumn.Name = "iDMESADataGridViewTextBoxColumn";
            this.iDMESADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMESADataGridViewTextBoxColumn.Width = 117;
            // 
            // iDSUCURSALDataGridViewTextBoxColumn
            // 
            this.iDSUCURSALDataGridViewTextBoxColumn.DataPropertyName = "ID_SUCURSAL";
            this.iDSUCURSALDataGridViewTextBoxColumn.HeaderText = "ID_SUCURSAL";
            this.iDSUCURSALDataGridViewTextBoxColumn.Name = "iDSUCURSALDataGridViewTextBoxColumn";
            this.iDSUCURSALDataGridViewTextBoxColumn.Width = 160;
            // 
            // cAPACIDADDataGridViewTextBoxColumn
            // 
            this.cAPACIDADDataGridViewTextBoxColumn.DataPropertyName = "CAPACIDAD";
            this.cAPACIDADDataGridViewTextBoxColumn.HeaderText = "CAPACIDAD";
            this.cAPACIDADDataGridViewTextBoxColumn.Name = "cAPACIDADDataGridViewTextBoxColumn";
            this.cAPACIDADDataGridViewTextBoxColumn.Width = 139;
            // 
            // tBLMESASBindingSource
            // 
            this.tBLMESASBindingSource.DataMember = "TBL_MESAS";
            this.tBLMESASBindingSource.DataSource = this.bDRestaurantesDataSet;
            // 
            // bDRestaurantesDataSet
            // 
            this.bDRestaurantesDataSet.DataSetName = "BDRestaurantesDataSet";
            this.bDRestaurantesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_MESASTableAdapter
            // 
            this.tBL_MESASTableAdapter.ClearBeforeFill = true;
            // 
            // frmMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 464);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarNu);
            this.Controls.Add(this.dataGridView2);
            this.Name = "frmMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMesas";
            this.Load += new System.EventHandler(this.frmMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMESASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDRestaurantesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSucur;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarNu;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BDRestaurantesDataSet bDRestaurantesDataSet;
        private System.Windows.Forms.BindingSource tBLMESASBindingSource;
        private BDRestaurantesDataSetTableAdapters.TBL_MESASTableAdapter tBL_MESASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSUCURSALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAPACIDADDataGridViewTextBoxColumn;
    }
}
namespace ProbabilidadEstadistica
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAgrupados = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtFrecuencias = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblProbEst = new System.Windows.Forms.Label();
            this.chartDatos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvDesagrupados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstadisticas = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblDesagrupados = new System.Windows.Forms.Label();
            this.lblAgrupados = new System.Windows.Forms.Label();
            this.btnDesagrupados = new System.Windows.Forms.Button();
            this.btnAgrupados = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDatosMensaje = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbTipoGrafico = new System.Windows.Forms.ComboBox();
            this.lblTipoGrafico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgrupados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesagrupados)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAgrupados
            // 
            this.dgvAgrupados.AllowUserToAddRows = false;
            this.dgvAgrupados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgrupados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgvAgrupados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAgrupados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvAgrupados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgrupados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAgrupados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgrupados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.Frecuencia});
            this.dgvAgrupados.EnableHeadersVisualStyles = false;
            this.dgvAgrupados.GridColor = System.Drawing.Color.Silver;
            this.dgvAgrupados.Location = new System.Drawing.Point(26, 310);
            this.dgvAgrupados.Margin = new System.Windows.Forms.Padding(1);
            this.dgvAgrupados.Name = "dgvAgrupados";
            this.dgvAgrupados.ReadOnly = true;
            this.dgvAgrupados.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAgrupados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAgrupados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgrupados.Size = new System.Drawing.Size(418, 176);
            this.dgvAgrupados.TabIndex = 0;
            this.dgvAgrupados.Visible = false;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Frecuencia
            // 
            this.Frecuencia.HeaderText = "Frecuencia";
            this.Frecuencia.Name = "Frecuencia";
            this.Frecuencia.ReadOnly = true;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(325, 157);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(116, 24);
            this.txtValor.TabIndex = 2;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFrecuencias
            // 
            this.txtFrecuencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFrecuencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFrecuencias.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrecuencias.ForeColor = System.Drawing.Color.Black;
            this.txtFrecuencias.Location = new System.Drawing.Point(327, 194);
            this.txtFrecuencias.MaxLength = 27;
            this.txtFrecuencias.Name = "txtFrecuencias";
            this.txtFrecuencias.Size = new System.Drawing.Size(114, 24);
            this.txtFrecuencias.TabIndex = 3;
            this.txtFrecuencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(272, 158);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(47, 21);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrecuencia.ForeColor = System.Drawing.Color.White;
            this.lblFrecuencia.Location = new System.Drawing.Point(231, 195);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(88, 21);
            this.lblFrecuencia.TabIndex = 5;
            this.lblFrecuencia.Text = "Frecuencia";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Crimson;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(488, 190);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(1);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 33);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Crimson;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(488, 151);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 33);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProbEst
            // 
            this.lblProbEst.AutoSize = true;
            this.lblProbEst.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProbEst.ForeColor = System.Drawing.Color.LightGray;
            this.lblProbEst.Location = new System.Drawing.Point(276, 19);
            this.lblProbEst.Name = "lblProbEst";
            this.lblProbEst.Size = new System.Drawing.Size(349, 32);
            this.lblProbEst.TabIndex = 8;
            this.lblProbEst.Text = "PROBABILIDAD Y ESTADÍSTICA";
            // 
            // chartDatos
            // 
            this.chartDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.chartDatos.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartDatos.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.chartDatos.BorderlineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chartDatos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDatos.Legends.Add(legend2);
            this.chartDatos.Location = new System.Drawing.Point(26, 554);
            this.chartDatos.Name = "chartDatos";
            this.chartDatos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartDatos.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Crimson,
        System.Drawing.Color.IndianRed};
            series2.ChartArea = "ChartArea1";
            series2.LabelBackColor = System.Drawing.Color.Gray;
            series2.LabelBorderColor = System.Drawing.Color.Silver;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDatos.Series.Add(series2);
            this.chartDatos.Size = new System.Drawing.Size(846, 255);
            this.chartDatos.TabIndex = 9;
            this.chartDatos.Visible = false;
            // 
            // dgvDesagrupados
            // 
            this.dgvDesagrupados.AllowUserToAddRows = false;
            this.dgvDesagrupados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesagrupados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgvDesagrupados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDesagrupados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvDesagrupados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDesagrupados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDesagrupados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesagrupados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvDesagrupados.EnableHeadersVisualStyles = false;
            this.dgvDesagrupados.GridColor = System.Drawing.Color.Silver;
            this.dgvDesagrupados.Location = new System.Drawing.Point(109, 310);
            this.dgvDesagrupados.Margin = new System.Windows.Forms.Padding(1);
            this.dgvDesagrupados.Name = "dgvDesagrupados";
            this.dgvDesagrupados.ReadOnly = true;
            this.dgvDesagrupados.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDesagrupados.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDesagrupados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDesagrupados.Size = new System.Drawing.Size(253, 176);
            this.dgvDesagrupados.TabIndex = 10;
            this.dgvDesagrupados.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblEstadisticas
            // 
            this.lblEstadisticas.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadisticas.ForeColor = System.Drawing.Color.Silver;
            this.lblEstadisticas.Location = new System.Drawing.Point(483, 310);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(404, 176);
            this.lblEstadisticas.TabIndex = 11;
            this.lblEstadisticas.Text = "DATO 1\r\nDATO 2\r\nDATO 3 \r\nDATO 4";
            this.lblEstadisticas.Visible = false;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.ForeColor = System.Drawing.Color.IndianRed;
            this.lblResultados.Location = new System.Drawing.Point(483, 276);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(110, 26);
            this.lblResultados.TabIndex = 12;
            this.lblResultados.Text = "Resultados:";
            this.lblResultados.Visible = false;
            // 
            // lblDesagrupados
            // 
            this.lblDesagrupados.AutoSize = true;
            this.lblDesagrupados.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesagrupados.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDesagrupados.Location = new System.Drawing.Point(156, 277);
            this.lblDesagrupados.Name = "lblDesagrupados";
            this.lblDesagrupados.Size = new System.Drawing.Size(158, 26);
            this.lblDesagrupados.TabIndex = 13;
            this.lblDesagrupados.Text = "DESAGRUPADOS";
            this.lblDesagrupados.Visible = false;
            // 
            // lblAgrupados
            // 
            this.lblAgrupados.AutoSize = true;
            this.lblAgrupados.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrupados.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAgrupados.Location = new System.Drawing.Point(173, 276);
            this.lblAgrupados.Name = "lblAgrupados";
            this.lblAgrupados.Size = new System.Drawing.Size(124, 26);
            this.lblAgrupados.TabIndex = 14;
            this.lblAgrupados.Text = "AGRUPADOS";
            this.lblAgrupados.Visible = false;
            // 
            // btnDesagrupados
            // 
            this.btnDesagrupados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.btnDesagrupados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDesagrupados.FlatAppearance.BorderSize = 0;
            this.btnDesagrupados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesagrupados.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesagrupados.ForeColor = System.Drawing.Color.DimGray;
            this.btnDesagrupados.Location = new System.Drawing.Point(1, 1);
            this.btnDesagrupados.Margin = new System.Windows.Forms.Padding(1);
            this.btnDesagrupados.Name = "btnDesagrupados";
            this.btnDesagrupados.Size = new System.Drawing.Size(169, 34);
            this.btnDesagrupados.TabIndex = 15;
            this.btnDesagrupados.Text = "DESAGRUPADOS";
            this.btnDesagrupados.UseVisualStyleBackColor = false;
            this.btnDesagrupados.Click += new System.EventHandler(this.btnDesagrupados_Click);
            // 
            // btnAgrupados
            // 
            this.btnAgrupados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.btnAgrupados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgrupados.FlatAppearance.BorderSize = 0;
            this.btnAgrupados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrupados.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrupados.ForeColor = System.Drawing.Color.DimGray;
            this.btnAgrupados.Location = new System.Drawing.Point(172, 1);
            this.btnAgrupados.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgrupados.Name = "btnAgrupados";
            this.btnAgrupados.Size = new System.Drawing.Size(170, 34);
            this.btnAgrupados.TabIndex = 16;
            this.btnAgrupados.Text = "AGRUPADOS";
            this.btnAgrupados.UseVisualStyleBackColor = false;
            this.btnAgrupados.Click += new System.EventHandler(this.btnAgrupados_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDesagrupados, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAgrupados, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(282, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 36);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lblDatosMensaje
            // 
            this.lblDatosMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosMensaje.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblDatosMensaje.Location = new System.Drawing.Point(231, 344);
            this.lblDatosMensaje.Name = "lblDatosMensaje";
            this.lblDatosMensaje.Size = new System.Drawing.Size(438, 143);
            this.lblDatosMensaje.TabIndex = 18;
            this.lblDatosMensaje.Text = "SELECCIONE AGRUPADOS O DESAGRUPADOS";
            this.lblDatosMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(635, 151);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(1);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 33);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(842, 23);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_MouseHover);
            // 
            // cmbTipoGrafico
            // 
            this.cmbTipoGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoGrafico.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoGrafico.FormattingEnabled = true;
            this.cmbTipoGrafico.Location = new System.Drawing.Point(26, 527);
            this.cmbTipoGrafico.Name = "cmbTipoGrafico";
            this.cmbTipoGrafico.Size = new System.Drawing.Size(336, 25);
            this.cmbTipoGrafico.TabIndex = 21;
            this.cmbTipoGrafico.Visible = false;
            this.cmbTipoGrafico.SelectedIndexChanged += new System.EventHandler(this.cmbTipoGrafico_SelectedIndexChanged);
            // 
            // lblTipoGrafico
            // 
            this.lblTipoGrafico.AutoSize = true;
            this.lblTipoGrafico.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoGrafico.ForeColor = System.Drawing.Color.White;
            this.lblTipoGrafico.Location = new System.Drawing.Point(22, 503);
            this.lblTipoGrafico.Name = "lblTipoGrafico";
            this.lblTipoGrafico.Size = new System.Drawing.Size(227, 21);
            this.lblTipoGrafico.TabIndex = 22;
            this.lblTipoGrafico.Text = "Seleccionar el tipo de gráfico:";
            this.lblTipoGrafico.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(900, 821);
            this.Controls.Add(this.lblTipoGrafico);
            this.Controls.Add(this.cmbTipoGrafico);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblDatosMensaje);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblAgrupados);
            this.Controls.Add(this.lblDesagrupados);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblEstadisticas);
            this.Controls.Add(this.dgvDesagrupados);
            this.Controls.Add(this.chartDatos);
            this.Controls.Add(this.lblProbEst);
            this.Controls.Add(this.lblFrecuencia);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtFrecuencias);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.dgvAgrupados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgrupados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesagrupados)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgrupados;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtFrecuencias;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblProbEst;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDatos;
        private System.Windows.Forms.DataGridView dgvDesagrupados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblEstadisticas;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblDesagrupados;
        private System.Windows.Forms.Label lblAgrupados;
        private System.Windows.Forms.Button btnDesagrupados;
        private System.Windows.Forms.Button btnAgrupados;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDatosMensaje;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbTipoGrafico;
        private System.Windows.Forms.Label lblTipoGrafico;
    }
}


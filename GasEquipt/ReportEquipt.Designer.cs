namespace GasEquipt
{
	partial class ReportEquipt
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gazmechDataSet = new GasEquipt.gazmechDataSet();
			this.assembl_gas_equiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.assembl_gas_equiptTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.assembl_gas_equiptTableAdapter();
			this.tableAdapterManager = new GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager();
			this.panel1 = new System.Windows.Forms.Panel();
			this.assembl_gas_equiptDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gas_equiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gas_equiptTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_equiptTableAdapter();
			this.button2 = new System.Windows.Forms.Button();
			this.craftitemsreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.craftitemsreportTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.craftitemsreportTableAdapter();
			this.assembl_gas_equiptDataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.assembl_gas_equiptBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.assembl_gas_equiptDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.craftitemsreportBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.assembl_gas_equiptDataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gazmechDataSet
			// 
			this.gazmechDataSet.DataSetName = "gazmechDataSet";
			this.gazmechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// assembl_gas_equiptBindingSource
			// 
			this.assembl_gas_equiptBindingSource.DataMember = "assembl_gas_equipt";
			this.assembl_gas_equiptBindingSource.DataSource = this.gazmechDataSet;
			// 
			// assembl_gas_equiptTableAdapter
			// 
			this.assembl_gas_equiptTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.assembl_gas_equiptTableAdapter = this.assembl_gas_equiptTableAdapter;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.component_componyTableAdapter = null;
			this.tableAdapterManager.craftitemsreportTableAdapter = null;
			this.tableAdapterManager.gas_component_admissionTableAdapter = null;
			this.tableAdapterManager.gas_componentTableAdapter = null;
			this.tableAdapterManager.gas_equiptTableAdapter = null;
			this.tableAdapterManager.gas_reciptTableAdapter = null;
			this.tableAdapterManager.loginTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.assembl_gas_equiptDataGridView);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.dateTimePicker2);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.ForeColor = System.Drawing.SystemColors.Control;
			this.panel1.Location = new System.Drawing.Point(0, 485);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(666, 184);
			this.panel1.TabIndex = 1;
			// 
			// assembl_gas_equiptDataGridView
			// 
			this.assembl_gas_equiptDataGridView.AllowUserToAddRows = false;
			this.assembl_gas_equiptDataGridView.AllowUserToDeleteRows = false;
			this.assembl_gas_equiptDataGridView.AutoGenerateColumns = false;
			this.assembl_gas_equiptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.assembl_gas_equiptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
			this.assembl_gas_equiptDataGridView.DataSource = this.assembl_gas_equiptBindingSource;
			this.assembl_gas_equiptDataGridView.Location = new System.Drawing.Point(585, 169);
			this.assembl_gas_equiptDataGridView.Name = "assembl_gas_equiptDataGridView";
			this.assembl_gas_equiptDataGridView.ReadOnly = true;
			this.assembl_gas_equiptDataGridView.Size = new System.Drawing.Size(10, 10);
			this.assembl_gas_equiptDataGridView.TabIndex = 8;
			this.assembl_gas_equiptDataGridView.Visible = false;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "idassembl";
			this.dataGridViewTextBoxColumn8.HeaderText = "idassembl";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "id_gas_equipt";
			this.dataGridViewTextBoxColumn9.HeaderText = "id_gas_equipt";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "agq_data";
			this.dataGridViewTextBoxColumn10.HeaderText = "agq_data";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "agq_count";
			this.dataGridViewTextBoxColumn11.HeaderText = "agq_count";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			// 
			// gas_equiptBindingSource
			// 
			this.gas_equiptBindingSource.DataMember = "gas_equipt";
			this.gas_equiptBindingSource.DataSource = this.gazmechDataSet;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(417, 84);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(178, 79);
			this.button1.TabIndex = 5;
			this.button1.Text = "Поиск";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(62, 134);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(335, 26);
			this.dateTimePicker2.TabIndex = 4;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(62, 84);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(335, 26);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Поиск";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "По:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "C:";
			// 
			// gas_equiptTableAdapter
			// 
			this.gas_equiptTableAdapter.ClearBeforeFill = true;
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(601, 485);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(321, 184);
			this.button2.TabIndex = 2;
			this.button2.Text = "Укажите дату для печати!";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// craftitemsreportBindingSource
			// 
			this.craftitemsreportBindingSource.DataMember = "craftitemsreport";
			this.craftitemsreportBindingSource.DataSource = this.gazmechDataSet;
			// 
			// craftitemsreportTableAdapter
			// 
			this.craftitemsreportTableAdapter.ClearBeforeFill = true;
			// 
			// assembl_gas_equiptDataGridView1
			// 
			this.assembl_gas_equiptDataGridView1.AllowUserToAddRows = false;
			this.assembl_gas_equiptDataGridView1.AllowUserToDeleteRows = false;
			this.assembl_gas_equiptDataGridView1.AutoGenerateColumns = false;
			this.assembl_gas_equiptDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.assembl_gas_equiptDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Name,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
			this.assembl_gas_equiptDataGridView1.DataSource = this.assembl_gas_equiptBindingSource;
			this.assembl_gas_equiptDataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.assembl_gas_equiptDataGridView1.Location = new System.Drawing.Point(0, 0);
			this.assembl_gas_equiptDataGridView1.Name = "assembl_gas_equiptDataGridView1";
			this.assembl_gas_equiptDataGridView1.ReadOnly = true;
			this.assembl_gas_equiptDataGridView1.Size = new System.Drawing.Size(942, 479);
			this.assembl_gas_equiptDataGridView1.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idassembl";
			this.dataGridViewTextBoxColumn1.HeaderText = "idassembl";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "id_gas_equipt";
			this.dataGridViewTextBoxColumn2.HeaderText = "id_gas_equipt";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Visible = false;
			// 
			// Name
			// 
			this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Name.DataPropertyName = "gq_name";
			this.Name.HeaderText = "Название оборудования";
			this.Name.Name = "Name";
			this.Name.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "agq_count";
			this.dataGridViewTextBoxColumn4.FillWeight = 50F;
			this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "agq_data";
			this.dataGridViewTextBoxColumn3.FillWeight = 50F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// ReportEquipt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.assembl_gas_equiptDataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Size = new System.Drawing.Size(942, 689);
			this.Load += new System.EventHandler(this.ReportEquipt_Load);
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.assembl_gas_equiptBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.assembl_gas_equiptDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.craftitemsreportBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.assembl_gas_equiptDataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private gazmechDataSet gazmechDataSet;
		private System.Windows.Forms.BindingSource assembl_gas_equiptBindingSource;
		private gazmechDataSetTableAdapters.assembl_gas_equiptTableAdapter assembl_gas_equiptTableAdapter;
		private gazmechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource gas_equiptBindingSource;
		private gazmechDataSetTableAdapters.gas_equiptTableAdapter gas_equiptTableAdapter;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.BindingSource craftitemsreportBindingSource;
		private gazmechDataSetTableAdapters.craftitemsreportTableAdapter craftitemsreportTableAdapter;
		private System.Windows.Forms.DataGridView assembl_gas_equiptDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridView assembl_gas_equiptDataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}

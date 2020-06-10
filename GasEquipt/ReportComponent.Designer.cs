namespace GasEquipt
{
	partial class ReportComponent
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
			this.gas_component_admissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_component_admissionTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_component_admissionTableAdapter();
			this.tableAdapterManager = new GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager();
			this.gas_componentTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_componentTableAdapter();
			this.gas_componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button2 = new System.Windows.Forms.Button();
			this.craftItemsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.craftitemsreportTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.craftitemsreportTableAdapter();
			this.craftitemsreportDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.craftitemsreportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_component_admissionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.craftItemsReportBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.craftitemsreportDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.craftitemsreportBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// gazmechDataSet
			// 
			this.gazmechDataSet.DataSetName = "gazmechDataSet";
			this.gazmechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gas_component_admissionBindingSource
			// 
			this.gas_component_admissionBindingSource.DataMember = "gas_component_admission";
			this.gas_component_admissionBindingSource.DataSource = this.gazmechDataSet;
			// 
			// gas_component_admissionTableAdapter
			// 
			this.gas_component_admissionTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.assembl_gas_equiptTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.component_componyTableAdapter = null;
			this.tableAdapterManager.craftitemsreportTableAdapter = null;
			this.tableAdapterManager.gas_component_admissionTableAdapter = this.gas_component_admissionTableAdapter;
			this.tableAdapterManager.gas_componentTableAdapter = this.gas_componentTableAdapter;
			this.tableAdapterManager.gas_equiptTableAdapter = null;
			this.tableAdapterManager.gas_reciptTableAdapter = null;
			this.tableAdapterManager.loginTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// gas_componentTableAdapter
			// 
			this.gas_componentTableAdapter.ClearBeforeFill = true;
			// 
			// gas_componentBindingSource
			// 
			this.gas_componentBindingSource.DataMember = "gas_component";
			this.gas_componentBindingSource.DataSource = this.gazmechDataSet;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Поиск";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dateTimePicker2);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 485);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(601, 180);
			this.panel1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(421, 66);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 85);
			this.button1.TabIndex = 7;
			this.button1.Text = "Поиск";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(13, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "По:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(13, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "С:";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "\"MM/dd/yyyy\"";
			this.dateTimePicker2.Location = new System.Drawing.Point(58, 120);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(334, 26);
			this.dateTimePicker2.TabIndex = 4;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "\"MM/dd/yyyy\"";
			this.dateTimePicker1.Location = new System.Drawing.Point(58, 66);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(334, 26);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(594, 485);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(327, 180);
			this.button2.TabIndex = 4;
			this.button2.Text = "Укажите дату для печати!";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// craftItemsReportBindingSource
			// 
			this.craftItemsReportBindingSource.DataMember = "craftitemsreport";
			this.craftItemsReportBindingSource.DataSource = this.gazmechDataSet;
			// 
			// craftitemsreportTableAdapter
			// 
			this.craftitemsreportTableAdapter.ClearBeforeFill = true;
			// 
			// craftitemsreportDataGridView
			// 
			this.craftitemsreportDataGridView.AllowUserToAddRows = false;
			this.craftitemsreportDataGridView.AllowUserToDeleteRows = false;
			this.craftitemsreportDataGridView.AutoGenerateColumns = false;
			this.craftitemsreportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.craftitemsreportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.craftitemsreportDataGridView.DataSource = this.craftitemsreportBindingSource1;
			this.craftitemsreportDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
			this.craftitemsreportDataGridView.Location = new System.Drawing.Point(0, 0);
			this.craftitemsreportDataGridView.Name = "craftitemsreportDataGridView";
			this.craftitemsreportDataGridView.ReadOnly = true;
			this.craftitemsreportDataGridView.Size = new System.Drawing.Size(925, 479);
			this.craftitemsreportDataGridView.TabIndex = 4;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idcip";
			this.dataGridViewTextBoxColumn1.HeaderText = "idcip";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Equipt";
			this.dataGridViewTextBoxColumn3.HeaderText = "Оборудование";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Compon";
			this.dataGridViewTextBoxColumn2.HeaderText = "Компонент";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "count";
			this.dataGridViewTextBoxColumn6.FillWeight = 50F;
			this.dataGridViewTextBoxColumn6.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "craftdate";
			this.dataGridViewTextBoxColumn7.FillWeight = 50F;
			this.dataGridViewTextBoxColumn7.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "idComp";
			this.dataGridViewTextBoxColumn4.HeaderText = "idComp";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Visible = false;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "idEquip";
			this.dataGridViewTextBoxColumn5.HeaderText = "idEquip";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Visible = false;
			// 
			// craftitemsreportBindingSource1
			// 
			this.craftitemsreportBindingSource1.DataMember = "craftitemsreport";
			this.craftitemsreportBindingSource1.DataSource = this.gazmechDataSet;
			// 
			// ReportComponent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.craftitemsreportDataGridView);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ReportComponent";
			this.Size = new System.Drawing.Size(925, 676);
			this.Load += new System.EventHandler(this.ReportComponent_Load);
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_component_admissionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.craftItemsReportBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.craftitemsreportDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.craftitemsreportBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private gazmechDataSet gazmechDataSet;
		private System.Windows.Forms.BindingSource gas_component_admissionBindingSource;
		private gazmechDataSetTableAdapters.gas_component_admissionTableAdapter gas_component_admissionTableAdapter;
		private gazmechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private gazmechDataSetTableAdapters.gas_componentTableAdapter gas_componentTableAdapter;
		private System.Windows.Forms.BindingSource gas_componentBindingSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.BindingSource craftItemsReportBindingSource;
		private gazmechDataSetTableAdapters.craftitemsreportTableAdapter craftitemsreportTableAdapter;
		private System.Windows.Forms.DataGridView craftitemsreportDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.BindingSource craftitemsreportBindingSource1;
	}
}

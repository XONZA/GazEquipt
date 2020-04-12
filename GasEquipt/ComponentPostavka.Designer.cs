namespace GasEquipt
{
	partial class ComponentPostavka
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
			this.gas_componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_componentTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_componentTableAdapter();
			this.tableAdapterManager = new GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager();
			this.gas_componentDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gas_component_admissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_component_admissionTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_component_admissionTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_component_admissionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gazmechDataSet
			// 
			this.gazmechDataSet.DataSetName = "gazmechDataSet";
			this.gazmechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gas_componentBindingSource
			// 
			this.gas_componentBindingSource.DataMember = "gas_component";
			this.gas_componentBindingSource.DataSource = this.gazmechDataSet;
			// 
			// gas_componentTableAdapter
			// 
			this.gas_componentTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.assembl_gas_equiptTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.component_componyTableAdapter = null;
			this.tableAdapterManager.gas_component_admissionTableAdapter = this.gas_component_admissionTableAdapter;
			this.tableAdapterManager.gas_componentTableAdapter = this.gas_componentTableAdapter;
			this.tableAdapterManager.gas_equiptTableAdapter = null;
			this.tableAdapterManager.gas_reciptTableAdapter = null;
			this.tableAdapterManager.loginTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// gas_componentDataGridView
			// 
			this.gas_componentDataGridView.AllowUserToAddRows = false;
			this.gas_componentDataGridView.AllowUserToDeleteRows = false;
			this.gas_componentDataGridView.AutoGenerateColumns = false;
			this.gas_componentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gas_componentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.gas_componentDataGridView.DataSource = this.gas_componentBindingSource;
			this.gas_componentDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
			this.gas_componentDataGridView.EnableHeadersVisualStyles = false;
			this.gas_componentDataGridView.Location = new System.Drawing.Point(0, 0);
			this.gas_componentDataGridView.Name = "gas_componentDataGridView";
			this.gas_componentDataGridView.ReadOnly = true;
			this.gas_componentDataGridView.Size = new System.Drawing.Size(921, 423);
			this.gas_componentDataGridView.TabIndex = 1;
			this.gas_componentDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Gas_componentDataGridView_MouseClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idgas_component";
			this.dataGridViewTextBoxColumn1.HeaderText = "idgas_component";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "gc_name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Название компонента";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "gc_coast";
			this.dataGridViewTextBoxColumn3.FillWeight = 70F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Цена(руб.)";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "id_compony";
			this.dataGridViewTextBoxColumn4.HeaderText = "id_compony";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Visible = false;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "gc_count";
			this.dataGridViewTextBoxColumn5.FillWeight = 55F;
			this.dataGridViewTextBoxColumn5.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Количество";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(12, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Дата";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(17, 158);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(315, 26);
			this.dateTimePicker1.TabIndex = 4;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(17, 68);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(315, 26);
			this.numericUpDown1.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 423);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(372, 242);
			this.panel1.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Location = new System.Drawing.Point(372, 423);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(549, 242);
			this.button1.TabIndex = 7;
			this.button1.Text = "Выберите компонент из таблицы";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// ComponentPostavka
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gas_componentDataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ComponentPostavka";
			this.Size = new System.Drawing.Size(921, 665);
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_component_admissionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private gazmechDataSet gazmechDataSet;
		private System.Windows.Forms.BindingSource gas_componentBindingSource;
		private gazmechDataSetTableAdapters.gas_componentTableAdapter gas_componentTableAdapter;
		private gazmechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView gas_componentDataGridView;
		private gazmechDataSetTableAdapters.gas_component_admissionTableAdapter gas_component_admissionTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.BindingSource gas_component_admissionBindingSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
	}
}

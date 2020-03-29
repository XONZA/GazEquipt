namespace GasEquipt
{
	partial class EquiptAdd
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
			this.eqa_name = new System.Windows.Forms.Label();
			this.eqa_coast = new System.Windows.Forms.Label();
			this.eqa_boxname = new System.Windows.Forms.TextBox();
			this.gas_componentDataGridView = new System.Windows.Forms.DataGridView();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.eqa_reciptadd = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gq_coastTextBox = new System.Windows.Forms.TextBox();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gas_componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gazmechDataSet = new GasEquipt.gazmechDataSet();
			this.gas_equiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_equiptTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_equiptTableAdapter();
			this.tableAdapterManager = new GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager();
			this.gas_componentTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_componentTableAdapter();
			this.gas_reciptTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_reciptTableAdapter();
			this.gas_reciptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gas_componentDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_reciptBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// eqa_name
			// 
			this.eqa_name.AutoSize = true;
			this.eqa_name.Location = new System.Drawing.Point(16, 17);
			this.eqa_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.eqa_name.Name = "eqa_name";
			this.eqa_name.Size = new System.Drawing.Size(195, 20);
			this.eqa_name.TabIndex = 0;
			this.eqa_name.Text = "Название оборудования";
			// 
			// eqa_coast
			// 
			this.eqa_coast.AutoSize = true;
			this.eqa_coast.Location = new System.Drawing.Point(698, 111);
			this.eqa_coast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.eqa_coast.Name = "eqa_coast";
			this.eqa_coast.Size = new System.Drawing.Size(203, 20);
			this.eqa_coast.TabIndex = 1;
			this.eqa_coast.Text = "Цена оборудования (руб.)";
			// 
			// eqa_boxname
			// 
			this.eqa_boxname.Location = new System.Drawing.Point(20, 60);
			this.eqa_boxname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.eqa_boxname.Name = "eqa_boxname";
			this.eqa_boxname.Size = new System.Drawing.Size(253, 26);
			this.eqa_boxname.TabIndex = 2;
			// 
			// gas_componentDataGridView
			// 
			this.gas_componentDataGridView.AutoGenerateColumns = false;
			this.gas_componentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gas_componentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.gas_componentDataGridView.DataSource = this.gas_componentBindingSource;
			this.gas_componentDataGridView.EnableHeadersVisualStyles = false;
			this.gas_componentDataGridView.Location = new System.Drawing.Point(315, 0);
			this.gas_componentDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gas_componentDataGridView.Name = "gas_componentDataGridView";
			this.gas_componentDataGridView.Size = new System.Drawing.Size(379, 703);
			this.gas_componentDataGridView.TabIndex = 3;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(702, 68);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(209, 26);
			this.numericUpDown1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(702, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Количество";
			// 
			// eqa_reciptadd
			// 
			this.eqa_reciptadd.Location = new System.Drawing.Point(702, 204);
			this.eqa_reciptadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.eqa_reciptadd.Name = "eqa_reciptadd";
			this.eqa_reciptadd.Size = new System.Drawing.Size(209, 35);
			this.eqa_reciptadd.TabIndex = 6;
			this.eqa_reciptadd.Text = "Добавить";
			this.eqa_reciptadd.UseVisualStyleBackColor = true;
			this.eqa_reciptadd.Click += new System.EventHandler(this.Eqa_reciptadd_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(19, 111);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(253, 35);
			this.button1.TabIndex = 7;
			this.button1.Text = "Добавить оборудование";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(4, 580);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(286, 80);
			this.button2.TabIndex = 9;
			this.button2.Text = "Сохранить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSalmon;
			this.panel1.Location = new System.Drawing.Point(298, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(623, 665);
			this.panel1.TabIndex = 10;
			// 
			// gq_coastTextBox
			// 
			this.gq_coastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gas_equiptBindingSource, "gq_coast", true));
			this.gq_coastTextBox.Location = new System.Drawing.Point(702, 150);
			this.gq_coastTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gq_coastTextBox.Name = "gq_coastTextBox";
			this.gq_coastTextBox.ReadOnly = true;
			this.gq_coastTextBox.Size = new System.Drawing.Size(209, 26);
			this.gq_coastTextBox.TabIndex = 11;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idgas_component";
			this.dataGridViewTextBoxColumn1.HeaderText = "idgas_component";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "gc_name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Название комплектующей";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "gc_coast";
			this.dataGridViewTextBoxColumn3.HeaderText = "gc_coast";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Visible = false;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "id_compony";
			this.dataGridViewTextBoxColumn4.HeaderText = "id_compony";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Visible = false;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "gc_count";
			this.dataGridViewTextBoxColumn5.HeaderText = "gc_count";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Visible = false;
			// 
			// gas_componentBindingSource
			// 
			this.gas_componentBindingSource.DataMember = "gas_component";
			this.gas_componentBindingSource.DataSource = this.gazmechDataSet;
			// 
			// gazmechDataSet
			// 
			this.gazmechDataSet.DataSetName = "gazmechDataSet";
			this.gazmechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gas_equiptBindingSource
			// 
			this.gas_equiptBindingSource.DataMember = "gas_equipt";
			this.gas_equiptBindingSource.DataSource = this.gazmechDataSet;
			// 
			// gas_equiptTableAdapter
			// 
			this.gas_equiptTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.assembl_gas_equiptTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.component_componyTableAdapter = null;
			this.tableAdapterManager.gas_component_admissionTableAdapter = null;
			this.tableAdapterManager.gas_componentTableAdapter = this.gas_componentTableAdapter;
			this.tableAdapterManager.gas_equiptTableAdapter = this.gas_equiptTableAdapter;
			this.tableAdapterManager.gas_reciptTableAdapter = this.gas_reciptTableAdapter;
			this.tableAdapterManager.loginTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// gas_componentTableAdapter
			// 
			this.gas_componentTableAdapter.ClearBeforeFill = true;
			// 
			// gas_reciptTableAdapter
			// 
			this.gas_reciptTableAdapter.ClearBeforeFill = true;
			// 
			// gas_reciptBindingSource
			// 
			this.gas_reciptBindingSource.DataMember = "gas_recipt";
			this.gas_reciptBindingSource.DataSource = this.gazmechDataSet;
			// 
			// EquiptAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.eqa_coast);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.eqa_boxname);
			this.Controls.Add(this.eqa_name);
			this.Controls.Add(this.gas_componentDataGridView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.eqa_reciptadd);
			this.Controls.Add(this.gq_coastTextBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximumSize = new System.Drawing.Size(1388, 1017);
			this.Name = "EquiptAdd";
			this.Size = new System.Drawing.Size(921, 665);
			this.Load += new System.EventHandler(this.EquiptAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.gas_componentDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_reciptBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private gazmechDataSet gazmechDataSet;
		private System.Windows.Forms.BindingSource gas_equiptBindingSource;
		private gazmechDataSetTableAdapters.gas_equiptTableAdapter gas_equiptTableAdapter;
		private gazmechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private gazmechDataSetTableAdapters.gas_componentTableAdapter gas_componentTableAdapter;
		private gazmechDataSetTableAdapters.gas_reciptTableAdapter gas_reciptTableAdapter;
		private System.Windows.Forms.BindingSource gas_reciptBindingSource;
		private System.Windows.Forms.Label eqa_name;
		private System.Windows.Forms.Label eqa_coast;
		private System.Windows.Forms.TextBox eqa_boxname;
		private System.Windows.Forms.BindingSource gas_componentBindingSource;
		private System.Windows.Forms.DataGridView gas_componentDataGridView;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button eqa_reciptadd;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox gq_coastTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}

namespace GasEquipt
{
	partial class EquiptPostavk
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
			this.gas_equiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_equiptTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_equiptTableAdapter();
			this.tableAdapterManager = new GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager();
			this.gas_componentTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_componentTableAdapter();
			this.gas_reciptTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_reciptTableAdapter();
			this.gas_equiptDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gas_reciptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_reciptDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.gas_componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_componentDataGridView = new System.Windows.Forms.DataGridView();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_reciptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_reciptDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
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
			// gas_equiptDataGridView
			// 
			this.gas_equiptDataGridView.AllowUserToAddRows = false;
			this.gas_equiptDataGridView.AllowUserToDeleteRows = false;
			this.gas_equiptDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gas_equiptDataGridView.AutoGenerateColumns = false;
			this.gas_equiptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gas_equiptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.gas_equiptDataGridView.DataSource = this.gas_equiptBindingSource;
			this.gas_equiptDataGridView.EnableHeadersVisualStyles = false;
			this.gas_equiptDataGridView.Location = new System.Drawing.Point(3, 40);
			this.gas_equiptDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.gas_equiptDataGridView.Name = "gas_equiptDataGridView";
			this.gas_equiptDataGridView.ReadOnly = true;
			this.gas_equiptDataGridView.Size = new System.Drawing.Size(908, 336);
			this.gas_equiptDataGridView.TabIndex = 1;
			this.gas_equiptDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gas_equiptDataGridView_CellClick);
			this.gas_equiptDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gas_equiptDataGridView_CellContentClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idgas_equipt";
			this.dataGridViewTextBoxColumn1.HeaderText = "idgas_equipt";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "gq_name";
			this.dataGridViewTextBoxColumn2.FillWeight = 135F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Оборудование";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "gq_coast";
			this.dataGridViewTextBoxColumn3.HeaderText = "Цена(руб.)";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "gq_count";
			this.dataGridViewTextBoxColumn4.FillWeight = 80F;
			this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// gas_reciptBindingSource
			// 
			this.gas_reciptBindingSource.DataMember = "gas_recipt";
			this.gas_reciptBindingSource.DataSource = this.gazmechDataSet;
			// 
			// gas_reciptDataGridView
			// 
			this.gas_reciptDataGridView.AllowUserToAddRows = false;
			this.gas_reciptDataGridView.AllowUserToDeleteRows = false;
			this.gas_reciptDataGridView.AutoGenerateColumns = false;
			this.gas_reciptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gas_reciptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column1,
            this.dataGridViewTextBoxColumn8});
			this.gas_reciptDataGridView.DataSource = this.gas_reciptBindingSource;
			this.gas_reciptDataGridView.EnableHeadersVisualStyles = false;
			this.gas_reciptDataGridView.Location = new System.Drawing.Point(3, 414);
			this.gas_reciptDataGridView.Name = "gas_reciptDataGridView";
			this.gas_reciptDataGridView.ReadOnly = true;
			this.gas_reciptDataGridView.Size = new System.Drawing.Size(562, 248);
			this.gas_reciptDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "idgas_recipt";
			this.dataGridViewTextBoxColumn5.HeaderText = "idgas_recipt";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Visible = false;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "id_gas_componenta";
			this.dataGridViewTextBoxColumn6.HeaderText = "id_gas_componenta";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Visible = false;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "id_gas_equipt";
			this.dataGridViewTextBoxColumn7.HeaderText = "id_gas_equipt";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Visible = false;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.DataPropertyName = "gc_name";
			this.Column1.HeaderText = "Компонент";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "r_count_component";
			this.dataGridViewTextBoxColumn8.FillWeight = 65F;
			this.dataGridViewTextBoxColumn8.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(571, 469);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(336, 64);
			this.button1.TabIndex = 2;
			this.button1.Text = "Создать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// gas_componentBindingSource
			// 
			this.gas_componentBindingSource.DataMember = "gas_component";
			this.gas_componentBindingSource.DataSource = this.gazmechDataSet;
			// 
			// gas_componentDataGridView
			// 
			this.gas_componentDataGridView.AutoGenerateColumns = false;
			this.gas_componentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gas_componentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
			this.gas_componentDataGridView.DataSource = this.gas_componentBindingSource;
			this.gas_componentDataGridView.Location = new System.Drawing.Point(908, 652);
			this.gas_componentDataGridView.Name = "gas_componentDataGridView";
			this.gas_componentDataGridView.Size = new System.Drawing.Size(10, 10);
			this.gas_componentDataGridView.TabIndex = 3;
			this.gas_componentDataGridView.Visible = false;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(571, 424);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(336, 26);
			this.numericUpDown1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(567, 387);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "Количество";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "idgas_component";
			this.dataGridViewTextBoxColumn9.HeaderText = "idgas_component";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "gc_name";
			this.dataGridViewTextBoxColumn10.HeaderText = "gc_name";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "gc_coast";
			this.dataGridViewTextBoxColumn11.HeaderText = "gc_coast";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.Visible = false;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "id_compony";
			this.dataGridViewTextBoxColumn12.HeaderText = "id_compony";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.Visible = false;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "gc_count";
			this.dataGridViewTextBoxColumn13.HeaderText = "gc_count";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Оборудование";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 387);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(192, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Компоненты сборки";
			// 
			// EquiptPostavk
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.gas_componentDataGridView);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gas_reciptDataGridView);
			this.Controls.Add(this.gas_equiptDataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "EquiptPostavk";
			this.Size = new System.Drawing.Size(921, 665);
			this.Load += new System.EventHandler(this.EquiptPostavk_Load);
			this.VisibleChanged += new System.EventHandler(this.EquiptPostavk_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_reciptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_reciptDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private gazmechDataSet gazmechDataSet;
		private System.Windows.Forms.BindingSource gas_equiptBindingSource;
		private gazmechDataSetTableAdapters.gas_equiptTableAdapter gas_equiptTableAdapter;
		private gazmechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView gas_equiptDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private gazmechDataSetTableAdapters.gas_reciptTableAdapter gas_reciptTableAdapter;
		private System.Windows.Forms.BindingSource gas_reciptBindingSource;
		private System.Windows.Forms.DataGridView gas_reciptDataGridView;
		private System.Windows.Forms.Button button1;
		private gazmechDataSetTableAdapters.gas_componentTableAdapter gas_componentTableAdapter;
		private System.Windows.Forms.BindingSource gas_componentBindingSource;
		private System.Windows.Forms.DataGridView gas_componentDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

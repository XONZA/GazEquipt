namespace GasEquipt
{
	partial class EquiptEdit
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
			System.Windows.Forms.Label r_count_componentLabel;
			this.gazmechDataSet = new GasEquipt.gazmechDataSet();
			this.gas_equiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_equiptTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_equiptTableAdapter();
			this.tableAdapterManager = new GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager();
			this.gas_equiptDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gas_componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_componentTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_componentTableAdapter();
			this.gas_componentDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gas_reciptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_reciptTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_reciptTableAdapter();
			this.gas_reciptDataGridView = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.gazmechDataSet1 = new GasEquipt.gazmechDataSet();
			this.button3 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.gq_coastTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.complname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			r_count_componentLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_reciptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_reciptDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
			this.tableAdapterManager.gas_componentTableAdapter = null;
			this.tableAdapterManager.gas_equiptTableAdapter = this.gas_equiptTableAdapter;
			this.tableAdapterManager.gas_reciptTableAdapter = null;
			this.tableAdapterManager.loginTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// gas_equiptDataGridView
			// 
			this.gas_equiptDataGridView.AutoGenerateColumns = false;
			this.gas_equiptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gas_equiptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.gas_equiptDataGridView.DataSource = this.gas_equiptBindingSource;
			this.gas_equiptDataGridView.EnableHeadersVisualStyles = false;
			this.gas_equiptDataGridView.Location = new System.Drawing.Point(3, 3);
			this.gas_equiptDataGridView.Name = "gas_equiptDataGridView";
			this.gas_equiptDataGridView.Size = new System.Drawing.Size(332, 543);
			this.gas_equiptDataGridView.TabIndex = 1;
			this.gas_equiptDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gas_equiptDataGridView_CellClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idgas_equipt";
			this.dataGridViewTextBoxColumn1.HeaderText = "idgas_equipt";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "gq_name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Оборудование";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "gq_coast";
			this.dataGridViewTextBoxColumn3.HeaderText = "gq_coast";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Visible = false;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "gq_count";
			this.dataGridViewTextBoxColumn4.HeaderText = "gq_count";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Visible = false;
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
			// gas_componentDataGridView
			// 
			this.gas_componentDataGridView.AutoGenerateColumns = false;
			this.gas_componentDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			this.gas_componentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gas_componentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
			this.gas_componentDataGridView.DataSource = this.gas_componentBindingSource;
			this.gas_componentDataGridView.EnableHeadersVisualStyles = false;
			this.gas_componentDataGridView.Location = new System.Drawing.Point(473, 3);
			this.gas_componentDataGridView.Name = "gas_componentDataGridView";
			this.gas_componentDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gas_componentDataGridView.Size = new System.Drawing.Size(445, 229);
			this.gas_componentDataGridView.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "idgas_component";
			this.dataGridViewTextBoxColumn5.HeaderText = "idgas_component";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Visible = false;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "gc_name";
			this.dataGridViewTextBoxColumn6.HeaderText = "Компонент";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "gc_coast";
			this.dataGridViewTextBoxColumn7.FillWeight = 65F;
			this.dataGridViewTextBoxColumn7.HeaderText = "Цена(руб.)";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "id_compony";
			this.dataGridViewTextBoxColumn8.HeaderText = "id_compony";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.Visible = false;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "gc_count";
			this.dataGridViewTextBoxColumn9.HeaderText = "коли";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.Visible = false;
			// 
			// gas_reciptBindingSource
			// 
			this.gas_reciptBindingSource.DataMember = "gas_recipt";
			this.gas_reciptBindingSource.DataSource = this.gazmechDataSet;
			// 
			// gas_reciptTableAdapter
			// 
			this.gas_reciptTableAdapter.ClearBeforeFill = true;
			// 
			// gas_reciptDataGridView
			// 
			this.gas_reciptDataGridView.AutoGenerateColumns = false;
			this.gas_reciptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gas_reciptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.complname,
            this.dataGridViewTextBoxColumn13,
            this.Column1});
			this.gas_reciptDataGridView.DataSource = this.gas_reciptBindingSource;
			this.gas_reciptDataGridView.EnableHeadersVisualStyles = false;
			this.gas_reciptDataGridView.Location = new System.Drawing.Point(473, 315);
			this.gas_reciptDataGridView.Name = "gas_reciptDataGridView";
			this.gas_reciptDataGridView.Size = new System.Drawing.Size(445, 254);
			this.gas_reciptDataGridView.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(767, 575);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(151, 75);
			this.button2.TabIndex = 4;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// gazmechDataSet1
			// 
			this.gazmechDataSet1.DataSetName = "gazmechDataSet";
			this.gazmechDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(767, 238);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(151, 71);
			this.button3.TabIndex = 5;
			this.button3.Text = "Добавить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(616, 238);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(145, 26);
			this.numericUpDown1.TabIndex = 6;
			// 
			// gq_coastTextBox
			// 
			this.gq_coastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gas_equiptBindingSource, "gq_coast", true));
			this.gq_coastTextBox.Location = new System.Drawing.Point(616, 283);
			this.gq_coastTextBox.Name = "gq_coastTextBox";
			this.gq_coastTextBox.ReadOnly = true;
			this.gq_coastTextBox.Size = new System.Drawing.Size(145, 26);
			this.gq_coastTextBox.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(469, 238);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Количество";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(469, 283);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Общая цена(руб.)";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "idgas_recipt";
			this.dataGridViewTextBoxColumn10.HeaderText = "idgas_recipt";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Visible = false;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "id_gas_componenta";
			this.dataGridViewTextBoxColumn11.HeaderText = "id_gas_componenta";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.Visible = false;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "id_gas_equipt";
			this.dataGridViewTextBoxColumn12.HeaderText = "id_gas_equipt";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.Visible = false;
			// 
			// complname
			// 
			this.complname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.complname.DataPropertyName = "gc_name";
			this.complname.HeaderText = "Компонент";
			this.complname.Name = "complname";
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "r_count_component";
			this.dataGridViewTextBoxColumn13.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.Width = 110;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "gc_coast";
			this.Column1.HeaderText = "Цена";
			this.Column1.Name = "Column1";
			this.Column1.Visible = false;
			// 
			// r_count_componentLabel
			// 
			r_count_componentLabel.AutoSize = true;
			r_count_componentLabel.Location = new System.Drawing.Point(469, 576);
			r_count_componentLabel.Name = "r_count_componentLabel";
			r_count_componentLabel.Size = new System.Drawing.Size(100, 20);
			r_count_componentLabel.TabIndex = 10;
			r_count_componentLabel.Text = "Количество";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(575, 576);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(170, 26);
			this.numericUpDown2.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(473, 619);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(272, 31);
			this.button1.TabIndex = 12;
			this.button1.Text = "Изменить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click_1);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(7, 612);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(328, 37);
			this.button4.TabIndex = 13;
			this.button4.Text = "Поиск";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 572);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(332, 26);
			this.textBox1.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 549);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 20);
			this.label3.TabIndex = 15;
			this.label3.Text = "Поиск по названию";
			// 
			// EquiptEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(r_count_componentLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gq_coastTextBox);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.gas_reciptDataGridView);
			this.Controls.Add(this.gas_componentDataGridView);
			this.Controls.Add(this.gas_equiptDataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "EquiptEdit";
			this.Size = new System.Drawing.Size(921, 665);
			this.Load += new System.EventHandler(this.EquiptEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_reciptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_reciptDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private gazmechDataSet gazmechDataSet;
		private System.Windows.Forms.BindingSource gas_equiptBindingSource;
		private gazmechDataSetTableAdapters.gas_equiptTableAdapter gas_equiptTableAdapter;
		private gazmechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView gas_equiptDataGridView;
		private System.Windows.Forms.BindingSource gas_componentBindingSource;
		private gazmechDataSetTableAdapters.gas_componentTableAdapter gas_componentTableAdapter;
		private System.Windows.Forms.DataGridView gas_componentDataGridView;
		private System.Windows.Forms.BindingSource gas_reciptBindingSource;
		private gazmechDataSetTableAdapters.gas_reciptTableAdapter gas_reciptTableAdapter;
		private System.Windows.Forms.DataGridView gas_reciptDataGridView;
		private System.Windows.Forms.Button button2;
		private gazmechDataSet gazmechDataSet1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.TextBox gq_coastTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn complname;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
	}
}

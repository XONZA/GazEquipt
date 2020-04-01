namespace GasEquipt
{
	partial class COmponentAdd
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
			System.Windows.Forms.Label gc_nameLabel;
			System.Windows.Forms.Label gc_coastLabel;
			System.Windows.Forms.Label gc_countLabel;
			System.Windows.Forms.Label co_NameLabel;
			this.gazmechDataSet = new GasEquipt.gazmechDataSet();
			this.gas_componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_componentTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_componentTableAdapter();
			this.tableAdapterManager = new GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager();
			this.component_componyTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.component_componyTableAdapter();
			this.gas_componentDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gc_nameTextBox = new System.Windows.Forms.TextBox();
			this.gc_coastTextBox = new System.Windows.Forms.TextBox();
			this.gc_countNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.component_componyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.component_componyComboBox = new System.Windows.Forms.ComboBox();
			this.cmkeycomponyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			gc_nameLabel = new System.Windows.Forms.Label();
			gc_coastLabel = new System.Windows.Forms.Label();
			gc_countLabel = new System.Windows.Forms.Label();
			co_NameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gc_countNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.component_componyBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmkeycomponyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// gc_nameLabel
			// 
			gc_nameLabel.AutoSize = true;
			gc_nameLabel.ForeColor = System.Drawing.SystemColors.Control;
			gc_nameLabel.Location = new System.Drawing.Point(12, 20);
			gc_nameLabel.Name = "gc_nameLabel";
			gc_nameLabel.Size = new System.Drawing.Size(178, 20);
			gc_nameLabel.TabIndex = 1;
			gc_nameLabel.Text = "Название компонента";
			// 
			// gc_coastLabel
			// 
			gc_coastLabel.AutoSize = true;
			gc_coastLabel.ForeColor = System.Drawing.SystemColors.Control;
			gc_coastLabel.Location = new System.Drawing.Point(12, 103);
			gc_coastLabel.Name = "gc_coastLabel";
			gc_coastLabel.Size = new System.Drawing.Size(87, 20);
			gc_coastLabel.TabIndex = 3;
			gc_coastLabel.Text = "Цена(руб.)";
			// 
			// gc_countLabel
			// 
			gc_countLabel.AutoSize = true;
			gc_countLabel.ForeColor = System.Drawing.SystemColors.Control;
			gc_countLabel.Location = new System.Drawing.Point(320, 103);
			gc_countLabel.Name = "gc_countLabel";
			gc_countLabel.Size = new System.Drawing.Size(100, 20);
			gc_countLabel.TabIndex = 5;
			gc_countLabel.Text = "Количество";
			// 
			// co_NameLabel
			// 
			co_NameLabel.AutoSize = true;
			co_NameLabel.ForeColor = System.Drawing.SystemColors.Control;
			co_NameLabel.Location = new System.Drawing.Point(320, 20);
			co_NameLabel.Name = "co_NameLabel";
			co_NameLabel.Size = new System.Drawing.Size(131, 20);
			co_NameLabel.TabIndex = 10;
			co_NameLabel.Text = "Производитель";
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
			this.tableAdapterManager.component_componyTableAdapter = this.component_componyTableAdapter;
			this.tableAdapterManager.gas_component_admissionTableAdapter = null;
			this.tableAdapterManager.gas_componentTableAdapter = this.gas_componentTableAdapter;
			this.tableAdapterManager.gas_equiptTableAdapter = null;
			this.tableAdapterManager.gas_reciptTableAdapter = null;
			this.tableAdapterManager.loginTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// component_componyTableAdapter
			// 
			this.component_componyTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.dataGridViewTextBoxColumn4});
			this.gas_componentDataGridView.DataSource = this.gas_componentBindingSource;
			this.gas_componentDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
			this.gas_componentDataGridView.EnableHeadersVisualStyles = false;
			this.gas_componentDataGridView.Location = new System.Drawing.Point(0, 0);
			this.gas_componentDataGridView.Name = "gas_componentDataGridView";
			this.gas_componentDataGridView.ReadOnly = true;
			this.gas_componentDataGridView.Size = new System.Drawing.Size(938, 439);
			this.gas_componentDataGridView.TabIndex = 1;
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
			this.dataGridViewTextBoxColumn3.FillWeight = 75F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Цена(руб.)";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "gc_count";
			this.dataGridViewTextBoxColumn5.FillWeight = 65F;
			this.dataGridViewTextBoxColumn5.HeaderText = "Количество на складе";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.DataPropertyName = "co_Name";
			this.Column1.HeaderText = "Компания";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "id_compony";
			this.dataGridViewTextBoxColumn4.HeaderText = "id_compony";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Visible = false;
			// 
			// gc_nameTextBox
			// 
			this.gc_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gas_componentBindingSource, "gc_name", true));
			this.gc_nameTextBox.Location = new System.Drawing.Point(16, 46);
			this.gc_nameTextBox.Name = "gc_nameTextBox";
			this.gc_nameTextBox.Size = new System.Drawing.Size(253, 26);
			this.gc_nameTextBox.TabIndex = 2;
			// 
			// gc_coastTextBox
			// 
			this.gc_coastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gas_componentBindingSource, "gc_coast", true));
			this.gc_coastTextBox.Location = new System.Drawing.Point(16, 126);
			this.gc_coastTextBox.Name = "gc_coastTextBox";
			this.gc_coastTextBox.Size = new System.Drawing.Size(253, 26);
			this.gc_coastTextBox.TabIndex = 4;
			// 
			// gc_countNumericUpDown
			// 
			this.gc_countNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gas_componentBindingSource, "gc_count", true));
			this.gc_countNumericUpDown.Location = new System.Drawing.Point(324, 126);
			this.gc_countNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.gc_countNumericUpDown.Name = "gc_countNumericUpDown";
			this.gc_countNumericUpDown.Size = new System.Drawing.Size(263, 26);
			this.gc_countNumericUpDown.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(638, 453);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(285, 58);
			this.button1.TabIndex = 8;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(638, 582);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(285, 58);
			this.button2.TabIndex = 9;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(638, 517);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(285, 58);
			this.button3.TabIndex = 10;
			this.button3.Text = "Сохранить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// component_componyBindingSource
			// 
			this.component_componyBindingSource.DataMember = "component_compony";
			this.component_componyBindingSource.DataSource = this.gazmechDataSet;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.component_componyComboBox);
			this.panel1.Controls.Add(gc_nameLabel);
			this.panel1.Controls.Add(co_NameLabel);
			this.panel1.Controls.Add(this.gc_nameTextBox);
			this.panel1.Controls.Add(this.gc_coastTextBox);
			this.panel1.Controls.Add(gc_coastLabel);
			this.panel1.Controls.Add(gc_countLabel);
			this.panel1.Controls.Add(this.gc_countNumericUpDown);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 439);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(632, 230);
			this.panel1.TabIndex = 12;
			// 
			// component_componyComboBox
			// 
			this.component_componyComboBox.DataSource = this.component_componyBindingSource;
			this.component_componyComboBox.DisplayMember = "co_Name";
			this.component_componyComboBox.FormattingEnabled = true;
			this.component_componyComboBox.Location = new System.Drawing.Point(324, 44);
			this.component_componyComboBox.Name = "component_componyComboBox";
			this.component_componyComboBox.Size = new System.Drawing.Size(263, 28);
			this.component_componyComboBox.TabIndex = 12;
			this.component_componyComboBox.ValueMember = "idcomponent_compony";
			// 
			// cmkeycomponyBindingSource
			// 
			this.cmkeycomponyBindingSource.DataMember = "cmkey_compony";
			this.cmkeycomponyBindingSource.DataSource = this.component_componyBindingSource;
			// 
			// COmponentAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gas_componentDataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "COmponentAdd";
			this.Size = new System.Drawing.Size(938, 669);
			this.Load += new System.EventHandler(this.COmponentAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_componentDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gc_countNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.component_componyBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmkeycomponyBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private gazmechDataSet gazmechDataSet;
		private System.Windows.Forms.BindingSource gas_componentBindingSource;
		private gazmechDataSetTableAdapters.gas_componentTableAdapter gas_componentTableAdapter;
		private gazmechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView gas_componentDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.TextBox gc_nameTextBox;
		private System.Windows.Forms.TextBox gc_coastTextBox;
		private System.Windows.Forms.NumericUpDown gc_countNumericUpDown;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private gazmechDataSetTableAdapters.component_componyTableAdapter component_componyTableAdapter;
		private System.Windows.Forms.BindingSource component_componyBindingSource;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox component_componyComboBox;
		private System.Windows.Forms.BindingSource cmkeycomponyBindingSource;
	}
}

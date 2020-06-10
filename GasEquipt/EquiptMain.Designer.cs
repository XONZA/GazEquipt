namespace GasEquipt
{
	partial class EquiptMains
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
			this.gas_equiptDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.gq_nameTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
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
			this.tableAdapterManager.craftitemsreportTableAdapter = null;
			this.tableAdapterManager.gas_component_admissionTableAdapter = null;
			this.tableAdapterManager.gas_componentTableAdapter = null;
			this.tableAdapterManager.gas_equiptTableAdapter = this.gas_equiptTableAdapter;
			this.tableAdapterManager.gas_reciptTableAdapter = null;
			this.tableAdapterManager.loginTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// gas_equiptDataGridView
			// 
			this.gas_equiptDataGridView.AllowUserToAddRows = false;
			this.gas_equiptDataGridView.AllowUserToDeleteRows = false;
			this.gas_equiptDataGridView.AutoGenerateColumns = false;
			this.gas_equiptDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
			this.gas_equiptDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gas_equiptDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gas_equiptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gas_equiptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
			this.gas_equiptDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.gas_equiptDataGridView.DataSource = this.gas_equiptBindingSource;
			this.gas_equiptDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
			this.gas_equiptDataGridView.EnableHeadersVisualStyles = false;
			this.gas_equiptDataGridView.Location = new System.Drawing.Point(0, 0);
			this.gas_equiptDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gas_equiptDataGridView.Name = "gas_equiptDataGridView";
			this.gas_equiptDataGridView.ReadOnly = true;
			this.gas_equiptDataGridView.Size = new System.Drawing.Size(921, 479);
			this.gas_equiptDataGridView.TabIndex = 1;
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
			this.dataGridViewTextBoxColumn2.FillWeight = 150F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Название оборудования";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "gq_count";
			this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "gq_coast";
			this.dataGridViewTextBoxColumn3.HeaderText = "Цена(руб.)";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(4, 484);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Название оборудования";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(9, 522);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(276, 26);
			this.textBox1.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(9, 576);
			this.button2.Margin = new System.Windows.Forms.Padding(5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(572, 71);
			this.button2.TabIndex = 5;
			this.button2.Text = "Поиск";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(294, 484);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Цена";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(299, 522);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(282, 26);
			this.textBox2.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.RoyalBlue;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(15, 7);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(195, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Название оборудования";
			// 
			// gq_nameTextBox
			// 
			this.gq_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gas_equiptBindingSource, "gq_name", true));
			this.gq_nameTextBox.Location = new System.Drawing.Point(19, 45);
			this.gq_nameTextBox.Name = "gq_nameTextBox";
			this.gq_nameTextBox.Size = new System.Drawing.Size(268, 26);
			this.gq_nameTextBox.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(19, 87);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(268, 44);
			this.button1.TabIndex = 11;
			this.button1.Text = "Сменить название";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.gq_nameTextBox);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(610, 477);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(311, 190);
			this.panel1.TabIndex = 12;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.RoyalBlue;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.SystemColors.Control;
			this.button3.Location = new System.Drawing.Point(19, 137);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(268, 33);
			this.button3.TabIndex = 12;
			this.button3.Text = "Удалить";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// EquiptMains
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gas_equiptDataGridView);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "EquiptMains";
			this.Size = new System.Drawing.Size(921, 667);
			this.Load += new System.EventHandler(this.EquiptMains_Load);
			this.VisibleChanged += new System.EventHandler(this.EquiptMains_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private gazmechDataSet gazmechDataSet;
		private System.Windows.Forms.BindingSource gas_equiptBindingSource;
		private gazmechDataSetTableAdapters.gas_equiptTableAdapter gas_equiptTableAdapter;
		private gazmechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView gas_equiptDataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox gq_nameTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button3;
	}
}

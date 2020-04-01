namespace GasEquipt
{
	partial class ComponentCompony
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
			System.Windows.Forms.Label co_NameLabel;
			System.Windows.Forms.Label co_AdressLabel;
			System.Windows.Forms.Label co_NumberLabel;
			this.gazmechDataSet = new GasEquipt.gazmechDataSet();
			this.component_componyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.component_componyTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.component_componyTableAdapter();
			this.tableAdapterManager = new GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager();
			this.component_componyDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.co_NameTextBox = new System.Windows.Forms.TextBox();
			this.co_AdressTextBox = new System.Windows.Forms.TextBox();
			this.co_NumberTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			co_NameLabel = new System.Windows.Forms.Label();
			co_AdressLabel = new System.Windows.Forms.Label();
			co_NumberLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.component_componyBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.component_componyDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gazmechDataSet
			// 
			this.gazmechDataSet.DataSetName = "gazmechDataSet";
			this.gazmechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// component_componyBindingSource
			// 
			this.component_componyBindingSource.DataMember = "component_compony";
			this.component_componyBindingSource.DataSource = this.gazmechDataSet;
			// 
			// component_componyTableAdapter
			// 
			this.component_componyTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.assembl_gas_equiptTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.component_componyTableAdapter = this.component_componyTableAdapter;
			this.tableAdapterManager.gas_component_admissionTableAdapter = null;
			this.tableAdapterManager.gas_componentTableAdapter = null;
			this.tableAdapterManager.gas_equiptTableAdapter = null;
			this.tableAdapterManager.gas_reciptTableAdapter = null;
			this.tableAdapterManager.loginTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// component_componyDataGridView
			// 
			this.component_componyDataGridView.AllowUserToAddRows = false;
			this.component_componyDataGridView.AllowUserToDeleteRows = false;
			this.component_componyDataGridView.AutoGenerateColumns = false;
			this.component_componyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.component_componyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.component_componyDataGridView.DataSource = this.component_componyBindingSource;
			this.component_componyDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
			this.component_componyDataGridView.EnableHeadersVisualStyles = false;
			this.component_componyDataGridView.Location = new System.Drawing.Point(0, 0);
			this.component_componyDataGridView.Name = "component_componyDataGridView";
			this.component_componyDataGridView.ReadOnly = true;
			this.component_componyDataGridView.Size = new System.Drawing.Size(921, 415);
			this.component_componyDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idcomponent_compony";
			this.dataGridViewTextBoxColumn1.HeaderText = "idcomponent_compony";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "co_Name";
			this.dataGridViewTextBoxColumn2.FillWeight = 80F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Название производителя";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "co_Adress";
			this.dataGridViewTextBoxColumn3.HeaderText = "Адрес";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "co_Number";
			this.dataGridViewTextBoxColumn4.HeaderText = "Контактные данные";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// co_NameLabel
			// 
			co_NameLabel.AutoSize = true;
			co_NameLabel.ForeColor = System.Drawing.SystemColors.Control;
			co_NameLabel.Location = new System.Drawing.Point(13, 18);
			co_NameLabel.Name = "co_NameLabel";
			co_NameLabel.Size = new System.Drawing.Size(206, 20);
			co_NameLabel.TabIndex = 1;
			co_NameLabel.Text = "Название производителя";
			// 
			// co_NameTextBox
			// 
			this.co_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.component_componyBindingSource, "co_Name", true));
			this.co_NameTextBox.Location = new System.Drawing.Point(17, 41);
			this.co_NameTextBox.Name = "co_NameTextBox";
			this.co_NameTextBox.Size = new System.Drawing.Size(317, 26);
			this.co_NameTextBox.TabIndex = 2;
			// 
			// co_AdressLabel
			// 
			co_AdressLabel.AutoSize = true;
			co_AdressLabel.ForeColor = System.Drawing.SystemColors.Control;
			co_AdressLabel.Location = new System.Drawing.Point(13, 145);
			co_AdressLabel.Name = "co_AdressLabel";
			co_AdressLabel.Size = new System.Drawing.Size(57, 20);
			co_AdressLabel.TabIndex = 3;
			co_AdressLabel.Text = "Адрес";
			// 
			// co_AdressTextBox
			// 
			this.co_AdressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.component_componyBindingSource, "co_Adress", true));
			this.co_AdressTextBox.Location = new System.Drawing.Point(17, 168);
			this.co_AdressTextBox.Name = "co_AdressTextBox";
			this.co_AdressTextBox.Size = new System.Drawing.Size(317, 26);
			this.co_AdressTextBox.TabIndex = 4;
			// 
			// co_NumberLabel
			// 
			co_NumberLabel.AutoSize = true;
			co_NumberLabel.ForeColor = System.Drawing.SystemColors.Control;
			co_NumberLabel.Location = new System.Drawing.Point(13, 80);
			co_NumberLabel.Name = "co_NumberLabel";
			co_NumberLabel.Size = new System.Drawing.Size(59, 20);
			co_NumberLabel.TabIndex = 5;
			co_NumberLabel.Text = "Номер";
			// 
			// co_NumberTextBox
			// 
			this.co_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.component_componyBindingSource, "co_Number", true));
			this.co_NumberTextBox.Location = new System.Drawing.Point(17, 103);
			this.co_NumberTextBox.Name = "co_NumberTextBox";
			this.co_NumberTextBox.Size = new System.Drawing.Size(317, 26);
			this.co_NumberTextBox.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(co_NumberLabel);
			this.panel1.Controls.Add(this.co_NameTextBox);
			this.panel1.Controls.Add(this.co_NumberTextBox);
			this.panel1.Controls.Add(co_NameLabel);
			this.panel1.Controls.Add(co_AdressLabel);
			this.panel1.Controls.Add(this.co_AdressTextBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 415);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(533, 252);
			this.panel1.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(368, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(162, 68);
			this.button1.TabIndex = 8;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.SystemColors.Control;
			this.button2.Location = new System.Drawing.Point(368, 80);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(162, 68);
			this.button2.TabIndex = 9;
			this.button2.Text = "Сохранить";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.SystemColors.Control;
			this.button3.Location = new System.Drawing.Point(368, 154);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(162, 68);
			this.button3.TabIndex = 10;
			this.button3.Text = "Удалить";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(539, 421);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "Поиск";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(632, 558);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(182, 77);
			this.button4.TabIndex = 9;
			this.button4.Text = "Поиск";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(539, 495);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(374, 26);
			this.textBox1.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(540, 469);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(206, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Название производителя";
			// 
			// ComponentCompony
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.component_componyDataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ComponentCompony";
			this.Size = new System.Drawing.Size(921, 667);
			this.Load += new System.EventHandler(this.ComponentCompony_Load);
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.component_componyBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.component_componyDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private gazmechDataSet gazmechDataSet;
		private System.Windows.Forms.BindingSource component_componyBindingSource;
		private gazmechDataSetTableAdapters.component_componyTableAdapter component_componyTableAdapter;
		private gazmechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView component_componyDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.TextBox co_NameTextBox;
		private System.Windows.Forms.TextBox co_AdressTextBox;
		private System.Windows.Forms.TextBox co_NumberTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
	}
}

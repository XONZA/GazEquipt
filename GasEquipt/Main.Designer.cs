namespace GasEquipt
{
	partial class Main
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.eq_supply = new System.Windows.Forms.Button();
			this.eq_edit = new System.Windows.Forms.Button();
			this.eq_add = new System.Windows.Forms.Button();
			this.eq_main = new System.Windows.Forms.Button();
			this.equiptMains1 = new GasEquipt.EquiptMains();
			this.equiptAdd1 = new GasEquipt.EquiptAdd();
			this.equiptEdit1 = new GasEquipt.EquiptEdit();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gazmechDataSet = new GasEquipt.gazmechDataSet();
			this.gas_equiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gas_equiptTableAdapter = new GasEquipt.gazmechDataSetTableAdapters.gas_equiptTableAdapter();
			this.tableAdapterManager = new GasEquipt.gazmechDataSetTableAdapters.TableAdapterManager();
			this.dragControl1 = new GasEquipt.DragControl();
			this.dragControl2 = new GasEquipt.DragControl();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(1, 59);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1139, 694);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.equiptMains1);
			this.tabPage1.Controls.Add(this.equiptAdd1);
			this.tabPage1.Controls.Add(this.equiptEdit1);
			this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1131, 661);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Оборудование";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel2.Controls.Add(this.eq_supply);
			this.panel2.Controls.Add(this.eq_edit);
			this.panel2.Controls.Add(this.eq_add);
			this.panel2.Controls.Add(this.eq_main);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 655);
			this.panel2.TabIndex = 1;
			// 
			// eq_supply
			// 
			this.eq_supply.BackColor = System.Drawing.Color.CornflowerBlue;
			this.eq_supply.Dock = System.Windows.Forms.DockStyle.Top;
			this.eq_supply.FlatAppearance.BorderSize = 0;
			this.eq_supply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.eq_supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.eq_supply.ForeColor = System.Drawing.SystemColors.Control;
			this.eq_supply.Location = new System.Drawing.Point(0, 192);
			this.eq_supply.Name = "eq_supply";
			this.eq_supply.Size = new System.Drawing.Size(200, 64);
			this.eq_supply.TabIndex = 3;
			this.eq_supply.Text = "Поставка оборудования";
			this.eq_supply.UseVisualStyleBackColor = false;
			// 
			// eq_edit
			// 
			this.eq_edit.BackColor = System.Drawing.Color.CornflowerBlue;
			this.eq_edit.Dock = System.Windows.Forms.DockStyle.Top;
			this.eq_edit.FlatAppearance.BorderSize = 0;
			this.eq_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.eq_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.eq_edit.ForeColor = System.Drawing.SystemColors.Control;
			this.eq_edit.Location = new System.Drawing.Point(0, 128);
			this.eq_edit.Name = "eq_edit";
			this.eq_edit.Size = new System.Drawing.Size(200, 64);
			this.eq_edit.TabIndex = 2;
			this.eq_edit.Text = "Редактировать оборудование";
			this.eq_edit.UseVisualStyleBackColor = false;
			this.eq_edit.Click += new System.EventHandler(this.Eq_edit_Click);
			// 
			// eq_add
			// 
			this.eq_add.BackColor = System.Drawing.Color.CornflowerBlue;
			this.eq_add.Dock = System.Windows.Forms.DockStyle.Top;
			this.eq_add.FlatAppearance.BorderSize = 0;
			this.eq_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.eq_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.eq_add.ForeColor = System.Drawing.SystemColors.Control;
			this.eq_add.Location = new System.Drawing.Point(0, 64);
			this.eq_add.Name = "eq_add";
			this.eq_add.Size = new System.Drawing.Size(200, 64);
			this.eq_add.TabIndex = 1;
			this.eq_add.Text = "Добавить новое оборудование";
			this.eq_add.UseVisualStyleBackColor = false;
			this.eq_add.Click += new System.EventHandler(this.Eq_add_Click);
			// 
			// eq_main
			// 
			this.eq_main.BackColor = System.Drawing.Color.CornflowerBlue;
			this.eq_main.Dock = System.Windows.Forms.DockStyle.Top;
			this.eq_main.FlatAppearance.BorderSize = 0;
			this.eq_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.eq_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.eq_main.ForeColor = System.Drawing.SystemColors.Control;
			this.eq_main.Location = new System.Drawing.Point(0, 0);
			this.eq_main.Name = "eq_main";
			this.eq_main.Size = new System.Drawing.Size(200, 64);
			this.eq_main.TabIndex = 0;
			this.eq_main.Text = "Информация";
			this.eq_main.UseVisualStyleBackColor = false;
			this.eq_main.Click += new System.EventHandler(this.Button2_Click);
			// 
			// equiptMains1
			// 
			this.equiptMains1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.equiptMains1.Location = new System.Drawing.Point(210, 0);
			this.equiptMains1.Margin = new System.Windows.Forms.Padding(4);
			this.equiptMains1.Name = "equiptMains1";
			this.equiptMains1.Size = new System.Drawing.Size(921, 665);
			this.equiptMains1.TabIndex = 2;
			// 
			// equiptAdd1
			// 
			this.equiptAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.equiptAdd1.Location = new System.Drawing.Point(210, 3);
			this.equiptAdd1.Margin = new System.Windows.Forms.Padding(4);
			this.equiptAdd1.MaximumSize = new System.Drawing.Size(1388, 1017);
			this.equiptAdd1.Name = "equiptAdd1";
			this.equiptAdd1.Size = new System.Drawing.Size(921, 665);
			this.equiptAdd1.TabIndex = 3;
			// 
			// equiptEdit1
			// 
			this.equiptEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.equiptEdit1.Location = new System.Drawing.Point(210, 3);
			this.equiptEdit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.equiptEdit1.Name = "equiptEdit1";
			this.equiptEdit1.Size = new System.Drawing.Size(921, 665);
			this.equiptEdit1.TabIndex = 4;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1131, 661);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Комплектующие";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 29);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1131, 661);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Отчёты";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 29);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(1131, 661);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "О программе";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1140, 53);
			this.panel1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.button1.Dock = System.Windows.Forms.DockStyle.Right;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(1079, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(61, 53);
			this.button1.TabIndex = 1;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(0, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Главное окно";
			this.label1.Click += new System.EventHandler(this.Label1_Click);
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
			// dragControl1
			// 
			this.dragControl1.SelectControl = this.panel1;
			// 
			// dragControl2
			// 
			this.dragControl2.SelectControl = this.label1;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1140, 756);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Main";
			this.Text = "Учёт газового оборудование  ";
			this.Activated += new System.EventHandler(this.Main_Activated);
			this.Load += new System.EventHandler(this.Main_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gazmechDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gas_equiptBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private DragControl dragControl1;
		private DragControl dragControl2;
		private System.Windows.Forms.Panel panel2;
		private EquiptMains equiptMains1;
		private System.Windows.Forms.Button eq_supply;
		private System.Windows.Forms.Button eq_edit;
		private System.Windows.Forms.Button eq_add;
		private System.Windows.Forms.Button eq_main;
		private gazmechDataSet gazmechDataSet;
		private System.Windows.Forms.BindingSource gas_equiptBindingSource;
		private gazmechDataSetTableAdapters.gas_equiptTableAdapter gas_equiptTableAdapter;
		private gazmechDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private EquiptAdd equiptAdd1;
		private EquiptEdit equiptEdit1;
	}
}


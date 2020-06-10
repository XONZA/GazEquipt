using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasEquipt
{
	public partial class COmponentAdd : UserControl
	{
		public void ComponentAddLoad()
		{
			this.gas_componentTableAdapter.FillByCompany(this.gazmechDataSet.gas_component);
			this.component_componyTableAdapter.Fill(this.gazmechDataSet.component_compony);
		}
		public COmponentAdd()
		{
			InitializeComponent();
		}

		private void Gas_componentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gas_componentBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);

		}

		private void COmponentAdd_Load(object sender, EventArgs e)
		{
			this.gas_componentTableAdapter.FillByCompany(this.gazmechDataSet.gas_component);
			this.component_componyTableAdapter.Fill(this.gazmechDataSet.component_compony);

		}

		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				int x;
				x = Convert.ToInt32(component_componyComboBox.SelectedValue);
				DataGridViewRow row = gas_componentDataGridView.CurrentRow;
				row.Cells[5].Value = x;
				this.Validate();
				this.gas_componentBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.gazmechDataSet);
				this.gas_componentTableAdapter.FillByCompany(this.gazmechDataSet.gas_component);
				this.component_componyTableAdapter.Fill(this.gazmechDataSet.component_compony);
			}
			catch (Exception)
			{
				MessageBox.Show("Введены некоректные данные!");
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.gas_componentDataGridView.Rows.RemoveAt(gas_componentDataGridView.CurrentRow.Index);
				this.gas_componentBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.gazmechDataSet);
			}
			catch
			{
				MessageBox.Show("Данная строка связана с оборудованием и её нельзя удалить!");
				this.gas_componentTableAdapter.FillByCompany(this.gazmechDataSet.gas_component);
				this.component_componyTableAdapter.Fill(this.gazmechDataSet.component_compony);
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			gazmechDataSet.gas_componentRow row;
			row = gazmechDataSet.gas_component.Newgas_componentRow();
			row.idgas_component = 0;
			row.gc_name = "Новый компонент";
			row.gc_count = 0;
			row.gc_coast = 0;
			row.id_compony = 1;
			gazmechDataSet.gas_component.Rows.Add(row);
			this.gas_componentTableAdapter.Update(this.gazmechDataSet.gas_component);
			this.gas_componentTableAdapter.FillByCompany(this.gazmechDataSet.gas_component);
		}
	}
}

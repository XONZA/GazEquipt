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
	public partial class ComponentPostavka : UserControl
	{
		public int idgas, nowcount, newcount;
		public ComponentPostavka()
		{
			InitializeComponent();
		}

		public void CompPostavkLoad()
		{
			this.gas_component_admissionTableAdapter.Fill(this.gazmechDataSet.gas_component_admission);
			this.gas_componentTableAdapter.Fill(this.gazmechDataSet.gas_component);
			button1.Enabled = false;
			button1.Text = "Выберите компонент из таблицы";
		}
		private void Gas_componentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gas_componentBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (gas_componentDataGridView.CurrentRow != null)
			{
				newcount = Convert.ToInt32(numericUpDown1.Value);
				DataGridViewRow row = gas_componentDataGridView.CurrentRow;
				row.Cells[4].Value = Convert.ToInt32(nowcount + newcount);
				gazmechDataSet.gas_component_admissionRow gas_comp;
				gas_comp = gazmechDataSet.gas_component_admission.Newgas_component_admissionRow();
				gas_comp.idgas_component_admission = 0;
				gas_comp.id_gas_component = idgas;
				gas_comp.gca_count = Convert.ToInt32(numericUpDown1.Value);
				gas_comp.gca_date = dateTimePicker1.Value;
				this.gazmechDataSet.gas_component_admission.Rows.Add(gas_comp);
				this.gas_component_admissionTableAdapter.Update(this.gazmechDataSet.gas_component_admission);
				this.gas_component_admissionTableAdapter.Fill(this.gazmechDataSet.gas_component_admission);
				this.gas_componentBindingSource.EndEdit();
				this.gas_componentTableAdapter.Update(this.gazmechDataSet.gas_component);
				this.gas_componentTableAdapter.Fill(this.gazmechDataSet.gas_component);
			}
			else MessageBox.Show("Выберите компонент");
		}

		private void Gas_componentDataGridView_MouseClick(object sender, MouseEventArgs e)
		{
			DataGridViewRow row = gas_componentDataGridView.CurrentRow;
			idgas = Convert.ToInt32(row.Cells[0].Value);
			nowcount = Convert.ToInt32(row.Cells[4].Value);
			button1.Enabled = true;
			button1.Text = "Добавить";
		}
	}
}

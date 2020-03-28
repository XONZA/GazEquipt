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
	public partial class EquiptAdd : UserControl
	{
		public int gas_idequip, coast;
		public EquiptAdd()
		{
			InitializeComponent();
		}

		private void Gas_equiptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gas_equiptBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);

		}

		private void Eqa_reciptadd_Click(object sender, EventArgs e)
		{
			if (gas_componentDataGridView.CurrentRow != null)
			{
				gazmechDataSet.gas_reciptRow gas_Recipt;
				gas_Recipt = gazmechDataSet.gas_recipt.Newgas_reciptRow();
				gas_Recipt.idgas_recipt = 0;
				gas_Recipt.id_gas_equipt = gas_idequip;
				DataGridViewRow roww = gas_componentDataGridView.CurrentRow;
				gas_Recipt.id_gas_componenta = Convert.ToInt32(roww.Cells[0].Value);
				coast += (Convert.ToInt32(roww.Cells[2].Value)) * (Convert.ToInt32(numericUpDown1.Value));
				gq_coastTextBox.Text = Convert.ToString(coast);
				gas_Recipt.r_count_component = Convert.ToInt32(numericUpDown1.Value);
				this.gazmechDataSet.gas_recipt.Rows.Add(gas_Recipt);
				this.gas_reciptTableAdapter.Update(this.gazmechDataSet.gas_recipt);
				this.gas_reciptTableAdapter.Fill(this.gazmechDataSet.gas_recipt);
				this.gas_equiptBindingSource.EndEdit();
				this.gas_equiptTableAdapter.Update(this.gazmechDataSet);
			}
			else MessageBox.Show("Выберите строку в таблице студентов");
		}

		private void EquiptAdd_Load(object sender, EventArgs e)
		{
			this.gas_reciptTableAdapter.Fill(this.gazmechDataSet.gas_recipt);
			this.gas_componentTableAdapter.Fill(this.gazmechDataSet.gas_component);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
			gazmechDataSet.gas_equiptRow gaseq;
			gaseq = gazmechDataSet.gas_equipt.Newgas_equiptRow();
			gaseq.idgas_equipt = 0;
			gaseq.gq_name = Convert.ToString(eqa_boxname.Text);
			gaseq.gq_coast = 0;
			gaseq.gq_count = 0;
			this.gazmechDataSet.gas_equipt.Rows.Add(gaseq);
			this.gas_equiptTableAdapter.Update(this.gazmechDataSet.gas_equipt);
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
			panel1.Visible = false;
			button1.Enabled = false;
			this.gas_equiptTableAdapter.FillBy(this.gazmechDataSet.gas_equipt);
			gas_idequip = gazmechDataSet.Tables["gas_equipt"].Rows[0].Field<int>("idgas_equipt");
		}

		private void Button2_Click(object sender, EventArgs e)
		{		
			panel1.Visible = true;
			button1.Enabled = true;
			eqa_boxname.Text = "";
		}
	}
}

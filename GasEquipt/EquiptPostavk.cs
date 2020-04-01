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
	public partial class EquiptPostavk : UserControl
	{
		public int idequip , equipcount, recidcomp, reccount;
		public decimal coastequip;
		public int[] compcount = new int[100];
		public int[] idcomp = new int[100];

		public void equiptPostavkaLoad()
		{
			this.gas_reciptTableAdapter.FillEquiptEdit(this.gazmechDataSet.gas_recipt);
			this.gas_componentTableAdapter.Fill(this.gazmechDataSet.gas_component);
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
			DataGridViewRow roww = gas_equiptDataGridView.CurrentRow;
			idequip = Convert.ToInt32(roww.Cells[0].Value);
			equipcount = Convert.ToInt32(roww.Cells[3].Value);
			DataView dv = new DataView(gazmechDataSet.gas_recipt);
			dv.RowFilter = ("id_gas_equipt = '" + 0 + "' ");
			gas_reciptDataGridView.DataSource = dv;
			numericUpDown1.Value = 0;
			this.gas_equiptBindingSource.MoveFirst();
			button1.Enabled = false;
		}
		public EquiptPostavk()
		{
			InitializeComponent();
		}

		private void Gas_equiptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gas_equiptBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);

		}

		private void EquiptPostavk_Load(object sender, EventArgs e)
		{
			this.gas_reciptTableAdapter.FillEquiptEdit(this.gazmechDataSet.gas_recipt);
			this.gas_componentTableAdapter.Fill(this.gazmechDataSet.gas_component);
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
			DataGridViewRow roww = gas_equiptDataGridView.CurrentRow;
			idequip = Convert.ToInt32(roww.Cells[0].Value);
			equipcount = Convert.ToInt32(roww.Cells[3].Value);
			DataView dv = new DataView(gazmechDataSet.gas_recipt);
			dv.RowFilter = ("id_gas_equipt = '" + 0 + "' ");
			gas_reciptDataGridView.DataSource = dv;
			this.gas_equiptBindingSource.MoveFirst();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			
		}

		private void Button2_Click_1(object sender, EventArgs e)
		{
			this.gas_equiptTableAdapter.Update(this.gazmechDataSet.gas_equipt);

		}

		private void EquiptPostavk_VisibleChanged(object sender, EventArgs e)
		{
			//this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
		}

		private void Gas_equiptDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			//Сборка оборудования по компонентам 
			int i = 0, q;
			// проверка достаточно ли элементов на складе
			for (; i < gas_reciptDataGridView.Rows.Count; i++)
				{
				// Взятие данных о компонентах которые нужно отнять и какое количество нужно отнять
					DataGridViewRow row = gas_reciptDataGridView.Rows[i];
					reccount = Convert.ToInt32(row.Cells[4].Value) * Convert.ToInt32(numericUpDown1.Value);
					idcomp[i] = Convert.ToInt32(row.Cells[1].Value);
					DataView dv = new DataView(gazmechDataSet.gas_component);
					dv.RowFilter = ("idgas_component = '" + idcomp[i] + "' ");
					gas_componentDataGridView.DataSource = dv;
					DataGridViewRow comrow = gas_componentDataGridView.Rows[0];
					compcount[i] = Convert.ToInt32(comrow.Cells[4].Value);
					if (compcount[i] >= reccount)
					{
						compcount[i] -= reccount;
					}
					else
					{
						MessageBox.Show("Недостаточно материала на складе!");
						gas_componentBindingSource.DataSource = gazmechDataSet.gas_component;
						break;
					}
				}
			// выполняем операцию по прибовлению количества к оборудованию и отнятие компонетов со склада
				if (i >= gas_reciptDataGridView.Rows.Count)
				{
					for (int x = 0; x < gas_reciptDataGridView.Rows.Count ; x++)
					{
						q = idcomp[x];
						DataView dv = new DataView(gazmechDataSet.gas_component);
						dv.RowFilter = ("idgas_component = '" + q + "' ");
						gas_componentDataGridView.DataSource = dv;
						DataGridViewRow comrow = gas_componentDataGridView.Rows[0];
						comrow.Cells[4].Value = Convert.ToInt32(compcount[x]);
						gas_componentDataGridView.DataSource = gazmechDataSet.gas_component;
				}
				DataView dqv = new DataView(gazmechDataSet.gas_equipt);
				dqv.RowFilter = ("idgas_equipt = '" + idequip + "' ");
				gas_equiptDataGridView.DataSource = dqv;
				DataGridViewRow roww = gas_equiptDataGridView.Rows[0];
				roww.Cells[3].Value = Convert.ToInt32(roww.Cells[3].Value) + Convert.ToInt32(numericUpDown1.Value);
				gas_equiptDataGridView.DataSource = gazmechDataSet.gas_equipt;
				this.gas_equiptTableAdapter.Update(this.gazmechDataSet.gas_equipt);
				this.gas_componentBindingSource.EndEdit();
				this.gas_componentTableAdapter.Update(this.gazmechDataSet.gas_component);
			}
			//this.gas_equiptBindingSource.EndEdit();
			//gas_componentDataGridView.DataSource = gazmechDataSet.gas_component;

			//this.gas_equiptTableAdapter.Update(this.gazmechDataSet.gas_equipt);
			//this.gas_componentTableAdapter.Update(this.gazmechDataSet.gas_component);
			/*	for (int i = 0; i < gas_reciptDataGridView.Rows.Count; i++)
			{
				DataGridViewRow row = gas_reciptDataGridView.Rows[i];
				DataGridViewRow comrow = gas_componentDataGridView.Rows[0];
				recidcomp = Convert.ToInt32(row.Cells[1].Value);
				reccount = Convert.ToInt32(row.Cells[4].Value);
				gas_componentBindingSource.Filter = ("idgas_component = '" + recidcomp + "' ");
				comrow.Cells[4].Value = Convert.ToInt32(comrow.Cells[4].Value) - reccount;
			}*/

		}

		private void Gas_equiptDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow roww = gas_equiptDataGridView.CurrentRow;
			idequip = Convert.ToInt32(roww.Cells[0].Value);
			equipcount = Convert.ToInt32(roww.Cells[3].Value);
			DataView dv = new DataView(gazmechDataSet.gas_recipt);
			dv.RowFilter = ("id_gas_equipt = '" + idequip + "' ");
			gas_reciptDataGridView.DataSource = dv;
			button1.Enabled = true;
		}
	}
}

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
	public partial class EquiptEdit : UserControl
	{
		public bool x;
		public int idequip;
		public decimal coast, minuscoast, nowcoast, coastequip;

		public void equaEditfocus()
		{
			tabControl1.Visible = false;
			this.gas_reciptTableAdapter.FillEquiptEdit(this.gazmechDataSet.gas_recipt);
			this.gas_componentTableAdapter.Fill(this.gazmechDataSet.gas_component);
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
			x = true;
			DataGridViewRow roww = gas_equiptDataGridView.CurrentRow;
			idequip = Convert.ToInt32(roww.Cells[0].Value);
			coastequip = Convert.ToDecimal(roww.Cells[2].Value);
			DataView dv = new DataView(gazmechDataSet.gas_recipt);
			dv.RowFilter = ("id_gas_equipt = '" + 0 + "' ");
			gas_reciptDataGridView.DataSource = dv;
			textBox1.Text = "";
			numericUpDown1.Value = 0;
			numericUpDown2.Value = 0;
			this.gas_equiptBindingSource.MoveFirst();
		}
		public EquiptEdit()
		{
			InitializeComponent();
		}

		private void Gas_equiptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gas_equiptBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			DataGridViewRow roww = gas_equiptDataGridView.CurrentRow;
			idequip = Convert.ToInt32(roww.Cells[0].Value);

			DataView dv = new DataView(gazmechDataSet.gas_recipt);
			dv.RowFilter = ("id_gas_equipt = '" + idequip + "' ");
			gas_reciptDataGridView.DataSource = dv;
		}

		private void FillEquiptEditToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.gas_reciptTableAdapter.FillEquiptEdit(this.gazmechDataSet.gas_recipt);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void FillEquiptEditToolStripButton_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.gas_reciptTableAdapter.FillEquiptEdit(this.gazmechDataSet.gas_recipt);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void EquiptEdit_Load(object sender, EventArgs e)
		{
			tabControl1.Visible = false;
			this.gas_reciptTableAdapter.FillEquiptEdit(this.gazmechDataSet.gas_recipt);
			this.gas_componentTableAdapter.Fill(this.gazmechDataSet.gas_component);
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
			x = true;
			DataGridViewRow roww = gas_equiptDataGridView.CurrentRow;
			idequip = Convert.ToInt32(roww.Cells[0].Value);
			coastequip = Convert.ToDecimal(roww.Cells[2].Value);
			DataView dv = new DataView(gazmechDataSet.gas_recipt);
			dv.RowFilter = ("id_gas_equipt = '" + 0 + "' ");
			gas_reciptDataGridView.DataSource = dv;
			this.gas_equiptBindingSource.MoveFirst();
		}

		private void FillEquiptEditToolStripButton_Click_2(object sender, EventArgs e)
		{
			try
			{
				this.gas_reciptTableAdapter.FillEquiptEdit(this.gazmechDataSet.gas_recipt);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void Gas_equiptDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow roww = gas_equiptDataGridView.CurrentRow;
			idequip = Convert.ToInt32(roww.Cells[0].Value);
			coastequip = Convert.ToDecimal(roww.Cells[2].Value);
			DataView dv = new DataView(gazmechDataSet.gas_recipt);
			dv.RowFilter = ("id_gas_equipt = '" + idequip + "' ");
			gas_reciptDataGridView.DataSource = dv;
			tabControl1.Visible = true;
		}

		private void FillEquiptEditToolStripButton_Click_3(object sender, EventArgs e)
		{
			try
			{
				this.gas_reciptTableAdapter.FillEquiptEdit(this.gazmechDataSet.gas_recipt);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void Button4_Click(object sender, EventArgs e)
		{
			if (x == true)
			{
				DataView dv = new DataView(gazmechDataSet.gas_equipt);
				dv.RowFilter = ("gq_name LIKE '" + textBox1.Text + "%' ");
				gas_equiptDataGridView.DataSource = dv;
				x = false;
				button4.Text = "Сбросить фильтр";
				textBox1.Text = "";
			}
			else
			{
				x = true;
				button4.Text = "Поиск";
				textBox1.Text = "";
				gas_equiptDataGridView.DataSource = gazmechDataSet.gas_equipt;
			}
		}

		private void Button5_Click(object sender, EventArgs e)
		{
		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			int locsumnow , locsumnew;
			DataGridViewRow rowed = gas_reciptDataGridView.CurrentRow;
			DataGridViewRow rowe = gas_equiptDataGridView.CurrentRow;
			coastequip = Convert.ToDecimal(rowe.Cells[2].Value);
			locsumnow = Convert.ToInt32(rowed.Cells[1].Value);
			locsumnew = Convert.ToInt32(numericUpDown2.Value);
			if (locsumnow < locsumnew)
			{
				minuscoast = Convert.ToDecimal(Convert.ToDecimal(rowed.Cells[5].Value)) * (locsumnew - locsumnow);
				coastequip += minuscoast;
				rowe.Cells[2].Value = Convert.ToDecimal(coastequip);
			}
			else if ( locsumnow > locsumnew)
			{
				minuscoast = (Convert.ToDecimal(rowed.Cells[5].Value)) * (locsumnow - locsumnew);
				coastequip -= minuscoast;
				rowe.Cells[2].Value = Convert.ToDecimal(coastequip);
			}
			rowed.Cells[1].Value = Convert.ToInt32(numericUpDown2.Value);
			this.gas_reciptBindingSource.EndEdit();
			this.gas_reciptTableAdapter.Update(this.gazmechDataSet.gas_recipt);
			this.gas_equiptBindingSource.EndEdit();
			this.gas_equiptTableAdapter.Update(this.gazmechDataSet);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			decimal coastrecipt;
			string message = "Вы действительно хотите удалить элемент сборки?";
			string caption = "Error Detected in Input";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;
			result = MessageBox.Show(message, caption, buttons);
			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				//DataView dv = new DataView(gazmechDataSet.gas_equipt);
				//dv.RowFilter = ("idgas_equipt = '" + idequip + "' ");
				//gas_equiptDataGridView.DataSource = dv;
				DataGridViewRow rowequipt = gas_equiptDataGridView.CurrentRow;
				DataGridViewRow rowrecipt = gas_reciptDataGridView.CurrentRow;
				coastequip = Convert.ToDecimal(rowequipt.Cells[2].Value);
				coastrecipt = (Convert.ToDecimal(rowrecipt.Cells[5].Value)) * (Convert.ToInt32(rowrecipt.Cells[1].Value));
				coastequip -= coastrecipt;
				rowequipt.Cells[2].Value = Convert.ToDecimal(coastequip);
				this.gas_reciptDataGridView.Rows.RemoveAt(gas_reciptDataGridView.CurrentRow.Index);
				this.gas_reciptBindingSource.EndEdit();
				this.gas_reciptTableAdapter.Update(this.gazmechDataSet.gas_recipt);
				gq_coastTextBox.Text = Convert.ToString(coastequip);
				this.gas_reciptTableAdapter.Fill(this.gazmechDataSet.gas_recipt);
				this.gas_reciptTableAdapter.FillEquiptEdit(this.gazmechDataSet.gas_recipt);
				this.gas_equiptBindingSource.EndEdit();
				this.gas_equiptTableAdapter.Update(this.gazmechDataSet);
			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (gas_componentDataGridView.CurrentRow != null)
			{
				gazmechDataSet.gas_reciptRow gas_Recipt;
				gas_Recipt = gazmechDataSet.gas_recipt.Newgas_reciptRow();
				gas_Recipt.idgas_recipt = 0;
				gas_Recipt.id_gas_equipt = idequip;
				DataGridViewRow roww = gas_componentDataGridView.CurrentRow;
				gas_Recipt.id_gas_componenta = Convert.ToInt32(roww.Cells[0].Value);
				coast = (Convert.ToDecimal(roww.Cells[2].Value)) * (Convert.ToInt32(numericUpDown1.Value));
				DataGridViewRow rows = gas_equiptDataGridView.CurrentRow;
				coastequip += coast;
				rows.Cells[2].Value = coastequip;
				gas_Recipt.r_count_component = Convert.ToInt32(numericUpDown1.Value);
				this.gazmechDataSet.gas_recipt.Rows.Add(gas_Recipt);
				this.gas_reciptTableAdapter.Update(this.gazmechDataSet.gas_recipt);
				this.gas_reciptTableAdapter.Fill(this.gazmechDataSet.gas_recipt);
				this.gas_reciptTableAdapter.FillEquiptEdit(this.gazmechDataSet.gas_recipt);
				this.gas_equiptBindingSource.EndEdit();
				this.gas_equiptTableAdapter.Update(this.gazmechDataSet);
			}
			else MessageBox.Show("Выберите компонент");
		}
	}
}

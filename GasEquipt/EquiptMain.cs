﻿using System;
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
	public partial class EquiptMains : UserControl
	{
		public bool x;

		public void EquipMainLoad()
		{
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
		}
		public EquiptMains()
		{
			InitializeComponent();
		}

		private void Gas_equiptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gas_equiptBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);

		}

		private void EquiptMains_Load(object sender, EventArgs e)
		{
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
			x = true;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (x == true)
			{
				if (textBox1.Text != "" && textBox2.Text == "")
				{
					DataView dv = new DataView(gazmechDataSet.gas_equipt);
					dv.RowFilter = ("gq_name LIKE '" + textBox1.Text + "%' ");
					gas_equiptDataGridView.DataSource = dv;
				}
				else if (textBox1.Text == "" && textBox2.Text != "")
				{
					DataView dv = new DataView(gazmechDataSet.gas_equipt);
					dv.RowFilter = ("gq_coast = '" + Convert.ToDecimal(textBox2.Text) + "' ");
					gas_equiptDataGridView.DataSource = dv;
				}
				else if (textBox1.Text != "" && textBox2.Text != "")
				{
					DataView dv = new DataView(gazmechDataSet.gas_equipt);
					dv.RowFilter = ("gq_name LIKE '" + textBox1.Text + "%' AND  gq_coast = '" + Convert.ToDecimal(textBox2.Text) + "' ");
					gas_equiptDataGridView.DataSource = dv;
				}
				button2.Text = "Сбросить фильтр";
				x = false;
			}
			else if (x == false)
			{
				textBox1.Text = "";
				textBox2.Text = "";
				gas_equiptDataGridView.DataSource = gazmechDataSet.gas_equipt;
				button2.Text = "Поиск";
				x = true;
			}
		}

		private void EquiptMains_VisibleChanged(object sender, EventArgs e)
		{
			try
			{
				this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
				x = true;
			}
			catch (Exception)
			{
				MessageBox.Show("База данных не обноружено!");
				Application.Exit();
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gas_equiptBindingSource.EndEdit();
			this.gas_equiptTableAdapter.Update(this.gazmechDataSet);
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			string message = "Вы действительно хотите удалить запись занятия? Вместе с записью удалятся все оценки и пропуски по данному занятию.";
			string caption = "Error Detected in Input";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;
			result = MessageBox.Show(message, caption, buttons);
			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				this.gas_equiptDataGridView.Rows.RemoveAt(gas_equiptDataGridView.CurrentRow.Index);
				this.gas_equiptBindingSource.EndEdit();
				this.gas_equiptTableAdapter.Update(this.gazmechDataSet.gas_equipt);
			}
		}
	}
}

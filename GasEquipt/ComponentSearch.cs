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
	public partial class ComponentSearch : UserControl
	{
		public bool check;
		public ComponentSearch()
		{
			InitializeComponent();
		}

		private void Gas_componentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gas_componentBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);

		}

		private void ComponentSearch_Load(object sender, EventArgs e)
		{
			this.gas_componentTableAdapter.FillByCompany(this.gazmechDataSet.gas_component);
			check = true;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (check == true)
			{
				if (textComponent.Text != "" && textCompony.Text == "" )
				{
					DataView dv = new DataView(gazmechDataSet.gas_component);
					dv.RowFilter = ("gc_name LIKE '" + textComponent.Text + "%' ");
					gas_componentDataGridView.DataSource = dv;
				}
				else if (textComponent.Text == "" && textCompony.Text != "" )
				{
					DataView dv = new DataView(gazmechDataSet.gas_component);
					dv.RowFilter = ("co_Name LIKE '" + textCompony.Text + "%' ");
					gas_componentDataGridView.DataSource = dv;
				}
				else if (textComponent.Text != "" && textCompony.Text != "" )
				{
					DataView dv = new DataView(gazmechDataSet.gas_component);
					dv.RowFilter = ("gc_name LIKE '" + textComponent.Text + "%' And co_Name LIKE '" + textCompony.Text + "%' ");
					gas_componentDataGridView.DataSource = dv;
				}
				button1.Text = "Сбросить фильтр";
				check = false;
			}
			else
			{
				textCompony.Text = "";
				textComponent.Text = "";
				gas_componentDataGridView.DataSource = gazmechDataSet.gas_component;
				this.gas_componentTableAdapter.FillByCompany(this.gazmechDataSet.gas_component);
				button1.Text = "Поиск";
				check = true;
			}
		}
	}
}

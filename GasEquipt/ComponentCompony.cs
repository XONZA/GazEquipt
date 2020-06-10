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
	public partial class ComponentCompony : UserControl
	{
		public bool check;

		public void CompComLoad()
		{
			this.component_componyTableAdapter.Fill(this.gazmechDataSet.component_compony);
		}
		public ComponentCompony()
		{
			InitializeComponent();
		}

		private void Component_componyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.component_componyBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);
			
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			if (check == true)
			{
			
				component_componyBindingSource.Filter = ("co_Name LIKE '" + textBox1.Text + "%' ");
				button4.Text = "Сбросить фильтр";
				check = false;
			}
			else
			{
				check = true;
				button4.Text = "Поиск";
				textBox1.Text = "";
				component_componyBindingSource.Filter = "";
			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.component_componyDataGridView.Rows.RemoveAt(component_componyDataGridView.CurrentRow.Index);
				this.component_componyBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.gazmechDataSet);
			}
			catch
			{
				MessageBox.Show("Данная компания связана с компонентами! Её нельзя удалить.");
				this.component_componyTableAdapter.Fill(this.gazmechDataSet.component_compony);
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.component_componyBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			gazmechDataSet.component_componyRow row;
			row = gazmechDataSet.component_compony.Newcomponent_componyRow();
			row.idcomponent_compony = 0;
			row.co_Name = "Новыя компания";
			gazmechDataSet.component_compony.Rows.Add(row);
			this.component_componyTableAdapter.Update(this.gazmechDataSet.component_compony);
			this.component_componyTableAdapter.Fill(this.gazmechDataSet.component_compony);
			this.component_componyBindingSource.MoveLast();
		}

		private void ComponentCompony_Load(object sender, EventArgs e)
		{
			this.component_componyTableAdapter.Fill(this.gazmechDataSet.component_compony);
			check = true;
		}
	}
}

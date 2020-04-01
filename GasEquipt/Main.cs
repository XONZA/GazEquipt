using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasEquipt
{
	public partial class Main : Form
	{
		public int Aunth_check;
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "gazmechDataSet.component_compony". При необходимости она может быть перемещена или удалена.
			this.component_componyTableAdapter.Fill(this.gazmechDataSet.component_compony);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "gazmechDataSet.gas_equipt". При необходимости она может быть перемещена или удалена.
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
			Auntth au = new Auntth();
			au.ShowDialog();
		}

		private void Main_Activated(object sender, EventArgs e)
		{
		}

		private void ПросмотрКомпонентовToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			equiptMains1.BringToFront();
			equiptMains1.EquipMainLoad();
			equiptEdit1.Visible = false;
			equiptMains1.Visible = true;
			equiptPostavk1.Visible = false;
			equiptAdd1.Visible = false;
		}

		private void Gas_equiptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gas_equiptBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);

		}

		private void Eq_add_Click(object sender, EventArgs e)
		{
			equiptAdd1.BringToFront();
			equiptAdd1.AddLoad();
			equiptEdit1.Visible = false;
			equiptMains1.Visible = false;
			equiptPostavk1.Visible = false;
			equiptAdd1.Visible = true;
		}

		private void Eq_edit_Click(object sender, EventArgs e)
		{
			equiptEdit1.BringToFront();
			equiptEdit1.Visible = true;
			equiptMains1.Visible = false;
			equiptPostavk1.Visible = false;
			equiptAdd1.Visible = false;
			equiptEdit1.equaEditfocus();
		}

		private void Eq_supply_Click(object sender, EventArgs e)
		{
			equiptPostavk1.BringToFront();
			equiptEdit1.Visible = false;
			equiptMains1.Visible = false;
			equiptPostavk1.Visible = true;
			equiptAdd1.Visible = false;
			equiptPostavk1.equiptPostavkaLoad();
		}

		private void EquiptPostavk1_Load(object sender, EventArgs e)
		{

		}

		private void Button3_Click(object sender, EventArgs e)
		{
			cOmponentAdd1.BringToFront();
			cOmponentAdd1.ComponentAddLoad();
		}

		private void Button2_Click_1(object sender, EventArgs e)
		{
			componentSearch1.BringToFront();
			componentSearch1.ComSearch();
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			componentCompony1.BringToFront();
			componentCompony1.CompComLoad();
		}
		
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Обновление данных при переключение между табами
			componentCompony1.CompComLoad();
			cOmponentAdd1.ComponentAddLoad();
			componentSearch1.ComSearch();
			equiptPostavk1.equiptPostavkaLoad();
			equiptEdit1.equaEditfocus();
			equiptAdd1.AddLoad();
			equiptMains1.EquipMainLoad();
		}
	}
}

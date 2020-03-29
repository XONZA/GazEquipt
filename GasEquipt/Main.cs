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
		}

		private void Eq_edit_Click(object sender, EventArgs e)
		{
			equiptEdit1.BringToFront();
		}
	}
}

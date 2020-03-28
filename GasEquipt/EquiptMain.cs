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
	public partial class EquiptMains : UserControl
	{
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
		}
	}
}

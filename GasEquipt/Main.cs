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
	}
}

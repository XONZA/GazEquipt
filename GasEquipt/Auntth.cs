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
	public partial class Auntth : Form
	{
		public int checkaut;

		public Auntth()
		{
			InitializeComponent();
		}
		private void Button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		/*Система авторизации через таблицу login*/
		private void Button1_Click(object sender, EventArgs e)
		{
			
			for (int i = 0; i <= gazmechDataSet.Tables["login"].Rows.Count - 1; i++)
			{
				if (textBox1.Text == gazmechDataSet.Tables["login"].Rows[i][1].ToString() && textBox2.Text == gazmechDataSet.Tables["login"].Rows[i][2].ToString())
				{
					checkaut = 1;
					this.Close();
					break;
				}
				else if (i == gazmechDataSet.Tables["login"].Rows.Count - 1)
				{
					MessageBox.Show("Неверный логин или пароль");
				}
			}
		}

		private void Auntth_FormClosed(object sender, FormClosedEventArgs e)
		{
			/*Проверка на автаризацию перез входом в главный блок программы*/
			if(checkaut == 1)
			{
				MessageBox.Show("Вы успешно авторизовались!");
			}
			else
			{
				Application.Exit();
			}
		}
		private void Auntth_Load_1(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "gazmechDataSet.login". При необходимости она может быть перемещена или удалена.
			this.loginTableAdapter.Fill(this.gazmechDataSet.login);

		}
	}
}

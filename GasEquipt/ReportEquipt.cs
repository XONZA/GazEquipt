using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;



namespace GasEquipt
{
	public partial class ReportEquipt : UserControl
	{
		public bool check;
		public ReportEquipt()
		{
			InitializeComponent();
		}
		public void ReportEquiptLoad()
		{
			craftitemsreportBindingSource.Filter = "";
			this.assembl_gas_equiptTableAdapter.ReportEquipt(this.gazmechDataSet.assembl_gas_equipt);
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
			this.craftitemsreportTableAdapter.Fill(this.gazmechDataSet.craftitemsreport);
			check = true;
			button1.Text = "Поиск";
		}
		private void Assembl_gas_equiptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.assembl_gas_equiptBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);

		}

		private void ReportEquipt_Load(object sender, EventArgs e)
		{
			this.assembl_gas_equiptTableAdapter.ReportEquipt(this.gazmechDataSet.assembl_gas_equipt);
			this.gas_equiptTableAdapter.Fill(this.gazmechDataSet.gas_equipt);
			this.craftitemsreportTableAdapter.Fill(this.gazmechDataSet.craftitemsreport);

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (check == true)
			{
				//dateTimePicker2.Value = dateTimePicker2.Value.AddDays(1);
				assembl_gas_equiptBindingSource.Filter = " [agq_data] >= '" + dateTimePicker1.Text + "' And " + "[agq_data] <= '" + dateTimePicker2.Text + "'";
				button1.Text = "Сбросить фильтр";
				check = false;
				button2.Text = "Печать";
				button2.Enabled = true;
			}
			else
			{
				assembl_gas_equiptBindingSource.Filter = "";
				button1.Text = "Поиск";
				check = true;
				button2.Text = "Укажите дату для печати!";
				button2.Enabled = false;
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			int coun, temp;
			coun = 0;
			for(int x = 0;x < assembl_gas_equiptDataGridView.Rows.Count ;x++)
			{
				temp = Convert.ToInt32(assembl_gas_equiptDataGridView.Rows[x].Cells[3].Value);
				coun += temp;
			}
			DGVPrinter pr = new DGVPrinter();
			pr.PorportionalColumns = true;
			pr.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
			pr.ColumnWidths.Add(assembl_gas_equiptDataGridView1.Columns[2].Name, 400);
			pr.ColumnWidths.Add(assembl_gas_equiptDataGridView1.Columns[3].Name, 150);
			pr.ColumnWidths.Add(assembl_gas_equiptDataGridView1.Columns[4].Name, 150);
			pr.PageNumbers = false;
			pr.Footer = "Дата с " + dateTimePicker1.Value.ToShortDateString() + " по: " + dateTimePicker2.Value.ToShortDateString() + "                                                                        Подпись:________";
			pr.FooterAlignment = StringAlignment.Near;
			pr.Title = ("ОАО'НЗГA' ");
			pr.TitleAlignment = StringAlignment.Far;
			pr.TitleFont = new Font("Consolas", Font.Size / 1.2f);
			pr.TitleSpacing = 20;
			pr.SubTitle = "Отчёт по Сборке оборудования";
			pr.SubTitleSpacing = 15;
			pr.PrintDataGridView(assembl_gas_equiptDataGridView1);
		}

		private void Gq_nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void Gq_nameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
		{

		}
	}
}

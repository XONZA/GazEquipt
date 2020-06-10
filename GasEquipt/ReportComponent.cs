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
	public partial class ReportComponent : UserControl
	{
		public bool check;
		public ReportComponent()
		{
			InitializeComponent();
		}
		public void ReportCompLoad()
		{
			craftitemsreportBindingSource1.DataSource = gazmechDataSet.craftitemsreport;
			this.gas_componentTableAdapter.Fill(this.gazmechDataSet.gas_component);
			this.gas_component_admissionTableAdapter.FillReport(this.gazmechDataSet.gas_component_admission);
			this.craftitemsreportTableAdapter.Fill(this.gazmechDataSet.craftitemsreport);
			check = true;
			button1.Text = "Поиск";

		}
		private void Gas_component_admissionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gas_component_admissionBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.gazmechDataSet);

		}

		private void ReportComponent_Load(object sender, EventArgs e)
		{
			this.gas_componentTableAdapter.Fill(this.gazmechDataSet.gas_component);
			this.gas_component_admissionTableAdapter.FillReport(this.gazmechDataSet.gas_component_admission);
			this.craftitemsreportTableAdapter.Fill(this.gazmechDataSet.craftitemsreport);
			check = true;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (check == true)
			{
				//dateTimePicker2.Value = dateTimePicker2.Value.AddDays(1);
				
				craftitemsreportBindingSource1.Filter = " [craftdate] >= '" + dateTimePicker1.Text + "' And " + "[craftdate] <= '" + dateTimePicker2.Text + "'";
				button1.Text = "Сбросить фильтр";
				check = false;
				button2.Text = "Печать";
				button2.Enabled = true;
			}
			else
			{
				craftitemsreportBindingSource1.Filter = "";
				button1.Text = "Поиск";
				check = true;
				button2.Text = "Укажите дату для печати!";
				button2.Enabled = false;
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			DGVPrinter pr = new DGVPrinter();
			pr.PorportionalColumns = true;
			pr.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
			pr.ColumnWidths.Add(craftitemsreportDataGridView.Columns[1].Name, 250);
			pr.ColumnWidths.Add(craftitemsreportDataGridView.Columns[2].Name, 250);
			pr.ColumnWidths.Add(craftitemsreportDataGridView.Columns[3].Name, 100);
			pr.ColumnWidths.Add(craftitemsreportDataGridView.Columns[4].Name, 100);
			pr.PageNumbers = false;
			pr.Footer = "Дата с " + dateTimePicker1.Value.ToShortDateString() + " по: " + dateTimePicker2.Value.ToShortDateString() + "                                                                        Подпись:________";
			pr.FooterAlignment = StringAlignment.Near;
			pr.Title = ("ОАО'НЗГA' ");
			pr.TitleAlignment = StringAlignment.Far;
			pr.TitleFont = new Font("Consolas", Font.Size / 1.2f);
			pr.TitleSpacing = 20;
			pr.SubTitle = "Отчёт по расходу компонентов";
			pr.SubTitleSpacing = 15;
			pr.PrintDataGridView(craftitemsreportDataGridView);
		}
	}
}

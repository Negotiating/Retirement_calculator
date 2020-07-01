using System;
using System.Linq;
using System.Windows.Forms;

namespace Retirement_calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void salary_box_TextChanged(object sender, EventArgs e)
		{
			if(salary_box.Text.Contains(',')||salary_box.Text.Contains('-'))
			{
				salary_box.Text = salary_box.Text.Replace(',', '.');
			}
			int count = 0;
			foreach(char symbol in salary_box.Text)
			{
				if (symbol == '.') count++;
			}
			if (count > 1)
			{
				MessageBox.Show("Некорректный ввод!");
				salary_box.Clear();
			}
			if (salary_box.Text != "")
			{

				try
				{
					Convert.ToDouble(salary_box.Text);
				}
				catch
				{
					MessageBox.Show("Некорректный ввод!");
					salary_box.Clear();
				}
			}
		}

		private void work_experience_box_TextChanged(object sender, EventArgs e)
		{
			if (work_experience_box.Text != "")
			{
				try
				{
					Convert.ToUInt32(work_experience_box.Text);
				}
				catch
				{
					MessageBox.Show("Некорректный ввод!");
					work_experience_box.Clear();
				}

			}
		}
		private void calculate_button_Click(object sender, EventArgs e)
		{
			try
			{
				bool gender;
				if (gender_box.Text == "женский") gender = false;
				else gender = true;
				Person person = new Person(gender,
					year_of_birth_box.Text,
					Convert.ToUInt32(military_servise_box.Value),
					Convert.ToUInt32(amount_of_children_box.Value),
					Convert.ToUInt32(work_experience_box.Text),
					Convert.ToDouble(salary_box.Text));
				SP_label.Text = Pension.Calculate_pension(person).ToString();
				IPK_label.Text = Pension.Calculate_IPK(person).ToString();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		
		}

		private void reset_button_Click(object sender, EventArgs e)
		{
			gender_box.Text = "";
			work_experience_box.Clear();
			salary_box.Clear();
			year_of_birth_box.Clear();
			amount_of_children_box.Value = 0;
			military_servise_box.Value = 0;
			SP_label.Text = "00.00";
			IPK_label.Text = "00.00";
		}
	}
}

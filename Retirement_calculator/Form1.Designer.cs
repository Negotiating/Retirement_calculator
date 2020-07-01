namespace Retirement_calculator
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.gender_label = new System.Windows.Forms.Label();
			this.year_of_birth_label = new System.Windows.Forms.Label();
			this.military_servise_label = new System.Windows.Forms.Label();
			this.amount_of_children_label = new System.Windows.Forms.Label();
			this.work_experience_label = new System.Windows.Forms.Label();
			this.salary_label = new System.Windows.Forms.Label();
			this.reset_button = new System.Windows.Forms.Button();
			this.calculate_button = new System.Windows.Forms.Button();
			this.gender_box = new System.Windows.Forms.ComboBox();
			this.year_of_birth_box = new System.Windows.Forms.MaskedTextBox();
			this.amount_of_children_box = new System.Windows.Forms.NumericUpDown();
			this.salary_box = new System.Windows.Forms.TextBox();
			this.work_experience_box = new System.Windows.Forms.TextBox();
			this.rezults_group = new System.Windows.Forms.GroupBox();
			this.SP_label = new System.Windows.Forms.Label();
			this.IPK_label = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.military_servise_box = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.amount_of_children_box)).BeginInit();
			this.rezults_group.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.military_servise_box)).BeginInit();
			this.SuspendLayout();
			// 
			// gender_label
			// 
			this.gender_label.AutoSize = true;
			this.gender_label.Location = new System.Drawing.Point(12, 32);
			this.gender_label.Name = "gender_label";
			this.gender_label.Size = new System.Drawing.Size(50, 22);
			this.gender_label.TabIndex = 0;
			this.gender_label.Text = "Пол:";
			// 
			// year_of_birth_label
			// 
			this.year_of_birth_label.AutoSize = true;
			this.year_of_birth_label.Location = new System.Drawing.Point(12, 68);
			this.year_of_birth_label.Name = "year_of_birth_label";
			this.year_of_birth_label.Size = new System.Drawing.Size(134, 22);
			this.year_of_birth_label.TabIndex = 1;
			this.year_of_birth_label.Text = "Год рождения:";
			// 
			// military_servise_label
			// 
			this.military_servise_label.AutoSize = true;
			this.military_servise_label.Location = new System.Drawing.Point(12, 103);
			this.military_servise_label.Name = "military_servise_label";
			this.military_servise_label.Size = new System.Drawing.Size(252, 22);
			this.military_servise_label.TabIndex = 2;
			this.military_servise_label.Text = "Срок военной службы (лет):";
			// 
			// amount_of_children_label
			// 
			this.amount_of_children_label.AutoSize = true;
			this.amount_of_children_label.Location = new System.Drawing.Point(12, 139);
			this.amount_of_children_label.Name = "amount_of_children_label";
			this.amount_of_children_label.Size = new System.Drawing.Size(168, 22);
			this.amount_of_children_label.TabIndex = 3;
			this.amount_of_children_label.Text = "Количество детей:";
			// 
			// work_experience_label
			// 
			this.work_experience_label.AutoSize = true;
			this.work_experience_label.Location = new System.Drawing.Point(12, 176);
			this.work_experience_label.Name = "work_experience_label";
			this.work_experience_label.Size = new System.Drawing.Size(333, 22);
			this.work_experience_label.TabIndex = 4;
			this.work_experience_label.Text = "Стаж в качестве наемного работника:";
			// 
			// salary_label
			// 
			this.salary_label.AutoSize = true;
			this.salary_label.Location = new System.Drawing.Point(12, 212);
			this.salary_label.Name = "salary_label";
			this.salary_label.Size = new System.Drawing.Size(212, 22);
			this.salary_label.TabIndex = 5;
			this.salary_label.Text = "Официальная зарплата:";
			// 
			// reset_button
			// 
			this.reset_button.Location = new System.Drawing.Point(215, 415);
			this.reset_button.Name = "reset_button";
			this.reset_button.Size = new System.Drawing.Size(197, 51);
			this.reset_button.TabIndex = 6;
			this.reset_button.Text = "Сбросить";
			this.reset_button.UseVisualStyleBackColor = true;
			this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
			// 
			// calculate_button
			// 
			this.calculate_button.Location = new System.Drawing.Point(12, 415);
			this.calculate_button.Name = "calculate_button";
			this.calculate_button.Size = new System.Drawing.Size(197, 51);
			this.calculate_button.TabIndex = 7;
			this.calculate_button.Text = "Рассчитать";
			this.calculate_button.UseVisualStyleBackColor = true;
			this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
			// 
			// gender_box
			// 
			this.gender_box.FormattingEnabled = true;
			this.gender_box.Items.AddRange(new object[] {
            "женский",
            "мужской"});
			this.gender_box.Location = new System.Drawing.Point(269, 29);
			this.gender_box.Name = "gender_box";
			this.gender_box.Size = new System.Drawing.Size(141, 30);
			this.gender_box.TabIndex = 8;
			// 
			// year_of_birth_box
			// 
			this.year_of_birth_box.Location = new System.Drawing.Point(269, 65);
			this.year_of_birth_box.Mask = "0000";
			this.year_of_birth_box.Name = "year_of_birth_box";
			this.year_of_birth_box.Size = new System.Drawing.Size(141, 30);
			this.year_of_birth_box.TabIndex = 9;
			this.year_of_birth_box.ValidatingType = typeof(int);
			// 
			// amount_of_children_box
			// 
			this.amount_of_children_box.Location = new System.Drawing.Point(269, 137);
			this.amount_of_children_box.Name = "amount_of_children_box";
			this.amount_of_children_box.Size = new System.Drawing.Size(141, 30);
			this.amount_of_children_box.TabIndex = 11;
			// 
			// salary_box
			// 
			this.salary_box.Location = new System.Drawing.Point(269, 209);
			this.salary_box.Name = "salary_box";
			this.salary_box.Size = new System.Drawing.Size(141, 30);
			this.salary_box.TabIndex = 12;
			this.salary_box.TextChanged += new System.EventHandler(this.salary_box_TextChanged);
			// 
			// work_experience_box
			// 
			this.work_experience_box.Location = new System.Drawing.Point(351, 173);
			this.work_experience_box.Name = "work_experience_box";
			this.work_experience_box.Size = new System.Drawing.Size(59, 30);
			this.work_experience_box.TabIndex = 13;
			this.work_experience_box.TextChanged += new System.EventHandler(this.work_experience_box_TextChanged);
			// 
			// rezults_group
			// 
			this.rezults_group.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.rezults_group.Controls.Add(this.SP_label);
			this.rezults_group.Controls.Add(this.IPK_label);
			this.rezults_group.Controls.Add(this.label2);
			this.rezults_group.Controls.Add(this.label1);
			this.rezults_group.Location = new System.Drawing.Point(21, 261);
			this.rezults_group.Name = "rezults_group";
			this.rezults_group.Size = new System.Drawing.Size(388, 126);
			this.rezults_group.TabIndex = 14;
			this.rezults_group.TabStop = false;
			this.rezults_group.Text = "Результаты расчета";
			// 
			// SP_label
			// 
			this.SP_label.AutoSize = true;
			this.SP_label.Location = new System.Drawing.Point(288, 96);
			this.SP_label.Name = "SP_label";
			this.SP_label.Size = new System.Drawing.Size(0, 22);
			this.SP_label.TabIndex = 3;
			// 
			// IPK_label
			// 
			this.IPK_label.AutoSize = true;
			this.IPK_label.Location = new System.Drawing.Point(288, 54);
			this.IPK_label.Name = "IPK_label";
			this.IPK_label.Size = new System.Drawing.Size(0, 22);
			this.IPK_label.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(272, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Размер страховой пенсии, руб:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Количество индивидуальных \r\nпенсионных коэфициентов:";
			// 
			// military_servise_box
			// 
			this.military_servise_box.Location = new System.Drawing.Point(269, 101);
			this.military_servise_box.Name = "military_servise_box";
			this.military_servise_box.Size = new System.Drawing.Size(141, 30);
			this.military_servise_box.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 480);
			this.Controls.Add(this.rezults_group);
			this.Controls.Add(this.work_experience_box);
			this.Controls.Add(this.salary_box);
			this.Controls.Add(this.amount_of_children_box);
			this.Controls.Add(this.military_servise_box);
			this.Controls.Add(this.year_of_birth_box);
			this.Controls.Add(this.gender_box);
			this.Controls.Add(this.calculate_button);
			this.Controls.Add(this.reset_button);
			this.Controls.Add(this.salary_label);
			this.Controls.Add(this.work_experience_label);
			this.Controls.Add(this.amount_of_children_label);
			this.Controls.Add(this.military_servise_label);
			this.Controls.Add(this.year_of_birth_label);
			this.Controls.Add(this.gender_label);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Form1";
			this.Text = "Пенсионый калькулятор";
			((System.ComponentModel.ISupportInitialize)(this.amount_of_children_box)).EndInit();
			this.rezults_group.ResumeLayout(false);
			this.rezults_group.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.military_servise_box)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label gender_label;
		private System.Windows.Forms.Label year_of_birth_label;
		private System.Windows.Forms.Label military_servise_label;
		private System.Windows.Forms.Label amount_of_children_label;
		private System.Windows.Forms.Label work_experience_label;
		private System.Windows.Forms.Label salary_label;
		private System.Windows.Forms.Button reset_button;
		private System.Windows.Forms.Button calculate_button;
		private System.Windows.Forms.ComboBox gender_box;
		private System.Windows.Forms.MaskedTextBox year_of_birth_box;
		private System.Windows.Forms.NumericUpDown amount_of_children_box;
		private System.Windows.Forms.TextBox salary_box;
		private System.Windows.Forms.TextBox work_experience_box;
		private System.Windows.Forms.GroupBox rezults_group;
		private System.Windows.Forms.Label SP_label;
		private System.Windows.Forms.Label IPK_label;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown military_servise_box;
		private System.Windows.Forms.ToolTip info_gender;
	}
}


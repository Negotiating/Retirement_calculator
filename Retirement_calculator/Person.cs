namespace Retirement_calculator
{
	class Person
	{
		private bool _gender;
		private string _year_of_birth;
		private uint _military_servise;
		private uint _amount_of_children;
		private uint _work_experience;
		private double _salary;
		public Person() { }
		public Person(bool gender, string year_of_birth, uint military_servise, uint amount_of_children, uint work_experience, double salary)
		{
			_gender = gender;
			_year_of_birth = year_of_birth;
			_military_servise = military_servise;
			_amount_of_children = amount_of_children;
			_work_experience = work_experience;
			_salary = salary;
		}
		public bool gender
		{
			get => _gender;
		}
		public string year_of_birth
		{
			get => _year_of_birth;
		}
		public uint military_servise
		{
			get => _military_servise;
		}
		public uint amount_of_children
		{
			get => _amount_of_children;
		}
		public uint work_experience
		{
			get => _work_experience;
		}
		public double salary
		{
			get => _salary;
		}
	}
}

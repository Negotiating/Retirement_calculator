using System;
namespace Retirement_calculator
{
	class Pension
	{
		private static double _SP;//размер страховой пенсии
		private static double _IPK;//индивидуальный пенсионный коэфициент
		private static double _KvFV=1;//коэфициент повышения ФВ
		public Pension() { }
		public static double Calculate_pension(Person person)
		{
			_IPK = Calculate_IPK(person);
			_KvFV = KvFV(person);
			return _SP = _IPK * 93.00 + (5686.25 * _KvFV);			
		}
		public static double Calculate_IPK(Person person)
		{
			Pension._IPK = (((person.salary / 0.87) * 12) * 0.16) / (1021000 * 0.16) * 10;
			Pension._IPK *= person.work_experience;
			//за каждый год военной службы +1.8  ИПК
			if (person.military_servise != 0)
				for (int i = 1; i < person.military_servise; i++)
					Pension._IPK += 1.8;
			//за год ухода за ребенком до четырех детей
			if (person.amount_of_children != 0)
			{
				switch (person.amount_of_children)
				{
					case 1: Pension._IPK += 1.8;
						break;
					case 2: Pension._IPK += 3.6;
						break;
					case 3: Pension._IPK += 5.4;
						break;
					case 4: Pension._IPK += 5.4;
						break;
					default: Pension._IPK += 0;
						break;
				}
			}
			//return Pension._IPK;
			return Math.Round(Pension._IPK, 2);
		}
		public static double KvFV(Person person)
		{
			int years = DateTime.Now.Year - Convert.ToInt32(person.year_of_birth);//возраст
			int buf;
			if (!person.gender)
				buf = years - 57;//количество лет отсрочки пенсии для женщин
			else
				buf = years - 62;//количество лет отсрочки для мужчин
			switch (buf)
			{
				case 0:
					_KvFV = 1;
					break;
				case 1:
					_KvFV = 1.07;
					break;
				case 2:
					_KvFV = 1.15;
					break;
				case 3:
					_KvFV = 1.24;
					break;
				case 4:
					_KvFV = 1.34;
					break;
				case 5:
					_KvFV = 1.45;
					break;
				case 6:
					_KvFV = 1.59;
					break;
				case 7:
					_KvFV = 1.74;
					break;
				case 8:
					_KvFV = 1.9;
					break;
				case 9:
					_KvFV = 2.09;
					break;
				case 10:
					_KvFV = 2.32;
					break;
				default:
					_KvFV = 1;
					break;
			}
			return _KvFV;
		}
	}
}

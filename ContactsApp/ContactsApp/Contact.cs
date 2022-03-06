using System;
using System.Globalization;

namespace ContactsApp
{
	/// <summary>
	/// Контакт в записной книжке
	/// </summary>
    public class Contact : ICloneable
    {
		/// <summary>
		/// Значение максимальной длины имени
        /// </summary>
		private const int MaxNameLength = 50;

        /// <summary>
        /// Значение максимальной длины email
        /// </summary>
        private const int MaxEmailLength = 50;

		/// <summary>
		/// Значение макимальной длины VK ID
		/// </summary>
		private const int MaxVkLength = 15;

		/// <summary>
		/// Хранит значение имени
		/// </summary>
		private string _name;

		/// <summary>
		/// Хранит значение фамилии
		/// </summary>
		private string _surname;

		/// <summary>
		/// Хранит значение даты рождения
		/// </summary>
		private DateTime _birthday;

		/// <summary>
		/// Хранит значение адреса email
		/// </summary>
		private string _email;

		/// <summary>
		/// Хранит значение VK ID
		/// </summary>
		private string _vkId;

		/// <summary>
		/// Устанавливает и возвращает значение имени
		/// </summary>
		public string Name
		{
			get => _name;

            set
			{
				ValueValidator.AssertStringLength(value,
					MaxNameLength, nameof(Name));
				_name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
			}

		}

		/// <summary>
		/// Устанавливает и возвращает значение фамилии
		/// </summary>
		public string Surname
		{
			get => _surname;

            set
			{
				ValueValidator.AssertStringLength(value,
					MaxNameLength, nameof(Surname));
				_surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); ;
			}
		}

		/// <summary>
		/// Устанавливает и возвращает значение адреса email
		/// </summary>
		public string Email
		{
			get => _email;

            set
			{
                ValueValidator.AssertStringLength(value,
					MaxEmailLength, nameof(Email));
				_email = value;
			}

		}

		/// <summary>
		///Устанавливает и возвращает значение номера телефона
		/// </summary>
		public PhoneNumber PhoneNumber { get; set; }

		/// <summary>
		/// Устанавливает и возвращает значение адреса VK ID
		/// </summary>
		public string VkId
		{
			get => _vkId;

            set
			{
                ValueValidator.AssertStringLength(value,
					MaxVkLength, nameof(VkId));
				_vkId = value;
			}

		}

		/// <summary>
		/// Устанавливает и возвращает дату дня рождения
		/// </summary>
		public DateTime Birthday
		{
			get => _birthday;

            set
			{
				ValueValidator.CheckDate(value);
				_birthday = value;
			}
		}

		/// <summary>
		/// Создает объект контакта
		/// </summary>
		/// <param name="surname">Фамилия</param>
		/// <param name="name">Имя</param>
		/// <param name="phoneNumber">Номер телефона</param>
		/// <param name="birthday">Дата рождения</param>
		/// <param name="email">Адрес email</param>
		/// <param name="vkId">VK ID</param>
		public Contact(string name, string surname,
			 PhoneNumber phoneNumber, DateTime birthday,
			 string email, string vkId)
		{
			Surname = surname;
			Name = name;
			PhoneNumber = phoneNumber;
			Birthday = birthday;
			Email = email;
			VkId = vkId;
		}

		/// <summary>
		/// Создает копию объекта Contact
		/// </summary>
		/// <returns>Копия объекта Contact</returns>
        public object Clone()
        {
            return new Contact(Name,  Surname,
                new PhoneNumber(PhoneNumber.Number),
                Birthday, Email, VkId);
        }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp
{
	/// <summary>
	/// Класс работы со списком контактов
	/// </summary>
    public class Project
    {
		/// <summary>
		/// Список всех текущих контактов
		/// </summary>
		public List<Contact> Contacts { set; get; } = new List<Contact>();

		/// <summary>
		/// Сортирует список контактов
		/// </summary>
		/// <returns>All sorted contacts</returns>
		private List<Contact> SortContacts()
		{
			for (int i = 0; i < Contacts.Count; i++)
			{
				if (Contacts[i] == null)
				{
					Contacts.RemoveAt(i);
				}
			}
			return Contacts.OrderBy(
				contact => contact.Surname).ToList();
        }

		/// <summary>
		/// Ищет контакт
		/// </summary>
		/// <param name="substring">
		/// Ищет контакт по имени или фамилии
		/// </param>
		/// <returns>
		/// Все найденные контакты
		/// </returns>
		public List<Contact> SearchContacts(string substring)
		{
			var contacts = new List<Contact>();
			var query = SortContacts();
			foreach (var i in query)
			{
				if (i.Surname.Contains(substring))
				{
					contacts.Add(i);
				}
				else if (i.Name.Contains(substring))
				{
					contacts.Add(i);
				}
			}

			return contacts;
		}

		/// <summary>
		/// Ищет все ненулевые контакты
		/// </summary>
		/// <returns>Returns all contacts</returns>
		public List<Contact> SearchContacts()
		{
			var contacts = new List<Contact>();
			var query = SortContacts();
			foreach (var i in query)
			{
				contacts.Add(i);
			}

			return contacts;
		}

		/// <summary>
		/// Ищет людей по дню рождения
		/// </summary>
		/// <param name="date"></param>
		/// <returns></returns>
		public List<Contact> FindBirthdayContacts(DateTime date)
		{
			var birthdayContacts = new List<Contact>();
			foreach (var contact in Contacts)
			{
				if (contact.Birthday.Day == date.Day &&
					contact.Birthday.Month == date.Month)
				{
					birthdayContacts.Add(contact);
				}
			}

			return birthdayContacts;
		}

		/// <summary>
		/// Ищет контакт по объекту Contact
		/// </summary>
		/// <param name="contact"></param>
		/// <returns>Первый найденный контакт</returns>
		public int FindIndex(Contact contact)
		{
			for (int i = 0; i < Contacts.Count; i++)
			{
				if (Contacts[i].Name == contact.Name &&
					Contacts[i].Surname == contact.Surname)
				{
					return i;
				}
			}

			return -1;
		}
	}
}

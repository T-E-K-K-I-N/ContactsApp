﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp
{
	/// <summary>
	/// Класс работы со списком контактов
	/// </summary>
    public class Project : IEquatable<Project>
    {
		/// <summary>
		/// Список всех текущих контактов
		/// </summary>
		public List<Contact> Contacts { get; set; } = new List<Contact>();

		/// <summary>
		/// Сортирует список контактов
		/// </summary>
		/// <returns>All sorted contacts</returns>
		private List<Contact> SortContacts()
		{
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
            contacts.AddRange(query.Where(i => 
                (i.Surname.Contains(substring)) 
                || (i.Name.Contains(substring))).ToList());
            
            //foreach (var i in query)
		   //{
		   //	if (i.Surname.Contains(substring))
		   //	{
		   //		contacts.Add(i);
		   //	}
		   //	else if (i.Name.Contains(substring))
		   //	{
		   //		contacts.Add(i);
		   //	}
		   //}
           
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
			contacts.AddRange(query);

			//foreach (var i in query)
			//{
			//	contacts.Add(i);
			//}

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
			birthdayContacts.AddRange(Contacts.Where(contact => 
                (contact.Birthday.Day.Equals(date.Day)) 
                && (contact.Birthday.Month.Equals(date.Month))));
			
            //foreach (var contact in Contacts)
			//{
			//	if (contact.Birthday.Day == date.Day &&
			//		contact.Birthday.Month == date.Month)
			//	{
			//		birthdayContacts.Add(contact);
			//	}
			//}

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

		/// <summary>
		/// Сравнивает два объекта проекта
		/// </summary>
		public bool Equals(Project other)
		{
			return other != null && this.Contacts.Equals(other.Contacts);
		}
	}
}

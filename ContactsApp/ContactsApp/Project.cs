using System.Collections.Generic;

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

	}
}

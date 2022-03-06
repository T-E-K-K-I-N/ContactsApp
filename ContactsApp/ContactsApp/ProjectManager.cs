using System;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Класс управления списокм контактов
    /// </summary>
    public static class ProjectManager
    {
		/// <summary>
		/// Имя файла сохранения
		/// </summary>
		private const string FileName = "ContactsApp.notes";

		/// <summary>
		/// Папка сохранения данных
		/// </summary>
		private static readonly string _folder = Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData) +
			"\\ContactsApp\\";

		/// <summary>
		/// Путь к файлу
		/// </summary>
		private static readonly string _path = _folder + FileName;

		/// <summary>
		/// Default path for save and read of the file
		/// </summary>
		public static string DefaultPath { get; set; } = _path;

		/// <summary>
		/// Чтение объекта Project из файла
		/// </summary>
		/// <returns>Десериализованный объект</returns>
		public static Project ReadProject()
		{
            var project = new Project();

			if (!File.Exists(DefaultPath))
			{
				return project;
			}

            try
			{
				using (StreamReader file = new StreamReader(
					DefaultPath, System.Text.Encoding.Default))
				{
					var projectText = file.ReadLine();
					if (string.IsNullOrEmpty(projectText))
					{
						projectText = null;
					}

					project = JsonConvert.DeserializeObject<Project>(projectText);
				}
			}
			catch (SerializationException)
			{
				return project;
			}

			return project;
		}

        /// <summary>
		/// Сохраняет объект Project в файл
		/// </summary>
		/// <param name="project">Объект для сохранения</param>
		public static void SaveProject(Project project)
		{
			if (!File.Exists(DefaultPath))
			{
				CreatePath(_folder, FileName);
			}

			using (StreamWriter file = new StreamWriter(
				DefaultPath, false, System.Text.Encoding.UTF8))
			{
				file.Write(JsonConvert.SerializeObject(project));
			}
		}

		/// <summary>
		/// Создает путья для сохранения файла
		/// </summary>
		/// <param name="folder">Расположение файла</param>
		/// <param name="fileName">Сохранение файла</param>
		public static void CreatePath(string folder, string fileName)
		{
			if (folder == null)
			{
				folder = _folder;
			}

			if (fileName == null)
			{
				fileName = FileName;
			}

			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}

			if (!File.Exists(folder + fileName))
			{
				File.Create(folder + fileName).Close();
			}

			DefaultPath = folder + fileName;
		}
	}
}

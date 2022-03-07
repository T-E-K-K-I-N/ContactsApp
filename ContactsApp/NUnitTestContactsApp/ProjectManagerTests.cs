using System.IO;
using System.Reflection;
using NUnit.Framework;
using Newtonsoft.Json;

namespace ContactsApp.UnitTests
{
    [TestFixture]
	public class ProjectManagerTests
	{
		/// <summary>
		/// Название файла для тестов
		/// </summary>
		private static readonly string _fileName = "TestFile.txt";

		/// <summary>
		/// Название папки для тестовых данных
		/// </summary>
		private static readonly string _folder = 
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestData\";

		/// <summary>
		/// Путь к файлу с тестовыми данными
		/// </summary>
		private static readonly string _path = _folder + _fileName;

		/// <summary>
		/// Путь к файлу с корректными данными
		/// </summary>
		private static readonly string _referencePath = 
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestData\CorrectData.txt";
        
        /// <summary>
        /// Путь к файлу с некорреткными данными
        /// </summary>
        private static readonly string _referenceBrokenPath = 
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestData\BrokenData.txt";

		/// <summary>
		/// Путь к несуществующему файлу
		/// </summary>
		private static readonly string _nonexistentFile = 
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestData\NonexistentFile.txt";

		/// <summary>
		/// Удаляет файл с данными при запуске тестов
		/// </summary>
		[TearDown]
		public void DeleteFile()
		{
			if (File.Exists(_path))
			{
				File.Delete(_path);
			}
		}

		[Test(Description = "Чтение корректного файла")]
		public void TestReadProject_CorrectData()
		{
			ProjectManager.DefaultPath = _path;
			var expectedString = File.ReadAllText(_referencePath);
			var expected = JsonConvert.DeserializeObject<Project>(
				expectedString);
			if (File.Exists(_path))
			{
				File.Delete(_path);
			}
			File.Create(_path).Close();
			File.WriteAllText(_path, expectedString);
			if (File.Exists(_path))
			{
				var actual = ProjectManager.ReadProject();
				var actualString = File.ReadAllText(_path);
				Assert.AreEqual(expectedString, actualString,
					"Данные не совпадают");
			}
		}

		[Test(Description = "Чтение файла с некорретными данными")]
		public void TestReadProject_BrokenData()
		{
			Assert.Throws<JsonReaderException>(() =>
				{
					ProjectManager.DefaultPath = _referenceBrokenPath;
					var project = ProjectManager.ReadProject();
				},
				"Произошло чтение файла с некорректными данными");
		}

		[Test(Description = "Чтение несуществующего файла")]
		public void TestReadProject_NonexistentFile()
		{
			var expected = JsonConvert.SerializeObject(new Project());

			ProjectManager.DefaultPath = _nonexistentFile;
			var actual = JsonConvert.SerializeObject(
				ProjectManager.ReadProject());

			Assert.AreEqual(expected, actual,
				"Произошло чтение несуществующего файла");
		}

		[Test(Description = "Тест записи в файл")]
		public void TestSaveProject_WithCreatedFile()
		{

			ProjectManager.DefaultPath = _path;
			if (File.Exists(_path))
			{
				File.Delete(_path);
			}
			File.Create(_path).Close();
			var expectedString = File.ReadAllText(_referencePath);
			var expected = JsonConvert.DeserializeObject<Project>(
				expectedString);
			ProjectManager.SaveProject(expected);
			if (File.Exists(_path))
			{
				var actualString = File.ReadAllText(_path);
				var actual = JsonConvert.DeserializeObject<Project>(
				actualString);
				Assert.AreEqual(expectedString, actualString,
					"Данные не совпадают");
			}
		}

		[Test(Description = "Создание и запись в файл")]
		public void TestSaveProject_WithoutCreatedFile()
		{

			ProjectManager.DefaultPath = _path;
			if (File.Exists(_path))
			{
				File.Delete(_path);
			}
			var expectedString = File.ReadAllText(_referencePath);
			var expected = JsonConvert.DeserializeObject<Project>(
				expectedString);
			ProjectManager.SaveProject(expected);
			if (File.Exists(ProjectManager.DefaultPath))
			{
				var actualString = File.ReadAllText(
					ProjectManager.DefaultPath);
				var actual = JsonConvert.DeserializeObject<Project>(
				actualString);
				Assert.AreEqual(expectedString, actualString,
					"Данные не совпадают");
			}
		}
	}
}
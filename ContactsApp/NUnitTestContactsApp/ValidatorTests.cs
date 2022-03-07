using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using ContactsApp;
using NUnit.Framework.Internal;

namespace ContactsApp.UnitTests
{
	[TestFixture]
	public class ValidatorTests
	{
		[TestCase(1600, 1, 1, "Exception: дата не меньше 1900",
			TestName = "Год меньше 1900")]
		[TestCase(3000, 1, 1, "Exception: дата не больше сегодняшней")]
		public void TestBirthdayValidator_ArgumentException(int year,
			int month, int day, string message)
		{
			var date = new DateTime(year, month, day);
			Assert.Throws<ArgumentException>(() =>
			{
				ValueValidator.CheckDate(date);
			}, message);
		}

		[Test(Description = "Тест проверки корректной даты")]
		public void TestBirthdayValidator_CorrectlyValue()
		{
			var date = new DateTime(2000, 12, 12);
			Assert.DoesNotThrow(() =>
			{
                ValueValidator.CheckDate(date);
			}, "Проверка корретной даты выкинула исключение");
		}

		[TestCase("", 12, "Длина 0",
			TestName = "Тест проверки строки со нулевым количеством символом")]
		[TestCase("dasdfsdfsafdsfasdfasfadfadfa", 5,
			"Тест проверки сторки с количеством символов больше ограничения",
			TestName = "Больше максимального")]
		public void TestAssertStringLength_IncorrectValue(string name,
			int maxCount, string message)
		{
			Assert.Throws<ArgumentException>(() =>
			{
                ValueValidator.AssertStringLength(name,
					maxCount, null);
			}, message);
		}

		[Test(Description = "Тест проверки корретной строки")]
		public void TestAssertStringLength_CorrectlyValue()
		{
			Assert.DoesNotThrow(() =>
			{
                ValueValidator.AssertStringLength("mem",
					10, null);
			}, "Корретная строка вызвала исключение");
		}

		[Test(Description = "Тест возврата путой строки при проверке номера")]
		public void TestGetClearPhoneNumber_EmptyString()
		{
			var number = "adfasdasdfasdfasdf";

			var expected = "";

			var actual = ValueValidator.ClearPhoneNumber(number);

			Assert.AreEqual(expected, actual,
				"Строка не была пустой");
		}

		[Test(Description = "Тест возврата значения при проверке номера")]
		public void TestGetClearPhoneNumber_Number()
		{
			var number = "a8d800fa555s3d5a35sdfasdfasdf";

			var expected = "88005553535";

			var actual = ValueValidator.ClearPhoneNumber(number);

			Assert.AreEqual(expected, actual,
				"Значение некорретно");
		}

		[TestCase(88005553535, 11, "Начинается не с 7",
			TestName = "Номер, начинающийся не с 7")]
		[TestCase(792355865554, 11,
			"Большого значения номера",
			TestName = "Тест большого значения номера")]
		public void TestAssertPhoneNumber_IncorrectValue(long number,
			int maxCount, string message)
		{
			Assert.Throws<ArgumentException>(() =>
			{
                ValueValidator.CheckPhoneNumber(number,
					maxCount);
			}, message);
		}

		[Test(Description = "Тест корректного значения номера")]
		public void TestAssertPhoneNumber_CorrectlyValue()
		{
			Assert.DoesNotThrow(() =>
			{
                ValueValidator.CheckPhoneNumber(78005553535, 11);
			}, "Корретное значение номера вызвало исключение");
		}
	}
}
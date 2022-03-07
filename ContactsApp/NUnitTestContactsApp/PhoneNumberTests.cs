using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    [TestFixture]
	public class PhoneNumberTests
	{
		private PhoneNumber CreateClearPhoneNumber()
		{
			return new PhoneNumber(70000000000);
		}

		[Test(Description = "Позитивный тест геттера номера")]
		public void TestNumberGet_CorrectValue()
		{
			var expected = 78005553535;

			var phoneNumber = CreateClearPhoneNumber();
			phoneNumber.Number = expected;

			var actual = phoneNumber.Number;

			Assert.AreEqual(expected, actual, 
				"Позитивный тест геттера номера не пройден");
		}


		[Test(Description = "Позитивный тест сеттера номера")]
		public void TestNumberSet_CorrectValue()
		{
			var number = 78005553535;

			var phoneNumber = CreateClearPhoneNumber();
			Assert.DoesNotThrow(
				()=> { phoneNumber.Number = number; },
				"Позитивный тест сеттера номера не пройден");
		}

		[Test(Description = "Позитивный тест конструктора")]
		public void TestConstructorPhoneNumber_CorrectValue()
		{
			var number = 78005553535;
			Assert.DoesNotThrow(
				() => { var phoneNumber = new PhoneNumber(number); },
				"Позитивный тест конструктора не пройден");
		}
	}
}
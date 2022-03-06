using System;

namespace ContactsApp
{
	/// <summary>
	/// Реализует проверку значений
	/// </summary>
    public static class ValueValidator
    {
        public static void CheckDate(DateTime date)
        {
            if (date.Year < 1900)
            {
                throw new ArgumentException(
                    "Значение года должно быть больше 1900");
            }

            if (date > DateTime.Now)
            {
                throw new ArgumentException(
                    "Значение даты не должно превышать текущую дату");
            }
        }

		/// <summary>
		/// Выбрасывает иключение, если строка больше установленного размера
		/// </summary>
		public static void AssertStringLength(string checkedString,
			int maxLength, string name)
		{
			if (checkedString.Length > maxLength || checkedString.Length == 0)
			{
				throw new ArgumentException(name + " некорректно");
			}
		}

        /// <summary>
        /// Очищаетномер телефона от всех значений, кроме цифр
        /// </summary>
        /// <param name="phoneNumber">Исходный номер телефона</param>
        /// <returns>Очищенный номер телефона</returns>
        public static string ClearPhoneNumber(string phoneNumber)
        {
            string clearPhoneNumber = "";
            foreach (var i in phoneNumber)
            {
                if (i >= '0' && i <= '9')
                {
                    clearPhoneNumber += i;
                }
            }
            return clearPhoneNumber;
        }

		/// <summary>
		/// Проверяет номер телефона 
		/// </summary>
		/// <param name="number">Исходный номер телефона</param>
		/// <param name="correctLength">Корректная длина номера телефона</param>
		public static void CheckPhoneNumber(long number, int correctLength)
		{
			string numberString = number.ToString();

			if (numberString.Length != correctLength)
			{
				throw new ArgumentException(
                    $"Длина номера телефона " +
                    $"не должна превышать {correctLength} символов");
			}

			if (numberString[0] != '7')
			{
				throw new ArgumentException(
					"Первая цифра номера телефона должна быть 7");
			}
		}
    }
}

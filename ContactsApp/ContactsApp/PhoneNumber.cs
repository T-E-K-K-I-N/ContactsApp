using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс номера телефона
    /// </summary>
    public class PhoneNumber : IEquatable<PhoneNumber>
    {
        /// <summary>
        /// Значение максимальной длины номера телефона
        /// </summary>
        public const int MaxNumberLength = 11;

		/// <summary>
        /// Значение номера телефона
        /// </summary>
        private long _number;

        /// <summary>
        /// Устанавливает и возвращает номер телефона
        /// </summary>
        public long Number
        {
            get => _number;

            set
            {
                ValueValidator.CheckPhoneNumber(value, MaxNumberLength);
                _number = value;
            }
        }

        /// <summary>
        /// Создает объект номера телефона
        /// </summary>
        /// <param name="number">Значение номера телефона</param>
        public PhoneNumber(long number)
        {
            Number = number;
        }

        /// <summary>
        /// Сравнивает два объекта номера телефона
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(PhoneNumber other)
        {
	        if (ReferenceEquals(null, other)) return false;
	        if (ReferenceEquals(this, other)) return true;
	        return _number == other._number;
        }
    }
}
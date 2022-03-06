namespace ContactsApp
{
    /// <summary>
    /// Класс номера телефона
    /// </summary>
    public class PhoneNumber
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
	}
}
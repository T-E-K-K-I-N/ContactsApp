using ContactsApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class ContactForm : Form
    {
		/// <summary>
		/// Объект контакта
		/// </summary>
		public Contact Contact { set; get; }

		/// <summary>
		/// Объект старого значения контакта для восстановления при отмене изменения
		/// </summary>
		private Contact _oldContact = null;

		public ContactForm()
		{
			InitializeComponent();
		}

		private void ContactForm_Load(object sender, EventArgs e)
		{
			if (Contact != null)
			{
				SurnameTextBox.Text = Contact.Surname;
				NameTextBox.Text = Contact.Name;
				BirthdayDateTimePicker.Value = Contact.Birthday;
				PhoneMaskedTextBox.Text = Contact.PhoneNumber.Number.ToString();
				EmailTextBox.Text = Contact.Email;
				VkTextBox.Text = Contact.VkId;
				_oldContact = (Contact)Contact.Clone();
			}
		}

		private void OK_Click(object sender, EventArgs e)
		{
			try
			{
				var phoneNumber = new PhoneNumber(
					Convert.ToInt64(ValueValidator.ClearPhoneNumber(
						PhoneMaskedTextBox.Text)));
				Contact = new Contact(NameTextBox.Text,
					SurnameTextBox.Text, phoneNumber,
					BirthdayDateTimePicker.Value, EmailTextBox.Text,
					VkTextBox.Text);
				DialogResult = DialogResult.OK;
			}
			catch (ArgumentException exception)
			{
				MessageBox.Show("Некорректное значение: \n" +
					exception.Message, exception.Message, MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			Contact = _oldContact;
			DialogResult = DialogResult.Cancel;
		}

		private void SurnameTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
                ValueValidator.AssertStringLength(SurnameTextBox.Text,
					Contact.MaxNameLength, null);
				SurnameTextBox.BackColor = Color.White;
			}
			catch (ArgumentException)
			{
				SurnameTextBox.BackColor = Color.LightSalmon;
			}
		}

		private void NameTextBox_TextChanged(object sender, EventArgs e)
		{
            NameTextBox.BackColor = Color.White;
			try
			{
                ValueValidator.AssertStringLength(NameTextBox.Text,
					Contact.MaxNameLength, null);
				NameTextBox.BackColor = Color.White;
			}
			catch (ArgumentException)
			{
				NameTextBox.BackColor = Color.LightSalmon;
			}
		}

		private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			try
			{
                ValueValidator.CheckDate(BirthdayDateTimePicker.Value);
				BirthdayDateTimePicker.CalendarTitleBackColor = Color.White;
			}
			catch (ArgumentException)
			{
				BirthdayDateTimePicker.CalendarTitleBackColor = Color.LightSalmon;
			}
		}

		private void EmailTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
                ValueValidator.AssertStringLength(EmailTextBox.Text,
					Contact.MaxEmailLength, null);
				EmailTextBox.BackColor = Color.White;
			}
			catch (ArgumentException)
			{
				EmailTextBox.BackColor = Color.LightSalmon;
			}
		}

		private void VkTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
                ValueValidator.AssertStringLength(VkTextBox.Text,
					Contact.MaxVkLength, null);
				VkTextBox.BackColor = Color.White;
			}
			catch (ArgumentException)
			{
				VkTextBox.BackColor = Color.LightSalmon;
			}
		}

        private void PhoneMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTextBox.BackColor = Color.White;
            try
            {
                ValueValidator.CheckPhoneNumber(Convert.ToInt64(
                        ValueValidator.ClearPhoneNumber(
                            PhoneMaskedTextBox.Text)),
                    PhoneNumber.MaxNumberLength);
                PhoneMaskedTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                PhoneMaskedTextBox.BackColor = Color.LightSalmon;
            }
		}
    }
}

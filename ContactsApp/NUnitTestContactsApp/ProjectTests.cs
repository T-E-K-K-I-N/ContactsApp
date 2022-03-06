using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectTests
    {
        [Test(Description = "Позитивный тест сеттера списка контактов")]
        public void TestContactsSet_CurrentValue()
        {
            Project project = new Project();
            var testList = new List<Contact>();

            Assert.DoesNotThrow(
                () => { project.Contacts = testList; },
                "Позитивный тест сеттера списка контактов не пройден");
        }

        [Test(Description = "Тест сортировки списка контактов")]
        public void TestSort_CorrectValue()
        {
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact("C", "C",
                    new PhoneNumber(70000000000),
                    new DateTime(2000, 12, 12),
                    "C", "C"),
                new Contact("B", "B",
                    new PhoneNumber(70000000000),
                    new DateTime(2010, 12, 12),
                    "B", "B"),
                new Contact("A", "A",
                    new PhoneNumber(70000000000),
                    new DateTime(2001, 12, 12),
                    "A", "A")
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact("A", "A",
                    new PhoneNumber(70000000000),
                    new DateTime(2001, 12, 12),
                    "A", "A"),
                new Contact("B", "B",
                    new PhoneNumber(70000000000),
                    new DateTime(2010, 12, 12),
                    "B", "B"),
                new Contact("C", "C",
                    new PhoneNumber(70000000000),
                    new DateTime(2000, 12, 12),
                    "C", "C")
            };

            var actual = new Project();
            actual.Contacts = project.SearchContacts();

            Assert.AreEqual(expected.Contacts[0].Surname,
                actual.Contacts[0].Surname, "Данные не отсортированы");
        }

        [Test(Description = "Сортировка списка контактов без данных")]
        public void TestSort_WithoutValues()
        {
            var project = new Project();

            var excepted = new List<Contact>();

            var actual = project.SearchContacts();

            Assert.AreEqual(excepted, actual,
                "Список не должен содержать данных");
        }

        [Test(Description = "Тест поиска дня рождения")]
        public void TestFindBirthday_HasContacts()
        {
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact("C", "C",
                    new PhoneNumber(70000000000),
                    new DateTime(2000, 12, 21),
                    "C", "C"),
                new Contact("B", "B",
                    new PhoneNumber(70000000000),
                    new DateTime(2010, 12, 12),
                    "B", "B"),
                new Contact("A", "A",
                    new PhoneNumber(70000000000),
                    new DateTime(2001, 12, 31),
                    "A", "A")
            };

            var expected = new List<Contact>()
            {
                new Contact("A", "A",
                    new PhoneNumber(70000000000),
                    new DateTime(2001, 12, 31),
                    "A", "A")
            };

            var actual = project.FindBirthdayContacts(
                new DateTime(1900, 12, 31));

            Assert.AreEqual(expected[0].Surname,
                actual[0].Surname, "Контакты по дню рождению не найдены");
        }

        [Test(Description = "Поиск контактов по дню рождения")]
        public void TestFindBirthday_HasNotContacts()
        {
            var project = new Project();
            project.Contacts = new List<Contact>();

            var expected = new List<Contact>();

            var actual = project.FindBirthdayContacts(
                new DateTime(1900, 12, 31));

            Assert.AreEqual(expected,
                actual, "Контаткы по дню рождению не должны быть найдены");
        }
    }
}
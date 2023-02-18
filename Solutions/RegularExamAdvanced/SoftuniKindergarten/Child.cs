using System;

namespace SoftUniKindergarten
{
    public class Child
    {
        private string firstName;
        private string lastName;
        private int age;
        private string parentName;
        private string contactNumber;
        
        public Child(string firstName, string lastName, int age, string parentName, string contactNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.parentName = parentName;
            this.contactNumber = contactNumber;
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName;} set { lastName = value; } }
        public int Age { get { return age;} set { age = value; } }
        public string ParentName { get { return parentName;} set { parentName = value; } }
        public string ContactNumber { get { return contactNumber; } set { contactNumber = value; } }

        public override string ToString()
        {
            return $"Child: {firstName} {lastName}, Age: {age}, Contact info: {parentName} - {contactNumber}";
        }
    }
}

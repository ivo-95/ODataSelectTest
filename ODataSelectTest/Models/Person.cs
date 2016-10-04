namespace ODataSelectTest.Models
{
    public enum Gender { Male, Female };

    public abstract class Person
    {
        protected Gender _gender;

        public Gender Gender { get
            {
                return _gender;
            }
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
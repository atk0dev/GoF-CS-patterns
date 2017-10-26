using System;

namespace PersonRepository.Interface
{
    public class Person
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual int Rating { get; set; }
    }
}

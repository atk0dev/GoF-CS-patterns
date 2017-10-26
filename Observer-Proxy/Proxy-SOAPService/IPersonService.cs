using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace People.Service
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        List<Person> GetPeople();
    }

    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime StartDate;
        public int Rating;
    }
}

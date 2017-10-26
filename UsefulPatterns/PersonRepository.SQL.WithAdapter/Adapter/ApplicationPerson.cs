using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRepository.SQL.Adapter
{
    class ApplicationPerson : Person
    {
        private DataPerson _dataPerson;

        public ApplicationPerson(DataPerson dataPerson)
        {
            _dataPerson = dataPerson;
        }

        public override string FirstName
        {
            get
            {
                return _dataPerson.FirstName;
            }
        }

        public override string LastName
        {
            get
            {
                return _dataPerson.LastName;
            }
        }

        public override DateTime StartDate
        {
            get
            {
                if (_dataPerson.StartDate.HasValue)
                    return _dataPerson.StartDate.Value;
                else
                    return DateTime.MinValue;
            }
        }

        public override int Rating
        {
            get
            {
                if (_dataPerson.Rating.HasValue)
                    return _dataPerson.Rating.Value;
                else
                    return int.MinValue;
            }
        }
    }
}

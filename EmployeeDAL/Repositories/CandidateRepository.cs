using EmployeeDAL.Interfaces;
using EmployeeDAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDAL.Repositories
{
    public class CandidateRepository: ICandidateRepository
    {
        private readonly EmployeeContext db = new EmployeeContext();

        /// <summary>
        /// Get all candidates from db
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Candidate> GetAll()
        {
            IEnumerable<Candidate> candidates = db.Candidates;
            foreach (Candidate candidate in candidates)
            {
                int personID = candidate.FK_PersonID;
                Person person = db.Persons.FirstOrDefault(pers => pers.PersonID == personID);
                candidate.Person = person;
            }

            return candidates;
        }

    }
}

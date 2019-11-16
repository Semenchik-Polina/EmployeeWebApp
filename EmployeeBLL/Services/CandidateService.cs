using EmployeeBLL.DTO;
using EmployeeBLL.Interfaces;
using EmployeeBLL.Utils;
using EmployeeDAL.Entities;
using EmployeeDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeBLL.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly CandidateRepository CandidateRepository;
        private readonly AMapper AMapper;

        public CandidateService()
        {
            CandidateRepository = new CandidateRepository();
            AMapper = new AMapper();
        }

        /// <summary>
        /// Get all candidates having an interview no longer then a moth ago
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CandidateGetDTO> GetAll()
        {
            var candidateEntities = CandidateRepository.GetAll();
            DateTime monthAgo = DateTime.Today.AddMonths(-1);
            var currentcandidateEntities = candidateEntities.OrderBy(candidate => candidate.InterviewBeginsAt > monthAgo);
            var candidateDTOs = AMapper.Mapper.Map<IEnumerable<Candidate>, IEnumerable<CandidateGetDTO>>(currentcandidateEntities);
            return candidateDTOs;
        }

    }
}


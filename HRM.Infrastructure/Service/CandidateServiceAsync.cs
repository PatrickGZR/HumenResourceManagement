using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Contract.Service;
using HRM.ApplicationCore.Entity;
using HRM.ApplicationCore.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Infrastructure.Service
{
    public class CandidateServiceAsync : ICandidateServiceAsync
    {
        private readonly ICandidateRepositoryAsync candidateRepositoryAsync;

        public CandidateServiceAsync(ICandidateRepositoryAsync _candidateRepositoryAsync)
        {
            candidateRepositoryAsync = _candidateRepositoryAsync;
        }
        public async Task<int> AddCandidateAsync(CandidateRequestModel model)
        {
            Candidate candidate = new Candidate()
            {
                FirstName= model.FirstName,
                LastName= model.LastName,
                EmailId= model.EmailId,
                Mobile= model.Phone,

            };
            return await candidateRepositoryAsync.InsertAsync(candidate);
        }

        public Task<int> DeleteCandidateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CandidateRequestModel> GetCandidateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CandidateRequestModel>> GetCandidatesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateCandidateAsync(CandidateRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}

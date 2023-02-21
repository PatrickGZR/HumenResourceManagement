using HRM.ApllicationCore.Model.Request;
using HRM.ApllicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApllicationCore.Service
{
    public interface ISubmissionServiceAsync
    {
        Task<int> AddSubmissiontAsync(SubmissionRequestModel model);
        Task<int> UpdateSubmissionAsync(SubmissionRequestModel model);
        Task<int> DeleteSubmissionAsync(int id);
        Task<SubmissionResponseModel> GetSubmissionByIdAsync(int id);
        Task<IEnumerable<SubmissionResponseModel>> GetAllSubmissionsAsync();

    }
}

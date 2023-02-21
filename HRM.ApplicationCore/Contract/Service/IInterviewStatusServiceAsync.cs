using HRM.ApllicationCore.Model.Request;
using HRM.ApllicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApllicationCore.Service
{
    public interface IInterviewStatusServiceAsync
    {
        Task<int> AddInterviewStatusAsync(InterviewStatusRequestModel model);
        Task<int> UpdateInterviewStatusAsync(InterviewStatusRequestModel model);
        Task<int> DeleteInterviewStatusAsync(int id);
        Task<InterviewStatusResponseModel> GetInterviewStatusByIdAsync(int id);
        Task<IEnumerable<InterviewStatusResponseModel>> GetAllInterviewStatusAsync();

    }
}

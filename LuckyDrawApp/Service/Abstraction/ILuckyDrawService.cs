using LuckyDrawApp.Service.Model.Request;
using LuckyDrawApp.Service.Model.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LuckyDrawApp.Service.Abstraction
{
    public interface ILuckyDrawService
    {
        Task<LuckyDrawResponse> SaveLuckyDraw(SaveRequest request);
        Task<bool> UpdateLuckyDraw(UpdateRequest request, string Server);
        Task<List<LuckyDrawResponse>> GetYearLuckyDraw(GetListYearRequest request);
        Task<LuckyDrawResponse> GetLuckyDraw(int ID);
        Task<bool> DeleteLuckyDraw(DeleteLuckyDraw Ids);
        Task<int> SaveLuckyDrawPrize(int ID, string Name, string Value, string Quantity, string ImageUrl, string Server, string CreatedBy);
        Task<bool> DeleteDetailPrize(string Server, int ID);
        Task<bool> SaveDataLuckyDrawData(List<LuckyDrawDataRequest> List, string Server, string MaNV);
        Task<List<LuckyDrawResultResponse>> GetWinnerLuckyDraw(int ID);
        Task<bool> ActiveLuckyDrawPrize(string Server, int ID, int LuckyDrawID);
        Task<LuckyDrawPrizeResponse> GetLuckyDrawPrize(int LuckyDrawID, string Server);

    }
}

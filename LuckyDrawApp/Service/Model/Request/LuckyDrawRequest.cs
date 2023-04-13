using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyDrawApp.Service.Model.Request
{
    public class SaveRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DrawMonth { get; set; }
        public string DrawYear { get; set; }
        public string BackgroundImgUrl { get; set; }
        public string CreatedBy { get; set; }
        public List<LuckyDrawPrizeRequest> LuckyDrawPrizes { get; set; } = null;
    }
    public class UpdateRequest : SaveRequest
    {
        public int Id { get; set; }
        public string UpdateBy { get; set; }
    }
    public class LuckyDrawPrizeRequest
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int Quantity { get; set; }
        public string ImageUri { get; set; }
    }
    public class GetListMonthRequest
    {
        public string Month { get; set; }
        public string Year { get; set; }
    }
    public class GetListYearRequest
    {
        public string Year { get; set; }
    }
    public class DeleteLuckyDraw
    {
        public List<int> Ids { get; set; }
    }

    public class LuckyDrawDataRequest
    {
        public string Data { get; set; }
        public string AgentId { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string CreatedBy { get; set; }
        public int LuckyDrawId { get; set; }
        public Boolean Deleted { get; set; }
        public string Note { get; set; }
    }
}

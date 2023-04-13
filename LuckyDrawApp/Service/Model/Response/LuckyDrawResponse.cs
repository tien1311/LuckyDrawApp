using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyDrawApp.Service.Model.Response
{
    public class LuckyDrawResponse
    {
        public int Id { get; set; } = 0;
        public int CountNumber { get; set; } = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public string DrawMonth { get; set; }
        public string DrawYear { get; set; }
        public string BackgroundImgUrl { get; set; }
        public DateTime CreatedUTC { get; set; } 
        public string CreatedBy { get; set; } = null;
        public DateTime UpdatedUTC { get; set; } 
        public string UpdatedBy { get; set; } = null;
        public Boolean Locked { get; set; }
        public List<LuckyDrawPrizeResponse> LuckyDrawPrizes { get; set; }
        public List<LuckyDrawResultResponse> LuckyDrawResults { get; set; } = null;
    }
    public class LuckyDrawPrizeResponse
    {
        public int Id { get; set; }
        public int LuckyDrawId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Quantity { get; set; }
        public string ImgUri { get; set; }
        public DateTime CreatedUTC { get; set; }
        public string CreatedBy { get; set; }
    }
    public class LuckyDrawDataResponse
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string AgentId { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public DateTime CreatedDate { get; set; }
        public Boolean Deleted { get; set; }
    }
    public class LuckyDrawResultResponse
    {
        public int id { get; set; }
        public LuckyDrawDataResponse LuckyDrawData { get; set; }
        public LuckyDrawPrizeResponse LuckyDrawPrize { get; set; }
        public LuckyDrawResponse LuckyDraw { get; set; }
        public int LuckyDrawId { get; set; }
        public int luckyDrawPrizeId { get; set; }
        public int LuckyDrawDataId { get; set; }
        public string AgentId { get; set; }
        public string AgentName { get; set; }
        public string DrawData { get; set; }
        public DateTime CreateUtc { get; set; }
    }
   
}

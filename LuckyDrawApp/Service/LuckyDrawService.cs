using Dapper;
using LuckyDrawApp.Service.Abstraction;
using LuckyDrawApp.Service.Model.Request;
using LuckyDrawApp.Service.Model.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace LuckyDrawApp.Service
{
    public class LuckyDrawService : ILuckyDrawService
    {
        public IHttpClientFactory _httpClientFactory;
        public LuckyDrawService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<LuckyDrawResponse> SaveLuckyDraw(SaveRequest request)
        {
            var httpClient = _httpClientFactory.CreateClient("luckydraw-service");
            string jsonContent = JsonConvert.SerializeObject(request);
            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("luckydraw", content);
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<LuckyDrawResponse>(responseContent);
        }

        public async Task<bool> UpdateLuckyDraw(UpdateRequest request, string Server)
        {
            bool result = false;
            int result_sql = 0;
            string sql = "";
            if (request.BackgroundImgUrl != "" && request.BackgroundImgUrl != null)
            {
                sql = @"update LuckyDraw set Name = N'" + request.Name + "', Description = N'" + request.Description + "', DrawMonth = '" + request.DrawMonth + "', DrawYear = '" + request.DrawYear + "', BackgroundImgUrl = '" + request.BackgroundImgUrl + "', UpdatedBy = '" + request.UpdateBy + "',UpdatedUtc=GetDate() where Id=" + request.Id;
            }    
            else
            {
                sql = @"update LuckyDraw set Name = N'" + request.Name + "', Description = N'" + request.Description + "', DrawMonth = '" + request.DrawMonth + "', DrawYear = '" + request.DrawYear + "', UpdatedBy = '" + request.UpdateBy + "',UpdatedUtc=GetDate() where Id=" + request.Id;
            }    
            using (var conn = new SqlConnection(Server))
            {
                result_sql = await conn.ExecuteAsync(sql, null, null, commandType: System.Data.CommandType.Text, commandTimeout: 30);
                conn.Dispose();
            }
            if (result_sql > 0)
            {
                result = true;
            }
            return result;

            //var httpClient = _httpClientFactory.CreateClient("luckydraw-service");
            //string jsonContent = JsonConvert.SerializeObject(request);
            //HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            //var response = await httpClient.PostAsync("luckydraw", content);
            //var responseContent = await response.Content.ReadAsStringAsync();
            //return JsonConvert.DeserializeObject<LuckyDrawResponse>(responseContent);
        }

        public async Task<List<LuckyDrawResponse>> GetYearLuckyDraw(GetListYearRequest request)
        {
            var httpClient = _httpClientFactory.CreateClient("luckydraw-service");
            string jsonContent = JsonConvert.SerializeObject(request);
            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("luckydraw/list", content);
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<LuckyDrawResponse>>(responseContent);
        }

        public async Task<LuckyDrawResponse> GetLuckyDraw(int ID)
        {
            var httpClient = _httpClientFactory.CreateClient("luckydraw-service");
            string jsonContent = JsonConvert.SerializeObject("");
            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await httpClient.GetAsync("luckydraw/" + ID);
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<LuckyDrawResponse>(responseContent);
        }

        public async Task<bool> DeleteLuckyDraw(DeleteLuckyDraw Ids)
        {
            var httpClient = _httpClientFactory.CreateClient("luckydraw-service");
            string jsonContent = JsonConvert.SerializeObject(Ids);
            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(httpClient.BaseAddress + "luckydraw"),
                    Content = content
                };
                request.Headers.Add("x-functions-key", "nHQesVUD5bA/pgSa7/PvF6neTvGdxiROTetNeEh6Stt4mgqZPhj15g==");
                var response = await client.SendAsync(request);
                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<bool>(responseContent);
            }
        }

        public async Task<int> SaveLuckyDrawPrize(int ID, string Name, string Value, string Quantity, string ImageUrl, string Server, string CreatedBy)
        {
            int result = 0;
            string sql = @"insert into LuckyDrawPrize(LuckyDrawId, Name, Value, Quantity, CreatedBy, CreatedUtc, UpdatedUtc, Deleted, ImgUri) values(" + ID+",N'"+Name+ "',N'" + Value + "','" + Quantity + "','" + CreatedBy + "','" + DateTime.Now + "','" + DateTime.Now + "',0,'" + ImageUrl + "')SELECT SCOPE_IDENTITY()";
            using (var conn = new SqlConnection(Server))
            {
                result = await conn.QueryFirstAsync<int>(sql, null, null, commandType: System.Data.CommandType.Text, commandTimeout: 30);
                conn.Dispose();
            }
            return result;
        }

        public async Task<bool> DeleteDetailPrize(string Server, int ID)
        {
            bool result = false;
            int result_sql = 0; 
            string sql = @"Delete LuckyDrawPrize where Id = " + ID;
            using (var conn = new SqlConnection(Server))
            {
                result_sql = await conn.ExecuteAsync(sql, null, null, commandType: System.Data.CommandType.Text, commandTimeout: 30);
                conn.Dispose();
            }
            if (result_sql > 0)
            {
                result = true;
            }
            return result;
        }

        public async Task<bool> SaveDataLuckyDrawData(List<LuckyDrawDataRequest> List, string Server, string MaNV)
        {
            int result = 0, dem = 0;
            string SqlInsert = "";
            for (int i = 0; i < List.Count; i++)
            {
                SqlInsert += @"INSERT INTO LuckyDrawData (Data, AgentId, Month, Year, CreatedBy, CreatedUtc, Deleted, LuckyDrawId, Note) VALUES ('" + List[i].Data + "','" + List[i].AgentId + "', '" + List[i].Month + "',  '" + List[i].Year + "',  '" + MaNV + "', '" + DateTime.Now + "',0, '" + List[i].LuckyDrawId + "',N'" + List[i].Note + "')";
                dem++;
                if (dem == 80)
                {
                    using (var conn = new SqlConnection(Server))
                    {
                        result = await conn.ExecuteAsync(SqlInsert, null, null, commandType: System.Data.CommandType.Text, commandTimeout: 30);
                        conn.Dispose();
                    }
                    SqlInsert = "";
                    dem = 0;
                }
            }
            if (dem > 0)
            {
                using (var conn = new SqlConnection(Server))
                {
                    result = await conn.ExecuteAsync(SqlInsert, null, null, commandType: System.Data.CommandType.Text, commandTimeout: 30);
                    conn.Dispose();
                }
            }

            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<List<LuckyDrawResultResponse>> GetWinnerLuckyDraw(int ID)
        {
            var httpClient = _httpClientFactory.CreateClient("luckydraw-service");
            string jsonContent = JsonConvert.SerializeObject("");
            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await httpClient.GetAsync(string.Format("luckydraw/{0}/winner/list", ID));
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<LuckyDrawResultResponse>>(responseContent);
        }

        public async Task<bool> ActiveLuckyDrawPrize(string Server, int ID, int LuckyDrawID)
        {
            bool result = false;
            int result_sql = 0;
            string sql = @"Update LuckyDrawPrize set IsActive = 0  where LuckyDrawID = " + LuckyDrawID;
            sql += @"Update LuckyDrawPrize set IsActive = 1  where ID = " + ID;
            using (var conn = new SqlConnection(Server))
            {
                result_sql = await conn.ExecuteAsync(sql, null, null, commandType: System.Data.CommandType.Text, commandTimeout: 30);
                conn.Dispose();
            }
            if(result_sql > 0)
            {
                result = true;
            }    
            return result;
        }

        public async Task<LuckyDrawPrizeResponse> GetLuckyDrawPrize(int LuckyDrawID, string Server)
        {
            LuckyDrawPrizeResponse result = new LuckyDrawPrizeResponse();
            string sql = @"select * from LuckyDrawPrize where isnull(IsActive,0) = 1 and LuckyDrawId = " + LuckyDrawID;
            using (var conn = new SqlConnection(Server))
            {
                result = await conn.QueryFirstAsync<LuckyDrawPrizeResponse>(sql, null, commandType: System.Data.CommandType.Text, commandTimeout: 30);
                conn.Dispose();
            }
            return result;
        }
    }
}

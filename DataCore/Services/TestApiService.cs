using AutoMapper;
using CPC.DBCore;
using DataCore.DTOs;
using DataCore.Models;
using StudyExtend.RequestProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi = DataCore.Models.TestApi;

namespace DataCore.Services
{
    public static class TestApiService 
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public static async Task<List<TestApiDTO>> GetTestApis()
        {
            Remote remote = new Remote();
            //var res =await  remote.requestProvider.GetAsync<List<TestApi>>(Remote.Address+"TestApi/GetTestApis");
            var res = await remote.requestProvider.GetAsync<List<TestApiDTO>>(Remote.Address + "TestApi/GetTestApis");
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<List<TestApi>, List<TestApiDTO>>());
            //var mapper = config.CreateMapper();
            //var orderDto = mapper.Map<List<TestApi>>(res);
            //var data = await res.Result;
            return res;
        }
        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="testApi"></param>
        /// <returns></returns>
        public static TestApi UpdateTestApi(TestApi testApi)
        {
            Remote remote = new Remote();
            var res = remote.requestProvider.PutAsync<TestApi>(Remote.Address + "TestApi/UpdateTestApis", testApi);
            var data = res.Result;
            return data;
        }
    }
    public class Remote
    {
        public static string Address { get; set; } = "http://localhost:3003/";
        public RequestProvider requestProvider { get; set; }
        public Remote()
        {
            requestProvider = new RequestProvider();
            if (requestProvider != null)
            {

            }
            else
            {
                
            }
        }
    }
}

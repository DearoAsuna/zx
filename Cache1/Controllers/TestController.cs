using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
namespace Cache1.Controllers;

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMemoryCache memoryCache;
        private readonly ILogger<TestController> logger;
        public TestController(IMemoryCache memoryCache, ILogger<TestController> logger)
        {
            this.memoryCache= memoryCache;
            this.logger= logger;
        }

        [HttpGet]
        public async Task<ActionResult<Book>> Get(int id)
        {
            /*var 
                bid = MyDbcontext.GetByid(id);
            if (bid == null)
            {
                return NotFound("找不到");
            }
            return Ok(bid);*/ 
            logger.LogInformation($"开始 id={id}");
         var i= await  memoryCache.GetOrCreateAsync
         ("book" + id, async (e) 
             =>
         {
             #region 缓存

             /*e.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(5);*///绝对
             /*e.SlidingExpiration=TimeSpan.FromSeconds(5);*///滑动
             /*e.SlidingExpiration=TimeSpan.FromSeconds(2);
          e.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(5);*///绝对+滑动
             /*logger.LogInformation($"缓存没有 id={id}");
             return await MyDbcontext.GetBookAync(id);*/
             #endregion

             #region 缓存穿透

             e.AbsoluteExpirationRelativeToNow=TimeSpan.FromSeconds(Random.Shared.Next(5,10));
             var i =await MyDbcontext.GetBookAync(id);
             logger.LogInformation("数据库的结果是"+(i==null?"null":"不为null"));
             return i;

             #endregion

            
         });
         logger.LogInformation($"结果 {i}");
        if (i==null)
        {
            return NotFound("没找到");
        }
        
        return i;
        }

        [HttpGet]
        public void Add(int id)
        {
            memoryCache.Remove("book" + id);
        }
    }
  


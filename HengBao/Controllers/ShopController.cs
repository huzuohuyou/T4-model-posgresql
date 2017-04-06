  
/* ****************************************************************************************
 * 版权所有：吴海龙
 * 用    途：控制器
 * 结构组成：
 * 作    者：吴海龙
 * 创建日期：2017-04-06 17:32:08 
 * 历史记录：
 * ****************************************************************************************
 * 修改人员：             
 * 修改日期：
 * 修改说明：
 * ****************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using HengBao.Controllers;
namespace xiaoheng.pos.Model
{
   
    /// <summary>
    /// shopController
    /// </summary>
    public class ShopController: ApiController
    {
        #region 方法
   
		/// <summary>
		/// 查询全部实体Shop
		/// </summary>
		[HttpGet]
        public Response GetAll(){
			return new Response();
		}

		/// <summary>
		/// 通过id查询实体Shop
		/// </summary>
		[HttpGet]
        public Response GetById(int id){
			return new Response();
		}

		/// <summary>
		/// 更新实体实体Shop
		/// </summary>
		[HttpPost]
        public Response Update(Shop shop){
			return new Response();
		}

		/// <summary>
		/// 新增实体Shop
		/// </summary>
		[HttpPut]
        public Response Add(Shop shop){
			return new Response();
		}

		/// <summary>
		/// 删除实体Shop
		/// </summary>
		[HttpDelete]
        public Response DeleteById(int id){
			return new Response();
		}

    
    #endregion
    }
}



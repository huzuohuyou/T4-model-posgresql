  
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
    /// productController
    /// </summary>
    public class ProductController: ApiController
    {
        #region 方法
   
		/// <summary>
		/// 查询全部实体Product
		/// </summary>
		[HttpGet]
        public Response GetAll(){
			return new Response();
		}

		/// <summary>
		/// 通过id查询实体Product
		/// </summary>
		[HttpGet]
        public Response GetById(int id){
			return new Response();
		}

		/// <summary>
		/// 更新实体实体Product
		/// </summary>
		[HttpPost]
        public Response Update(Product product){
			return new Response();
		}

		/// <summary>
		/// 新增实体Product
		/// </summary>
		[HttpPut]
        public Response Add(Product product){
			return new Response();
		}

		/// <summary>
		/// 删除实体Product
		/// </summary>
		[HttpDelete]
        public Response DeleteById(int id){
			return new Response();
		}

    
    #endregion
    }
}



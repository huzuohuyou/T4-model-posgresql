  
/* ****************************************************************************************
 * 版权所有：吴海龙
 * 用    途：数据传输对象(DTO)
 * 结构组成：
 * 作    者：吴海龙
 * 创建日期：2017-03-31 15:16:25 
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

namespace xiaoheng.pos.Model
{
   
    /// <summary>
    /// product
    /// </summary>
    public class Product
    {
        #region 属性
    	/// <summary>
		/// name：row["field"].ToString()
		/// type：row["type"].ToString()
		/// </summary>
        public string Name { get; set; }
    	/// <summary>
		/// name：row["field"].ToString()
		/// type：row["type"].ToString()
		/// </summary>
        public decimal Price { get; set; }
    	/// <summary>
		/// name：row["field"].ToString()
		/// type：row["type"].ToString()
		/// </summary>
        public bool Status { get; set; }
    	/// <summary>
		/// name：row["field"].ToString()
		/// type：row["type"].ToString()
		/// </summary>
        public string Url { get; set; }
    	/// <summary>
		/// name：row["field"].ToString()
		/// type：row["type"].ToString()
		/// </summary>
        public string Kind { get; set; }
    	/// <summary>
		/// name：row["field"].ToString()
		/// type：row["type"].ToString()
		/// </summary>
        public int Shopid { get; set; }
        #endregion
    }
}



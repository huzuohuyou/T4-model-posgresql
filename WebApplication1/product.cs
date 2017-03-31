  
/* ****************************************************************************************
 * 版权所有：吴海龙
 * 用    途：数据传输对象(DTO)
 * 结构组成：
 * 作    者：吴海龙
 * 创建日期：2017-03-31 13:43:57 
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
    [Serializable]
    /// <summary>
    /// product
    /// </summary>
    public class product
    {
        #region 属性
    	/// <summary>
        /// name
		/// varchar
        /// </summary>
        public string Name {get;set;}
    	/// <summary>
        /// price
		/// numeric
        /// </summary>
        public decimal Price {get;set;}
    	/// <summary>
        /// status
		/// bool
        /// </summary>
        public bool Status {get;set;}
    	/// <summary>
        /// url
		/// varchar
        /// </summary>
        public string Url {get;set;}
    	/// <summary>
        /// kind
		/// varchar
        /// </summary>
        public string Kind {get;set;}
    	/// <summary>
        /// shopid
		/// int4
        /// </summary>
        public int Shopid {get;set;}
        #endregion
    }
}



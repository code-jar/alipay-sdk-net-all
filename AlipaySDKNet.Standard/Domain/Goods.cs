using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Goods Data Structure.
    /// </summary>
    [Serializable]
    public class Goods : AopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("goods_num")]
        public string GoodsNum { get; set; }

        /// <summary>
        /// 商品图片（图片上传返回id）
        /// </summary>
        [XmlElement("goods_pic_url")]
        public string GoodsPicUrl { get; set; }

        /// <summary>
        /// 商品单价，单位为元，精确到小数点后两位，取值范围为 [0.01,100000000]
        /// </summary>
        [XmlElement("goods_price")]
        public string GoodsPrice { get; set; }

        /// <summary>
        /// 商品规格份、件、斤、kg，默认为份
        /// </summary>
        [XmlElement("goods_specs")]
        public string GoodsSpecs { get; set; }
    }
}

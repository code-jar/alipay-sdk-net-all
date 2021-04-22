using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicTicketInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicTicketInfo : AopObject
    {
        /// <summary>
        /// 自动检票时间
        /// </summary>
        [XmlElement("auto_check_time")]
        public string AutoCheckTime { get; set; }

        /// <summary>
        /// 检票时间
        /// </summary>
        [XmlElement("check_time")]
        public string CheckTime { get; set; }

        /// <summary>
        /// 完结时间
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// IDENTITY_CARD("IDENTITY_CARD_ONLY", "凭身份证入园"), QR_CODE("QR_CODE_ONLY", "凭二维码入园"), IDENTITY_CARD_AND_QR_CODE("IDENTITY_CARD_AND_QR_CODE", "凭二维码或身份证入园");
        /// </summary>
        [XmlElement("enter_way")]
        public string EnterWay { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("scenic_ext_info")]
        public List<ScenicExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 具体不可用的日期
        /// </summary>
        [XmlArray("invalid_dates")]
        [XmlArrayItem("date")]
        public List<string> InvalidDates { get; set; }

        /// <summary>
        /// 表示一周内什么时间不可用。示例中表示周六、周日不可用。
        /// </summary>
        [XmlElement("invalid_day_in_week")]
        public string InvalidDayInWeek { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 门票单价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 门票状态 INIT("INIT","初始化") TICKET_RUNNING("TICKET_RUNNING",出票中) TICKET_SUCCESS(TICKET_SUCCESS,出票成功) TICKET_FAILURE("TICKET_FAILURE",出票失败) TO_USE("TO_USE",待核销) USED("USED",已核销) CLOSED("CLOSED",已完结) REFUND_RUNNING("REFUND_RUNNING",待退票) REFUND_SUCCESS("REFUND_SUCCESS",已退票) REFUND_FAILURE("REFUND_FAILURE",退票失败)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 票据数量，若一个实例表示一个门票，ticket_count = 1, 若为聚合门票, ticket_count = n;
        /// </summary>
        [XmlElement("ticket_count")]
        public long TicketCount { get; set; }

        /// <summary>
        /// 更新商品信息时候返回的商品id
        /// </summary>
        [XmlElement("ticket_goods_id")]
        public string TicketGoodsId { get; set; }

        /// <summary>
        /// 票据小程序链接
        /// </summary>
        [XmlElement("ticket_link")]
        public string TicketLink { get; set; }

        /// <summary>
        /// 门票名称
        /// </summary>
        [XmlElement("ticket_name")]
        public string TicketName { get; set; }

        /// <summary>
        /// 单据号
        /// </summary>
        [XmlElement("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 门票规格 成人票、全价票
        /// </summary>
        [XmlElement("ticket_specs")]
        public string TicketSpecs { get; set; }

        /// <summary>
        /// 门票类型 NORMAL("NORMAL","普通"), GROUP("GROUP","套票"), PERIOD("PERIOD","时段票"), REGION("REGION","区域票")
        /// </summary>
        [XmlElement("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 票凭证code
        /// </summary>
        [XmlElement("ticket_use_code")]
        public string TicketUseCode { get; set; }

        /// <summary>
        /// 购票二维码图片
        /// </summary>
        [XmlElement("ticket_use_pic")]
        public string TicketUsePic { get; set; }

        /// <summary>
        /// 使用结束日期
        /// </summary>
        [XmlElement("use_end_date")]
        public string UseEndDate { get; set; }

        /// <summary>
        /// 入园结束时间
        /// </summary>
        [XmlElement("use_end_time")]
        public string UseEndTime { get; set; }

        /// <summary>
        /// 使用开始日期
        /// </summary>
        [XmlElement("use_start_date")]
        public string UseStartDate { get; set; }

        /// <summary>
        /// 入园开始时间
        /// </summary>
        [XmlElement("use_start_time")]
        public string UseStartTime { get; set; }
    }
}

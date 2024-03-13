using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphonePayinadvanceCancelResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphonePayinadvanceCancelResponse : AopResponse
    {
        /// <summary>
        /// 提前结清支付宝订单号
        /// </summary>
        [XmlElement("alipay_biz_no")]
        public string AlipayBizNo { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝主单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 当期外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 提前结清金额，单位元
        /// </summary>
        [XmlElement("pay_in_advance_amount")]
        public string PayInAdvanceAmount { get; set; }

        /// <summary>
        /// 提前结清状态
        /// </summary>
        [XmlElement("pay_in_advance_status")]
        public string PayInAdvanceStatus { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportBikeEnergyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportBikeEnergyQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID（对外）
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

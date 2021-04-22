using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppBillkeyUpgradeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppBillkeyUpgradeModel : AopObject
    {
        /// <summary>
        /// 原户号
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型英文名称 ，固定传JF，表示缴费
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构英文简称
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 升级后的户号
        /// </summary>
        [XmlElement("new_bill_key")]
        public string NewBillKey { get; set; }

        /// <summary>
        /// UPGRADE代表户号升级 ROLLBACK代表户号回滚
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 子业务类型英文名称，ELECTRIC-电费，WATER-水费，GAS-燃气费
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}

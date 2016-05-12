﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.util
{
    /// <summary>
    /// 常量类
    /// </summary>
    public class Constant
    {
        /// <summary>
        /// 每日登陆数据下载
        /// </summary>
        public const string DOWNLOAD_DAILY = "1";
        /// <summary>
        /// 零售数据下载
        /// </summary>
        public const string DOWNLOAD_RESALE = "2";

        /// <summary>
        /// 订单状态6：代提货
        /// </summary>
        public const string ORDER_STATUS_RECEIPT = "6";
       
        /// <summary>
        /// 订单状态：完成
        /// </summary>
        public const string ORDER_STATUS_FININSH = "7";

        /// <summary>
        /// 订单状态：全部拒收
        /// </summary>
        public const string ORDER_STATUS_ALL_REFUSE = "9";

        /// <summary>
        /// 订单状态：部分拒收
        /// </summary>
        public const string ORDER_STATUS_PART_REFUSE = "10";

        /// <summary>
        /// 订单状态：全部退款
        /// </summary>
        public const string ORDER_STATUS_ALL_REFUND = "11";

        /// <summary>
        /// 订单状态：部分退款
        /// </summary>
        public const string ORDER_STATUS_PART_REFUND = "12";

        /// <summary>
        /// 亭点收获状态：已收获
        /// </summary>
        public const bool HARVEST_YES = true;

        /// <summary>
        /// 亭点收获状态：未收货
        /// </summary>
        public const bool HARVEST_NO = false;

        /// <summary>
        /// 结算
        /// </summary>
        public const string BALANCE = "1";

        /// <summary>
        /// 退款
        /// </summary>
        public const string REFUND = "2";

        /// <summary>
        /// 零售
        /// </summary>
        public const string RETAIL = "3";

        /// <summary>
        /// 提货
        /// </summary>
        public const string PICK_UP_GOODS = "4";

        /// <summary>
        /// 订单状态 ：待提交
        /// </summary>
        public const string CHECK_STATUS_UNDO = "0";
        /// <summary>
        ///订单状态：待审核 
        /// </summary>
        public const string CHECK_STATUS_WAITCHECK = "1";

        /// <summary>
        /// 订单状态: 完成
        /// </summary>
        public const string CHECK_STATUS_FINISH = "4";

        /// <summary>
        /// 日常收货表
        /// </summary>
        public const string DAILY_RECEIVE_GOODS = "DAILY_RECEIVE_GOODS";

        /// <summary>
        /// 支付信息表
        /// </summary>
        public const string PAY_INFO = "PAY_INFO";

        /// <summary>
        /// 支付明细
        /// </summary>
        public const string PAY_INFO_ITEM = "PAY_INFO_ITEM";

        public const string ZC_ORDER_HISTORY = "ZC_ORDER_HISTORY";

        public const string ZC_ORDER_HISTORY_UPDATE = "ZC_ORDER_HISTORY_UPDATE";

        public const string ZC_ORDER_HISTORY_ITEM = "ZC_ORDER_HISTORY_ITEM";

        public const string ZC_ORDER_TRANSIT_DELETE = "ZC_ORDER_TRANSIT_DELETE";

        public const string ZC_ORDER_TRANSIT_ITEM_DELETE = "ZC_ORDER_TRANSIT_ITEM_DELETE";

        public const string ZC_ORDER_TRANSIT_UPDATE = "ZC_ORDER_TRANSIT_UPDATE";
        /// <summary>
        /// 拒收
        /// </summary>
        public const string ZC_ORDER_REFUSE = "ZC_ORDER_REFUSE";
        /// <summary>
        /// 拒收明细
        /// </summary>
        public const string ZC_ORDER_REFUSE_ITEM = "ZC_ORDER_REFUSE_ITEM";
        /// <summary>
        /// 退款
        /// </summary>
        public const string ZC_ORDER_REFUND = "ZC_ORDER_REFUND";
        /// <summary>
        /// 退款明细
        /// </summary>
        public const string ZC_ORDER_REFUND_ITEM = "ZC_ORDER_REFUND_ITEM";
        /// <summary>
        /// 零售
        /// </summary>
        public const string ZC_RESALE = "ZC_RESALE";
        /// <summary>
        /// 零售明细
        /// </summary>
        public const string ZC_RESALE_ITME = "ZC_RESALE_ITME";


        /// <summary>
        /// 要货单
        /// </summary>
        public const string ZC_REQUIRE = "ZC_REQUIRE";

        public const string ZC_REQUIRE_DELETE = "ZC_REQUIRE_DELETE";

        public const string ZC_REQUIRE_UPDATE = "ZC_REQUIRE_UPDATE";

        /// <summary>
        /// 要货单明细
        /// </summary>
        public const string ZC_REQUIRE_ITEM = "ZC_REQUIRE_ITEM";

        /// <summary>
        /// 库存更新
        /// </summary>
        public const string ZC_STOREHOUSE_UPDATE = "ZC_STOREHOUSE_UPDATE";
    }
}

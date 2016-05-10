﻿using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Branch.com.proem.exm.dao.branch
{
    /// <summary>
    /// 流水明细数据
    /// </summary>
    public class BranchPayInfoItemDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchPayInfoItemDao));

        /// <summary>
        /// 添加支付明细
        /// </summary>
        /// <param name="list"></param>
        public void AddPayInfoItem(List<PayInfoItem> list)
        {
            string sql = "insert into zc_payInfo_item values (@id, @createTime, @updateTime, @payInfoId, @payMode, @money)";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction tran = null;
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                foreach(PayInfoItem obj in list)
                {
                    cmd.Parameters.AddWithValue("@id", obj.Id);
                    cmd.Parameters.AddWithValue("@createTime", obj.CreateTime);
                    cmd.Parameters.AddWithValue("@updateTime", obj.UpdateTime);
                    cmd.Parameters.AddWithValue("@payInfoId", obj.PayInfoId);
                    cmd.Parameters.AddWithValue("@payMode", obj.PayMode);
                    cmd.Parameters.AddWithValue("@money", obj.Money);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("本地数据库插入支付明细失败", ex);
            }
            finally
            {
                CloseConnection(conn);
            }
        }

    }
}
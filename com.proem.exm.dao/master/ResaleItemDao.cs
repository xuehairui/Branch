﻿using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using log4net;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Branch.com.proem.exm.dao.master
{
    /// <summary>
    /// 零售明细服务器操作类
    /// </summary>
    public class ResaleItemDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(ResaleItemDao));

        /// <summary>
        /// 上传零售明细
        /// </summary>
        /// <param name="list"></param>
        public void AddResaleItem(List<ResaleItem> list)
        {
            string sql = "insert into zc_resale_item (id, createTime, updateTime, goodsFile_id, nums, money, resale_id) "
                +" values(:id, :createTime, :updateTime, :gooodsFileId, :nums, :money, :resaleId)";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(ResaleItem obj in list){
                    cmd.Parameters.Add(":id", obj.Id);
                    cmd.Parameters.Add(":createTime", obj.CreateTime);
                    cmd.Parameters.Add(":updateTime", obj.UpdateTime);
                    cmd.Parameters.Add(":gooodsFileId", obj.GoodsFileId);
                    cmd.Parameters.Add(":nums", obj.Nums);
                    cmd.Parameters.Add(":money", obj.Money);
                    cmd.Parameters.Add(":resaleId", obj.ResaleId);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> upList = new List<UploadInfo>();
                foreach (ResaleItem obj in list)
                {
                    UploadInfo uploadInfo = new UploadInfo();
                    uploadInfo.Id = obj.Id;
                    uploadInfo.CreateTime = DateTime.Now;
                    uploadInfo.UpdateTime = DateTime.Now;
                    uploadInfo.Type = Constant.ZC_RESALE_ITME;
                    upList.Add(uploadInfo);
                }
                UploadDao uploadDao = new UploadDao();
                uploadDao.AddUploadInfo(upList);
                log.Error("上传零售明细发生异常", ex);
            }
            finally
            {
                OracleUtil.CloseConn(conn);
            }
        }
    }
}

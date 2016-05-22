﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch.com.proem.exm.window.order
{
    public partial class RefuseReason : Form
    {
        /// <summary>
        /// 商品名
        /// </summary>
        private string goodName;

        /// <summary>
        /// 提货界面对象
        /// </summary>
        private CustomerDelivery obj;

        /// <summary>
        /// 填写拒收原因的行
        /// </summary>
        private int index;

        /// <summary>
        /// 工作模式
        /// </summary>
        private string WorkMode;

        private bool flag;

        public RefuseReason()
        {
            InitializeComponent();
        }

        public RefuseReason(CustomerDelivery obj,string name, string WorkMode)
        {
            InitializeComponent();
            this.WorkMode = WorkMode;
            this.Text = "退货原因";
            this.goodName = name;
            this.obj = obj;
        }

        public RefuseReason(CustomerDelivery obj, string name, bool flag)
        {
            InitializeComponent();
            this.goodName = name;
            this.obj = obj;
            this.flag = flag;
        }

        /// <summary>
        /// 重载构造函数
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        public RefuseReason(CustomerDelivery obj, string name, int index, bool flag)
        {
            InitializeComponent();
            this.goodName = name;
            this.obj = obj;
            this.index = index;
            this.flag = flag;
        }

        /// <summary>
        /// 拒收原因界面load方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefuseReason_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(WorkMode))
            {
                messagelabel.Text = goodName + "提货份数存在差异, 请输入拒收原因?";
                reasonTextbox.Focus();
            }
            else 
            {
                messagelabel.Text = "请输入" + goodName + "退货原因?";
                reasonTextbox.Focus();
            }
        }

        /// <summary>
        /// 确定点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirm_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(WorkMode)){
                ///添加拒收原因
                obj.AddRefuseReason(index, reasonTextbox.Text, flag);
            }else
            {
                obj.AddRefundReason(reasonTextbox.Text);
            }
            this.Close();
        }

        /// <summary>
        /// 取消点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 绑定快捷键按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefuseReason_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                confirm_Click(this, e);
            }
            if(e.KeyCode == Keys.Escape)
            {
                button2_Click(this, e);
            }

        }
    }
}

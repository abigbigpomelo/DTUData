﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.Units
{
    public partial class DataCounter : UserControl
    {
        public DataCounter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 清空计数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblReceiveCount.Text = "0";
        }

        /// <summary>
        /// 累计接收字节数
        /// </summary>
        /// <param name="count">累加数</param>
        public void PlusReceive(int count)
        {
            lblReceiveCount.Invoke(new MethodInvoker(delegate
            {
                lblReceiveCount.Text = (int.Parse(lblReceiveCount.Text) + count).ToString();
            }));
        }
    }
}

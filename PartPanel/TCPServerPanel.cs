﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.PartPanel
{
    public partial class TCPServerPanel : BasePanel
    {
        public TCPServerPanel()
        {
            InitializeComponent();
        }
        private void Configer_DataReceived(object sender, byte[] data)
        {
            tabDataReceiver.AddData(sender.ToString(),data);
            MDataCounter.PlusReceive(data.Length);
            labelShow.showdata(data);
        }

        public override void ClearSelf()
        {
            Configer.ClearSelf();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.Units
{
    public partial class Label : UserControl
    {
        public Label()
        {
            InitializeComponent();
        }
        private List<byte> readedDataBuffer = new List<byte>();

        private delegate void SetLabelDelegate(byte[] data);

        public void showdata(byte[] data)
        {

            if (this.InvokeRequired)
            {
                SetLabelDelegate d = new SetLabelDelegate(showdata);
                this.Invoke(d, new object[] { data });
            }
            else
            {
                for (int i = 0; i < data.Length; ++i)
                    readedDataBuffer.Add(data[i]);
                if (readedDataBuffer.Count >= 2)
                {
                    int removeCount = 0;
                    for (int i = 0; i < readedDataBuffer.Count - 1; ++i)
                    {
                        // 14 7B节点
                        if (readedDataBuffer[i] == 0xFD)
                        {

                            int data31, data32;
                            float v3, T3, H;
                            data31 = readedDataBuffer[i];//高八位
                            data32 = readedDataBuffer[i + 1];//低八位
                            v3 = (data31 * 256 + data32);//电压值
                            T3 = (v3 / 1023) * 3.3f;
                            H = (T3 * 100) / 3;
                            this.label1.Text = data32.ToString();
                        }
                        removeCount++;
                    }

                    if (readedDataBuffer.Count >= removeCount)
                        readedDataBuffer.RemoveRange(0, removeCount);
                }
            }

        }
        /*
        public void showdata (byte[] data)
        {
            for (int i = 0; i < data.Length; ++i)
                readedDataBuffer.Add(data[i]);
            if (readedDataBuffer.Count >= 2)
            {
                int removeCount = 0;
                for (int i = 0; i < readedDataBuffer.Count - 1; ++i)
                {
                    // 14 7B节点
                    if (readedDataBuffer[i] == 0xFD)
                    {

                        int data31, data32;
                        float v3, T3, H;
                        data31 = readedDataBuffer[i];//高八位
                        data32 = readedDataBuffer[i + 1];//低八位
                        v3 = (data31 * 256 + data32);//电压值
                        T3 = (v3 / 1023) * 3.3f;
                        H = (T3 * 100) / 3;
                        label1.Text = data31.ToString();
                    }
                    //removeCount++;
                }

                if (readedDataBuffer.Count >= removeCount)
                    readedDataBuffer.RemoveRange(0, removeCount);
            }
        }
        */
    }
}

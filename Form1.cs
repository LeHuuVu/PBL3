using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace HuffmanCoding
{


    public partial class Form1 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        HuffmanCoding huffman;
        public Form1()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            lstFrequency.ListViewItemSorter = lvwColumnSorter;
            lvwColumnSorter.SortColumn = 0;
            huffman = new HuffmanCoding();
        }
        private void NhapFile(History h)
        {
            String filepath = @"C:\Users\Admin\Desktop\DA\DACK.txt";
            StreamWriter writer = new StreamWriter(filepath, true);
            writer.WriteLine(h.STT.ToString() + " " + h.TruocMaHoa.ToString() + " " + h.SauMaHoa.ToString() + " " + h.ThoiGian.ToString());
            writer.Flush();
            writer.Close();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if(rtxtInput.Text == ""){
                MessageBox.Show("Ban phai nhap chuoi can encode!");
            }
            else
            {
                lstFrequency.Items.Clear();
                txtEncodedString.Text = huffman.Encode(rtxtInput.Text);
                foreach (char c in huffman.Symbols)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = c.ToString();
                    item.SubItems.Add(huffman.GetFrequency(c).ToString());
                    item.SubItems.Add(huffman.GetCodeword(c).ToString());
                    lstFrequency.Items.Add(item);
                }
                lblAverageBit.Text = Math.Round(huffman.AverageBit, 2).ToString();
                lstFrequency.Sort();

                History h = new History
                {
                    TruocMaHoa = rtxtInput.Text,
                    SauMaHoa = txtEncodedString.Text,
                    ThoiGian = DateTime.Now
                };
                using (QLDB_DACK db = new QLDB_DACK())
                {
                    db.Histories.Add(h);
                    db.SaveChanges();
                }
                NhapFile(h);
            }            
        }

        private void lstFrequency_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                    lvwColumnSorter.Order = SortOrder.Descending;
                else
                    lvwColumnSorter.Order = SortOrder.Ascending;
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            lstFrequency.Sort();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if(txtEncodedString.Text == "")
            {
                MessageBox.Show("Ban phai nhap chuoi can decode!");
            }
            else
            {
                rtxtInput.Text = huffman.Decode(txtEncodedString.Text);

                History h = new History
                {
                    TruocMaHoa = rtxtInput.Text,
                    SauMaHoa = txtEncodedString.Text,
                    ThoiGian = DateTime.Now
                };
                using (QLDB_DACK db = new QLDB_DACK())
                {
                    db.Histories.Add(h);
                    db.SaveChanges();
                }
                NhapFile(h);
            }            
        }

        private void butHis_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
    class ListViewColumnSorter : IComparer
    {
        public int SortColumn;
        public SortOrder Order;
        #region IComparer Members

        public int Compare(object x, object y)
        {
            string a = (x as ListViewItem).SubItems[SortColumn].Text;
            string b = (y as ListViewItem).SubItems[SortColumn].Text;

            if (Order == SortOrder.Descending)
            {
                string c = a;
                a = b;
                b = c;
            }
            if (SortColumn == 1)
            {
                int m = int.Parse(a);
                int n = int.Parse(b);
                return m.CompareTo(n);
            }
            else
                return a.CompareTo(b);
        }

        #endregion
    }
}

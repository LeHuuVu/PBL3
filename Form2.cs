using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuffmanCoding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void butShow_Click(object sender, EventArgs e)
        {
            QLDB_DACK db = new QLDB_DACK();
            var query = from p in db.Histories select p;            
            dgvHistory.DataSource = query.ToList();            
        }
        private void butSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Ban phai nhap chuoi can tim!");
            }
            else
            {
                QLDB_DACK db = new QLDB_DACK();
                var query = db.Histories.Where(p => p.TruocMaHoa.Contains(txtSearch.Text) || p.SauMaHoa.Contains(txtSearch.Text));
                dgvHistory.DataSource = query.ToList();
            }            
        }
        private void butDel_Click(object sender, EventArgs e)
        {
            if(dgvHistory.SelectedRows.Count > 0)
            {
                QLDB_DACK db = new QLDB_DACK();
                foreach(DataGridViewRow i in dgvHistory.SelectedRows)
                {
                    int STT = Convert.ToInt32(i.Cells["STT"].Value);                    
                    History Mydel = db.Histories.Find(STT);                    
                    db.Histories.Remove(Mydel);
                    db.SaveChanges();
                }
                var query = from p in db.Histories select p;
                dgvHistory.DataSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Ban phai nhap dong can xoa!");
            }
        }
        private void butExit_Click(object sender, EventArgs e)
        {            
            this.Dispose();
        } 
        private void butSort_Click(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex == -1)
            {
                MessageBox.Show("Ban phai chon doi tuong can sap xep!");
            }
            else
            {
                QLDB_DACK db = new QLDB_DACK();
                List<History> history = new List<History>();
                history = db.Histories.ToList();
                string item = cbbSort.SelectedItem.ToString();
                if (item == "TruocMaHoa") dgvHistory.DataSource = history.OrderBy(P => P.TruocMaHoa).ToList();
                if (item == "SauMaHoa") dgvHistory.DataSource = history.OrderBy(P => P.SauMaHoa).ToList();
                if (item == "ThoiGian") dgvHistory.DataSource = history.OrderBy(P => P.ThoiGian).ToList();
            }            
        }       
    }
}

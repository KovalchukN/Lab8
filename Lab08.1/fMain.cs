using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab08Lib;

namespace Lab08._1
{
    public partial class fMain : Form
    {
        private BindingList<Sub> subs = new BindingList<Sub>();
        public fMain()
        {
            InitializeComponent();
            lbSubInfo.DataSource = subs;
            lbSubInfo.DisplayMember = "Name";
            lbSubInfo.ValueMember = "SecondName";


            lbSubInfo.SelectedIndexChanged += new EventHandler(lbSubInfo_SelectedIndexChanged);
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            Sub sub = new Sub();
            fSub ft = new fSub(sub);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                subs.Add(sub);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Прекратить работу?","Прекратить работу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }   
        }

        private void lbSubInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sub sub = (Sub)lbSubInfo.SelectedItem;
            MessageBox.Show(lbSubInfo.Text += string.Format("{0} {1}.  Номер телефона абонента:{2}.  {3}.  Стоимость пакета услуг:{4}({5})\r\n", sub.Name, sub.SecondName, sub.PhoneNum, sub.Country, sub.Cost, sub.HasCost ? "Тариф оплачен" : "Тариф не оплачен"));

        }
    }
}

using BasicQueuingCashier;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueueingForm
{
    public partial class WindowsQueueForm : Form
    {
        public delegate void NowServing(object sender);
        public NowServing nowServe;

        cashierView cashierView = new cashierView();
        Boolean openForm = false;
        FormCollection AllForms = Application.OpenForms;
        Form OpenedForm = new Form();

        public WindowsQueueForm()
        {
            InitializeComponent();

            Timer timer1 = new Timer();
            timer1.Interval = (1 * 1000);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }


        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listQueue.Items.Add(obj.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshBtn.PerformClick();
        }

        public void NextServing()
        {
            foreach (Form form in AllForms)
            {
                if (form.Name == "CustomerView")
                {
                    OpenedForm = form;
                    openForm = true;
                }
            }
            if (openForm == true)
            {
                if (nowServe != null)
                {
                    cashierView.lblServe.Text = CashierClass.CashierQueue.Peek();                }
            }
            else
            {
                cashierView.ShowDialog();
                cashierView.lblServe.Text = CashierClass.CashierQueue.Peek().ToString();
                CashierClass.CashierQueue.Dequeue();
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            NextServing();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
    }

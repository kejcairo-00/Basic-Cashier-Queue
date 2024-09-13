using BasicQueuingCashier;
using System;
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
    public partial class QueueForm : Form
    {
        private CashierClass cashier = new CashierClass();
        internal object lblNowServing;

        public QueueForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            WindowsQueueForm obj = new WindowsQueueForm();
            obj.Show();
        }

        private void QueueForm_Load(object sender, EventArgs e)
        {

        }

        private void CashierBtn_Click(object sender, EventArgs e)
        {
            QueueLbl.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = QueueLbl.Text;

            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}

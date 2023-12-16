using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAKop_client.Forms {
    public partial class FrmWait : Form {

        public Action Worker { get; set; }

        public FrmWait(Action worker) {
            InitializeComponent();

            if (worker == null)
                throw new ArgumentNullException();
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void FrmWait_Load(object sender, EventArgs e) {

        }
    }
}

using Service.Implementation;
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

namespace Test.Implementation
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        #region ProcessAutomatico
        //private void btnProManualFileBd_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnProManualFileCc_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnProManualFileCp_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnProManualFileDe_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnProManualFileEu_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnProManualFileLisglo_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        private void btnProAutoAllFiles_Click(object sender, EventArgs e)
        {
            LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
            worker.StartAsync(CancellationToken.None);
        }
        #endregion

        //#region Reprocess
        //private void btnReProFileBd_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnReProFileCc_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnReProFileCp_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnReProFileDe_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnReProFileEu_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnReProFileLisglo_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}

        //private void btnReProAllFiles_Click(object sender, EventArgs e)
        //{
        //    LoadingHistoryWorker worker = new LoadingHistoryWorker(null);
        //    worker.StartAsync(CancellationToken.None);
        //}
        //#endregion
    }
}

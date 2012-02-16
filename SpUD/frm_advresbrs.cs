using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// The namespace. 'nuff said...
namespace com.sensepost.SPUD
{

    #region Delegate Items
    public delegate void DlgCtlEnaSet(System.Windows.Forms.Control myctl, bool enabled);
    public delegate void DlgCtlColSet(System.Windows.Forms.Control myctl, System.Drawing.Color mycol);
    public delegate void DlgCtlTxtSet(System.Windows.Forms.Control myctl, String mytxt);
    public delegate void DlgCtlLvwClr(System.Windows.Forms.ListView myctl);
    public delegate void DlgCtlLvwAdd(System.Windows.Forms.ListView myctl, ListViewItem myitm);
    public delegate void DlgCtlImgSet(System.Windows.Forms.PictureBox myctl, Image myimg);
    public delegate void DlgCtlCtlAdd(System.Windows.Forms.Control myctl, System.Windows.Forms.Control myres);
    public delegate void DlgCtlCtlClr(System.Windows.Forms.Control myctl);
    public delegate void DlgCtlSusLot(System.Windows.Forms.Control myctl, bool suspend);
    public delegate ListViewItem DlgCtlLstItm(System.Windows.Forms.ListView myctl, int myidx);
    #endregion

    // The class.  'nuff said...
    public partial class frm_advresbrs : Form
    {
        #region Private Class Variables
        private frm_main the_main;
        private int n_start;
        private int n_length;
        //private com.sensepost.web.obj.StructuredResult g_res;
        private bool HaveILoaded = false;
        private int SortColumnNum = -1;
        private volatile bool AmISearching;
        #endregion

        #region Public Class Variables
        #region Delegate Items
        public DlgCtlEnaSet del_ctl_ena_set;
        public DlgCtlColSet del_ctl_col_set;
        public DlgCtlTxtSet del_ctl_txt_set;
        public DlgCtlLvwClr del_ctl_lvw_clr;
        public DlgCtlLvwAdd del_ctl_lvw_add;
        public DlgCtlImgSet del_ctl_img_set;
        public DlgCtlCtlAdd del_ctl_ctl_add;
        public DlgCtlCtlClr del_ctl_ctl_clr;
        public DlgCtlSusLot del_ctl_sus_lot;
        public DlgCtlLstItm del_ctl_lst_itm;
        public delegate void TheWorkerThread();
        #endregion
        #endregion

        #region Class Instantiation
        public frm_advresbrs(frm_main frmm)
        {
            this.the_main = frmm;
            this.n_start = 0;
            this.n_length = 10;
            InitializeComponent();
            chk_google.Checked = the_main.UseGoogle;
            chk_google.Enabled = the_main.UseGoogle;
            chk_live.Checked = the_main.UseLive;
            chk_live.Enabled = the_main.UseLive;
            chk_yahoo.Checked = the_main.UseYahoo;
            chk_yahoo.Enabled = the_main.UseYahoo;
            this.del_ctl_ena_set = new DlgCtlEnaSet(this.Dtg_Ctl_Ena_Set);
            this.del_ctl_col_set = new DlgCtlColSet(this.Dtg_Ctl_Col_Set);
            this.del_ctl_txt_set = new DlgCtlTxtSet(this.Dtg_Ctl_Txt_Set);
            this.del_ctl_lvw_clr = new DlgCtlLvwClr(this.Dtg_Ctl_Lvw_Clr);
            this.del_ctl_lvw_add = new DlgCtlLvwAdd(this.Dtg_Ctl_Lvw_Add);
            this.del_ctl_img_set = new DlgCtlImgSet(this.Dtg_Ctl_Img_Set);
            this.del_ctl_ctl_add = new DlgCtlCtlAdd(this.Dtg_Ctl_Ctl_Add);
            this.del_ctl_ctl_clr = new DlgCtlCtlClr(this.Dtg_Ctl_Ctl_Clr);
            this.del_ctl_sus_lot = new DlgCtlSusLot(this.Dtg_Ctl_Sus_Lot);
            this.del_ctl_lst_itm = new DlgCtlLstItm(this.Dtg_Ctl_Lst_Itm);
            HaveILoaded = true;
            this.AmISearching = false;
        }
        #endregion

        #region Public Methods
        public void StartSearching(String the_query)
        {
            if (!this.AmISearching)
            {
                this.txt_search.Text = the_query;
                this.n_length = (int)nud_rpq.Value;
                TheWorkerThread del_strthread = new TheWorkerThread(GetTheDetails);
                AsyncCallback cbk_strthread = new AsyncCallback(EndTheDetails);
                del_strthread.BeginInvoke(cbk_strthread, null);
                this.AmISearching = true;
            }
        }
        #endregion

        #region Private Helper Methods
        private void StartSearching()
        {
            if (!this.AmISearching)
            {
                this.the_main.LogTheEvent("APP-RESULT", "DEBUG", "New Search:Q=" + this.txt_search.Text + ":S=" + this.n_start.ToString() + ":L=" + this.n_length.ToString());
                this.n_length = (int)nud_rpq.Value;
                TheWorkerThread del_strthread = new TheWorkerThread(GetTheDetails);
                AsyncCallback cbk_strthread = new AsyncCallback(EndTheDetails);
                del_strthread.BeginInvoke(cbk_strthread, null);
                this.AmISearching = true;
            }
        }
        private void GetTheDetails()
        {
            if (this.the_main.ShowingBrowserDialig)
            {
                this.Invoke(this.del_ctl_ena_set, new Object[] { this.txt_search, false });
                this.Invoke(this.del_ctl_ena_set, new Object[] { this.btn_goforit, false });
                this.Invoke(this.del_ctl_ena_set, new Object[] { this.btn_next, false });
                this.Invoke(this.del_ctl_ena_set, new Object[] { this.btn_prev, false });
                this.Invoke(this.del_ctl_col_set, new Object[] { this.btn_goforit, System.Drawing.Color.IndianRed });
                this.Invoke(this.del_ctl_img_set, new Object[] { this.pbx_loading, res_images.loading });
            }
            com.sensepost.web.obj.Service the_srv = new global::com.sensepost.SPUD.com.sensepost.web.obj.Service();
            com.sensepost.web.obj.StructuredResult the_res = new global::com.sensepost.SPUD.com.sensepost.web.obj.StructuredResult();
            the_res = the_srv.GetStructResult(txt_search.Text, this.n_start, this.n_length, false);
            this.the_main.all_results = the_res;
        }

        private void EndTheDetails(IAsyncResult arResult)
        {
            the_main.ShowAbForm();
            this.Invoke(this.del_ctl_col_set, new Object[] { this.btn_goforit, System.Drawing.Color.MediumAquamarine });
            this.Invoke(this.del_ctl_ena_set, new Object[] { this.btn_goforit, true });
            this.Invoke(this.del_ctl_ena_set, new Object[] { this.txt_search, true });
            this.Invoke(this.del_ctl_img_set, new Object[] { this.pbx_loading, res_images.waiting });
            PopulateTheResults();
            this.AmISearching = false;
            this.the_main.NotifyText = "SensePost SPUD : Search Complete";
            this.the_main.ShowNfForm();
        }

        private void PopulateTheResults()
        {
            // We do this in two processes.
            // Firstly, we update the list view, and then, we update the web view.
            // Reason being:
            // The first items added to the list view end up at the end...
            // So, we add items in reverse...
            this.Invoke(this.del_ctl_sus_lot, new Object[] { this.tpg_web, true });
            this.Invoke(this.del_ctl_lvw_clr, new Object[] { this.lvw_results });
            this.Invoke(this.del_ctl_ctl_clr, new Object[] { this.tpg_web });
            this.Invoke(this.del_ctl_txt_set, new Object[] { this.lbl_google, "Total Google Results: " + this.the_main.all_results.ResultGoogleTotal.ToString() });
            this.Invoke(this.del_ctl_txt_set, new Object[] { this.lbl_live, "Total MSN Live Results: " + this.the_main.all_results.ResultLiveTotal.ToString() });
            this.Invoke(this.del_ctl_txt_set, new Object[] { this.lbl_yahoo, "Total! Yahoo! Results!: " + this.the_main.all_results.ResultYahooTotal.ToString() });
            if (this.the_main.all_results.ResultGoogleTotal <= n_length && this.the_main.all_results.ResultLiveTotal <= n_length && this.the_main.all_results.ResultYahooTotal <= n_length)
                this.Invoke(this.del_ctl_ena_set, new Object[] { this.btn_next, false });
            else
                this.Invoke(this.del_ctl_ena_set, new Object[] { this.btn_next, true });
            if (this.n_start == 0)
                this.Invoke(this.del_ctl_ena_set, new Object[] { this.btn_prev, false });
            else
                this.Invoke(this.del_ctl_ena_set, new Object[] { this.btn_prev, true });
            if (this.the_main.all_results.ResultTotal > 0)
            {
                foreach (com.sensepost.web.obj.StructuredResultElement the_elm in this.the_main.all_results.ResultItems)
                {
                    if (the_elm.ResultSource.ToLower() == "google" && chk_google.Checked)
                    {
                        String[] tmp = new String[6];
                        tmp[0] = the_elm.ResultSource;
                        tmp[1] = the_elm.ResultTitle;
                        tmp[2] = the_elm.ResultUrl;
                        if (the_elm.ResultErrorCode.ToLower() != "success")
                            tmp[3] = the_elm.ResultErrorCode;
                        else tmp[3] = the_elm.ResultSnippet;
                        tmp[4] = the_elm.ResultCacheSize;
                        tmp[5] = the_elm.ResultErrorCode;
                        ListViewItem lvi = new ListViewItem(tmp);
                        if (the_elm.ResultErrorCode.ToLower() != "success")
                            lvi.BackColor = System.Drawing.Color.Red;
                        else
                            lvi.BackColor = System.Drawing.Color.White;
                        this.Invoke(this.del_ctl_lvw_add, new Object[] { this.lvw_results, lvi });
                    }
                    if (the_elm.ResultSource.ToLower() == "live" && chk_live.Checked)
                    {
                        String[] tmp = new String[6];
                        tmp[0] = the_elm.ResultSource;
                        tmp[1] = the_elm.ResultTitle;
                        tmp[2] = the_elm.ResultUrl;
                        if (the_elm.ResultErrorCode.ToLower() != "success")
                            tmp[3] = the_elm.ResultErrorCode;
                        else tmp[3] = the_elm.ResultSnippet;
                        tmp[4] = the_elm.ResultCacheSize;
                        tmp[5] = the_elm.ResultErrorCode;
                        ListViewItem lvi = new ListViewItem(tmp);
                        if (the_elm.ResultErrorCode.ToLower() != "success")
                            lvi.BackColor = System.Drawing.Color.Red;
                        else
                            lvi.BackColor = System.Drawing.Color.White;
                        this.Invoke(this.del_ctl_lvw_add, new Object[] { this.lvw_results, lvi });
                    }
                    if (the_elm.ResultSource.ToLower() == "yahoo" && chk_yahoo.Checked)
                    {
                        String[] tmp = new String[6];
                        tmp[0] = the_elm.ResultSource;
                        tmp[1] = the_elm.ResultTitle;
                        tmp[2] = the_elm.ResultUrl;
                        if (the_elm.ResultErrorCode.ToLower() != "success")
                            tmp[3] = the_elm.ResultErrorCode;
                        else tmp[3] = the_elm.ResultSnippet;
                        tmp[4] = the_elm.ResultCacheSize;
                        tmp[5] = the_elm.ResultErrorCode;
                        ListViewItem lvi = new ListViewItem(tmp);
                        if (the_elm.ResultErrorCode.ToLower() != "success")
                            lvi.BackColor = System.Drawing.Color.Red;
                        else
                            lvi.BackColor = System.Drawing.Color.White;
                        this.Invoke(this.del_ctl_lvw_add, new Object[] { this.lvw_results, lvi });
                    }
                }
            }
            this.Invoke(this.del_ctl_sus_lot, new Object[] { this.tpg_web, false });
            PopulateWebResults();
        }

        private void PopulateWebResults()
        {
            int i = 0;
            this.Invoke(this.del_ctl_ctl_clr, new Object[] { this.tpg_web });
            this.Invoke(this.del_ctl_sus_lot, new Object[] { this.tpg_web, true });
            for (i = lvw_results.Items.Count; i > 0; i--)
            {
                ListViewItem the_itm = (ListViewItem)this.Invoke(this.del_ctl_lst_itm, new Object[] { lvw_results, i - 1 });
                Image img;
                String titl;
                String link;
                String snip;
                String stat;
                if (the_itm.SubItems[0].Text.ToLower() == "google")
                    img = res_images.google;
                else if (the_itm.SubItems[0].Text.ToLower() == "live")
                    img = res_images.msn_live;
                else
                    img = res_images.yahoo;
                titl = the_itm.SubItems[1].Text;
                link = the_itm.SubItems[2].Text;
                snip = the_itm.SubItems[3].Text;
                stat = the_itm.SubItems[5].Text;
                ctl_results the_res = new ctl_results(img, titl, link, snip, stat);
                the_res.MaximumSize = new Size(tpg_web.Width, 0);
                the_res.Dock = DockStyle.Top;
                this.Invoke(this.del_ctl_ctl_add, new Object[] { tpg_web, the_res });
                Panel the_pnl = new Panel();
                the_pnl.Height = 10;
                the_pnl.Dock = DockStyle.Top;
                this.Invoke(this.del_ctl_ctl_add, new Object[] { tpg_web, the_pnl });

            }
            this.Invoke(this.del_ctl_sus_lot, new Object[] { this.tpg_web, false });
        }

        private void SetUpTheDisplay()
        {
        }
        #endregion

        #region Delegate Target Items
        private void Dtg_Ctl_Ena_Set(System.Windows.Forms.Control myctl, bool enabled)
        {
            myctl.Enabled = enabled;
        }

        private void Dtg_Ctl_Col_Set(System.Windows.Forms.Control myctl, System.Drawing.Color mycol)
        {
            myctl.BackColor = mycol;
        }

        private void Dtg_Ctl_Txt_Set(System.Windows.Forms.Control myctl, String mytxt)
        {
            myctl.Text = mytxt;
        }

        private void Dtg_Ctl_Lvw_Clr(System.Windows.Forms.ListView myctl)
        {
            myctl.Items.Clear();
        }

        private void Dtg_Ctl_Lvw_Add(System.Windows.Forms.ListView myctl, ListViewItem myitm)
        {
            myctl.Items.Add(myitm);
        }

        public void Dtg_Ctl_Img_Set(System.Windows.Forms.PictureBox myctl, Image myimg)
        {
            myctl.Image = myimg;
        }

        public void Dtg_Ctl_Ctl_Add(System.Windows.Forms.Control myctl, System.Windows.Forms.Control myres)
        {
            myctl.Controls.Add(myres);
        }

        public void Dtg_Ctl_Ctl_Clr(System.Windows.Forms.Control myctl)
        {
            myctl.Controls.Clear();
        }

        public void Dtg_Ctl_Sus_Lot(System.Windows.Forms.Control myctl, bool suspend)
        {
            if (suspend) myctl.SuspendLayout();
            else myctl.ResumeLayout();
        }

        public ListViewItem Dtg_Ctl_Lst_Itm(System.Windows.Forms.ListView myctl, int myidx)
        {
            ListViewItem returnitm = myctl.Items[myidx];
            return returnitm;
        }
        #endregion

        #region Widget Voids
        private void frm_advresbrs_Load(object sender, EventArgs e)
        {
            this.n_start = 0;
            this.n_length = 10;
            chk_google.Checked = the_main.UseGoogle;
            chk_google.Enabled = the_main.UseGoogle;
            chk_live.Checked = the_main.UseLive;
            chk_live.Enabled = the_main.UseLive;
            chk_yahoo.Checked = the_main.UseYahoo;
            chk_yahoo.Enabled = the_main.UseYahoo;
            HaveILoaded = true;
            this.AmISearching = false;
        }

        private void btn_goforit_Click(object sender, EventArgs e)
        {
            this.n_start = 0;
            StartSearching();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (this.n_start == 0)
            {
                return;
            }
            this.n_start = this.n_start - this.n_length;
            StartSearching();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.n_start = this.n_start + 10;
            StartSearching();
        }

        private void lvw_results_DoubleClick(object sender, EventArgs e)
        {
            if (lvw_results.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvw_results.SelectedItems[0];
            String the_Url = lvi.SubItems[2].Text;
            if (the_Url.Length == 0) return;
            System.Diagnostics.Process.Start(the_Url);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.Length > 0)
            {
                this.btn_goforit.Enabled = true;
                this.btn_prev.Enabled = false;
                this.btn_next.Enabled = false;
            }
        }

        private void lvw_results_Resize(object sender, EventArgs e)
        {
            int n_w = lvw_results.Width;
            col_source.Width = n_w / 100 * 6;
            col_title.Width = n_w / 100 * 25;
            col_url.Width = n_w / 100 * 25;
            col_snippet.Width = n_w / 100 * 38;
            col_cache.Width = n_w / 100 * 6;
        }

        private void nud_rpq_ValueChanged(object sender, EventArgs e)
        {
            this.n_length = (int)nud_rpq.Value;
        }

        private void ResultFilter(object sender, EventArgs e)
        {
            if (HaveILoaded)
            {
                PopulateTheResults();
            }
        }

        private void rtb_results_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void lvw_results_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != this.SortColumnNum)
            {
                SortColumnNum = e.Column;
                lvw_results.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (lvw_results.Sorting == SortOrder.Ascending)
                    lvw_results.Sorting = SortOrder.Descending;
                else
                    lvw_results.Sorting = SortOrder.Ascending;
            }
            lvw_results.Sort();
            this.lvw_results.ListViewItemSorter = new ListViewComparer(e.Column, lvw_results.Sorting);
            PopulateWebResults();
        }

        private void frm_advresbrs_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.the_main.HideAbForm();
        }
        #endregion

        #region Comparison Class for ListView Sorting

        class ListViewComparer : IComparer
        {
            private int col;
            private SortOrder order;
            public ListViewComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }
            public ListViewComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                        ((ListViewItem)y).SubItems[col].Text);
                // Determine whether the sort order is descending.
                if (order == SortOrder.Descending)
                    // Invert the value returned by String.Compare.
                    returnVal *= -1;
                return returnVal;
            }

        }
        #endregion

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace İsTakip
{
    public partial class frmGrid : DevExpress.XtraEditors.XtraForm
    {
        string formadi = "";

        public frmGrid(DataTable dtlist,string formisim)
        {
            InitializeComponent();
            gridControl1.DataSource = dtlist;
            gwGrid.RefreshData();
            gwGrid.BestFitColumns();
            formadi = formisim;
        }
        

        private void frmGrid_Load(object sender, EventArgs e)
        {
          
        }

        private void gwGrid_DoubleClick(object sender, EventArgs e)
        {
            string kod=gwGrid.GetRowCellValue(gwGrid.FocusedRowHandle,gwGrid.Columns["kod"]).ToString();

            if (formadi=="Login")
            {
                frmLogin1 myform = new frmLogin1(kod);
                myform.ShowDialog();
            }
            else if (formadi=="Gorevler")
            {
                frmGorevler myform = new frmGorevler(kod);
                myform.ShowDialog();
            }
            else if(formadi=="Cariler")
            {
                frmCariler myform = new frmCariler(kod);
                myform.ShowDialog();
            }
            else if (formadi == "CariYetkili")
            {
                frmCariYetkili myform = new frmCariYetkili(kod);
                myform.ShowDialog();
            }
            this.Close();

	{
		 
	}
        }
    }
}
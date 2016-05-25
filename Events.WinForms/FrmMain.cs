using Events.WinForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events.WinForms
{
    public partial class FrmMain : Form
    {
        private MianWindowViewModel _mainWindowViewModel;
        public FrmMain()
        {
            InitializeComponent();

            //dgvEvents.AutoGenerateColumns = false;

            _mainWindowViewModel = new MianWindowViewModel();
            dgvEvents.DataSource = _mainWindowViewModel.Events;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddEditViewModel addEditViewModel = new AddEditViewModel();

            FrmAddEdit frmAddEdit = new FrmAddEdit(addEditViewModel);

            if (frmAddEdit.ShowDialog() 
                == System.Windows.Forms.DialogResult.OK)
            {
                //cos bede robil
            }
        }
    }
}

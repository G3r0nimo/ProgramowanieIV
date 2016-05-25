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
    public partial class FrmAddEdit : Form
    {
        private AddEditViewModel _addEditViewModel;
        public FrmAddEdit(AddEditViewModel addEditViewModel)
        {
            InitializeComponent();
            _addEditViewModel = addEditViewModel;

            txtTitle.DataBindings.Add("Text", 
                _addEditViewModel, 
                "Title", 
                false, 
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void cbxEventType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

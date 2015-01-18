using System;
using System.Windows.Forms;

namespace RedisAdmin
{
    public partial class UrnFilterDialog : Form
    {
        public string Filter { get; set; }

        public UrnFilterDialog( string Name = null )
        {
            InitializeComponent();
            this.Filter = Name;
            this.NameText.Text = Name ?? string.Empty;
        }

        private void OkButton_Click( object sender, EventArgs e )
        {
            this.Filter = this.NameText.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

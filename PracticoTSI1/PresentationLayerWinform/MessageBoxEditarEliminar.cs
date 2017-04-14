using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerWinform
{
    public partial class MessageBoxEditarEliminar : Form
    {
        static MessageBoxEditarEliminar newMessageBox;
        static string sOpcion = "0";

        public MessageBoxEditarEliminar()
        {
            InitializeComponent();
        }

        public static string ShowBox()
        {
            newMessageBox = new MessageBoxEditarEliminar();
            newMessageBox.ShowDialog();
            return sOpcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            sOpcion = "0";
            newMessageBox.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            sOpcion = "1";
            newMessageBox.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sOpcion = "2";
            newMessageBox.Dispose();
        }
    }
}

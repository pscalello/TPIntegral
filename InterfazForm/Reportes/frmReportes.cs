using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazForm.Reportes
{
    public partial class frmReportes : Form
    {
        private int Host;
        private Control controlTooltipActual = null;

        public frmReportes(int Host)
        {
            InitializeComponent();
            this.Host = Host;
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // Vendedor no puede ver ni stock crítico ni reporte de productos más vendido por categoría
            if (Host == 1)
            {
                btnReporteStockCtitico.Enabled = false;
                btnReporteProductosMasVendidos.Enabled = false;
            }
        }


        // El form frmReporte recibe 1 para stock critico, 2 para ventas por vendedor
        // y 3 para productos más vendidos por categoria

        private void btnReporteStockCtitico_Click(object sender, EventArgs e)
        {
            frmReporte frmReporte = new frmReporte(1);
            frmReporte.ShowDialog();
        }

        private void btnReporteVentasPorVendedor_Click(object sender, EventArgs e)
        {
            frmReporte frmReporte = new frmReporte(2);
            frmReporte.ShowDialog();
        }

        private void btnReporteProductosMasVendidos_Click(object sender, EventArgs e)
        {
            frmReporte frmReporte = new frmReporte(3);
            frmReporte.ShowDialog();
        }

        private void frmReportes_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = GetChildAtPoint(e.Location);
            if (control != null)
            {
                if (!control.Enabled && controlTooltipActual == null)
                {
                    string toolTipString = "La visualización de este reporte solo está disponible para Supervisores y Administradores";
                    tooltipBotonesDeshabilitados.Show(toolTipString, control, control.Width / 2, control.Height / 2);
                    controlTooltipActual = control;
                }
            }
            else
            {
                if (controlTooltipActual != null) tooltipBotonesDeshabilitados.Hide(controlTooltipActual);
                controlTooltipActual = null;
            }
        }
    }
}

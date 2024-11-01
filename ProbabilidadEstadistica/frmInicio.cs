using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProbabilidadEstadistica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            cmbTipoGrafico.DataSource = Enum.GetValues(typeof(SeriesChartType));
            if (maxAltoPantalla < 900)
            {
                modificarTamaño();
            }
        }

        #region EVENTOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvDesagrupados.Visible == false)
            {
                AgregarAgrupados();
            }
            else
            {
                AgregarDesgrupados();
            }

        }

        private void btnDesagrupados_Click(object sender, EventArgs e)
        {
            limpiarAgrupados();
            habilitarDesagrupados();
            Button[] btns = { btnAgrupados, btnDesagrupados };
            colorButtons(btns, btnDesagrupados, Color.FromArgb(25, 84, 185), Color.FromArgb(30, 144, 255));
        }

        private void btnAgrupados_Click(object sender, EventArgs e)
        {
            limpiarDesagrupados();
            habilitarAgrupados();
            Button[] btns = { btnAgrupados, btnDesagrupados };
            colorButtons(btns, btnAgrupados, Color.FromArgb(25, 84, 185), Color.FromArgb(30, 144, 255));
        }

        private void colorButtons(Button[] buttons, Button btn, Color colDes, Color colSelected)
        {
            foreach (Button button in buttons)
            {
                button.BackColor = colDes;
                button.ForeColor = Color.DimGray;
            }

            btn.BackColor = colSelected;
            btn.ForeColor = Color.White;
            lblDatosMensaje.Visible = false;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAgrupados.Visible == false)
                {
                    Desagrupados();
                }
                else
                {
                    Agrupados();
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Error en los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (dgvAgrupados.Visible == false)
            {
                limpiarDesagrupados();
            }
            else
            {
                limpiarAgrupados();
            }
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Crimson;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el tipo de gráfico seleccionado en el ComboBox
            SeriesChartType chartTypeSeleccionado = (SeriesChartType)cmbTipoGrafico.SelectedItem;

            // Aplicar el tipo de gráfico seleccionado a la serie de chartDatos
            if (chartDatos.Series.Count > 0)
            {
                chartDatos.Series[0].ChartType = chartTypeSeleccionado;
                if (chartTypeSeleccionado == SeriesChartType.Doughnut  || chartTypeSeleccionado == SeriesChartType.Pie || chartTypeSeleccionado == SeriesChartType.Pyramid || chartTypeSeleccionado == SeriesChartType.Funnel)
                {
                    chartDatos.Palette = ChartColorPalette.Excel;
                }
                else
                {
                    Color[] colors = {Color.Crimson, Color.IndianRed };
                    chartDatos.Palette = ChartColorPalette.None;
                    chartDatos.PaletteCustomColors = colors;
                }
            }
        }

        #endregion

        #region FUNCIONES

        private void modificarTamaño()
        {
            this.Height = maxAltoPantalla;
            dgvAgrupados.Height = 90;
            dgvDesagrupados.Height = 90;
            chartDatos.Location = new Point(26, 454);
            cmbTipoGrafico.Location = new Point(26, 427);
            lblTipoGrafico.Location = new Point(22, 403);
        }

        private void CalcularEstadisticasAgrupadas()
        {

            List<double> datos = new List<double>();
            Dictionary<double, int> frecuencias = new Dictionary<double, int>();

            foreach (DataGridViewRow row in dgvAgrupados.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    double valor;
                    if (double.TryParse(row.Cells[0].Value.ToString(), out valor))
                    {
                        int frecuencia = int.Parse(row.Cells[1].Value.ToString());

                        // Agregar valor al diccionario de frecuencias
                        if (frecuencias.ContainsKey(valor))
                        {
                            frecuencias[valor] += frecuencia;
                        }
                        else
                        {
                            frecuencias[valor] = frecuencia;
                        }

                        // Agregar cada valor según su frecuencia a la lista
                        for (int i = 0; i < frecuencia; i++)
                        {
                            datos.Add(valor);
                        }
                    }
                }
            }

            // Calcular moda
            double moda = CalcularModa(frecuencias);

            // Calcular mediana
            var mediana = datos.OrderBy(x => x).ToList();
            double medianaValor;
            if (mediana.Count % 2 == 0)
            {
                medianaValor = (mediana[mediana.Count / 2 - 1] + mediana[mediana.Count / 2]) / 2;
            }
            else
            {
                medianaValor = mediana[mediana.Count / 2];
            }

            // Calcular desviación estándar y coeficiente de variación
            double media = datos.Average();
            double sumatoria = datos.Sum(x => Math.Pow(x - media, 2));
            double desviacionEstandar = Math.Sqrt(sumatoria / (datos.Count - 1));
            double coeficienteVariacion = (desviacionEstandar / media) * 100;

            // Mostrar resultados
            lblEstadisticas.Visible = true;
            lblResultados.Visible = true;

            if (decimal.TryParse(desviacionEstandar.ToString(), out decimal desvEst) || decimal.TryParse(coeficienteVariacion.ToString(), out decimal coefVar))
            {
                lblEstadisticas.Text = $"◦ Moda: {moda}\n◦ Mediana: {medianaValor}\n◦ Desviación Estándar: {decimal.Round(decimal.Parse(desviacionEstandar.ToString()), 2)}\n◦ Coeficiente de Variación: {decimal.Round(decimal.Parse(coeficienteVariacion.ToString()), 2)}%";
            }
            else
            {
                lblEstadisticas.Text = $"◦ Moda: {moda}\n◦ Mediana: {medianaValor}\n◦ Desviación Estándar: {desviacionEstandar}\n◦ Coeficiente de Variación: {coeficienteVariacion}";
            }



            // Configurar el Chart para mostrar frecuencias
            chartDatos.Series.Clear();
            chartDatos.Titles.Clear();
            chartDatos.Series.Add("Frecuencia");
            chartDatos.Titles.Add("Frecuencias de Datos Agrupados");


            // Agregar puntos sin sobrescribir el color
            foreach (var item in frecuencias)
            {
                chartDatos.Series["Frecuencia"].Points.AddXY(item.Key, item.Value);
            }

            configurarChart(chartDatos);

        }

        private void CalcularEstadisticasDesagrupados()
        {
            List<double> datos = new List<double>();
            foreach (DataGridViewRow row in dgvDesagrupados.Rows)
            {
                if (double.TryParse(row.Cells[0].Value?.ToString(), out double valor))
                {
                    datos.Add(valor);
                }
            }

            if (datos.Count == 0)
            {
                MessageBox.Show("No hay datos para calcular.");
                return;
            }

            // Calcular moda
            double moda = datos.GroupBy(x => x)
                               .OrderByDescending(g => g.Count())
                               .First().Key;

            // Calcular mediana
            var datosOrdenados = datos.OrderBy(x => x).ToList();
            double mediana = (datosOrdenados.Count % 2 == 0)
                ? (datosOrdenados[datosOrdenados.Count / 2 - 1] + datosOrdenados[datosOrdenados.Count / 2]) / 2
                : datosOrdenados[datosOrdenados.Count / 2];

            // Calcular media
            double media = datos.Average();

            // Calcular desviación estándar
            double sumatoria = datos.Sum(x => Math.Pow(x - media, 2));
            double desviacionEstandar = Math.Sqrt(sumatoria / (datos.Count - 1));

            // Calcular coeficiente de variación
            double coeficienteVariacion = (desviacionEstandar / media) * 100;

            // Mostrar resultados en etiquetas
            lblEstadisticas.Visible = true;
            lblResultados.Visible = true;

            if (decimal.TryParse(desviacionEstandar.ToString(), out decimal desvEst) || decimal.TryParse(coeficienteVariacion.ToString(), out decimal coefVar))
            {
                lblEstadisticas.Text = $"◦ Moda: {moda}\n◦ Mediana: {mediana}\n◦ Desviación Estándar: {decimal.Round(decimal.Parse(desviacionEstandar.ToString()), 2)}\n◦ Coeficiente de Variación: {decimal.Round(decimal.Parse(coeficienteVariacion.ToString()), 2)}%";
            }
            else
            {
                lblEstadisticas.Text = $"◦ Moda: {moda}\n◦ Mediana: {mediana}\n◦ Desviación Estándar: {desviacionEstandar}\n◦ Coeficiente de Variación: {coeficienteVariacion}%";
            }


            // Configurar el Chart para mostrar las frecuencias de los datos desagrupados

            chartDatos.Series.Clear();
            chartDatos.Titles.Clear();
            chartDatos.Series.Add("Frecuencia");
            chartDatos.Titles.Add("Frecuencias de Datos Agrupados");

            // Agrupar datos y añadir frecuencias al Chart
            var frecuencias = datos.GroupBy(x => x)
                                   .Select(g => new { Valor = g.Key, Frecuencia = g.Count() });

            foreach (var item in frecuencias)
            {
                chartDatos.Series["Frecuencia"].Points.AddXY(item.Valor, item.Frecuencia);
            }

            configurarChart(chartDatos);

        }

        private void configurarChart(Chart Objchart)
        {
            Objchart.Titles[0].ForeColor = Color.White;
            Objchart.ChartAreas[0].BackColor = Color.FromArgb(35, 35, 42);
            Objchart.Series["Frecuencia"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            Objchart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            Objchart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            Objchart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            Objchart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            Objchart.Legends[0].BackColor = Color.FromArgb(35, 35, 42);
            Objchart.Legends[0].ForeColor = Color.White;
        }

        private double CalcularModa(Dictionary<double, int> frecuencias)
        {
            double moda = 0;
            int maxFrecuencia = 0;

            foreach (var par in frecuencias)
            {
                if (par.Value > maxFrecuencia)
                {
                    moda = par.Key;
                    maxFrecuencia = par.Value;
                }
            }

            return moda;
        }

        private void AgregarAgrupados()
        {
            txtValor.Text.Replace('.', ',');

            if (double.TryParse(txtValor.Text, out double Valor) && int.TryParse(txtFrecuencias.Text, out int Frecuencia))
            {
                dgvAgrupados.Rows.Add(Valor, Frecuencia);
                txtFrecuencias.Text = string.Empty;
                txtValor.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos", "Error al agregar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AgregarDesgrupados()
        {
            txtValor.Text = txtValor.Text.Replace('.', ',');

            if (double.TryParse(txtValor.Text, out double Valor))
            {
                dgvDesagrupados.Rows.Add(Valor);
                txtValor.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos", "Error al agregar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void habilitarAgrupados()
        {
            txtFrecuencias.Visible = true;
            lblFrecuencia.Visible = true;
            txtValor.Visible = true;
            lblValor.Visible = true;
            dgvAgrupados.Visible = true;
            dgvDesagrupados.Visible = false;
            lblAgrupados.Visible = true;
            lblDesagrupados.Visible = false;
            btnAgregar.Enabled = true;
            btnCalcular.Enabled = true;
            btnLimpiar.Enabled = true;
            txtFrecuencias.Enabled = true;
            txtValor.Enabled = true;
            lblValor.Enabled = true;
            lblFrecuencia.Enabled = true;
            
        }

        private void habilitarDesagrupados()
        {
            txtFrecuencias.Visible = false;
            lblFrecuencia.Visible = false;
            txtValor.Visible = true;
            lblValor.Visible = true;
            dgvAgrupados.Visible = false;
            dgvDesagrupados.Visible = true;
            lblAgrupados.Visible = false;
            lblDesagrupados.Visible = true;
            btnAgregar.Enabled = true;
            btnCalcular.Enabled = true;
            btnLimpiar.Enabled = true;
            txtFrecuencias.Enabled = true;
            txtValor.Enabled = true;
            lblValor.Enabled = true;
            lblFrecuencia.Enabled = true;
        }

        private void Agrupados()
        {
            if (dgvAgrupados.Rows.Count > 0)
            {
                CalcularEstadisticasAgrupadas();
                chartDatos.Visible = true;
                cmbTipoGrafico.Visible = true;
                lblTipoGrafico.Visible = true;
            }
            else
            {
                MessageBox.Show("Ingrese valores en la grilla", "Error al calcular los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Desagrupados()
        {
            if (dgvDesagrupados.Rows.Count > 0)
            {
                CalcularEstadisticasDesagrupados();
                chartDatos.Visible = true;
                cmbTipoGrafico.Visible = true;
                lblTipoGrafico.Visible = true;
            }
            else
            {
                MessageBox.Show("Ingrese valores en la grilla", "Error al calcular los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limpiarAgrupados()
        {
            dgvAgrupados.Rows.Clear();
            txtValor.Text = "";
            txtFrecuencias.Text = "";
            chartDatos.Visible = false;
            cmbTipoGrafico.Visible = false;
            lblTipoGrafico.Visible = false;
            lblEstadisticas.Visible = false;
            lblResultados.Visible = false;
        }

        private void limpiarDesagrupados()
        {
            dgvDesagrupados.Rows.Clear();
            txtValor.Text = "";
            chartDatos.Visible = false;
            cmbTipoGrafico.Visible = false;
            lblTipoGrafico.Visible = false;
            lblEstadisticas.Visible = false;
            lblResultados.Visible = false;
        }

        #endregion

        int maxAltoPantalla = Screen.PrimaryScreen.Bounds.Height;

    }
}


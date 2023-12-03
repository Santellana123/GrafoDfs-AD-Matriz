namespace GrafoDfs
{
    public partial class Form1 : Form
    {
        private Grafo grafo = new Grafo();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAgregarVertice_Click(object sender, EventArgs e)
        {
            int vertice;

            if (!string.IsNullOrWhiteSpace(txtVertice.Text) && int.TryParse(txtVertice.Text, out vertice))
            {
                grafo.AgregarVertice(vertice);
                ActualizarListBox();
                MostrarMatrizAdyacencia();
            }
            else
            {
                MessageBox.Show("Ingrese un n�mero v�lido para el v�rtice.");
            }

            txtVertice.Clear();
        }
        private void ActualizarListBox()
        {
            listGrafo.Items.Clear();

            foreach (var vertice in grafo.ObtenerVertices())
            {
                listGrafo.Items.Add($"V�rtice: {vertice}");
                foreach (var vecino in grafo.ObtenerVecinos(vertice))
                {
                    listGrafo.Items.Add($"  -> Vecino: {vecino}");
                }
            }

        }

        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            int origen, destino, peso;

            if (int.TryParse(txtOrigen.Text, out origen) && int.TryParse(txtDestino.Text, out destino) && int.TryParse(txtPeso.Text, out peso))
            {
                grafo.AgregarArista(origen, destino, peso);
                ActualizarListBox();
                MostrarMatrizAdyacencia();
            }
            else
            {
                MessageBox.Show("Ingrese n�meros v�lidos para el origen, destino y peso de la arista.");
            }

            txtOrigen.Clear();
            txtDestino.Clear();
            txtPeso.Clear();
        }

        private void btnEliminarVertice_Click(object sender, EventArgs e)
        {
            if (listGrafo.SelectedItem != null)
            {

                string[] partes = listGrafo.SelectedItem.ToString().Split(':');

                if (partes.Length >= 2 && int.TryParse(partes[1].Trim(), out int vertice))
                {
                    grafo.EliminarVertice(vertice);
                    ActualizarListBox();
                }
                else
                {
                    MessageBox.Show("Error al extraer el v�rtice seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un v�rtice para eliminar.");
            }
        }

        private void btnEncontrarCamino_Click(object sender, EventArgs e)
        {
            int origen, destino;

            if (int.TryParse(txtOrigen.Text, out origen) && int.TryParse(txtDestino.Text, out destino))
            {
                var resultadoDFS = grafo.DFS(origen, destino);

                // Obtener el mejor camino desde la tupla
                List<int> mejorCamino = resultadoDFS.mejorCamino;

                if (mejorCamino.Count > 0)
                {
                    string caminoStr = string.Join(" -> ", mejorCamino);

                   
                    int pesoTotal = CalcularPesoTotal(mejorCamino);

                    MessageBox.Show($"Mejor camino encontrado desde el v�rtice {origen} hasta el v�rtice {destino}: {caminoStr}\n" +
                                    $"Peso total del camino: {pesoTotal}");
                }
                else
                {
                    MessageBox.Show($"No se encontr� un camino desde el v�rtice {origen} hasta el v�rtice {destino}.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese n�meros v�lidos para el origen y destino del camino.");
            }

            txtOrigen.Clear();
            txtDestino.Clear();
        }
        private int CalcularPesoTotal(List<int> camino)
        {
            int pesoTotal = 0;

            for (int i = 0; i < camino.Count - 1; i++)
            {
                int origen = camino[i];
                int destino = camino[i + 1];


                foreach ((int vecino, int peso) in grafo.ObtenerVecinos(origen))
                {
                    if (vecino == destino)
                    {
                        pesoTotal += peso;
                        break;
                    }
                }
            }

            return pesoTotal;
        }
        private void MostrarMatrizAdyacencia()
        {
            List<string> matrizStrings = grafo.ObtenerMatrizAdyacencia();

            listBoxMatrizAdyacencia.Items.Clear();

            foreach (var row in matrizStrings)
            {
                listBoxMatrizAdyacencia.Items.Add(row);
            }
        }

        private void btnRecorridoDFS_Click(object sender, EventArgs e)
        {
            int origen;

            if (int.TryParse(txtOrigen.Text, out origen))
            {
                var resultadoDFS = grafo.DFS(origen, -1);

                if (resultadoDFS.pasos.Count > 0)
                {
                    listRecorridoDFS.Items.Clear();

                    for (int i = 0; i < resultadoDFS.pasos.Count; i++)
                    {
                        List<int> paso = resultadoDFS.pasos[i];
                        string pasoStr = string.Join(" -> ", paso);
                        listRecorridoDFS.Items.Add($"Paso {i + 1}: {pasoStr}");
                    }
                }
                else
                {
                    listRecorridoDFS.Items.Clear();
                    listRecorridoDFS.Items.Add($"No se encontr� un recorrido DFS desde el v�rtice {origen}.");
                }
            }
            else
            {
                listRecorridoDFS.Items.Clear();
                listRecorridoDFS.Items.Add("Ingrese un n�mero v�lido para el v�rtice de inicio del recorrido DFS.");
            }

            txtOrigen.Clear();
        }
    }
}
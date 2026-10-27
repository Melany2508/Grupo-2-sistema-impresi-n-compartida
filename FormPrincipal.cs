namespace ColaCircularWinForms;

public partial class FormPrincipal : Form
{
    private readonly ColaCircular _cola = new();
    private readonly Label[] _celdas;

    public FormPrincipal()
    {
        InitializeComponent();
        _celdas = [lblCelda0, lblCelda1, lblCelda2, lblCelda3, lblCelda4];

        btnAgregar.Click += (_, _) => AgregarDocumento();
        btnImprimir.Click += (_, _) => ImprimirSiguiente();
        btnPrueba.Click += (_, _) => CargarPrueba();
        btnSalir.Click += (_, _) => Close();
        ActualizarVista();
    }

    private void AgregarDocumento()
    {
        var nombre = txtDocumento.Text.Trim();
        if (nombre.Length == 0)
        {
            MessageBox.Show("Escribe el nombre del documento.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!_cola.Encolar(nombre))
        {
            MessageBox.Show("La cola está llena. Imprime un documento antes de agregar otro.", "Cola llena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        txtDocumento.Clear();
        ActualizarVista();
    }

    private void ImprimirSiguiente()
    {
        if (!_cola.IntentarImprimir(out var documento))
        {
            MessageBox.Show("No hay documentos pendientes.", "Cola vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        MessageBox.Show($"Documento enviado a impresión: {documento}", "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ActualizarVista();
    }

    private void CargarPrueba()
    {
        _cola.Limpiar();
        foreach (var documento in new[] { "A", "B", "C", "D", "E" }) _cola.Encolar(documento);
        _cola.IntentarImprimir(out _);
        _cola.IntentarImprimir(out _);
        _cola.Encolar("F");
        _cola.Encolar("G");
        ActualizarVista();
    }

    private void ActualizarVista()
    {
        for (int i = 0; i < ColaCircular.Capacidad; i++)
            _celdas[i].Text = _cola.Posiciones[i] ?? "(vacío)";

        lstOrden.Items.Clear();
        for (int i = 0; i < _cola.Cantidad; i++)
            lstOrden.Items.Add($"{i + 1}. {_cola.Posiciones[(_cola.IndiceFrente + i) % ColaCircular.Capacidad]}");

        lblEstado.Text = _cola.EstaVacia
            ? "Estado: COLA VACÍA"
            : _cola.EstaLlena
                ? "Estado: COLA LLENA"
                : $"Pendientes: {_cola.Cantidad} / {ColaCircular.Capacidad}    ·    Frente: {_cola.IndiceFrente}    ·    Siguiente posición de inserción: {_cola.IndiceSiguienteInsercion}";
        lblEstado.ForeColor = _cola.EstaLlena ? Color.DarkRed : Color.FromArgb(40, 75, 90);
    }

    private void lblCelda4_Click(object sender, EventArgs e)
    {

    }
}

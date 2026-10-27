#nullable enable

namespace ColaCircularWinForms;

partial class FormPrincipal
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!;
    private Label lblSubtitulo = null!;
    private GroupBox grpArreglo = null!;
    private Panel panelCelda0 = null!;
    private Panel panelCelda1 = null!;
    private Panel panelCelda2 = null!;
    private Panel panelCelda3 = null!;
    private Panel panelCelda4 = null!;
    private Label lblIndice0 = null!;
    private Label lblIndice1 = null!;
    private Label lblIndice2 = null!;
    private Label lblIndice3 = null!;
    private Label lblIndice4 = null!;
    private Label lblCelda0 = null!;
    private Label lblCelda1 = null!;
    private Label lblCelda2 = null!;
    private Label lblCelda3 = null!;
    private Label lblCelda4 = null!;
    private GroupBox grpOperaciones = null!;
    private Label lblNombreDocumento = null!;
    private TextBox txtDocumento = null!;
    private Button btnAgregar = null!;
    private Button btnImprimir = null!;
    private Button btnPrueba = null!;
    private Button btnSalir = null!;
    private GroupBox grpOrden = null!;
    private ListBox lstOrden = null!;
    private Label lblEstado = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblSubtitulo = new Label();
        grpArreglo = new GroupBox();
        panelCelda0 = new Panel();
        lblCelda0 = new Label();
        lblIndice0 = new Label();
        panelCelda1 = new Panel();
        lblCelda1 = new Label();
        lblIndice1 = new Label();
        panelCelda2 = new Panel();
        lblCelda2 = new Label();
        lblIndice2 = new Label();
        panelCelda3 = new Panel();
        lblCelda3 = new Label();
        lblIndice3 = new Label();
        panelCelda4 = new Panel();
        lblCelda4 = new Label();
        lblIndice4 = new Label();
        grpOperaciones = new GroupBox();
        lblNombreDocumento = new Label();
        txtDocumento = new TextBox();
        btnAgregar = new Button();
        btnImprimir = new Button();
        btnPrueba = new Button();
        btnSalir = new Button();
        grpOrden = new GroupBox();
        lstOrden = new ListBox();
        lblEstado = new Label();
        grpArreglo.SuspendLayout();
        panelCelda0.SuspendLayout();
        panelCelda1.SuspendLayout();
        panelCelda2.SuspendLayout();
        panelCelda3.SuspendLayout();
        panelCelda4.SuspendLayout();
        grpOperaciones.SuspendLayout();
        grpOrden.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitulo.Location = new Point(12, 9);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(332, 41);
        lblTitulo.TabIndex = 5;
        lblTitulo.Text = "Impresora compartida";
        // 
        // lblSubtitulo
        // 
        lblSubtitulo.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        lblSubtitulo.ForeColor = Color.Black;
        lblSubtitulo.Location = new Point(31, 69);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(724, 30);
        lblSubtitulo.TabIndex = 4;
        lblSubtitulo.Text = "Cola circular de capacidad fija: 5 documentos";
        lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblSubtitulo.UseCompatibleTextRendering = true;
        // 
        // grpArreglo
        // 
        grpArreglo.BackColor = Color.FromArgb(192, 192, 255);
        grpArreglo.Controls.Add(panelCelda0);
        grpArreglo.Controls.Add(panelCelda1);
        grpArreglo.Controls.Add(panelCelda2);
        grpArreglo.Controls.Add(panelCelda3);
        grpArreglo.Controls.Add(panelCelda4);
        grpArreglo.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        grpArreglo.Location = new Point(28, 108);
        grpArreglo.Name = "grpArreglo";
        grpArreglo.Size = new Size(724, 155);
        grpArreglo.TabIndex = 3;
        grpArreglo.TabStop = false;
        grpArreglo.Text = "Arreglo físico";
        // 
        // panelCelda0
        // 
        panelCelda0.BackColor = Color.FromArgb(192, 255, 255);
        panelCelda0.BorderStyle = BorderStyle.FixedSingle;
        panelCelda0.Controls.Add(lblCelda0);
        panelCelda0.Controls.Add(lblIndice0);
        panelCelda0.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        panelCelda0.Location = new Point(20, 38);
        panelCelda0.Name = "panelCelda0";
        panelCelda0.Size = new Size(120, 88);
        panelCelda0.TabIndex = 0;
        // 
        // lblCelda0
        // 
        lblCelda0.Dock = DockStyle.Fill;
        lblCelda0.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic);
        lblCelda0.ForeColor = Color.Navy;
        lblCelda0.Location = new Point(0, 23);
        lblCelda0.Name = "lblCelda0";
        lblCelda0.Size = new Size(118, 63);
        lblCelda0.TabIndex = 0;
        lblCelda0.Text = "(vacío)";
        lblCelda0.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblIndice0
        // 
        lblIndice0.Dock = DockStyle.Top;
        lblIndice0.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic);
        lblIndice0.Location = new Point(0, 0);
        lblIndice0.Name = "lblIndice0";
        lblIndice0.Size = new Size(118, 23);
        lblIndice0.TabIndex = 0;
        lblIndice0.Text = "Índice 0";
        lblIndice0.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panelCelda1
        // 
        panelCelda1.BackColor = Color.FromArgb(192, 255, 255);
        panelCelda1.BorderStyle = BorderStyle.FixedSingle;
        panelCelda1.Controls.Add(lblCelda1);
        panelCelda1.Controls.Add(lblIndice1);
        panelCelda1.Location = new Point(157, 38);
        panelCelda1.Name = "panelCelda1";
        panelCelda1.Size = new Size(120, 88);
        panelCelda1.TabIndex = 1;
        // 
        // lblCelda1
        // 
        lblCelda1.Dock = DockStyle.Fill;
        lblCelda1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic);
        lblCelda1.ForeColor = Color.Navy;
        lblCelda1.Location = new Point(0, 23);
        lblCelda1.Name = "lblCelda1";
        lblCelda1.Size = new Size(118, 63);
        lblCelda1.TabIndex = 0;
        lblCelda1.Text = "(vacío)";
        lblCelda1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblIndice1
        // 
        lblIndice1.Dock = DockStyle.Top;
        lblIndice1.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic);
        lblIndice1.Location = new Point(0, 0);
        lblIndice1.Name = "lblIndice1";
        lblIndice1.Size = new Size(118, 23);
        lblIndice1.TabIndex = 0;
        lblIndice1.Text = "Índice 1";
        lblIndice1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panelCelda2
        // 
        panelCelda2.BackColor = Color.FromArgb(192, 255, 255);
        panelCelda2.BorderStyle = BorderStyle.FixedSingle;
        panelCelda2.Controls.Add(lblCelda2);
        panelCelda2.Controls.Add(lblIndice2);
        panelCelda2.Location = new Point(294, 38);
        panelCelda2.Name = "panelCelda2";
        panelCelda2.Size = new Size(120, 88);
        panelCelda2.TabIndex = 2;
        // 
        // lblCelda2
        // 
        lblCelda2.Dock = DockStyle.Fill;
        lblCelda2.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic);
        lblCelda2.ForeColor = Color.Navy;
        lblCelda2.Location = new Point(0, 23);
        lblCelda2.Name = "lblCelda2";
        lblCelda2.Size = new Size(118, 63);
        lblCelda2.TabIndex = 0;
        lblCelda2.Text = "(vacío)";
        lblCelda2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblIndice2
        // 
        lblIndice2.Dock = DockStyle.Top;
        lblIndice2.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic);
        lblIndice2.Location = new Point(0, 0);
        lblIndice2.Name = "lblIndice2";
        lblIndice2.Size = new Size(118, 23);
        lblIndice2.TabIndex = 0;
        lblIndice2.Text = "Índice 2";
        lblIndice2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panelCelda3
        // 
        panelCelda3.BackColor = Color.FromArgb(192, 255, 255);
        panelCelda3.BorderStyle = BorderStyle.FixedSingle;
        panelCelda3.Controls.Add(lblCelda3);
        panelCelda3.Controls.Add(lblIndice3);
        panelCelda3.Location = new Point(431, 38);
        panelCelda3.Name = "panelCelda3";
        panelCelda3.Size = new Size(120, 88);
        panelCelda3.TabIndex = 3;
        // 
        // lblCelda3
        // 
        lblCelda3.Dock = DockStyle.Fill;
        lblCelda3.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic);
        lblCelda3.ForeColor = Color.Navy;
        lblCelda3.Location = new Point(0, 23);
        lblCelda3.Name = "lblCelda3";
        lblCelda3.Size = new Size(118, 63);
        lblCelda3.TabIndex = 0;
        lblCelda3.Text = "(vacío)";
        lblCelda3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblIndice3
        // 
        lblIndice3.Dock = DockStyle.Top;
        lblIndice3.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic);
        lblIndice3.Location = new Point(0, 0);
        lblIndice3.Name = "lblIndice3";
        lblIndice3.Size = new Size(118, 23);
        lblIndice3.TabIndex = 0;
        lblIndice3.Text = "Índice 3";
        lblIndice3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panelCelda4
        // 
        panelCelda4.BackColor = Color.FromArgb(192, 255, 255);
        panelCelda4.BorderStyle = BorderStyle.FixedSingle;
        panelCelda4.Controls.Add(lblCelda4);
        panelCelda4.Controls.Add(lblIndice4);
        panelCelda4.Location = new Point(568, 38);
        panelCelda4.Name = "panelCelda4";
        panelCelda4.Size = new Size(120, 88);
        panelCelda4.TabIndex = 4;
        // 
        // lblCelda4
        // 
        lblCelda4.Dock = DockStyle.Fill;
        lblCelda4.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic);
        lblCelda4.ForeColor = Color.Navy;
        lblCelda4.Location = new Point(0, 23);
        lblCelda4.Name = "lblCelda4";
        lblCelda4.Size = new Size(118, 63);
        lblCelda4.TabIndex = 0;
        lblCelda4.Text = "(vacío)";
        lblCelda4.TextAlign = ContentAlignment.MiddleCenter;
        lblCelda4.Click += lblCelda4_Click;
        // 
        // lblIndice4
        // 
        lblIndice4.Dock = DockStyle.Top;
        lblIndice4.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic);
        lblIndice4.Location = new Point(0, 0);
        lblIndice4.Name = "lblIndice4";
        lblIndice4.Size = new Size(118, 23);
        lblIndice4.TabIndex = 0;
        lblIndice4.Text = "Índice 4";
        lblIndice4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // grpOperaciones
        // 
        grpOperaciones.Controls.Add(lblNombreDocumento);
        grpOperaciones.Controls.Add(txtDocumento);
        grpOperaciones.Controls.Add(btnAgregar);
        grpOperaciones.Controls.Add(btnImprimir);
        grpOperaciones.Controls.Add(btnPrueba);
        grpOperaciones.Controls.Add(btnSalir);
        grpOperaciones.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        grpOperaciones.Location = new Point(12, 278);
        grpOperaciones.Name = "grpOperaciones";
        grpOperaciones.Size = new Size(366, 284);
        grpOperaciones.TabIndex = 2;
        grpOperaciones.TabStop = false;
        grpOperaciones.Text = "Operaciones";
        // 
        // lblNombreDocumento
        // 
        lblNombreDocumento.AutoSize = true;
        lblNombreDocumento.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        lblNombreDocumento.Location = new Point(18, 31);
        lblNombreDocumento.Name = "lblNombreDocumento";
        lblNombreDocumento.Size = new Size(163, 19);
        lblNombreDocumento.TabIndex = 0;
        lblNombreDocumento.Text = "Nombre del documento";
        // 
        // txtDocumento
        // 
        txtDocumento.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        txtDocumento.Location = new Point(20, 57);
        txtDocumento.Name = "txtDocumento";
        txtDocumento.PlaceholderText = "Ejemplo: Informe.pdf";
        txtDocumento.Size = new Size(309, 26);
        txtDocumento.TabIndex = 1;
        // 
        // btnAgregar
        // 
        btnAgregar.BackColor = Color.Red;
        btnAgregar.FlatStyle = FlatStyle.Flat;
        btnAgregar.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        btnAgregar.ForeColor = Color.White;
        btnAgregar.Location = new Point(20, 99);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new Size(309, 48);
        btnAgregar.TabIndex = 2;
        btnAgregar.Text = "Agregar a la cola";
        btnAgregar.UseVisualStyleBackColor = false;
        // 
        // btnImprimir
        // 
        btnImprimir.BackColor = Color.FromArgb(128, 128, 255);
        btnImprimir.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        btnImprimir.Location = new Point(18, 162);
        btnImprimir.Name = "btnImprimir";
        btnImprimir.Size = new Size(149, 42);
        btnImprimir.TabIndex = 3;
        btnImprimir.Text = "Imprimir siguiente";
        btnImprimir.UseVisualStyleBackColor = false;
        // 
        // btnPrueba
        // 
        btnPrueba.BackColor = Color.FromArgb(255, 128, 255);
        btnPrueba.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        btnPrueba.Location = new Point(174, 162);
        btnPrueba.Name = "btnPrueba";
        btnPrueba.Size = new Size(158, 50);
        btnPrueba.TabIndex = 4;
        btnPrueba.Text = "Cargar prueba A–G";
        btnPrueba.UseVisualStyleBackColor = false;
        // 
        // btnSalir
        // 
        btnSalir.BackColor = Color.FromArgb(192, 0, 0);
        btnSalir.FlatStyle = FlatStyle.Flat;
        btnSalir.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        btnSalir.ForeColor = Color.White;
        btnSalir.Location = new Point(16, 218);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(313, 49);
        btnSalir.TabIndex = 5;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = false;
        // 
        // grpOrden
        // 
        grpOrden.Controls.Add(lstOrden);
        grpOrden.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        grpOrden.Location = new Point(394, 278);
        grpOrden.Name = "grpOrden";
        grpOrden.Size = new Size(358, 245);
        grpOrden.TabIndex = 1;
        grpOrden.TabStop = false;
        grpOrden.Text = "Orden de impresión (frente → final)";
        // 
        // lstOrden
        // 
        lstOrden.BackColor = Color.FromArgb(255, 255, 192);
        lstOrden.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lstOrden.FormattingEnabled = true;
        lstOrden.Location = new Point(18, 29);
        lstOrden.Name = "lstOrden";
        lstOrden.Size = new Size(324, 172);
        lstOrden.TabIndex = 0;
        // 
        // lblEstado
        // 
        lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblEstado.Location = new Point(30, 537);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(715, 25);
        lblEstado.TabIndex = 0;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.RosyBrown;
        ClientSize = new Size(1355, 620);
        Controls.Add(lblEstado);
        Controls.Add(grpOrden);
        Controls.Add(grpOperaciones);
        Controls.Add(grpArreglo);
        Controls.Add(lblSubtitulo);
        Controls.Add(lblTitulo);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(700, 580);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ColaCircularGrupo2 | Impresora compartida";
        grpArreglo.ResumeLayout(false);
        panelCelda0.ResumeLayout(false);
        panelCelda1.ResumeLayout(false);
        panelCelda2.ResumeLayout(false);
        panelCelda3.ResumeLayout(false);
        panelCelda4.ResumeLayout(false);
        grpOperaciones.ResumeLayout(false);
        grpOperaciones.PerformLayout();
        grpOrden.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

}

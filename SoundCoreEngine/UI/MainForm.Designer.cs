namespace SoundCoreEngine
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelRegistro = new FlowLayoutPanel();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblArtista = new Label();
            txtArtista = new TextBox();
            lblBpm = new Label();
            numBpm = new NumericUpDown();
            lblDuracion = new Label();
            numDuracion = new NumericUpDown();
            rbPropia = new RadioButton();
            rbLinkedList = new RadioButton();
            rbList = new RadioButton();
            btnCargarArchivos = new Button();
            panelAcciones = new FlowLayoutPanel();
            btnEncolarFinal = new Button();
            btnReproducirSiguiente = new Button();
            btnAvanzar = new Button();
            btnInvertir = new Button();
            btnOrdenarBpm = new Button();
            btnPurgar = new Button();
            panelPlaylist = new Panel();
            dgvCola = new DataGridView();
            lblNowPlaying = new Label();
            panelTransporte = new FlowLayoutPanel();
            btnPlay = new Button();
            btnPause = new Button();
            btnStop = new Button();
            progressBarPlayback = new ProgressBar();
            lblTiempoTranscurrido = new Label();
            lblEstadisticas = new Label();
            playbackTimer = new System.Windows.Forms.Timer(components);
            panelBenchmark = new TableLayoutPanel();
            lblBenchmark = new Label();
            txtResultadosBenchmark = new TextBox();
            btnBenchmark = new Button();
            numInseccionesBenchmark = new NumericUpDown();
            panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBpm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            panelAcciones.SuspendLayout();
            panelPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCola).BeginInit();
            panelTransporte.SuspendLayout();
            panelBenchmark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numInseccionesBenchmark).BeginInit();
            SuspendLayout();
            // 
            // panelRegistro
            // 
            panelRegistro.BackColor = Color.FromArgb(18, 10, 12);
            panelRegistro.Controls.Add(lblTitulo);
            panelRegistro.Controls.Add(txtTitulo);
            panelRegistro.Controls.Add(lblArtista);
            panelRegistro.Controls.Add(txtArtista);
            panelRegistro.Controls.Add(lblBpm);
            panelRegistro.Controls.Add(numBpm);
            panelRegistro.Controls.Add(lblDuracion);
            panelRegistro.Controls.Add(numDuracion);
            panelRegistro.Controls.Add(rbPropia);
            panelRegistro.Controls.Add(rbLinkedList);
            panelRegistro.Controls.Add(rbList);
            panelRegistro.Controls.Add(btnCargarArchivos);
            panelRegistro.Dock = DockStyle.Top;
            panelRegistro.Location = new Point(0, 0);
            panelRegistro.Margin = new Padding(3, 4, 3, 4);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Padding = new Padding(11, 13, 11, 13);
            panelRegistro.Size = new Size(1902, 133);
            panelRegistro.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.ForeColor = Color.FromArgb(139, 149, 161);
            lblTitulo.Location = new Point(14, 24);
            lblTitulo.Margin = new Padding(3, 11, 3, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(50, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(45, 51, 59);
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.ForeColor = Color.FromArgb(216, 221, 227);
            txtTitulo.Location = new Point(70, 17);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(183, 27);
            txtTitulo.TabIndex = 1;
            // 
            // lblArtista
            // 
            lblArtista.AutoSize = true;
            lblArtista.ForeColor = Color.FromArgb(139, 149, 161);
            lblArtista.Location = new Point(267, 24);
            lblArtista.Margin = new Padding(11, 11, 3, 4);
            lblArtista.Name = "lblArtista";
            lblArtista.Size = new Size(55, 20);
            lblArtista.TabIndex = 2;
            lblArtista.Text = "Artista:";
            // 
            // txtArtista
            // 
            txtArtista.BackColor = Color.FromArgb(45, 51, 59);
            txtArtista.BorderStyle = BorderStyle.FixedSingle;
            txtArtista.ForeColor = Color.FromArgb(216, 221, 227);
            txtArtista.Location = new Point(328, 17);
            txtArtista.Margin = new Padding(3, 4, 3, 4);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(183, 27);
            txtArtista.TabIndex = 3;
            // 
            // lblBpm
            // 
            lblBpm.AutoSize = true;
            lblBpm.ForeColor = Color.FromArgb(139, 149, 161);
            lblBpm.Location = new Point(525, 24);
            lblBpm.Margin = new Padding(11, 11, 3, 4);
            lblBpm.Name = "lblBpm";
            lblBpm.Size = new Size(42, 20);
            lblBpm.TabIndex = 4;
            lblBpm.Text = "BPM:";
            // 
            // numBpm
            // 
            numBpm.BackColor = Color.FromArgb(45, 51, 59);
            numBpm.BorderStyle = BorderStyle.FixedSingle;
            numBpm.ForeColor = Color.FromArgb(216, 221, 227);
            numBpm.Location = new Point(573, 17);
            numBpm.Margin = new Padding(3, 4, 3, 4);
            numBpm.Maximum = new decimal(new int[] { 220, 0, 0, 0 });
            numBpm.Minimum = new decimal(new int[] { 60, 0, 0, 0 });
            numBpm.Name = "numBpm";
            numBpm.Size = new Size(69, 27);
            numBpm.TabIndex = 5;
            numBpm.Value = new decimal(new int[] { 124, 0, 0, 0 });
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.ForeColor = Color.FromArgb(139, 149, 161);
            lblDuracion.Location = new Point(656, 24);
            lblDuracion.Margin = new Padding(11, 11, 3, 4);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(88, 20);
            lblDuracion.TabIndex = 6;
            lblDuracion.Text = "Duración(s):";
            // 
            // numDuracion
            // 
            numDuracion.BackColor = Color.FromArgb(45, 51, 59);
            numDuracion.BorderStyle = BorderStyle.FixedSingle;
            numDuracion.ForeColor = Color.FromArgb(216, 221, 227);
            numDuracion.Location = new Point(750, 17);
            numDuracion.Margin = new Padding(3, 4, 3, 4);
            numDuracion.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            numDuracion.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(80, 27);
            numDuracion.TabIndex = 7;
            numDuracion.Value = new decimal(new int[] { 210, 0, 0, 0 });
            // 
            // rbPropia
            // 
            rbPropia.AutoSize = true;
            rbPropia.Checked = true;
            rbPropia.ForeColor = Color.FromArgb(139, 149, 161);
            rbPropia.Location = new Point(856, 24);
            rbPropia.Margin = new Padding(23, 11, 3, 4);
            rbPropia.Name = "rbPropia";
            rbPropia.Size = new Size(215, 24);
            rbPropia.TabIndex = 8;
            rbPropia.TabStop = true;
            rbPropia.Text = "Lista Simple Propia (Nodos)";
            rbPropia.UseVisualStyleBackColor = true;
            rbPropia.CheckedChanged += RadioEstructura_CheckedChanged;
            // 
            // rbLinkedList
            // 
            rbLinkedList.AutoSize = true;
            rbLinkedList.ForeColor = Color.FromArgb(139, 149, 161);
            rbLinkedList.Location = new Point(1085, 24);
            rbLinkedList.Margin = new Padding(11, 11, 3, 4);
            rbLinkedList.Name = "rbLinkedList";
            rbLinkedList.Size = new Size(157, 24);
            rbLinkedList.TabIndex = 9;
            rbLinkedList.Text = ".NET LinkedList<T>";
            rbLinkedList.UseVisualStyleBackColor = true;
            rbLinkedList.CheckedChanged += RadioEstructura_CheckedChanged;
            // 
            // rbList
            // 
            rbList.AutoSize = true;
            rbList.ForeColor = Color.FromArgb(139, 149, 161);
            rbList.Location = new Point(1256, 24);
            rbList.Margin = new Padding(11, 11, 3, 4);
            rbList.Name = "rbList";
            rbList.Size = new Size(114, 24);
            rbList.TabIndex = 10;
            rbList.Text = ".NET List<T>";
            rbList.UseVisualStyleBackColor = true;
            rbList.CheckedChanged += RadioEstructura_CheckedChanged;
            // 
            // btnCargarArchivos
            // 
            btnCargarArchivos.AutoSize = true;
            btnCargarArchivos.BackColor = Color.FromArgb(45, 51, 59);
            btnCargarArchivos.FlatAppearance.BorderSize = 0;
            btnCargarArchivos.FlatStyle = FlatStyle.Flat;
            btnCargarArchivos.ForeColor = Color.FromArgb(216, 221, 227);
            btnCargarArchivos.Location = new Point(1390, 20);
            btnCargarArchivos.Margin = new Padding(17, 7, 3, 4);
            btnCargarArchivos.Name = "btnCargarArchivos";
            btnCargarArchivos.Size = new Size(179, 40);
            btnCargarArchivos.TabIndex = 11;
            btnCargarArchivos.Text = "📁 Cargar Archivos...";
            btnCargarArchivos.UseVisualStyleBackColor = false;
            btnCargarArchivos.Click += btnCargarArchivos_Click;
            // 
            // panelAcciones
            // 
            panelAcciones.BackColor = Color.FromArgb(18, 10, 12);
            panelAcciones.Controls.Add(btnEncolarFinal);
            panelAcciones.Controls.Add(btnReproducirSiguiente);
            panelAcciones.Controls.Add(btnAvanzar);
            panelAcciones.Controls.Add(btnInvertir);
            panelAcciones.Controls.Add(btnOrdenarBpm);
            panelAcciones.Controls.Add(btnPurgar);
            panelAcciones.Dock = DockStyle.Left;
            panelAcciones.FlowDirection = FlowDirection.TopDown;
            panelAcciones.Location = new Point(0, 133);
            panelAcciones.Margin = new Padding(3, 4, 3, 4);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Padding = new Padding(11, 13, 11, 13);
            panelAcciones.Size = new Size(251, 660);
            panelAcciones.TabIndex = 1;
            panelAcciones.WrapContents = false;
            // 
            // btnEncolarFinal
            // 
            btnEncolarFinal.BackColor = Color.FromArgb(38, 18, 24);
            btnEncolarFinal.FlatAppearance.BorderSize = 0;
            btnEncolarFinal.FlatStyle = FlatStyle.Flat;
            btnEncolarFinal.ForeColor = Color.FromArgb(250, 240, 242);
            btnEncolarFinal.Location = new Point(14, 17);
            btnEncolarFinal.Margin = new Padding(3, 4, 3, 4);
            btnEncolarFinal.Name = "btnEncolarFinal";
            btnEncolarFinal.Size = new Size(217, 43);
            btnEncolarFinal.TabIndex = 0;
            btnEncolarFinal.Text = "+ Encolar al Final";
            btnEncolarFinal.UseVisualStyleBackColor = false;
            btnEncolarFinal.Click += btnEncolarFinal_Click;
            // 
            // btnReproducirSiguiente
            // 
            btnReproducirSiguiente.BackColor = Color.FromArgb(38, 18, 24);
            btnReproducirSiguiente.FlatAppearance.BorderSize = 0;
            btnReproducirSiguiente.FlatStyle = FlatStyle.Flat;
            btnReproducirSiguiente.ForeColor = Color.FromArgb(216, 221, 227);
            btnReproducirSiguiente.Location = new Point(14, 68);
            btnReproducirSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnReproducirSiguiente.Name = "btnReproducirSiguiente";
            btnReproducirSiguiente.Size = new Size(217, 43);
            btnReproducirSiguiente.TabIndex = 1;
            btnReproducirSiguiente.Text = "⏭ Reproducir Siguiente";
            btnReproducirSiguiente.UseVisualStyleBackColor = false;
            btnReproducirSiguiente.Click += btnReproducirSiguiente_Click;
            // 
            // btnAvanzar
            // 
            btnAvanzar.BackColor = Color.FromArgb(38, 18, 24);
            btnAvanzar.FlatAppearance.BorderSize = 0;
            btnAvanzar.FlatStyle = FlatStyle.Flat;
            btnAvanzar.ForeColor = Color.FromArgb(216, 221, 227);
            btnAvanzar.Location = new Point(14, 119);
            btnAvanzar.Margin = new Padding(3, 4, 3, 4);
            btnAvanzar.Name = "btnAvanzar";
            btnAvanzar.Size = new Size(217, 43);
            btnAvanzar.TabIndex = 2;
            btnAvanzar.Text = "⏩ Avanzar Pista";
            btnAvanzar.UseVisualStyleBackColor = false;
            btnAvanzar.Click += btnAvanzar_Click;
            // 
            // btnInvertir
            // 
            btnInvertir.BackColor = Color.FromArgb(38, 18, 24);
            btnInvertir.FlatAppearance.BorderSize = 0;
            btnInvertir.FlatStyle = FlatStyle.Flat;
            btnInvertir.ForeColor = Color.FromArgb(216, 221, 227);
            btnInvertir.Location = new Point(14, 170);
            btnInvertir.Margin = new Padding(3, 4, 3, 4);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(217, 43);
            btnInvertir.TabIndex = 3;
            btnInvertir.Text = "⇅ Invertir Lista (In-Place)";
            btnInvertir.UseVisualStyleBackColor = false;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // btnOrdenarBpm
            // 
            btnOrdenarBpm.BackColor = Color.FromArgb(38, 18, 24);
            btnOrdenarBpm.FlatAppearance.BorderSize = 0;
            btnOrdenarBpm.FlatStyle = FlatStyle.Flat;
            btnOrdenarBpm.ForeColor = Color.FromArgb(216, 221, 227);
            btnOrdenarBpm.Location = new Point(14, 221);
            btnOrdenarBpm.Margin = new Padding(3, 4, 3, 4);
            btnOrdenarBpm.Name = "btnOrdenarBpm";
            btnOrdenarBpm.Size = new Size(217, 43);
            btnOrdenarBpm.TabIndex = 4;
            btnOrdenarBpm.Text = "⚡ Ordenar por Curva BPM";
            btnOrdenarBpm.UseVisualStyleBackColor = false;
            btnOrdenarBpm.Click += btnOrdenarBpm_Click;
            // 
            // btnPurgar
            // 
            btnPurgar.BackColor = Color.FromArgb(38, 18, 24);
            btnPurgar.FlatAppearance.BorderSize = 0;
            btnPurgar.FlatStyle = FlatStyle.Flat;
            btnPurgar.ForeColor = Color.FromArgb(216, 221, 227);
            btnPurgar.Location = new Point(14, 272);
            btnPurgar.Margin = new Padding(3, 4, 3, 4);
            btnPurgar.Name = "btnPurgar";
            btnPurgar.Size = new Size(217, 43);
            btnPurgar.TabIndex = 5;
            btnPurgar.Text = "\U0001f9f9 Purgar Duplicados";
            btnPurgar.UseVisualStyleBackColor = false;
            btnPurgar.Click += btnPurgar_Click;
            // 
            // panelPlaylist
            // 
            panelPlaylist.BackColor = Color.FromArgb(34, 39, 46);
            panelPlaylist.Controls.Add(dgvCola);
            panelPlaylist.Controls.Add(lblNowPlaying);
            panelPlaylist.Controls.Add(panelTransporte);
            panelPlaylist.Controls.Add(lblEstadisticas);
            panelPlaylist.Dock = DockStyle.Fill;
            panelPlaylist.Location = new Point(251, 133);
            panelPlaylist.Margin = new Padding(3, 4, 3, 4);
            panelPlaylist.Name = "panelPlaylist";
            panelPlaylist.Size = new Size(1651, 660);
            panelPlaylist.TabIndex = 2;
            // 
            // dgvCola
            // 
            dgvCola.AllowUserToAddRows = false;
            dgvCola.AllowUserToDeleteRows = false;
            dgvCola.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCola.BackgroundColor = Color.FromArgb(38, 18, 24);
            dgvCola.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 51, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(139, 149, 161);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCola.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCola.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 39, 46);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(216, 221, 227);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 51, 59);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(63, 208, 201);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCola.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCola.EnableHeadersVisualStyles = false;
            dgvCola.GridColor = Color.FromArgb(58, 65, 75);
            dgvCola.Location = new Point(0, 93);
            dgvCola.Margin = new Padding(3, 4, 3, 4);
            dgvCola.Name = "dgvCola";
            dgvCola.ReadOnly = true;
            dgvCola.RowHeadersWidth = 51;
            dgvCola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCola.Size = new Size(1651, 535);
            dgvCola.TabIndex = 0;
            // 
            // lblNowPlaying
            // 
            lblNowPlaying.BackColor = Color.FromArgb(38, 18, 24);
            lblNowPlaying.Dock = DockStyle.Top;
            lblNowPlaying.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNowPlaying.ForeColor = Color.FromArgb(168, 140, 148);
            lblNowPlaying.Location = new Point(0, 0);
            lblNowPlaying.Name = "lblNowPlaying";
            lblNowPlaying.Size = new Size(1651, 40);
            lblNowPlaying.TabIndex = 1;
            lblNowPlaying.Text = "▶ Sonando: (nada en reproducción)";
            // 
            // panelTransporte
            // 
            panelTransporte.BackColor = Color.FromArgb(38, 18, 24);
            panelTransporte.Controls.Add(btnPlay);
            panelTransporte.Controls.Add(btnPause);
            panelTransporte.Controls.Add(btnStop);
            panelTransporte.Controls.Add(progressBarPlayback);
            panelTransporte.Controls.Add(lblTiempoTranscurrido);
            panelTransporte.Location = new Point(0, 40);
            panelTransporte.Margin = new Padding(3, 4, 3, 4);
            panelTransporte.Name = "panelTransporte";
            panelTransporte.Padding = new Padding(0, 4, 0, 4);
            panelTransporte.Size = new Size(1006, 53);
            panelTransporte.TabIndex = 4;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(190, 18, 60);
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(3, 8);
            btnPlay.Margin = new Padding(3, 4, 3, 4);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(114, 37);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "▶ Play (Head)";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.FromArgb(225, 29, 72);
            btnPause.FlatAppearance.BorderSize = 0;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.ForeColor = Color.FromArgb(216, 221, 227);
            btnPause.Location = new Point(123, 8);
            btnPause.Margin = new Padding(3, 4, 3, 4);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(103, 37);
            btnPause.TabIndex = 1;
            btnPause.Text = "⏸ Pausar";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(225, 29, 72);
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.ForeColor = Color.FromArgb(216, 221, 227);
            btnStop.Location = new Point(232, 8);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(91, 37);
            btnStop.TabIndex = 2;
            btnStop.Text = "⏹ Detener";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // progressBarPlayback
            // 
            progressBarPlayback.BackColor = Color.FromArgb(45, 51, 59);
            progressBarPlayback.Location = new Point(329, 8);
            progressBarPlayback.Margin = new Padding(3, 4, 3, 4);
            progressBarPlayback.Maximum = 1000;
            progressBarPlayback.Name = "progressBarPlayback";
            progressBarPlayback.Size = new Size(343, 29);
            progressBarPlayback.TabIndex = 3;
            // 
            // lblTiempoTranscurrido
            // 
            lblTiempoTranscurrido.AutoSize = true;
            lblTiempoTranscurrido.ForeColor = Color.FromArgb(139, 149, 161);
            lblTiempoTranscurrido.Location = new Point(678, 4);
            lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            lblTiempoTranscurrido.Size = new Size(93, 20);
            lblTiempoTranscurrido.TabIndex = 4;
            lblTiempoTranscurrido.Text = "00:00 / 00:00";
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.BackColor = Color.FromArgb(15, 10, 10);
            lblEstadisticas.Dock = DockStyle.Bottom;
            lblEstadisticas.ForeColor = Color.FromArgb(168, 140, 148);
            lblEstadisticas.Location = new Point(0, 628);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(1651, 32);
            lblEstadisticas.TabIndex = 2;
            lblEstadisticas.Text = "Total en cola: 0";
            // 
            // playbackTimer
            // 
            playbackTimer.Interval = 300;
            playbackTimer.Tick += PlaybackTimer_Tick;
            // 
            // panelBenchmark
            // 
            panelBenchmark.BackColor = Color.FromArgb(38, 18, 24);
            panelBenchmark.ColumnCount = 3;
            panelBenchmark.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            panelBenchmark.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            panelBenchmark.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1034F));
            panelBenchmark.Controls.Add(lblBenchmark, 0, 0);
            panelBenchmark.Controls.Add(txtResultadosBenchmark, 0, 1);
            panelBenchmark.Controls.Add(btnBenchmark, 2, 0);
            panelBenchmark.Controls.Add(numInseccionesBenchmark, 1, 0);
            panelBenchmark.Dock = DockStyle.Bottom;
            panelBenchmark.Location = new Point(0, 793);
            panelBenchmark.Margin = new Padding(3, 4, 3, 4);
            panelBenchmark.Name = "panelBenchmark";
            panelBenchmark.Padding = new Padding(11, 13, 11, 13);
            panelBenchmark.RowCount = 2;
            panelBenchmark.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            panelBenchmark.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBenchmark.Size = new Size(1902, 240);
            panelBenchmark.TabIndex = 3;
            // 
            // lblBenchmark
            // 
            lblBenchmark.Anchor = AnchorStyles.Left;
            lblBenchmark.ForeColor = Color.FromArgb(168, 140, 148);
            lblBenchmark.Location = new Point(14, 13);
            lblBenchmark.Name = "lblBenchmark";
            lblBenchmark.Size = new Size(122, 53);
            lblBenchmark.TabIndex = 0;
            lblBenchmark.Text = "Cantidad de pistas para test de estrés:";
            // 
            // txtResultadosBenchmark
            // 
            txtResultadosBenchmark.BackColor = Color.FromArgb(20, 24, 28);
            txtResultadosBenchmark.BorderStyle = BorderStyle.FixedSingle;
            panelBenchmark.SetColumnSpan(txtResultadosBenchmark, 3);
            txtResultadosBenchmark.Dock = DockStyle.Fill;
            txtResultadosBenchmark.Font = new Font("Consolas", 9F);
            txtResultadosBenchmark.ForeColor = Color.FromArgb(139, 149, 161);
            txtResultadosBenchmark.Location = new Point(14, 70);
            txtResultadosBenchmark.Margin = new Padding(3, 4, 3, 4);
            txtResultadosBenchmark.Multiline = true;
            txtResultadosBenchmark.Name = "txtResultadosBenchmark";
            txtResultadosBenchmark.ReadOnly = true;
            txtResultadosBenchmark.ScrollBars = ScrollBars.Vertical;
            txtResultadosBenchmark.Size = new Size(1874, 153);
            txtResultadosBenchmark.TabIndex = 3;
            // 
            // btnBenchmark
            // 
            btnBenchmark.AutoSize = true;
            btnBenchmark.BackColor = Color.FromArgb(58, 25, 34);
            btnBenchmark.FlatAppearance.BorderSize = 0;
            btnBenchmark.FlatStyle = FlatStyle.Flat;
            btnBenchmark.ForeColor = Color.FromArgb(244, 228, 232);
            btnBenchmark.Location = new Point(214, 17);
            btnBenchmark.Margin = new Padding(3, 4, 3, 4);
            btnBenchmark.Name = "btnBenchmark";
            btnBenchmark.Size = new Size(279, 40);
            btnBenchmark.TabIndex = 2;
            btnBenchmark.Text = "🚀 Iniciar Prueba de Rendimiento";
            btnBenchmark.UseVisualStyleBackColor = false;
            btnBenchmark.Click += btnBenchmark_Click;
            // 
            // numInseccionesBenchmark
            // 
            numInseccionesBenchmark.Anchor = AnchorStyles.Left;
            numInseccionesBenchmark.BackColor = Color.FromArgb(45, 51, 59);
            numInseccionesBenchmark.BorderStyle = BorderStyle.FixedSingle;
            numInseccionesBenchmark.ForeColor = Color.FromArgb(216, 221, 227);
            numInseccionesBenchmark.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numInseccionesBenchmark.Location = new Point(143, 26);
            numInseccionesBenchmark.Margin = new Padding(3, 4, 3, 4);
            numInseccionesBenchmark.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            numInseccionesBenchmark.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numInseccionesBenchmark.Name = "numInseccionesBenchmark";
            numInseccionesBenchmark.Size = new Size(63, 27);
            numInseccionesBenchmark.TabIndex = 1;
            numInseccionesBenchmark.Value = new decimal(new int[] { 20000, 0, 0, 0 });
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 31, 36);
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelPlaylist);
            Controls.Add(panelAcciones);
            Controls.Add(panelBenchmark);
            Controls.Add(panelRegistro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoundCore Engine v2.0 - DJ Set Controller [TecNM Monclova]";
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBpm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            panelAcciones.ResumeLayout(false);
            panelPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCola).EndInit();
            panelTransporte.ResumeLayout(false);
            panelTransporte.PerformLayout();
            panelBenchmark.ResumeLayout(false);
            panelBenchmark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numInseccionesBenchmark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Declaración de controles accesibles para el diseñador
        private System.Windows.Forms.FlowLayoutPanel panelRegistro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label lblBpm;
        private System.Windows.Forms.NumericUpDown numBpm;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.RadioButton rbPropia;
        private System.Windows.Forms.RadioButton rbLinkedList;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.Button btnCargarArchivos;

        private System.Windows.Forms.FlowLayoutPanel panelAcciones;
        private System.Windows.Forms.Button btnEncolarFinal;
        private System.Windows.Forms.Button btnReproducirSiguiente;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Button btnOrdenarBpm;
        private System.Windows.Forms.Button btnPurgar;

        private System.Windows.Forms.Panel panelPlaylist;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.Label lblNowPlaying;
        private System.Windows.Forms.FlowLayoutPanel panelTransporte;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ProgressBar progressBarPlayback;
        private System.Windows.Forms.Label lblTiempoTranscurrido;
        private System.Windows.Forms.Label lblEstadisticas;
        private System.Windows.Forms.Timer playbackTimer;

        private System.Windows.Forms.TableLayoutPanel panelBenchmark;
        private System.Windows.Forms.Label lblBenchmark;
        private System.Windows.Forms.NumericUpDown numInseccionesBenchmark;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.TextBox txtResultadosBenchmark;
    }
}
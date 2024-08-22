namespace CronometroApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelCronometro = new Label();
            btnIniciar = new Button();
            btnParar = new Button();
            timerCronometro = new System.Windows.Forms.Timer(components);
            textBoxTempo = new TextBox();
            labelTemporizador = new Label();
            btnPausarTemporizador = new Button();
            btnRedefinirTemporizador = new Button();
            btnIniciarTemporizador = new Button();
            label1 = new Label();
            btnRedefinirCronometro = new Button();
            label2 = new Label();
            btnPararTemporizador = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timerTemporizador = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label3 = new Label();
            btnPausarCronometro = new Button();
            SuspendLayout();
            // 
            // labelCronometro
            // 
            labelCronometro.AutoSize = true;
            labelCronometro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCronometro.Location = new Point(102, 41);
            labelCronometro.Name = "labelCronometro";
            labelCronometro.Size = new Size(88, 37);
            labelCronometro.TabIndex = 0;
            labelCronometro.Text = "00:00";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(2, 9);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 34);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Íniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(2, 67);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(75, 34);
            btnParar.TabIndex = 2;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // timerCronometro
            // 
            timerCronometro.Interval = 1000;
            timerCronometro.Tick += timerCronometro_Tick;
            // 
            // textBoxTempo
            // 
            textBoxTempo.BackColor = SystemColors.Menu;
            textBoxTempo.Location = new Point(401, 52);
            textBoxTempo.Name = "textBoxTempo";
            textBoxTempo.Size = new Size(52, 23);
            textBoxTempo.TabIndex = 3;
            textBoxTempo.Text = "1";
            textBoxTempo.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTemporizador
            // 
            labelTemporizador.AutoSize = true;
            labelTemporizador.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTemporizador.Location = new Point(384, 78);
            labelTemporizador.Name = "labelTemporizador";
            labelTemporizador.Size = new Size(88, 37);
            labelTemporizador.TabIndex = 4;
            labelTemporizador.Text = "00:00";
            // 
            // btnPausarTemporizador
            // 
            btnPausarTemporizador.Location = new Point(524, 38);
            btnPausarTemporizador.Name = "btnPausarTemporizador";
            btnPausarTemporizador.Size = new Size(75, 33);
            btnPausarTemporizador.TabIndex = 5;
            btnPausarTemporizador.Text = "Pausar";
            btnPausarTemporizador.UseVisualStyleBackColor = true;
            btnPausarTemporizador.Click += btnPausarTemporizador_Click;
            // 
            // btnRedefinirTemporizador
            // 
            btnRedefinirTemporizador.Location = new Point(524, 67);
            btnRedefinirTemporizador.Name = "btnRedefinirTemporizador";
            btnRedefinirTemporizador.Size = new Size(75, 33);
            btnRedefinirTemporizador.TabIndex = 6;
            btnRedefinirTemporizador.Text = "Redefinir";
            btnRedefinirTemporizador.UseVisualStyleBackColor = true;
            btnRedefinirTemporizador.Click += btnRedefinirTemporizador_Click;
            // 
            // btnIniciarTemporizador
            // 
            btnIniciarTemporizador.Location = new Point(524, 9);
            btnIniciarTemporizador.Name = "btnIniciarTemporizador";
            btnIniciarTemporizador.Size = new Size(75, 33);
            btnIniciarTemporizador.TabIndex = 7;
            btnIniciarTemporizador.Text = "Íniciar";
            btnIniciarTemporizador.UseVisualStyleBackColor = true;
            btnIniciarTemporizador.Click += btnIniciarTemporizador_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 8;
            label1.Text = "Cronômetro";
            // 
            // btnRedefinirCronometro
            // 
            btnRedefinirCronometro.Location = new Point(2, 96);
            btnRedefinirCronometro.Name = "btnRedefinirCronometro";
            btnRedefinirCronometro.Size = new Size(75, 34);
            btnRedefinirCronometro.TabIndex = 9;
            btnRedefinirCronometro.Text = "Redefinir";
            btnRedefinirCronometro.UseVisualStyleBackColor = true;
            btnRedefinirCronometro.Click += btnRedefinirCronometro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(364, 9);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 10;
            label2.Text = "Temporizador";
            // 
            // btnPararTemporizador
            // 
            btnPararTemporizador.Location = new Point(524, 96);
            btnPararTemporizador.Name = "btnPararTemporizador";
            btnPararTemporizador.Size = new Size(75, 29);
            btnPararTemporizador.TabIndex = 11;
            btnPararTemporizador.Text = "Parar";
            btnPararTemporizador.UseVisualStyleBackColor = true;
            btnPararTemporizador.Click += btnPararTemporizador_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(273, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 143);
            panel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(384, 34);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 13;
            label3.Text = "Digite Minutos";
            // 
            // btnPausarCronometro
            // 
            btnPausarCronometro.Location = new Point(2, 38);
            btnPausarCronometro.Name = "btnPausarCronometro";
            btnPausarCronometro.Size = new Size(75, 33);
            btnPausarCronometro.TabIndex = 14;
            btnPausarCronometro.Text = "Pausar";
            btnPausarCronometro.UseVisualStyleBackColor = true;
            btnPausarCronometro.Click += btnPausarCronometro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 143);
            Controls.Add(btnPausarCronometro);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnPararTemporizador);
            Controls.Add(label2);
            Controls.Add(btnRedefinirCronometro);
            Controls.Add(label1);
            Controls.Add(btnIniciarTemporizador);
            Controls.Add(btnRedefinirTemporizador);
            Controls.Add(btnPausarTemporizador);
            Controls.Add(labelTemporizador);
            Controls.Add(textBoxTempo);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Controls.Add(labelCronometro);
            Name = "Form1";
            Text = "Projeto Cronômetro/Temporizador Prof. Jeferssor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCronometro;
        private Button btnIniciar;
        private Button btnParar;
        private System.Windows.Forms.Timer timerCronometro;
        private TextBox textBoxTempo;
        private Label labelTemporizador;
        private Button btnPausarTemporizador;
        private Button btnRedefinirTemporizador;
        private Button btnIniciarTemporizador;
        private Label label1;
        private Button btnRedefinirCronometro;
        private Label label2;
        private Button btnPararTemporizador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerTemporizador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label3;
        private Button btnPausarCronometro;
    }
}

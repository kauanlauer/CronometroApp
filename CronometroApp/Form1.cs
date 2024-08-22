using System;
using System.Windows.Forms;

namespace CronometroApp
{
    public partial class Form1 : Form
    {
        // Variáveis do cronômetro
        int segundos = 0;
        int minutos = 0;

        // Variáveis do temporizador
        int tempoRestanteSegundos = 0;
        bool temporizadorAtivo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Evento do botão Iniciar Cronômetro
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            temporizadorAtivo = false; // Desativa o temporizador, caso esteja ativo
            timerCronometro.Start();   // Inicia o Timer para o cronômetro
        }

        // Evento do botão Parar Cronômetro
        private void btnParar_Click(object sender, EventArgs e)
        {
            timerCronometro.Stop();    // Para o Timer
        }

        // Evento do botão Iniciar Temporizador
        private void btnIniciarTemporizador_Click(object sender, EventArgs e)
        {
            int minutosDefinidos;
            if (int.TryParse(textBoxTempo.Text, out minutosDefinidos))
            {
                tempoRestanteSegundos = minutosDefinidos * 60; // Converte minutos para segundos
                temporizadorAtivo = true; // Ativa o temporizador
                timerCronometro.Start();  // Inicia o Timer
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido para os minutos.");
            }
        }

        // Evento do botão Pausar Temporizador
        private void btnPausarTemporizador_Click(object sender, EventArgs e)
        {
            timerCronometro.Stop();    // Pausa o Timer
            temporizadorAtivo = false; // Desativa o temporizador
        }

        // Evento do botão Redefinir Temporizador
        private void btnRedefinirTemporizador_Click(object sender, EventArgs e)
        {
            timerCronometro.Stop();          // Para o Timer
            tempoRestanteSegundos = 0;       // Reseta o tempo restante
            temporizadorAtivo = false;       // Desativa o temporizador
            labelTemporizador.Text = "00:00"; // Reseta o label
        }

        // Evento disparado pelo Timer a cada segundo
        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            if (temporizadorAtivo)
            {
                // Lógica do temporizador
                if (tempoRestanteSegundos > 0)
                {
                    tempoRestanteSegundos--; // Reduz o tempo em um segundo

                    // Converte os segundos restantes para minutos e segundos
                    int minutosRestantes = tempoRestanteSegundos / 60;
                    int segundosRestantes = tempoRestanteSegundos % 60;

                    // Atualiza o Label do temporizador
                    labelTemporizador.Text = $"{minutosRestantes:D2}:{segundosRestantes:D2}";
                }
                else
                {
                    timerCronometro.Stop();    // Para o Timer quando o tempo acabar
                    temporizadorAtivo = false; // Desativa o temporizador
                    MessageBox.Show("O tempo acabou!");
                }
            }
            else
            {
                // Lógica do cronômetro
                segundos++;

                if (segundos == 60)
                {
                    minutos++;
                    segundos = 0;
                }

                // Atualiza o Label do cronômetro
                labelCronometro.Text = $"{minutos:D2}:{segundos:D2}";
            }
        }

        private void btnRedefinirCronometro_Click(object sender, EventArgs e)
        {
            timerTemporizador.Stop();          // Para o Timer
            tempoRestanteSegundos = 0;       // Reseta o tempo restante
            temporizadorAtivo = false;       // Desativa o temporizador
            labelCronometro.Text = "00:00"; // Reseta o label
        }

        private void btnPararTemporizador_Click(object sender, EventArgs e)
        {
            timerTemporizador.Stop();    // Para o Timer
        }

        private void btnPausarCronometro_Click(object sender, EventArgs e)
        {
            timerCronometro.Stop();    // Pausa o Timer
            temporizadorAtivo = false; // Desativa o temporizador
        }
    }
}

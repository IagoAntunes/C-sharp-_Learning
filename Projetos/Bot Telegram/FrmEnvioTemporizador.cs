using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telegram.Bot;

namespace BotTelegram1
{
    public partial class FrmEnvioTemporizador : Form
    {
        //Variaveis globais

        private List<string> lstMensagens;
        //Status do envio
        private int posicaoEnvio;

        public FrmEnvioTemporizador()
        {
            InitializeComponent();
            lstMensagens = new List<string>();
            //Desabilitando o botao
            btnEnviar.Enabled = false;
        }

        private void PrepararEnvio()
        {
            //Inicializa a posicao como 0
            posicaoEnvio = 0;
            inicializarProgressBar();
            inicializarTimerControle();
        }
        private void inicializarProgressBar()
        {
            prbStatusEnvio.Value = 0;
            prbStatusEnvio.Maximum = lstMensagens.Count;
        }
        private void inicializarTimerControle()
        {
            //Declarando variavel
            var minutos = Convert.ToInt32(txtTempo.Text.Trim());
            //Transformando em Milisegundos
            timerControle.Interval = minutos * 60 * 10000;
            //Habilitando Timer
            timerControle.Enabled = true;

            //Metodo que vai ser rodado a cada intervalo de tempo
            this.timerControle.Tick += new EventHandler(timerControle_tickAsync);
            //trocando cor de background
            this.BackColor = Color.Red;
        }
        private void PararTimerControle()
        {
            timerControle.Enabled = false;
            timerControle.Tick -= new EventHandler(timerControle_tickAsync);
            this.BackColor = SystemColors.Control;
            btnEnviar.Enabled = true;
        }

        
        private void AtualizarProgressoEnvio()
        {
            prbStatusEnvio.Value++;
            lblStatusEnvio.Text = string.Format("Enviando {0} de {1}....",posicaoEnvio,lstMensagens.Count);
        }
        
        
        private async void timerControle_tickAsync(object sender,EventArgs e)
        {
            try
            {
                var telegramBot = new TelegramBotClient("1755387732:AAHWVTH6AeabrHiEA2R73OUK52oN6gZw9i0");
                var mensagemAtual = lstMensagens[posicaoEnvio];

                mensagemAtual = EmojiConfigcs.Config(mensagemAtual);

                await telegramBot.SendTextMessageAsync(chatId: "-1001506779457", text: mensagemAtual, parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                posicaoEnvio++;

                //Atualizar progesso de Envio :>
                AtualizarProgressoEnvio();

                if(posicaoEnvio == lstMensagens.Count)
                {
                    PararTimerControle();
                }
            }
            catch (Exception ex)
            {
                PararTimerControle();
                MessageBox.Show("Erro ao enviar Mensagem!!" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarregarMensagens_Click(object sender, EventArgs e)
        {
            try
            {
                //Desabilitando
                btnCarregarMensagens.Enabled = false;
                //Pegando nome do arquivo para ser lido
                var arquivoMensagens = "Mensagens.txt";

                //Garantindo que não tenha nada no list e listBox
                lstMensagens.Clear();
                lbMensagens.Items.Clear();

                //Leitura do Arquivo
                using (StreamReader sr = new StreamReader(arquivoMensagens))
                {
                    //Vai receber cada linha lida do arquivo
                    var strLinha = string.Empty;

                    //Aqui lê cada linha do arquivo
                    while ((strLinha = sr.ReadLine()) != null)
                    {
                        //Verificando se a linha esta vazia(REMOVER ESPAÇO DESNECESSÁRIO)
                        //Negação no inicio , verificando se tem conteudo
                        if (!strLinha.Trim().Equals(string.Empty))
                        {
                            lstMensagens.Add(strLinha.Trim());
                            lbMensagens.Items.Add(strLinha.Trim());
                        }
                    }
                }
                //Se tiver mensagem o botão de enviar é ativado
                if(lstMensagens.Count  > 0){
                    btnEnviar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                btnCarregarMensagens.Enabled = true;
                btnEnviar.Enabled = false;
                lstMensagens.Clear();
                lbMensagens.Items.Clear();
                MessageBox.Show("Erro ao carregar o arquivo!!"+ex.Message,this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Verificando se preenchi o tempo
            if (txtTempo.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o tempo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Desabilita o Botao
            btnEnviar.Enabled = false;

            //Verificar se encontrou uma linha no arquivo de texto
            if(lstMensagens.Count == 0)
            {
                MessageBox.Show("Nenhuma mensagem carrregaa do arquivo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrepararEnvio();
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                //Representa o andamento do evento
                e.Handled = true;
            }
        }
    }
}

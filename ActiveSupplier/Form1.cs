using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ActiveSupplier
{
    public partial class ActiveSupplier : Form
    {
        /// <summary>
        /// Tela unica e principal onde sera visualizado o Log a lista na tela sera atualizada a cada 2 segundo
        /// onde durante esse tempo as notificacoes serao armazenadas temporariamente em uma lista manipula pelo 
        /// objeto workerObject onde seu metodo sera executado em uma Thread
        /// </summary>

        Worker workerObject;

        public ActiveSupplier()
        {
            InitializeComponent();

            StartThread();
        }

        /// <summary>
        /// Inicia uma Thread para verificacao de novas notificacoes  
        /// </summary>

        private void StartThread()
        {
            workerObject = new Worker();
            Thread workerThread = new Thread(workerObject.DoWork);

            workerThread.Start();

            //            while (!workerThread.IsAlive) ;
            //            Thread.Sleep(1);
        }

        /// <summary>
        /// metodo chamado a cada 2 segundos para atualizacao da lista de log
        /// </summary>

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<String> listinfo = workerObject.Get();

            foreach (string info in listinfo)
            {
                log.Rows.Add(info);
            }

            // Apos carregar na tela o log limpa pilha para receber novas noficacoes
            listinfo.Clear();
        }
    }
}

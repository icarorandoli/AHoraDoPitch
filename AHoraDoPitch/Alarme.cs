using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AHoraDoPitch
{
    public class Alarme
    {
        public Alarme()
        {
            this.Tempo = 3; //tres minutos
            this.EfeitoSonoro = 200;
        }

        public Alarme(int tempo)
        {
            this.Tempo=tempo;
        }

        private int tempo;
       
        // controla o tempo do Pitch
        public int Tempo
        {
            get { return tempo; }
            set { tempo = 1000 * 60 * value; }
        }

        public void Iniciar()
        {
            Thread.Sleep(this.Tempo);
            Console.Beep(250, 1000);
        }
    }

}

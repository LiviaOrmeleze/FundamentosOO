using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Elfo : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Meu nome é " + this.Nome + ", sou um elfo, estou no nível  " + this.Nivel + ", tenho " + this.Vida + " pontos de vida, minha inteligência é de " + this.Inteligencia + " pontos.");
        }





    }

}


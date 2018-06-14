using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CaixaEletronico
    {
        public string Sacar(int valorDesejado)
        {
            int[] notasDisponiveis = { 100, 50, 20, 10 };
            string saque = string.Empty;
            int i = 0;

            if (valorDesejado <= 0)
                return saque = "Valor indisponível";
            else
            {
                while (i < notasDisponiveis.Length)
                {
                    if (valorDesejado >= notasDisponiveis[i])
                    {
                        if (saque == string.Empty)
                            saque = "Entregar " + (valorDesejado / notasDisponiveis[i]).ToString() + " nota(s) de R$" + notasDisponiveis[i].ToString() + ",00";
                        else if ((valorDesejado % notasDisponiveis[i]) >= 10)
                        {
                            saque += ", " + (valorDesejado / notasDisponiveis[i]).ToString() + " nota(s) de R$" + notasDisponiveis[i].ToString() + ",00";
                        }
                        else
                            saque += " e " + (valorDesejado / notasDisponiveis[i]).ToString() + " nota(s) de R$" + notasDisponiveis[i].ToString() + ",00";

                        valorDesejado = valorDesejado % notasDisponiveis[i];
                    }
                    i++;
                }
                if (valorDesejado != 0)
                    saque = "Não há notas disponíveis para realizar este saque";
                return saque;
            }
        }
    }
}

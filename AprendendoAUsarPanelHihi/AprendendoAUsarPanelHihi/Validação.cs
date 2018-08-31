using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendoAUsarPanelHihi
{
    class Validação
    {
        public void soletras(KeyPressEventArgs letras)
        {
            try
            {
                if (char.IsLetter(letras.KeyChar))
                {
                    letras.Handled = false;
                }
                else if (char.IsControl(letras.KeyChar))
                {
                    letras.Handled = false;
                }
                else if (char.IsSeparator(letras.KeyChar))
                {
                    letras.Handled = false;
                }
                else
                {
                    letras.Handled = true;
                }

            }
            catch (Exception ex)
            {

            }

        }
        public void sonumeros(KeyPressEventArgs numeros)
        {
            try
            {
                if (char.IsNumber(numeros.KeyChar))
                {
                    numeros.Handled = false;
                }
                else if (char.IsControl(numeros.KeyChar))
                {
                    numeros.Handled = false;
                }
                else if (char.IsSeparator(numeros.KeyChar))
                {
                    numeros.Handled = false;
                }
                else
                {
                    numeros.Handled = true;
                }

            }
            catch (Exception ex)
            {

            }



        }


    }
}

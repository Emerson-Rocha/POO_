using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http.Headers;

namespace POO
{
    class Apresentacao:Form
    {
        // Objeto
     
         Button btobj01  = new Button();
 
        // toda classe tem um construtor
        public Apresentacao() {
            this.Text = "Titulo ";
            this.Size = new Size(600, 600);
            btobj01.Text = " Clicar ";
            btobj01.Location = new Point(50, 50);
            btobj01.Click += clicar;
            this.Controls.Add(btobj01);
        }

        // metodo de Evento
        private void clicar( object sender , EventArgs e ) {
            MessageBox.Show("Metodo de Evento");
        }


    }
}

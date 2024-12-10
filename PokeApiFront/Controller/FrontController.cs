using PokeApiFront.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeApiFront.Model
{
    public class FrontController
    {
        WelcomeForm form = new WelcomeForm();

        public FrontController()
        {
            SetListeners();
            form.Show();
        }

        private void SetListeners()
        {
            form.bEntrar.Click += BEntrar_Click;
        }

        private void BEntrar_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            form.Close();
        }
    }
}

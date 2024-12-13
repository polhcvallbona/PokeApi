using PokeApiBack.Repositories;
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
        WelcomeForm welcomeForm = new WelcomeForm();
        MainForm mainForm = new MainForm();

        public FrontController()
        {
            SetListeners();
            LoadData();
            welcomeForm.Show();
        }

        private void SetListeners()
        {
            welcomeForm.bEntrar.Click += BEntrar_Click;
            mainForm.cbPokemonName1.SelectedIndexChanged += CbPokemonName1_SelectedIndexChanged;
            mainForm.cbPokemonName2.SelectedIndexChanged += CbPokemonName2_SelectedIndexChanged;
        }

        private void CbPokemonName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainForm.cbPokemonName2.Text != "" && mainForm.cbPokemonName2.Text != null)
            {
                //mainForm.cbPokemonCard2.DataSource = await PokemonRepository.GetAllPokemonsByName(mainForm.cbPokemonName2.Text);
            }
        }

        private async void CbPokemonName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainForm.cbPokemonName1.Text != "" && mainForm.cbPokemonName1.Text != null)
            {
                mainForm.cbPokemonCard1.DataSource = await PokemonRepository.GetAllPokemonsByName(mainForm.cbPokemonName1.Text);
            }
        }

        private void BEntrar_Click(object sender, EventArgs e)
        {
            welcomeForm.Hide();
            mainForm.Show();
            welcomeForm.Close();
        }

        private async Task LoadData()
        {
            mainForm.cbPokemonName1.DataSource = await PokemonRepository.GetAllPokemonNames();
            mainForm.cbPokemonName2.DataSource = await PokemonRepository.GetAllPokemonNames();
        }

    }
}

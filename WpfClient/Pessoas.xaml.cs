using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfClient.CRUDAPI;

namespace WpfClient
{
    /// <summary>
    /// Lógica interna para Pessoas.xaml
    /// </summary>
    public partial class Pessoas : Window
    {
        private ICRUDAPIClient Api;
        public int SelectedPessoaId { get; set; }


        public Pessoas(ICRUDAPIClient api)
        {
            Api = api;
            InitializeComponent();
        }

        public async void LoadDataGridPessoas()
        {
            var pessoas = await Api.Pessoas.GetPessoasAsync();
            dataGridPessoas.ItemsSource = pessoas;
        }

        public async void LoadPessoa()
        {

        }

        public async void AddPessoa()
        {

        }

        public async void UpdatePessoa()
        {

        }

        public async void DeletePessoa()
        {

        }
    }
}

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

namespace CRUDClient
{
    /// <summary>
    /// Lógica interna para Pessoas.xaml
    /// </summary>
    public partial class Pessoas : Window
    {
        //private ICRUDAPI Api;

        public Pessoas()
        {
            InitializeComponent();
            //Api = api;
        }


        public async void LoadDataGridPessoas()
        {
            var pessoas = new List<object>();
            dataGridPessoas.ItemsSource = pessoas;
        }
    }
}

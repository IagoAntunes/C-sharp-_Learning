using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotacaoDolar
{
    public partial class FrmDolar : Form
    {
        public FrmDolar()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=0242323e";

            //O codigo fique somente dentro

            using (HttpClient client = new HttpClient())
            {
                
                

                try
                {
                    //Pegar o resultado da url
                    var response = client.GetAsync(strURL).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        //Pega o conteudo e lê a string
                        var result = response.Content.ReadAsStringAsync().Result;

                        //Deserialiaze a classe
                        Market market = JsonConvert.DeserializeObject<Market>(result);

                        //Convertendo o valor para valores de moeda e mostrando no LABEL
                        lblBuy.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        lblSell.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        lblVar.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);

                    }
                    else
                    {
                        lblBuy.Text = "-";
                        lblSell.Text = "-";
                        lblVar.Text = "-";
                    }
                }
                catch (Exception ex)
                {
                    lblBuy.Text = "-";
                    lblSell.Text = "-";
                    lblVar.Text = "-";
                    MessageBox.Show(ex.Message);
                }   
            }
        }
    }
}

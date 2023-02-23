using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace URLShortWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CreateQR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void btn_CreateShortURL_Click(object sender, EventArgs e)
        {
            // Verifica se o usuario adicionou uma chave bitly
            string apiKey = txtBox_inputKey.Text;
            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("Por favor insira uma chave Bitly API.");
                return;
            }

            // Verifica se o usuario colocou uma URL
            string urlLonga = txtBox_EnterURL.Text;
            if (string.IsNullOrEmpty(urlLonga))
            {
                MessageBox.Show("Por favor insira uma URL");
                return;
            }

            // Chamando a API do bitly
            string apiUrl = $"https://api-ssl.bitly.com/v4/shorten";
            var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            var pedido = new StringContent($"{{\"long_url\":\"{urlLonga}\"}}", System.Text.Encoding.UTF8, "application/json");
            var resposta = await cliente.PostAsync(apiUrl, pedido);
            var respostaFinal = await resposta.Content.ReadAsStringAsync();

            // Separando o link no JSON
            JObject converteJSON = JObject.Parse(respostaFinal);
            string urlCurta = converteJSON["link"].ToString();

            // Adiciona a URL encurtada ao textbox
            txtBox_displayShortURL.Text = urlCurta;




        }

        private void checkBox1_CreateQR_Click(object sender, EventArgs e)
        {

        }

        private void displayShortURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_EnterURL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using Aspose.Cells;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Windows_Form_teste
{
    public partial class Form1 : Form
    {
        public const string pasta = @"C:\Users\Magno\Documents\teste\teste-forms\Windows Form teste\Windows Form teste\test.txt";
        public const string pastaJs = @"C:\Users\Magno\Documents\teste\teste-forms\Windows Form teste\Windows Form teste\testjson.txt";
        public const string pastaXml = @"C:\Users\Magno\Documents\teste\teste-forms\Windows Form teste\Windows Form teste\testXml";
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            
            string texto = File.ReadAllText($"{pasta}");
                       
            string[] linhas = texto.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            XElement raiz = new XElement("dados");
            foreach (var linha in linhas)
            {
                string[] partes = linha.Split(':');
                if (partes.Length == 2)
                {
                    string chave = partes[0].Trim();
                    string valor = partes[1].Trim();
                    
                    XElement elemento = new XElement(chave, valor);
                    raiz.Add(elemento);
                }
            }

            XDocument documento = new XDocument(raiz);

            documento.Save($"{pastaXml}");

            richTextBox1.Text = documento.ToString();

        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {

            StreamReader leitor = new StreamReader(pasta);

            var conteudo = leitor.ReadToEnd();

            richTextBox1.Text = conteudo.ToString();

            leitor.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnJson_Click(object sender, EventArgs e)
        {
           
            string texto = File.ReadAllText($"{pasta}");
            string[] linhas = texto.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var dados = new Dictionary<string, string>();
            foreach (var linha in linhas)
            {
                string[] partes = linha.Split(':');
                if (partes.Length == 2)
                {
                    string chave = partes[0].Trim();
                    string valor = partes[1].Trim();
                    dados.Add(chave, valor);
                }
            }

            string json = JsonConvert.SerializeObject(dados, Formatting.Indented);
            File.WriteAllText($"{pastaJs}", json);

            richTextBox1.Text = json;
        }
    }
}

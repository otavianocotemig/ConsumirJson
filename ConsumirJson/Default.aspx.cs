using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumirJson
{
    public partial class Default : System.Web.UI.Page
    {
              
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public DataTable GetJson()
        {
           var requisicaoWeb = WebRequest.CreateHttp("https://jsonplaceholder.typicode.com/posts");
           requisicaoWeb.Method = "GET";
           requisicaoWeb.UserAgent = "AspNet";
                   
            // Recupera a resposta da requisição web
            var resposta = requisicaoWeb.GetResponse();
            // Recupera os dados do Body = Conteudo de uma requisicao Web
            var streamDados = resposta.GetResponseStream();
            StreamReader reader = new StreamReader(streamDados);
            string objResponse = reader.ReadToEnd();


            var table = JsonConvert.DeserializeObject<DataTable>(objResponse);
            return table;



        }

        protected void btnJson_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = GetJson();
            GridView1.DataBind();
        }

        protected void btnSituacaoLoja_Click(object sender, EventArgs e)
        {
            


        }
    }
}
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
            var requisicaoWeb = WebRequest.CreateHttp("https://jsonplaceholder.typicode.com/albums");
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "AspNet";
            

            var resposta = requisicaoWeb.GetResponse();
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
    }
}
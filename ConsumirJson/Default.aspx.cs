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
            GridView1.DataSource = GetPost();
            GridView1.DataBind();
        }

        public DataTable GetPost()
        {
            var requisicaoWeb = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/");
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "ReqOtaviano";
            var resposta = requisicaoWeb.GetResponse();
            var streamDados = resposta.GetResponseStream();
            StreamReader reader = new StreamReader(streamDados);
            string objResponse = reader.ReadToEnd();
            var table = JsonConvert.DeserializeObject<DataTable>(objResponse);
            return table;



        }

        
    }
}
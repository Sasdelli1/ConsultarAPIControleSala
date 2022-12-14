using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsultarAPIControleSala.Consulta
{
    class ConsultaAlunos
    {
        public string Consulta(string nome)
        {
            string oURL = "https://localhost:5001/api/Aluno?p_nome_aluno=" + nome;
            HttpClient _httpClient = new HttpClient();
            HttpResponseMessage result =_httpClient.GetAsync(oURL).Result;
            String JsonRetorno = result.Content.ReadAsStringAsync().Result;
            return JsonRetorno;
        }
    }
}

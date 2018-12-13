using SDClasses.Controller;
using SDClasses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDWeb
{
    public partial class HistoricoChamados : System.Web.UI.Page
    {
        public List<Chamado> listaChamados = new List<Chamado>();
        ChamadoController chamadoController = new ChamadoController();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.carregarChamados();
        }
        public void carregarChamados()
        {
            listaChamados = new Chamado().obterChamado();
            var teste = 0;
        }

    }
}
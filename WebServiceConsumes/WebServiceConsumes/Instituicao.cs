using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebServiceConsumes
{
    public class Instituicao
    {
        [Key]
        public String cepInstituicao { get; set; }
        public String cidadeInstituicao { get; set; }
        public String enderecoInstituicao { get; set; }
        public String estadoInstituicao { get; set; }
        public String idInstituicao { get; set; }
        public String idStatusInstituicao { get; set; }
        public String nomeInstituicao { get; set; }
        public String telefoneInstituicao { get; set; }
    }
}
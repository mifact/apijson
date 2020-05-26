using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public class RespuestaInvoice
    {
        
        public string errors { get; set; }
              
        public string estado_documento { get; set; }
      
        public string tipo_cpe { get; set; }
      
        public string serie_cpe { get; set; }
      
        public string correlativo_cpe { get; set; }
      
        public string url { get; set; }
      
        public string sunat_description { get; set; }
      
        public string sunat_note { get; set; }
      
        public string sunat_responsecode { get; set; }
      
        public string pdf_bytes { get; set; }
      
        public string xml_enviado { get; set; }
      
        public string cdr_sunat { get; set; }
      
        public string cadena_para_codigo_qr { get; set; }
      
        public string codigo_hash { get; set; }
      
        public string ticket_sunat { get; set; }

        public RespuestaInvoice()
        {
            errors = "";
            estado_documento = "";
            tipo_cpe = "";
            serie_cpe = "";
            correlativo_cpe = "";
            url = "";
            sunat_description = "";
            sunat_note = "";
            sunat_responsecode = "";
            xml_enviado = "";
            cdr_sunat = "";
            cadena_para_codigo_qr = "";
            codigo_hash = "";
            ticket_sunat = "";
        }
    }
}

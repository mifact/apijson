using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using RestSharp;
namespace Json
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

        private void button2_Click(object sender, EventArgs e)
        {
            //// si quiere leer desde un achivo json decomente estas 4 lineas 
            //System.IO.StreamReader file =
            //new System.IO.StreamReader(@"C:\Users\desarrolo\Documents\scripts\txt_json_test.txt");
            //var json = file.ReadToEnd();
            //file.Close();

            string json = "";
            json=GeneraJson();

            // SendInvoice Metodo SendInvoice para enviar facturas, boletas, notas de credito y debito
            SendInvoice("http://demo.mifact.net.pe/api/invoiceService.svc/SendInvoice", json);

            //GetInvoice metodo para extraer el PDF o XML en cualquier momento
            //SendInvoice("http://demo.mifact.net.pe/api/invoiceService.svc/GetInvoice", json);
        }

        public string SendInvoice(string ruta, string json)
        {
            try
            {
              
                {
                              
               

                    var client = new RestClient(ruta);
                    var request = new RestRequest(Method.POST);                   
                    request.AddHeader("content-type", "application/json");                    
                    request.AddParameter("application/json",json, ParameterType.RequestBody);
                    // enviando los valores al request del api.
                    IRestResponse response = client.Execute(request);

                    // desearilanzo la respuesta del API REST
                    dynamic leer_respuesta = JsonConvert.DeserializeObject<RespuestaInvoice>(response.Content);

                    RespuestaInvoice oRespuesta = new RespuestaInvoice();
                    oRespuesta = leer_respuesta;

                    // mostramos la respuestas en pantalla
                    txt_cadena_codigo_qr.Text=oRespuesta.cadena_para_codigo_qr ;
                    txterror.Text = oRespuesta.errors;
                    txtestadodocumeto.Text= oRespuesta.estado_documento;
                    txttipo_cpe.Text= oRespuesta.tipo_cpe;
                    txt_cdr.Text= oRespuesta.cdr_sunat;
                    txt_codigohash.Text= oRespuesta.codigo_hash;
                    txt_correl.Text= oRespuesta.correlativo_cpe;
                    txt_seriedoc.Text= oRespuesta.serie_cpe;
                    txt_sunat_descrip.Text= oRespuesta.sunat_description;
                    txt_sunat_recsponsecode.Text= oRespuesta.sunat_responsecode;
                    txt_ticket_sunat.Text= oRespuesta.ticket_sunat;
                    txt_xmlenviado.Text= oRespuesta.xml_enviado;

                    // nombre de archivo para guardar en mi disco local los archivos zip qu estan en base 64
                    string nombre_Archivo = oRespuesta.serie_cpe + "_" + oRespuesta.correlativo_cpe;

                    // borrarArchivos
                    if (File.Exists(@"D:\MIFACTFE\" + nombre_Archivo + ".zip")) File.Delete(@"D:\MIFACTFE\" + nombre_Archivo + ".pdf");
                    if (File.Exists(@"D:\MIFACTFE\" + "cdr_sunat_" + nombre_Archivo + ".zip")) File.Delete(@"D:\MIFACTFE\" + "cdr_sunat_" + nombre_Archivo + ".zip");
                    if (File.Exists(@"D:\MIFACTFE\" + "xml_enviado_" + nombre_Archivo + ".zip")) File.Delete(@"D:\MIFACTFE\" + "xml_enviado_" + nombre_Archivo + ".zip");


                    byte[] archivoByte = null;
                    // recuperando el pdf que esta en base 64 y luego se guarda en mi disco local
                    if (oRespuesta.pdf_bytes != null)
                    {
                        archivoByte = Convert.FromBase64String(oRespuesta.pdf_bytes);
                        File.WriteAllBytes(@"D:\MIFACTFE\" + nombre_Archivo + ".pdf", archivoByte);
                    }
                    // recuperando el xml enviado que esta en base 64 y luego se guarda en mi disco local
                    if (oRespuesta.xml_enviado != null)
                    {
                        archivoByte = Convert.FromBase64String(oRespuesta.xml_enviado);
                        File.WriteAllBytes(@"D:\MIFACTFE\" + "xml_enviado_" + nombre_Archivo + ".zip", archivoByte);
                    }

                    if (oRespuesta.cdr_sunat != null)
                    {
                        // recuperando el xml de respuesta de SUNAT (CDR) que esta en base 64 y luego se guarda en mi disco local
                        archivoByte = Convert.FromBase64String(oRespuesta.cdr_sunat);
                        File.WriteAllBytes(@"D:\MIFACTFE\" + "cdr_sunat_" + nombre_Archivo + ".zip", archivoByte);
                    }

                    return "";
                }
            }
            catch (WebException ex)
            {
                /// EN CASO EXISTA ALGUN ERROR, LO TOMAMOS
                var respuesta = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                /// Y LO 'RETORNAMOS'
                return respuesta;
            }
        }

        public string GeneraJson()
        {
            CPE_CABECERA_BE omifact = new CPE_CABECERA_BE();
            omifact.TOKEN = "gN8zNRBV+/FVxTLwdaZx0w==";
            omifact.COD_TIP_NIF_EMIS = "6";
            omifact.NUM_NIF_EMIS = "20100100100";
            omifact.NOM_RZN_SOC_EMIS = "empresa demo";
            omifact.NOM_COMER_EMIS = "demo";
            omifact.COD_UBI_EMIS = "103040";
            omifact.TXT_DMCL_FISC_EMIS = "avenida abcd";
            omifact.COD_TIP_NIF_RECP = "6";
            omifact.NUM_NIF_RECP = "20200200200";
            omifact.NOM_RZN_SOC_RECP = "cliente abcd";
            omifact.TXT_DMCL_FISC_RECEP = "direccion del cliente";
            omifact.FEC_EMIS = "2018-03-13";
            omifact.FEC_VENCIMIENTO = "2018-09-09";
            omifact.COD_TIP_CPE = "01";
            omifact.NUM_SERIE_CPE = "FJ01";
            omifact.NUM_CORRE_CPE = "00000011";
            omifact.COD_MND = "PEN";
            omifact.NUM_PLACA = "";
            omifact.MailEnvio = "mifact@outlook.com";            
            omifact.COD_PRCD_CARGA = "001";
            omifact.MNT_TOT_GRAVADO = "200.00";
            omifact.MNT_TOT_TRIB_IGV = "36.00";          
            omifact.MNT_TOT = "236.00";
            omifact.COD_FORM_IMPR = "001";
            omifact.COD_TIP_OPE_SUNAT = "0101";
            omifact.COD_PTO_VENTA = "jmifact";
            omifact.COD_ANEXO_EMIS = "0000";// si tiene sucursal colocar el codigo de anexo de la sucursal
            omifact.TXT_VERS_UBL = "2.1";
            omifact.TXT_VERS_ESTRUCT_UBL = "2.0";
            omifact.RETORNA_PDF = "false"; // si no deseas que el servicio retorne el PDF generado enviar false, caso contrario colocar true
            omifact.RETORNA_XML_ENVIO = "false"; // si no deseas que el servicio retorne el XML firmado que se envia a SUNAT, colocar false caso contrario enviar true
            omifact.RETORNA_XML_CDR = "false"; // si no deseas que el servicio retorne el XML respuesta SUNAT o CDR colocal false, caso contrario enviar true.
            omifact.ENVIAR_A_SUNAT = "false"; // si deseas enviar a SUNAT (solo facturas y NC) en ese mismo instante enviar true, caso contrario enviar false para que el sistema mifact lo envie mas tarde de forma automatica.
            omifact.items = new List<CPE_DETALLE_BE>()
                {
                new CPE_DETALLE_BE()
                {
                    COD_UNID_ITEM = "NIU",
                    COD_ITEM = "001",
                    TXT_DESC_ITEM = "DETALLE DEL PRODUCTO 1",
                    CANT_UNID_ITEM = "1",
                    VAL_UNIT_ITEM = "100",
                    PRC_VTA_UNIT_ITEM = "118",                    
                    VAL_VTA_ITEM = "100",
                    MNT_BRUTO="100",
                    COD_TIP_AFECT_IGV_ITEM="10",
                    MNT_IGV_ITEM = "18.00",
                    MNT_PV_ITEM = "118.00",
                    POR_IGV_ITEM="18",
                    COD_TIP_PRC_VTA="01"
                   
                },
                new CPE_DETALLE_BE()
                {
                     COD_UNID_ITEM = "NIU",
                    COD_ITEM = "001",
                    TXT_DESC_ITEM = "auto mazda 1",
                    DET_VAL_ADIC01="año 2014",
                    DET_VAL_ADIC02="motor HYTRD44556453444",
                    CANT_UNID_ITEM = "1",
                    VAL_UNIT_ITEM = "100",
                    PRC_VTA_UNIT_ITEM = "118",                    
                    VAL_VTA_ITEM = "100",
                    MNT_BRUTO="100",
                    COD_TIP_AFECT_IGV_ITEM="10",
                    MNT_IGV_ITEM = "18.00",
                    MNT_PV_ITEM = "118.00",
                    POR_IGV_ITEM="18",
                    COD_TIP_PRC_VTA="01"
                },
            };

            omifact.guias = new List<CPE_DOC_REF_BE>()
            {
                new CPE_DOC_REF_BE()
                {
                    COD_TIP_DOC_REF="09",
                    NUM_SERIE_CPE_REF="0002",
                    NUM_CORRE_CPE_REF="00000304",
                    SERIE_CORRE_CPE_REF="0002-00000304",

                }
            };
            omifact.datos_adicionales = new List<CPE_DAT_ADIC_BE>()
            {
                new CPE_DAT_ADIC_BE()
                {
                    COD_TIP_ADIC_SUNAT="01",
                    TXT_DESC_ADIC_SUNAT="EFECTIVO"

                },
                new CPE_DAT_ADIC_BE()
                {
                    COD_TIP_ADIC_SUNAT="15",
                    TXT_DESC_ADIC_SUNAT="OC-8373983"
                }
            };

            string json = JsonConvert.SerializeObject(omifact, Formatting.Indented);
           // Console.WriteLine(json);
            //byte[] bytes = Encoding.UTF8.GetBytes(json);
            //string json_en_utf_8 = Encoding.UTF8.GetString(bytes);
            textBox1.Text = json;
            ImprimirJson(json);
            return json;
        }

        private void ImprimirJson(string pJson)
        {
            dynamic leer_respuesta = JsonConvert.DeserializeObject<CPE_CABECERA_BE>(pJson);
            
        }

        private void btnSendGuiaRemision_Click(object sender, EventArgs e)
        {
            string json = "";
            json = GeneraGuiaJSON();

            
            SendGuia("http://demo.mifact.net.pe/GuiaRemision.svc/SendGuia", json);
        }
        public string GeneraGuiaJSON()
        {
            GR_CABECERA omifact = new GR_CABECERA();
            omifact.TOKEN = "gN8zNRBV+/FVxTLwdaZx0w==";
            omifact.RETORNA_PDF = "true";
            omifact.RETORNA_XML_ENVIO = "true";
            omifact.COD_TIP_NIF_EMIS = "6";
            omifact.NUM_NIF_EMIS = "20100100100";
            omifact.NOM_RZN_SOC_EMIS = "empresa demo";
            omifact.NOM_COMER_EMIS = "demo";
            omifact.COD_UBI_EMIS = "150132";
            omifact.TXT_DMCL_FISC_EMIS = "avenida abcd";

            omifact.COD_TIP_NIF_DEST = "6";
            omifact.NUM_NIF_DEST = "20200200200";
            omifact.NOM_RZN_SOC_DEST = "cliente abcd";
            omifact.TXT_DMCL_FISC_DEST = "direccion del cliente";
            omifact.FEC_EMIS_GUR = "2018-08-13";            
            omifact.COD_TIP_GUR = "09";
            omifact.NUM_SERIE_GUR = "T001";
            omifact.NUM_CORRE_GUR = "00000109";
            // codigo de la modalidad de traslado, si es publico tendra que enviar la razon social y ruc de la empresa de transporte  y si es pivado tendra que enviar el DNI y Nombre del conductor , ver catalogo de codigos en el excel
            //omifact.MOD_TRASLADO = "01";            

            //omifact.COD_TIP_NIF_TRANSP = "6";
            //omifact.NUM_NIF_TRANSP = "20300300300";
            //omifact.NOM_RZN_SOC_TRANSP = "TRANSPORTES TOSCANO SAC";

            // codigo de la modalidad de traslado, si es publico tendra que enviar la razon social y ruc de la empresa de transporte  y si es pivado tendra que enviar el DNI y Nombre del conductor , ver catalogo de codigos en el excel
            omifact.MOD_TRASLADO = "02";
            omifact.COD_TIP_NIF_CONDUCT = "1";
            omifact.NUM_NIF_CONDUCT = "40578746";
            omifact.NOM_RZN_SOC_CONDUCT = "KARINA CHAVEZ";
            // placa del vehiculo que raliza el traslado, SI NO TIENE PLACA PONER UN GUION 
            omifact.PLACA = "-";


            omifact.DIR_LLEGADA = "AV. WILSON 201";
            omifact.DIR_PARTIDA = "AVENIDA TOMAS MARZANO 203";


            omifact.FEC_TRASLADO = "2018-08-14";
            //INDICADOR SI SERA CON TRANSBORDO EL TRANSPORTE
            omifact.IND_TRANSBORDO = "false";

            // codigo del motivo de traslado puede ser por venta, venta itinerante, entre el mismo establecimiento etc ver catalogos de codigos en el excel 
            omifact.MOT_TRASLADO = "01";
            // el motivo del traslado en letras
            omifact.TXT_MOT_TRASLADO = "VENTA INTERNA";

            omifact.NRO_BULTOS = "0"; // solo enviar los bultos cuando es importacion el traslado
            omifact.NRO_CONTENEDOR = "";
            omifact.PESO_BRUTO = "23.00";
          
           
            
            //codigo de ubigeo de 6 caracteres del distrito segun el inei
            omifact.UBI_LLEGADA = "150132";
            //codigo de ubigeo de 6 caracteres del distrito segun el inei
            omifact.UBI_PARTIDA = "150101";

            omifact.UND_MEDIDA = "KGM";
            omifact.COD_TIP_NIF_EMIS = "6";
            omifact.NOM_COMER_EMIS = "EMPRESA DEMO";
            omifact.TXT_DMCL_FISC_EMIS = "calle monte alamo 1010 surco";

            // enviar alguna observacion si no tiene ninguna observacion por lo menos enviar un caracter.
            omifact.OBSERVACIONES = "ninguna";

            //si no tiene correo no enviar este tag
            omifact.TXT_CORREO_ENVIO = "soporte@mifact.net";

            omifact.items = new List<GR_DETALLE_BE>()
                {
                new GR_DETALLE_BE()
                {
                    NUM_LINEA = "1",
                    CANT_ITEM = "20",
                    COD_ITEM = "P001",
                    DESC_ITEM = "DETALLE DEL PRODUCTO 1",
                    PESO_ITEM = "20",                  
                    COD_UND_MEDIDA_ITEM = "KGM",
                   

                },
               new GR_DETALLE_BE()
                {
                    NUM_LINEA = "2",
                    CANT_ITEM = "6",
                    COD_ITEM = "P002",
                    DESC_ITEM = "DETALLE DEL PRODUCTO 2",
                    PESO_ITEM = "3",                   
                    COD_UND_MEDIDA_ITEM = "KGM",


                },
            };

          

            string json = JsonConvert.SerializeObject(omifact, Formatting.Indented);
            // Console.WriteLine(json);
            byte[] bytes = Encoding.UTF8.GetBytes(json);
            string json_en_utf_8 = Encoding.UTF8.GetString(bytes);
            textBox1.Text = json_en_utf_8;
            return json_en_utf_8;
        }
        public string SendGuia(string ruta, string json)
        {
            try
            {

                {



                    var client = new RestClient(ruta);
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("content-type", "application/json");
                    request.AddParameter("application/json", json, ParameterType.RequestBody);
                    // enviando los valores al request del api.
                    IRestResponse response = client.Execute(request);

                    // desearilanzo la respuesta del API REST
                    dynamic leer_respuesta = JsonConvert.DeserializeObject<RespuestaInvoice>(response.Content);

                    RespuestaInvoice oRespuesta = new RespuestaInvoice();
                    oRespuesta = leer_respuesta;

                    // mostramos la respuestas en pantalla
                    txt_cadena_codigo_qr.Text = oRespuesta.cadena_para_codigo_qr;
                    txterror.Text = oRespuesta.errors;
                    txtestadodocumeto.Text = oRespuesta.estado_documento;
                    txttipo_cpe.Text = oRespuesta.tipo_cpe;
                    txt_cdr.Text = oRespuesta.cdr_sunat;
                    txt_codigohash.Text = oRespuesta.codigo_hash;
                    txt_correl.Text = oRespuesta.correlativo_cpe;
                    txt_seriedoc.Text = oRespuesta.serie_cpe;
                    txt_sunat_descrip.Text = oRespuesta.sunat_description;
                    txt_sunat_recsponsecode.Text = oRespuesta.sunat_responsecode;
                    txt_ticket_sunat.Text = oRespuesta.ticket_sunat;
                    txt_xmlenviado.Text = oRespuesta.xml_enviado;

                    // nombre de archivo para guardar en mi disco local los archivos zip qu estan en base 64
                    string nombre_Archivo = oRespuesta.serie_cpe + "_" + oRespuesta.correlativo_cpe;

                    // borrarArchivos
                    if (File.Exists(@"D:\MIFACTFE\" + nombre_Archivo + ".pdf")) File.Delete(@"D:\MIFACTFE\" + nombre_Archivo + ".pdf");
                    if (File.Exists(@"D:\MIFACTFE\" + "cdr_sunat_" + nombre_Archivo + ".zip")) File.Delete(@"D:\MIFACTFE\" + "cdr_sunat_" + nombre_Archivo + ".zip");
                    if (File.Exists(@"D:\MIFACTFE\" + "xml_enviado_" + nombre_Archivo + ".zip")) File.Delete(@"D:\MIFACTFE\" + "xml_enviado_" + nombre_Archivo + ".zip");


                    // recuperando el pdf que esta en base 64 y luego se guarda en mi disco local
                    byte[] archivoByte = Convert.FromBase64String(oRespuesta.pdf_bytes);
                    File.WriteAllBytes(@"D:\MIFACTFE\" + nombre_Archivo + ".pdf", archivoByte);

                    // recuperando el xml enviado que esta en base 64 y luego se guarda en mi disco local
                    archivoByte = Convert.FromBase64String(oRespuesta.xml_enviado);
                    File.WriteAllBytes(@"D:\MIFACTFE\" + "xml_enviado_" + nombre_Archivo + ".zip", archivoByte);

                    // recuperando el xml de respuesta de SUNAT (CDR) que esta en base 64 y luego se guarda en mi disco local
                    archivoByte = Convert.FromBase64String(oRespuesta.cdr_sunat);
                    File.WriteAllBytes(@"D:\MIFACTFE\" + "cdr_sunat_" + nombre_Archivo + ".zip", archivoByte);


                    return "";
                }
            }
            catch (WebException ex)
            {
                /// EN CASO EXISTA ALGUN ERROR, LO TOMAMOS
                var respuesta = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                /// Y LO 'RETORNAMOS'
                return respuesta;
            }
        }
    }
}

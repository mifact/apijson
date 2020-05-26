using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public class GR_CABECERA
    {
       
            public List<GR_DETALLE_BE> items { get; set; }

            //public List<GUR_DOC_REF_BE> docs_referenciado { get; set; }

            //public List<GUR_DAT_ADIC_BE> datos_adicionales { get; set; }

            public string TOKEN { get; set; }

            public string TXT_COD_HASH { get; set; }

            public string RETORNA_XML_ENVIO { get; set; }
            public string RETORNA_XML_CDR { get; set; }
            public string RETORNA_PDF { get; set; }


            private String vNUM_CORRE_GUR = "";


            public GR_CABECERA()
            {
                COD_GPO_ECON = "";
                NUM_SERIE_GUR = "";
                NUM_CORRE_GUR = "";
                COD_TIP_GUR = "";


                NUM_CORRE_GUR = "";
                FEC_EMIS_GUR = "";

                //Emision

                NUM_NIF_EMIS = "";


                NUM_NIF_DEST = "";
                DIR_LLEGADA = "";
                UBI_LLEGADA = "";
                NOM_COMER_DEST = "";
                NOM_RZN_SOC_DEST = "";

                //
                COD_TIP_NIF_TERC = "";
                NOM_RZN_SOC_TERC = "";
                MOT_TRASLADO = "";
                IND_TRANSBORDO = "";
                UND_MEDIDA = "";
                MOD_TRASLADO = "";
                NUM_NIF_TRANSP = "";
                COD_TIP_NIF_TRANSP = "";
                FEC_TRASLADO = "";
                NOM_RZN_SOC_TRANSP = "";
                NUM_NIF_CONDUCT = "";
                //Variables Adicionales
                TXT_VERS_UBL = "2.0";
                TXT_VERS_ESTRUCT_UBL = "1.0";
                COD_IMPRE_DEST = "";
                NUM_INTENTO = "0";
                TXT_MTVO_BAJA = "";
                NUM_INT_CORREO = "0";
                FLG_PUB_GUR = "";
                FLG_CORREO_GUR = "";
                FLG_IMPR_GUR = "";
                COD_PRCD_CARGA = "";
                NUM_RESUM = "";
                //Datos de Estado
                COD_TIP_NIF_EMIS = "6";
                NUM_NIF_EMIS = "";
                NOM_COMER_EMIS = "";
                COD_UBI_EMIS = "";
                TXT_DMCL_FISC_EMIS = "";
                COD_ESCN_CPE = "001";
                COD_ESTD_SUNAT = "";
                OBSERVACIONES = "";
                TXT_DMCL_FISC_DEST = "";
                TXT_MOT_TRASLADO = "";
                MARCA = "";
                FLG_DOC_REF = "0";
                ENVIAR_A_SUNAT = "true";
            }
            public String OBSERVACIONES { get; set; }
            public String COD_GPO_ECON { get; set; }
            //Valores  Generales
            public String COD_TIP_NIF_EMIS { get; set; }
            public String NUM_NIF_EMIS { get; set; }
            public String NOM_COMER_EMIS { get; set; }
            public String TXT_DMCL_FISC_EMIS { get; set; }
            public String NOM_RZN_SOC_EMIS { get; set; }

            public String COD_UBI_EMIS { get; set; }
            public String COD_TIP_GUR { get; set; }

            public String NUM_GUR { get; set; }
            public String NUM_SERIE_GUR { get; set; }
            public string ENVIAR_A_SUNAT { get; set; }
            public String NUM_CORRE_GUR
            {
                get
                {
                    return vNUM_CORRE_GUR.PadLeft(8, Convert.ToChar("0"));
                }
                set { vNUM_CORRE_GUR = value; }
            }

            public String FEC_EMIS_GUR { get; set; }

            // Datos del Emisor

            public String COD_TIP_NIF_REMIT { get; set; }
            public String NOM_RZN_SOC_REMITENTE { get; set; }
            public String TXT_DMCL_FISC_REMITENTE { get; set; }
            public String NUM_NIF_REMITENTE { get; set; }
            public String COD_TIP_NIF_DEST { get; set; }
            public String TXT_DMCL_FISC_DEST { get; set; }
            public String COD_ESTD_SUNAT { get; set; }
            public String NUM_NIF_DEST { get; set; }
            public String NOM_COMER_DEST { get; set; }
            public String DIR_LLEGADA { get; set; }
            public String UBI_LLEGADA { get; set; }

            public String NOM_RZN_SOC_DEST { get; set; }
            public String NUM_NIF_TERC { get; set; }
            // Datos del Proveedor 
            public String COD_TIP_NIF_TERC { get; set; }
            public String NOM_RZN_SOC_TERC { get; set; }
            public String MOT_TRASLADO { get; set; }
            public String TXT_MOT_TRASLADO { get; set; }
            public String IND_TRANSBORDO { get; set; }
            public String PESO_BRUTO { get; set; }
            public String UND_MEDIDA { get; set; }
            public String MOD_TRASLADO { get; set; }
            public String FEC_TRASLADO { get; set; }
            public String NUM_NIF_TRANSP { get; set; }
            public String COD_TIP_NIF_TRANSP { get; set; }
            public String NOM_RZN_SOC_TRANSP { get; set; }
            public String NUM_NIF_CONDUCT { get; set; }
            //DATOS DE LA RETENCIÓN(INICIO)
            public String COD_TIP_NIF_CONDUCT { get; set; }

            public String COD_ESCN_CPE { get; set; }

            public String NOM_RZN_SOC_CONDUCT { get; set; }


            public String MARCA { get; set; }
            public String PLACA { get; set; }
            public String NRO_BULTOS { get; set; }
            public String NRO_CONTENEDOR { get; set; }
            // Valores en la Recepcion de retorno Sunat
            public String COD_FORM_IMPR { get; set; }
            public String DIR_PARTIDA { get; set; }
            public String UBI_PARTIDA { get; set; }
            public String HOR_RECEP_DOC_SUNAT { get; set; }
            public String FEC_GENE_DOC_SUNAT { get; set; }
            public String HOR_GENE_DOC_SUNAT { get; set; }
            public String COD_RPTA_ENV_SUNAT { get; set; }


            // Datos Adicionales 
            public String TXT_VERS_UBL { get; set; }
            public String TXT_VERS_ESTRUCT_UBL { get; set; }
            public String COD_IMPRE_DEST { get; set; }
            public String NUM_INTENTO { get; set; }
            public String EST_PROCESO { get; set; }

            public String MSG_PROCESO { get; set; }
            public String FEC_INICIO { get; set; }
            public String FEC_FIN { get; set; }

            public String TXT_MTVO_BAJA { get; set; }

            public String NUM_INT_CORREO { get; set; }
            public String FLG_PUB_GUR { get; set; }
            public String FLG_CORREO_GUR { get; set; }

            public String FLG_IMPR_GUR { get; set; }
            public String COD_PRCD_CARGA { get; set; }
            public String COD_PUERTO { get; set; }
            // Elementos Adicionales dos

            public String NOMBRE_ARCHIVO
            {
                get
                {
                    return NUM_NIF_EMIS + "-" + COD_TIP_GUR + "-" + NUM_SERIE_GUR + "-" + NUM_CORRE_GUR;
                }
            }
            public String COD_ID_RECEP_SUNAT { get; set; }
            public String FEC_RECEP_DOC_SUNAT { get; set; }

            public String TXT_CORREO_ENVIO { get; set; }
            public String TXT_CORREO_COPIA { get; set; }
            public String TXT_CORREO_OCULTO { get; set; }
            // Si es impresion por Tiketera o A4

            public String NUM_RESUM { get; set; }

            public String FLG_DOC_REF { get; set; }

        
    }
    public class GR_DETALLE_BE
    {


        public string NUM_LINEA { get; set; }
        public string COD_ITEM { get; set; }
        public string DESC_ITEM { get; set; }
        public string UnidadMedida { get; set; }
        public string CANT_ITEM { get; set; }
        public string PESO_ITEM { get; set; }
        //public float vPESO_TOT_ITEM { get; set; }
        public string COD_UND_MEDIDA_ITEM { get; set; }

        public string DET_VAL_ADIC01 { get; set; }
        public string DET_VAL_ADIC02 { get; set; }
        public string DET_VAL_ADIC03 { get; set; }
        public string DET_VAL_ADIC04 { get; set; }
        public string DET_VAL_ADIC05 { get; set; }
        public string DET_VAL_ADIC06 { get; set; }
        public GR_DETALLE_BE()
        {
            PESO_ITEM = "0";
            CANT_ITEM = "0";
            //  aObservacion = "";
            DET_VAL_ADIC01 = "";
            DET_VAL_ADIC02 = "";
            DET_VAL_ADIC03 = "";
            DET_VAL_ADIC04 = "";
            DET_VAL_ADIC05 = "";
            DET_VAL_ADIC06 = "";

        }
        //public float PESO_TOT_ITEM
        //{
        //    get
        //    {
        //        vPESO_TOT_ITEM = float.Parse(PESO_ITEM) * float.Parse(CANT_ITEM);
        //        return vPESO_TOT_ITEM;
        //    }
        //    set { vPESO_TOT_ITEM = value; }
        //}
    }
}

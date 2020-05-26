using System;
using System.Collections.Generic;
using System.Text;

namespace Json
{
    public class CPE_CABECERA_BE
    {
        public List<CPE_DETALLE_BE> items { get; set; }
        public List<CPE_DOC_REF_BE> guias { get; set; }
        public List<CPE_DOC_REF_BE> docs_referenciado { get; set; }
        public List<CPE_DOC_REF_BE> otro_docs_referenciado { get; set; }
        public List<CPE_DAT_ADIC_BE> datos_adicionales { get; set; }
        public List<CPE_ANTICIPO_BE> anticipos { get; set; }
        public List<CPE_FAC_GUIA_BE> transporte { get; set; }
        public string TOKEN { get; set; }
        public string USUARIO_ENVIO { get; set; }
        public string TXT_COD_HASH { get; set; }
        public string ENVIAR_A_SUNAT { get; set; }
        public string RETORNA_XML_ENVIO { get; set; }
        public string RETORNA_XML_CDR { get; set; }
        public string RETORNA_PDF { get; set; }


        public string NRO_CUENTA_DETRAC { get; set; }
        public string COD_ANEXO_EMIS { get; set; }
        public string MNT_TOT_REAL
        {
            get
            {
                double MntTotalValorVenta = 0;
                if (COD_TIP_CARGO == "50" || COD_TIP_CARGO == "51" || COD_TIP_CARGO == "46" || COD_TIP_CARGO == "52" || COD_TIP_CARGO == "53")
                    MntTotalValorVenta = double.Parse(MNT_TOT);
                else
                    MntTotalValorVenta = double.Parse(MNT_TOT_EXONERADO) + double.Parse(MNT_TOT_INAFECTO) + double.Parse(MNT_TOT_GRAVADO) + double.Parse(MNT_DSCTO_GLOB);

                return MntTotalValorVenta.ToString("F2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
        public string DSCTO_GLOB_PORC
        {
            get
            {
                double MntTotalValorVenta = 0, PorcDescuento = 0;
                MntTotalValorVenta = double.Parse(MNT_TOT_EXONERADO) + double.Parse(MNT_TOT_INAFECTO) + double.Parse(MNT_TOT_GRAVADO) + double.Parse(MNT_DSCTO_GLOB);
                PorcDescuento = Math.Round(double.Parse(MNT_DSCTO_GLOB) / MntTotalValorVenta, 5, MidpointRounding.AwayFromZero);
                return PorcDescuento.ToString("F5", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
        public string CARGO_GLOB_PORC
        {
            get
            {
                double MntTotalValorVenta = 0, PorcDescuento = 0;
                if (COD_TIP_CARGO == "50" || COD_TIP_CARGO == "51" || COD_TIP_CARGO == "46" || COD_TIP_CARGO == "52" || COD_TIP_CARGO == "53")
                    MntTotalValorVenta = double.Parse(MNT_TOT);
                else
                    MntTotalValorVenta = double.Parse(MNT_TOT_EXONERADO) + double.Parse(MNT_TOT_INAFECTO) + double.Parse(MNT_TOT_GRAVADO) + double.Parse(MNT_DSCTO_GLOB);

                PorcDescuento = Math.Round(double.Parse(MNT_TOT_OTR_CGO) / MntTotalValorVenta, 5, MidpointRounding.AwayFromZero);
                return PorcDescuento.ToString("F5", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
        public string COD_TIP_DSCTO { get; set; }
        public string COD_TIP_CARGO { get; set; }
        private String vMNT_TOT_GRAVADO = "0.00";
        private String vMNT_TOT_INAFECTO = "0.00";
        private String vMNT_TOT_EXONERADO = "0.00";
        private String vMNT_TOT_GRATUITO = "0.00";
        private String vMNT_TOT_DESCUENTO = "0.00";
        private String vMNT_TOT_TRIB_IGV = "0.00";
        private String vMNT_TOT_TRIB_ISC = "0.00";
        private String vMNT_TOT_TRIB_OTR = "0.00";
        private String vMNT_DSCTO_GLOB = "0.00";
        private String vMNT_TOT_OTR_CGO = "0.00";
        private String vMNT_TOT = "0.00";
        private String vMNT_TOT_PERCEPCION = "0.00";
        private String vMNT_IMPTO_PERCEPCION = "0.00";
        private String vMNT_TOT_MAS_PERCEPCION = "0.00";
        private String vMNT_TOT_DETRACCION = "0.00";
        private String vPOR_DETRACCION = "0.00";
        private String vNUM_CORRE_CPE = "";
        private string vMailEnvio = "";
        private string vMailCopia = "";

        private String vFLG_TIP_CAMBIO = "0";

        // #################################################################################################################################//
        // ##################################Inicio (2015-09-25):  Cambio de Calculo por el Tipo de  Cambio#################################//
        // #################################################################################################################################//
        private String vTIP_CAMBIO = "0.00";
        private String vMNT_TOT_GRAVADO_NAC = "0.00";
        private String vMNT_TOT_INAFECTO_NAC = "0.00";
        private String vMNT_TOT_EXONERADO_NAC = "0.00";
        private String vMNT_TOT_GRATUITO_NAC = "0.00";
        private String vMNT_TOT_DESCUENTO_NAC = "0.00";
        private String vMNT_TOT_OTR_CGO_NAC = "0.00";
        private String vMNT_TOT_TRIB_IGV_NAC = "0.00";
        private String vMNT_TOT_TRIB_ISC_NAC = "0.00";
        private String vMNT_TOT_TRIB_OTR_NAC = "0.00";
        private String vMNT_DSCTO_GLOB_NAC = "0.00";
        private String vMNT_TOT_NAC = "0.00";
        private String vMNT_TOT_ANTCP = "0.00";
        // #################################################################################################################################//
        // ##################################Fin (2015-09-25):  Cambio de Calculo por el Tipo de  Cambio#################################//
        // #################################################################################################################################//

        public CPE_CABECERA_BE()
        {
            COD_TIP_DSCTO = "";
            COD_TIP_CARGO = "";
            USUARIO_ENVIO = "APIMIFACT";
            RETORNA_PDF = "false";
            RETORNA_XML_CDR = "false";
            RETORNA_XML_ENVIO = "false";
            TOKEN = "";
            ENVIAR_A_SUNAT = "false";
            NUM_CPE = "";
            NUM_SERIE_CPE = "";
            NUM_CORRE_CPE = "";
            NOM_RZN_SOC_EMIS = "";
            NUM_NIF_EMIS = "";
            TXT_DMCL_FISC_EMIS = "";
            TXT_URB_EMIS = "";
            TXT_PROV_EMIS = "";
            TXT_DPTO_EMIS = "";
            TXT_DISTR_EMIS = "";
            TXT_PAIS_EMIS = "";
            COD_UBI_EMIS = "";
            NOM_COMER_EMIS = "";
            COD_TIP_CPE = "";
            COD_TIP_NIF_RECP = "";
            NUM_NIF_RECP = "";
            NOM_RZN_SOC_RECP = "";
            TXT_DMCL_FISC_RECEP = "";
            COD_MND = "";
            TXT_DESC_MTVO = "XXX";
            COD_TIP_NC = "";
            MNT_TOT_GRAVADO = "0.00";
            MNT_TOT_INAFECTO = "0.00";
            MNT_TOT_EXONERADO = "0.00";
            MNT_TOT_GRATUITO = "0.00";
            MNT_TOT_DESCUENTO = "0.00";
            MNT_TOT_TRIB_IGV = "0.00";
            MNT_TOT_TRIB_ISC = "0.00";
            MNT_TOT_TRIB_OTR = "0.00";
            MNT_DSCTO_GLOB = "0.00";
            MNT_TOT_OTR_CGO = "0.00";
            MNT_TOT = "0.00";
            // #################################################################################################################################//
            // ##################################Inicio (2015-09-25):  Cambio de Calculo por el Tipo de  Cambio#################################//
            // #################################################################################################################################//
            TIP_CAMBIO = "0.00";
            MNT_TOT_GRAVADO_NAC = "0.00";
            MNT_TOT_INAFECTO_NAC = "0.00";
            MNT_TOT_EXONERADO_NAC = "0.00";
            MNT_TOT_GRATUITO_NAC = "0.00";
            MNT_TOT_DESCUENTO_NAC = "0.00";
            MNT_TOT_OTR_CGO_NAC = "0.00";
            MNT_TOT_TRIB_IGV_NAC = "0.00";
            MNT_TOT_TRIB_ISC_NAC = "0.00";
            MNT_TOT_TRIB_OTR_NAC = "0.00";
            MNT_DSCTO_GLOB_NAC = "0.00";
            MNT_TOT_NAC = "0.00";
            // #################################################################################################################################//
            // ###################################Fin (2015-09-25):  Cambio de Calculo por el Tipo de  Cambio###################################//
            // #################################################################################################################################//
            MNT_TOT_PERCEPCION = "0.00";
            MNT_TOT_MAS_PERCEPCION = "0.00";
            MNT_TOT_DETRACCION = "0.00";
            COD_IMPRE_DEST = "";
            COD_GPO_ECON = "";
            COD_ESCN_CPE = "";
            NUM_RESUM = "";
            COD_TIP_NIF_EMIS = "6";
            COD_TIP_PAGO = "";
            COD_PRCD_CARGA = "";
            COD_ESTD_SUNAT = "";
            FLG_IMPR_CPE = "";
            COD_FRM_PAGO = "";
            FLG_PUB_CPE = "";
            FLG_CORREO_CPE = "";
            TXT_VERS_UBL = "2.0";
            TXT_VERS_ESTRUCT_UBL = "1.0";
            //Modificado por Diego 2-22-2016
            FEC_INICIO = "";
            FEC_VENCIMIENTO = "";
            NUM_INTENTO = "";
            MSG_PROCESO = "";
            EST_PROCESO = "";
            NUM_RESUM_BOL = "";
            NUM_RESUM_BAJ = "";
            NUM_INT_CORREO = "";

            COD_TIP_OPE_SUNAT = "0101";
            NUM_PLACA = "";
            MailCopia = "";
            MailEnvio = "";
            COD_FORM_IMPR = "001";
            TXT_CORREO_ENVIO = "";
            TXT_COD_HASH = "";

            COD_TIP_DETRACCION = "";
            NRO_CUENTA_DETRAC = "";
            COD_ANEXO_EMIS = "0000";
            TXT_PAIS_RECEP = "PE";
            //
        }
        public String NUM_CPE { get; set; }
        public String COD_GPO_ECON { get; set; }
        public String COD_TIP_NIF_EMIS { get; set; }
        public String NUM_NIF_EMIS { get; set; }
        public String COD_TIP_NIF_RECP { get; set; }
        public String NUM_NIF_RECP { get; set; }
        public String COD_ESCN_CPE { get; set; }
        public String NUM_RESUM { get; set; }
        public String COD_TIP_CPE { get; set; }
        public String FEC_EMIS { get; set; }
        public String FEC_VENCIMIENTO { get; set; }
        public String NOM_RZN_SOC_EMIS { get; set; }
        public String NOM_COMER_EMIS { get; set; }
        public String COD_UBI_EMIS { get; set; }
        public String TXT_DMCL_FISC_EMIS { get; set; }
        public String TXT_URB_EMIS { get; set; }
        public String TXT_DISTR_EMIS { get; set; }
        public String TXT_PROV_EMIS { get; set; }
        public String TXT_DPTO_EMIS { get; set; }
        public String TXT_PAIS_EMIS
        {
            get
            {
                return TXT_PAIS_RECEP;
            }
            set { TXT_PAIS_RECEP = value; }
        }
        public String TXT_PAIS_RECEP { get; set; }
        public String NUM_SERIE_CPE { get; set; }
        public String NUM_PLACA { get; set; }

        public String MailEnvio
        {
            get
            {
                return vMailEnvio;
            }
            set { vMailEnvio = value; }
        }
        public String MailCopia
        {
            get
            {
                return vMailCopia;
            }
            set { vMailCopia = value; }
        }
        public String NUM_CORRE_CPE
        {
            get
            {
                return vNUM_CORRE_CPE.PadLeft(8, Convert.ToChar("0"));
            }
            set { vNUM_CORRE_CPE = value; }
        }

        public String COD_TIP_PAGO { get; set; }
        public String COD_FRM_PAGO { get; set; }
        public String NOM_RZN_SOC_RECP { get; set; }
        public String TXT_DMCL_FISC_RECEP { get; set; }
        public String COD_MND { get; set; }
        public String COD_IMPRE_DEST { get; set; }
        public String COD_PRCD_CARGA { get; set; }
        public String MNT_TOT_GRAVADO
        {
            get
            {
                if (vMNT_TOT_GRAVADO.Trim().Equals("")) vMNT_TOT_GRAVADO = "0.00";
                return vMNT_TOT_GRAVADO;
            }
            set { vMNT_TOT_GRAVADO = value; }
        }
        public String MNT_TOT_INAFECTO
        {
            get
            {
                if (vMNT_TOT_INAFECTO.Trim().Equals("")) vMNT_TOT_INAFECTO = "0.00";
                return vMNT_TOT_INAFECTO;
            }
            set { vMNT_TOT_INAFECTO = value; }
        }
        public String MNT_TOT_EXONERADO
        {
            get
            {
                if (vMNT_TOT_EXONERADO.Trim().Equals("")) vMNT_TOT_EXONERADO = "0.00";
                return vMNT_TOT_EXONERADO;
            }
            set { vMNT_TOT_EXONERADO = value; }
        }
        public String MNT_TOT_GRATUITO
        {
            get
            {
                if (vMNT_TOT_GRATUITO.Trim().Equals("")) vMNT_TOT_GRATUITO = "0.00";
                return vMNT_TOT_GRATUITO;
            }
            set { vMNT_TOT_GRATUITO = value; }
        }
        public String MNT_TOT_DESCUENTO
        {
            get
            {
                if (vMNT_TOT_DESCUENTO.Trim().Equals("")) vMNT_TOT_DESCUENTO = "0.00";
                return vMNT_TOT_DESCUENTO;
            }
            set { vMNT_TOT_DESCUENTO = value; }
        }
        public String MNT_TOT_TRIB_IGV
        {
            get
            {
                if (vMNT_TOT_TRIB_IGV.Trim().Equals("")) vMNT_TOT_TRIB_IGV = "0.00";
                return vMNT_TOT_TRIB_IGV;
            }
            set { vMNT_TOT_TRIB_IGV = value; }
        }
        public String MNT_TOT_TRIB_ISC
        {
            get
            {
                if (vMNT_TOT_TRIB_ISC.Trim().Equals("")) vMNT_TOT_TRIB_ISC = "0.00";
                return vMNT_TOT_TRIB_ISC;
            }
            set { vMNT_TOT_TRIB_ISC = value; }
        }
        public String MNT_TOT_TRIB_OTR
        {
            get
            {
                if (vMNT_TOT_TRIB_OTR.Trim().Equals("")) vMNT_TOT_TRIB_OTR = "0.00";
                return vMNT_TOT_TRIB_OTR;
            }
            set { vMNT_TOT_TRIB_OTR = value; }
        }
        public String MNT_DSCTO_GLOB
        {
            get
            {
                if (vMNT_DSCTO_GLOB.Trim().Equals("")) vMNT_DSCTO_GLOB = "0.00";
                return vMNT_DSCTO_GLOB;
            }
            set { vMNT_DSCTO_GLOB = value; }
        }
        public String MNT_TOT_OTR_CGO
        {
            get
            {
                if (vMNT_TOT_OTR_CGO.Trim().Equals("")) vMNT_TOT_OTR_CGO = "0.00";
                return vMNT_TOT_OTR_CGO;
            }
            set { vMNT_TOT_OTR_CGO = value; }
        }
        public String MNT_TOT
        {
            get
            {
                if (vMNT_TOT.Trim().Equals("")) vMNT_TOT = "0.00";
                return vMNT_TOT;
            }
            set { vMNT_TOT = value; }
        }

        // #################################################################################################################################//
        // ##################################Inicio (2015-09-25):  Cambio de Calculo por el Tipo de  Cambio#################################//
        // #################################################################################################################################//
        public String TIP_CAMBIO
        {
            get
            {
                if (vTIP_CAMBIO.Trim().Equals("")) vTIP_CAMBIO = "0.00";
                return vTIP_CAMBIO;
            }
            set { vTIP_CAMBIO = value; }
        }
        public String MNT_TOT_GRAVADO_NAC
        {
            get
            {
                if (vMNT_TOT_GRAVADO_NAC.Trim().Equals("")) vMNT_TOT_GRAVADO_NAC = "0.00";
                return vMNT_TOT_GRAVADO_NAC;
            }
            set { vMNT_TOT_GRAVADO_NAC = value; }
        }
        public String MNT_TOT_INAFECTO_NAC
        {
            get
            {
                if (vMNT_TOT_INAFECTO_NAC.Trim().Equals("")) vMNT_TOT_INAFECTO_NAC = "0.00";
                return vMNT_TOT_INAFECTO_NAC;
            }
            set { vMNT_TOT_INAFECTO_NAC = value; }
        }
        public String MNT_TOT_EXONERADO_NAC
        {
            get
            {
                if (vMNT_TOT_EXONERADO_NAC.Trim().Equals("")) vMNT_TOT_EXONERADO_NAC = "0.00";
                return vMNT_TOT_EXONERADO_NAC;
            }
            set { vMNT_TOT_EXONERADO_NAC = value; }
        }
        public String MNT_TOT_GRATUITO_NAC
        {
            get
            {
                if (vMNT_TOT_GRATUITO_NAC.Trim().Equals("")) vMNT_TOT_GRATUITO_NAC = "0.00";
                return vMNT_TOT_GRATUITO_NAC;
            }
            set { vMNT_TOT_GRATUITO_NAC = value; }
        }
        public String MNT_TOT_DESCUENTO_NAC
        {
            get
            {
                if (vMNT_TOT_DESCUENTO_NAC.Trim().Equals("")) vMNT_TOT_DESCUENTO_NAC = "0.00";
                return vMNT_TOT_DESCUENTO_NAC;
            }
            set { vMNT_TOT_DESCUENTO_NAC = value; }
        }
        public String MNT_TOT_OTR_CGO_NAC
        {
            get
            {
                if (vMNT_TOT_OTR_CGO_NAC.Trim().Equals("")) vMNT_TOT_OTR_CGO_NAC = "0.00";
                return vMNT_TOT_OTR_CGO_NAC;
            }
            set { vMNT_TOT_OTR_CGO_NAC = value; }
        }
        public String MNT_TOT_TRIB_IGV_NAC
        {
            get
            {
                if (vMNT_TOT_TRIB_IGV_NAC.Trim().Equals("")) vMNT_TOT_TRIB_IGV_NAC = "0.00";
                return vMNT_TOT_TRIB_IGV_NAC;
            }
            set { vMNT_TOT_TRIB_IGV_NAC = value; }
        }
        public String MNT_TOT_TRIB_ISC_NAC
        {
            get
            {
                if (vMNT_TOT_TRIB_ISC_NAC.Trim().Equals("")) vMNT_TOT_TRIB_ISC_NAC = "0.00";
                return vMNT_TOT_TRIB_ISC_NAC;
            }
            set { vMNT_TOT_TRIB_ISC_NAC = value; }
        }
        public String MNT_TOT_TRIB_OTR_NAC
        {
            get
            {
                if (vMNT_TOT_TRIB_OTR_NAC.Trim().Equals("")) vMNT_TOT_TRIB_OTR_NAC = "0.00";
                return vMNT_TOT_TRIB_OTR_NAC;
            }
            set { vMNT_TOT_TRIB_OTR_NAC = value; }
        }
        public String MNT_DSCTO_GLOB_NAC
        {
            get
            {
                if (vMNT_DSCTO_GLOB_NAC.Trim().Equals("")) vMNT_DSCTO_GLOB_NAC = "0.00";
                return vMNT_DSCTO_GLOB_NAC;
            }
            set { vMNT_DSCTO_GLOB_NAC = value; }
        }
        public String MNT_TOT_NAC
        {
            get
            {
                if (vMNT_TOT_NAC.Trim().Equals("")) vMNT_TOT_NAC = "0.00";
                return vMNT_TOT_NAC;
            }
            set { vMNT_TOT_NAC = value; }
        }

        // #################################################################################################################################//
        // ###################################FIN (2015-09-25):  Cambio de Calculo por el Tipo de  Cambio##################################//
        // #################################################################################################################################//

        public String MNT_TOT_PERCEPCION
        {
            get
            {
                if (vMNT_TOT_PERCEPCION.Trim().Equals("")) vMNT_TOT_PERCEPCION = "0.00";
                return vMNT_TOT_PERCEPCION;
            }
            set { vMNT_TOT_PERCEPCION = value; }
        }
        public String COD_TIP_PERCEPCION { get; set; }
        public String MNT_IMPTO_PERCEPCION
        {
            get
            {
                if (vMNT_IMPTO_PERCEPCION.Trim().Equals("")) vMNT_IMPTO_PERCEPCION = "0.00";
                return vMNT_IMPTO_PERCEPCION;
            }
            set { vMNT_IMPTO_PERCEPCION = value; }
        }
        public String MNT_TOT_MAS_PERCEPCION
        {
            get
            {
                if (vMNT_TOT_MAS_PERCEPCION.Trim().Equals("")) vMNT_TOT_MAS_PERCEPCION = "0.00";
                return vMNT_TOT_MAS_PERCEPCION;
            }
            set { vMNT_TOT_MAS_PERCEPCION = value; }
        }
        public String MNT_TOT_DETRACCION
        {
            get
            {
                if (vMNT_TOT_DETRACCION.Trim().Equals("")) vMNT_TOT_DETRACCION = "0.00";
                return vMNT_TOT_DETRACCION;
            }
            set { vMNT_TOT_DETRACCION = value; }
        }
        public String COD_TIP_DETRACCION { get; set; }
        public String POR_DETRACCION
        {
            get
            {
                if (vPOR_DETRACCION.Trim().Equals("")) vPOR_DETRACCION = "0.00";
                return vPOR_DETRACCION;
            }
            set { vPOR_DETRACCION = value; }
        }
        public String COD_TIP_NC { get; set; }
        public String COD_TIP_ND { get; set; }
        public String TXT_DESC_MTVO { get; set; }
        public String TXT_VERS_UBL { get; set; }
        public String TXT_VERS_ESTRUCT_UBL { get; set; }
        public String FLG_IMPR_CPE { get; set; }
        public String FLG_PUB_CPE { get; set; }
        public String FLG_CORREO_CPE { get; set; }
        public String COD_ESTD_SUNAT { get; set; }
        public String COD_ID_RECEP_SUNAT { get; set; }
        public String FEC_RECEP_DOC_SUNAT { get; set; }
        public String HOR_RECEP_DOC_SUNAT { get; set; }
        public String FEC_GENE_DOC_SUNAT { get; set; }
        public String HOR_GENE_DOC_SUNAT { get; set; }
        public String COD_RPTA_ENV_SUNAT { get; set; }
        public String NOMBRE_ARCHIVO
        {
            get
            {
                return NUM_NIF_EMIS + "-" + COD_TIP_CPE + "-" + NUM_SERIE_CPE + "-" + NUM_CORRE_CPE;
            }
        }

        public String TXT_CORREO_ENVIO { get; set; }
        public String TXT_CORREO_COPIA { get; set; }
        public String TXT_CORREO_OCULTO { get; set; }
        public String COD_FORM_IMPR { get; set; }
        public String FLG_TIP_CAMBIO
        {
            get
            {
                if (vFLG_TIP_CAMBIO.Trim().Equals("")) vFLG_TIP_CAMBIO = "0";
                return vFLG_TIP_CAMBIO;
            }
            set { vFLG_TIP_CAMBIO = value; }
        }
        //Modificado po Diego 2-22-2016
        //MOtivo : Detalle Monitor
        public String FEC_INICIO { get; set; }
        public String NUM_INTENTO { get; set; }
        public String MSG_PROCESO { get; set; }
        public String EST_PROCESO { get; set; }
        public String NUM_RESUM_BOL { get; set; }
        public String NUM_RESUM_BAJ { get; set; }
        public String NUM_INT_CORREO { get; set; }
        public String COD_TIP_OPE_SUNAT { get; set; }
        public String COD_PTO_VENTA { get; set; }

        public String MNT_TOT_ANTCP
        {
            get
            {
                if (vMNT_TOT_ANTCP.Trim().Equals("")) vMNT_TOT_ANTCP = "0.00";
                return vMNT_TOT_ANTCP;
            }
            set { vMNT_TOT_ANTCP = value; }
        }
    }
    public class CPE_DAT_ADIC_BE
    {
        public String COD_TIP_ADIC_SUNAT { get; set; }
        public String TXT_DESC_ADIC_SUNAT { get; set; }

    }
    public class CPE_DETALLE_BE
    {
        private String vMNT_OTR_ITEM = "0.00";
        private String vPOR_OTR_ITEM = "0.00";
        private String vPRC_VTA_UNIT_ITEM = "0.00";
        private String vVAL_UNIT_ITEM = "0.00";
        private String vVAL_VTA_ITEM = "0.00";
        private String vMNT_DSCTO_ITEM = "0.00";
        private String vMNT_RECGO_ITEM = "0.00";
        private String vMNT_IGV_ITEM = "0.00";
        private String vPOR_IGV_ITEM = "0.00";
        private String vMNT_ISC_ITEM = "0.00";
        private String vPOR_ISC_ITEM = "0.00";
        private String vCANT_UNID_ITEM = "0.00";
        private String vMNT_PV_ITEM = "0.00";
        private decimal vMntTotalItem;
        private String VMontoBruto = "0.00";
        public string DSCTO_DET_PORC
        {
            get
            {
                double MntTotalValorVenta = 0, PorcDescuento = 0;
                MntTotalValorVenta = double.Parse(VAL_VTA_ITEM) + double.Parse(MNT_DSCTO_ITEM);
                PorcDescuento = Math.Round(double.Parse(MNT_DSCTO_ITEM) / MntTotalValorVenta, 5, MidpointRounding.AwayFromZero);
                return PorcDescuento.ToString("F5", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
        public CPE_DETALLE_BE()
        {
            COD_TIP_PRC_VTA = "01";
            COD_TRIB_IGV_ITEM = "1000";
            NOM_TRIB_IGV_ITEM = "IGV";
            COD_INTER_IGV_ITEM = "VAT";
            COD_TIP_SIST_ISC = "01";
            COD_TRIB_ISC_ITEM = "2000";
            NOM_TRIB_ISC_ITEM = "ISC";
            COD_INTER_ISC_ITEM = "EXC";
            MNT_OTR_ITEM = "0.00";
            POR_OTR_ITEM = "0.00";
            PRC_VTA_UNIT_ITEM = "0.00";
            VAL_UNIT_ITEM = "0.00";
            VAL_VTA_ITEM = "0.00";
            MNT_DSCTO_ITEM = "0.00";
            MNT_RECGO_ITEM = "0.00";
            MNT_IGV_ITEM = "0.00";
            POR_IGV_ITEM = "0.00";
            MNT_ISC_ITEM = "0.00";
            POR_ISC_ITEM = "0.00";
            TXT_DESC_ADIC_ITEM = "";
            MNT_PV_ITEM = "0.00";
            COD_ITEM_SUNAT = "00000000";
            CTA_CONTABLE_VENTA = "";

        }
        //ORC 28-12-2016
        public String MNT_PV_ITEM
        {
            get
            {

                //vMNT_PV_ITEM = ((decimal.Parse(PRC_VTA_UNIT_ITEM)  - double.Parse(MNT_DSCTO_ITEM)) * double.Parse(CANT_UNID_ITEM)).ToString("0.00");
                // vMntTotalItem = (decimal.Parse(VAL_VTA_ITEM, System.Globalization.CultureInfo.CreateSpecificCulture("en-US")) -
                //              decimal.Parse(MNT_DSCTO_ITEM, System.Globalization.CultureInfo.CreateSpecificCulture("en-US")))*1.18;
                //if (MNT_PV_ITEM == "" || MNT_PV_ITEM == "0.00")
                //{
                //    vMntTotalItem = (decimal.Parse(PRC_VTA_UNIT_ITEM, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
                //                     *
                //               decimal.Parse(CANT_UNID_ITEM, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))) -
                //                    decimal.Parse(MNT_DSCTO_ITEM, System.Globalization.CultureInfo.CreateSpecificCulture("en-US")) *
                //                    decimal.Parse("1.18", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));


                //    vMNT_PV_ITEM = vMntTotalItem.ToString("F2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                //}
                //  vMNT_PV_ITEM = vMNT_PV_ITEM.Replace(",", ".");
                if (vMNT_PV_ITEM.Trim() == "" || vMNT_PV_ITEM.Trim() == "0" || vMNT_PV_ITEM.Trim() == "0.00")
                {
                    vMntTotalItem = (decimal.Parse(PRC_VTA_UNIT_ITEM, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
                                     *
                               decimal.Parse(CANT_UNID_ITEM, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))) -
                                    decimal.Parse(MNT_DSCTO_ITEM, System.Globalization.CultureInfo.CreateSpecificCulture("en-US")) *
                                    decimal.Parse("1.18", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));


                    vMNT_PV_ITEM = vMntTotalItem.ToString("F2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                }

                return vMNT_PV_ITEM;
            }
            set { vMNT_PV_ITEM = value; }
        }
        public String MNT_BRUTO
        {
            get
            {
                decimal VMontoBrutoTotal;
                VMontoBrutoTotal = (decimal.Parse(VAL_VTA_ITEM, System.Globalization.CultureInfo.CreateSpecificCulture("en-US")))
                                    +
                                    decimal.Parse(MNT_DSCTO_ITEM, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));


                VMontoBruto = VMontoBrutoTotal.ToString("F2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));


                return VMontoBruto;
            }
            set { VMontoBruto = value; }
        }
        public String NUM_CPE { get; set; }
        public String NUM_SEQ { get; set; }
        public String NUM_LIN_ITEM { get; set; }
        public String COD_UNID_ITEM { get; set; }
        public String CANT_UNID_ITEM
        {
            get
            {
                if (vCANT_UNID_ITEM.Trim().Equals("")) vCANT_UNID_ITEM = "0.00";
                return vCANT_UNID_ITEM;
            }
            set { vCANT_UNID_ITEM = value; }
        }
        public String VAL_VTA_ITEM
        {
            get
            {
                if (vVAL_VTA_ITEM.Trim().Equals("")) vVAL_VTA_ITEM = "0.00";
                return vVAL_VTA_ITEM;
            }
            set { vVAL_VTA_ITEM = value; }
        }
        public String PRC_VTA_UNIT_ITEM
        {
            get
            {
                if (vPRC_VTA_UNIT_ITEM.Trim().Equals("")) vPRC_VTA_UNIT_ITEM = "0.00";
                return vPRC_VTA_UNIT_ITEM;
            }
            set { vPRC_VTA_UNIT_ITEM = value; }
        }
        public String COD_TIP_PRC_VTA { get; set; }
        public String COD_TRIB_IGV_ITEM { get; set; }
        public String POR_IGV_ITEM
        {
            get
            {
                if (vPOR_IGV_ITEM.Trim().Equals("")) vPOR_IGV_ITEM = "0.00";
                return vPOR_IGV_ITEM;
            }
            set { vPOR_IGV_ITEM = value; }
        }
        public String MNT_IGV_ITEM
        {
            get
            {
                if (vMNT_IGV_ITEM.Trim().Equals("")) vMNT_IGV_ITEM = "0.00";
                return vMNT_IGV_ITEM;
            }
            set { vMNT_IGV_ITEM = value; }
        }
        public String COD_TIP_AFECT_IGV_ITEM { get; set; }
        public String COD_TRIB_ISC_ITEM { get; set; }
        public String POR_ISC_ITEM
        {
            get
            {
                if (vPOR_ISC_ITEM.Trim().Equals("")) vPOR_ISC_ITEM = "0.00";
                return vPOR_ISC_ITEM;
            }
            set { vPOR_ISC_ITEM = value; }
        }
        public String MNT_ISC_ITEM
        {
            get
            {
                if (vMNT_ISC_ITEM.Trim().Equals("")) vMNT_ISC_ITEM = "0.00";
                return vMNT_ISC_ITEM;
            }
            set { vMNT_ISC_ITEM = value; }
        }
        public String COD_TIP_SIST_ISC { get; set; }
        public String MNT_OTR_ITEM
        {
            get
            {
                if (vMNT_OTR_ITEM.Trim().Equals("")) vMNT_OTR_ITEM = "0.00";
                return vMNT_OTR_ITEM;
            }
            set { vMNT_OTR_ITEM = value; }
        }
        public String POR_OTR_ITEM
        {
            get
            {
                if (vPOR_OTR_ITEM.Trim().Equals("")) vPOR_OTR_ITEM = "0.00";
                return vPOR_OTR_ITEM;
            }
            set { vPOR_OTR_ITEM = value; }
        }
        public String TXT_DESC_ITEM { get; set; }
        public String TXT_DESC_ADIC_ITEM { get; set; }
        public String COD_ITEM { get; set; }
        public String VAL_UNIT_ITEM
        {
            get
            {
                if (vVAL_UNIT_ITEM.Trim().Equals("")) vVAL_UNIT_ITEM = "0.00";
                return vVAL_UNIT_ITEM;
            }
            set { vVAL_UNIT_ITEM = value; }
        }
        //public String NUM_ORD_ITEM { get; set; }
        //public String COD_TIP_PRC_ITEM { get; set; } 
        //public String IND_DSCTO_ITEM { get; set; }
        public String MNT_DSCTO_ITEM
        {
            get
            {
                if (vMNT_DSCTO_ITEM.Trim().Equals("")) vMNT_DSCTO_ITEM = "0.00";
                return vMNT_DSCTO_ITEM;
            }
            set { vMNT_DSCTO_ITEM = value; }
        }
        public String MNT_RECGO_ITEM
        {
            get
            {
                if (vMNT_RECGO_ITEM.Trim().Equals("")) vMNT_RECGO_ITEM = "0.00";
                return vMNT_RECGO_ITEM;
            }
            set { vMNT_RECGO_ITEM = value; }
        }
        public String NOM_TRIB_IGV_ITEM { get; set; }
        public String COD_INTER_IGV_ITEM { get; set; }
        public String NOM_TRIB_ISC_ITEM { get; set; }
        public String COD_INTER_ISC_ITEM { get; set; }

        public String DET_VAL_ADIC01 { get; set; }
        public String DET_VAL_ADIC02 { get; set; }
        public String DET_VAL_ADIC03 { get; set; }
        public String DET_VAL_ADIC04 { get; set; }
        public String DET_VAL_ADIC05 { get; set; }
        public String DET_VAL_ADIC06 { get; set; }
        public String DET_VAL_ADIC07 { get; set; }
        public String DET_VAL_ADIC08 { get; set; }
        public String DET_VAL_ADIC09 { get; set; }
        public String DET_VAL_ADIC10 { get; set; }
        public String COD_ITEM_SUNAT { get; set; }
        public String CTA_CONTABLE_VENTA { get; set; }
    }
    public class CPE_DOC_REF_BE
    {
        private String vSERIE_CORRE_CPE_REF = "";
        public String NUM_LIN_REF { get; set; }
        public String COD_TIP_DOC_REF { get; set; }
        public String NUM_SERIE_CPE_REF { get; set; }
        public String NUM_CORRE_CPE_REF { get; set; }
        public String FEC_DOC_REF { get; set; }
        public String COD_TIP_OTR_DOC_REF { get; set; }
        public String NUM_OTR_DOC_REF { get; set; }

        public String SERIE_CORRE_CPE_REF
        {
            get
            {
                return NUM_SERIE_CPE_REF + "-" + NUM_CORRE_CPE_REF;
            }
            set { vSERIE_CORRE_CPE_REF = value; }
        }
    }
    public class CPE_ANTICIPO_BE
    {
        private String vNUM_LIN_ANTCP = null;
        private String vMNT_ANTCP = null;
        private String vCOD_TIP_DOC_ANTCP = "";
        private String vNUM_SERIE_CPE_ANTCP = "";
        private String vNUM_CORRE_CPE_ANTCP = "";

        public string FEC_ANTICIPO { get; set; }
        public String NUM_LIN_ANTCP
        {
            get { return vNUM_LIN_ANTCP; }
            set { vNUM_LIN_ANTCP = value; }
        }

        public String MNT_ANTCP
        {
            get { return vMNT_ANTCP; }
            set { vMNT_ANTCP = value; }
        }

        public String COD_TIP_DOC_ANTCP
        {
            get { return vCOD_TIP_DOC_ANTCP; }
            set { vCOD_TIP_DOC_ANTCP = value; }
        }

        public String NUM_SERIE_CPE_ANTCP
        {
            get { return vNUM_SERIE_CPE_ANTCP; }
            set { vNUM_SERIE_CPE_ANTCP = value; }
        }

        public String NUM_CORRE_CPE_ANTCP
        {
            get { return vNUM_CORRE_CPE_ANTCP; }
            set { vNUM_CORRE_CPE_ANTCP = value; }
        }

        public String SERIE_CORRE_ANTCP
        {
            get { return NUM_SERIE_CPE_ANTCP + "-" + NUM_CORRE_CPE_ANTCP; }
        }

        public CPE_ANTICIPO_BE()
        {
            FEC_ANTICIPO = "";
        }

    }
    public class CPE_FAC_GUIA_BE
    {
        // Dirección del punto de Partida
        public String COD_UBI_PRTD { get; set; }
        public String TXT_DMCL_FISC_PRTD { get; set; }
        public String TXT_URB_PRTD { get; set; }
        public String TXT_PROV_PRTD { get; set; }
        public String TXT_DPTO_PRTD { get; set; }
        public String TXT_DISTR_PRTD { get; set; }
        public String TXT_PAIS_PRTD { get; set; }
        // Dirección del punto de Llegada
        public String COD_UBI_LLGD { get; set; }
        public String TXT_DMCL_FISC_LLGD { get; set; }
        public String TXT_URB_LLGD { get; set; }
        public String TXT_PROV_LLGD { get; set; }
        public String TXT_DPTO_LLGD { get; set; }
        public String TXT_DISTR_LLGD { get; set; }
        public String TXT_PAIS_LLGD { get; set; }
        // Marca y placa del vehiculo
        public String PLACA_AUTO_TRNSP { get; set; }
        public String CERT_AUTO_TRNSP { get; set; }
        public String MARCA_AUTO_TRNSP { get; set; }
        // N° de Licencia de conducir
        public String LIC_COND_TRNSP { get; set; }
        // RUC de transportista
        public String RUC_TRNSP { get; set; }
        public String COD_OTR_TRNSP { get; set; }
        // Razón Social del Transportista
        public String RZN_SCL_TRNSP { get; set; }
        // Modalidad de Transporte
        public String COD_MOD_TRNSP { get; set; }
        // Total de Peso Bruto
        public String TOT_PSO_BRUTO { get; set; }
        public String COD_UND_MEDIDA { get; set; }
        public String DETALLE_VIAJE { get; set; }
        public String VALOR_REF_SERV_TRANSP { get; set; }
        public String VALOR_REF_CARGA_EFECT { get; set; }
        public String VALOR_REF_CARGA_UTIL { get; set; }
        public CPE_FAC_GUIA_BE()
        {
            COD_UBI_PRTD = "150101";
            TXT_DMCL_FISC_PRTD = "";
            TXT_URB_PRTD = "";
            TXT_PROV_PRTD = "";
            TXT_DPTO_PRTD = "";
            TXT_DISTR_PRTD = "";
            TXT_PAIS_PRTD = "";
            // Dirección del punto de Llegada
            COD_UBI_LLGD = "";
            TXT_DMCL_FISC_LLGD = "";
            TXT_URB_LLGD = "";
            TXT_PROV_LLGD = "";
            TXT_DPTO_LLGD = "";
            TXT_DISTR_LLGD = "";
            TXT_PAIS_LLGD = "";
            // Marca y placa del vehiculo
            PLACA_AUTO_TRNSP = "";
            CERT_AUTO_TRNSP = "";
            MARCA_AUTO_TRNSP = "";
            // N° de Licencia de conducir
            LIC_COND_TRNSP = "";
            // RUC de transportista
            RUC_TRNSP = "";
            COD_OTR_TRNSP = "";
            // Razón Social del Transportista
            RZN_SCL_TRNSP = "";
            // Modalidad de Transporte
            COD_MOD_TRNSP = "";
            // Total de Peso Bruto
            TOT_PSO_BRUTO = "0.00";
            COD_UND_MEDIDA = "";
            DETALLE_VIAJE = "";
            VALOR_REF_SERV_TRANSP = "0.00";
            VALOR_REF_CARGA_EFECT = "0.00";
            VALOR_REF_CARGA_UTIL = "0.00";
        }

    }
}
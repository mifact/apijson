# apijson
Integración api para software de terceros con la plataforma mifact
Para poder hacer las pruebas debera conectar su aplicacion con nuestra plataforma mifact mediante el apirest bajo el formato Json, para ello usted tiene un excel llamado DocumentacionFV_BV_NC_ND_Json.xlsx para el caso de facturas, boeletas, notas de credito y debito y DocumentacionGuiaRemisionJson.xlsx para guia de remision remitente.
DocumentacionRetencionJson.xlsx para retenciones

Estructura para Facturas, Boletas, Notas de creedito y Debito (carpeta: integracionConJson_FV_BV_NC_ND):

    Carpeta Codigos Fuentes Varios Lenguajes: contiene ejemplo para lenguaje Visual Studio C#

    Carpeta Ejemplos Archivos JSON UBL 2_1: contiene ejemplos json armados para distintos escenarios, Factura normal, operaciones Inafectas, exonerads, exportacion etre otras, anular documento, ver estados, ver PDF, XML y CDR.

    Archivo DocumentacionFV_BV_NC_ND_Json.xlsx: contiene que tags soporta el servicio api, que siginifica cada tag y que                      restricciones tiene,    tambien contiene los catalogos de SUNAT, respuesta del servicio API y su tratamiento.

    Archivo URLs_PRUEBAS.txt: estan las URL de pruebas, el token de conexion y un ruc de pruebas, cuando termine de hacer sus pruebas debera de cambiar la URL por la de produccion, cambiar el token por cada RUC (emisor).


Estructura para Guia de remision Remitente (carpeta integracionConJson_GuiaRemision):
    Carpeta Ejemplos Archivos JSON: contiene ejemplos json armados para distintos escenarios, anulaciones, enviar correo, ver estado, descargar pdf.

    Archivo DocumentacionGuiaRemisionJson.xlsx: contiene que tags soporta el servicio api, que siginifica cada tag y que            restricciones tiene,    tambien contiene los catalogos de SUNAT, respuesta del servicio API y su tratamiento.

    Archivo URLs_PRUEBAS.txt: estan las URL de pruebas, el token de conexion y un ruc de pruebas, cuando termine de hacer sus pruebas debera de cambiar la URL por la de produccion, cambiar el token por cada RUC (emisor). 

Estructura para Retenciones (integracionConJson_RetencionesPercepciones):
    Carpeta Ejemplos Archivos JSON: contiene ejemplos json armados para distintos escenarios, anulaciones, enviar correo, ver estado, descargar pdf.

    Archivo DocumentacionRetencionJson.xlsx: contiene que tags soporta el servicio api, que siginifica cada tag y que            restricciones tiene,    tambien contiene los catalogos de SUNAT, respuesta del servicio API y su tratamiento.

    Archivo URLs_PRUEBAS.txt: estan las URL de pruebas, el token de conexion y un ruc de pruebas, cuando termine de hacer sus pruebas debera de cambiar la URL por la de produccion, cambiar el token por cada RUC (emisor). 


El servicio de integración para consulta RUC es gratuito para nuestros partners autorizados, si usted ya es nuestro parnert, solicite las credenciales para el servicio de consulta RUC.

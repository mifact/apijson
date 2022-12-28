## Documentación para integrarse a la facturación electrónica de  boletas, facturas, nota de crédito, débito, contingencias, guía remisión de electrónica, retenciones y percepciones
Integración api para software de terceros con la plataforma mifact
Para poder hacer las pruebas deberá conectar su aplicación con nuestra plataforma mifact mediante el apirest bajo el formato Json, para ello usted tiene una estructura de carpetas y archivos para las facturas, boletas, notas de crédito, guía remisión, retenciones y percepciones. Existe un Excel llamado DocumentacionFV_BV_NC_ND_Json.xlsx para el caso de facturas, boletas, notas de crédito y débito y DocumentacionGuiaRemisionRemitenteJson.xlsx para guía de remisión remitente y DocumentacionGuiaRemisionTransportistaJson - copia.xlsx para guía remisión transportista. DocumentacionRetencionJson.xlsx para retenciones en estos archivos están los significados de cada campo (tag), existen ejemplos Json armados para cada escenario posible (se recomienda revisar los ejemplos en conjunto con la documentación del archivo Excel).
- Se sugiere armar la estructura json y probar la conexión con la aplicación de terceros llamado Postman o Insomnia estas herramientas le permiten conectar a servicios apirest mediante post y el json generado como se muestra en la imagen, después ya puede hacer el llamado desde su aplicación.
[![Imagen Prueba de Conexión al servicio mifact](https://img-logos-mifact.s3.amazonaws.com/JsonConexionMifact.png "Imagen Prueba de Conexión al servicio mifact")](https://img-logos-mifact.s3.amazonaws.com/JsonConexionMifact.png "Imagen Prueba de Conexión al servicio mifact")

- La estructura de respuesta del servicio está en el archivo excel que se indica lineas abajo.
## Estructura para Facturas, Boletas, Notas de crédito y débito (carpeta: integracionConJson_FV_BV_NC_ND) 👇


- Carpeta códigos Fuentes Varios Lenguajes: contiene ejemplo para lenguaje Visual Studio C# [Ver Carpeta](https://github.com/mifact/apijson/tree/master/integracionConJson_FV_BV_NC_ND/Codigos%20Fuentes%20Varios%20Lenguajes)
- ***Carpeta con Ejemplos*** Archivos JSON UBL 2_1: contiene ejemplos json armados para distintos escenarios, Factura normal, operaciones Inafectas, exoneradas, exportación etre otras, anular documento, ver estados, ver PDF, XML y CDR. [Ver Carpeta](https://github.com/mifact/apijson/tree/master/integracionConJson_FV_BV_NC_ND/Ejemplos%20Archivos%20JSON%20UBL%202_1)
- Archivo DocumentacionFV_BV_NC_ND_Json.xlsx: contiene que tags soporta el servicio api, que significa cada tag y que restricciones tiene, también contiene los catálogos de SUNAT, respuesta del servicio API y su tratamiento.  [Descargar archivo (botón Download)](https://github.com/mifact/apijson/blob/master/integracionConJson_FV_BV_NC_ND/DocumentacionFV_BV_NC_ND_Json.xlsx) 
- Archivo URLs_PRUEBAS.txt: están las URL de pruebas y métodos (envió de documento "nueva emisión", consultar PDF, XML y CDR, consultar el estado del documento, enviar correo electrónico, anular documento. Cuando termine de hacer sus pruebas deberá de cambiar la URL por la de producción, el token de pruebas y el RUC del emisor. (cambiar el token y URL por cada RUC emisor). [Ver Archivo](https://github.com/mifact/apijson/blob/master/integracionConJson_FV_BV_NC_ND/URLs_PRUEBAS.txt) 

## Estructura para guía de Remisión Remitente (carpeta integracionConJson_GuiaRemision) 👇
- Carpeta con Ejemplos Archivos JSON: contiene ejemplos json armados para distintos escenarios, anulaciones, enviar correo, ver estado, descargar pdf.[ ver carpeta](https://github.com/mifact/apijson/tree/master/integracionConJson_GuiaRemision/Ejemplos%20Archivos%20JSON)
- Archivo DocumentacionGuiaRemisionRemitenteJson.xlsx: contiene que tags  soporta el servicio api, que significa cada tag y que restricciones tiene, también contiene los catálogos de SUNAT, respuesta del servicio API y su tratamiento.
 [Descargar archivo (botón Download)](https://github.com/mifact/apijson/blob/master/integracionConJson_GuiaRemision/DocumentacionGuiaRemisionRemitenteJson.xlsx)
-  Archivo URLs_PRUEBAS.txt: están las URL de pruebas, el token de conexión y un ruc de pruebas, cuando termine de hacer sus pruebas deberá de cambiar la URL por la de producción, cambiar el token por cada RUC (emisor).  [Ver Archivo](https://github.com/mifact/apijson/blob/master/integracionConJson_GuiaRemision/URLs_PRUEBAS.txt)
- NOTA IMPORTANTE: Por favor tome en cuenta que tenemos un ambiente de pruebas con casuísticas limitadas. Para hacer una validación plena se deberá hacer directamente en producción con los servidores de SUNAT (validación de placas, DNI, licencia de conducir, registros MTC etc). Está limitación se debe a que SUNAT no tiene servidores de pruebas para Guías de Remisión Electrónicas.

## Estructura para guía de Remisión Transportista (carpeta integracionConJson_GuiaRemision) 👇
- Carpeta con Ejemplos Archivos JSON: contiene ejemplos json armados para distintos escenarios, anulaciones, enviar correo, ver estado, descargar pdf.[ ver carpeta](https://github.com/mifact/apijson/tree/master/integracionConJson_GuiaRemision/Ejemplos%20Archivos%20JSON)
- Archivo DocumentacionGuiaRemisionTransportistaJson.xlsx: contiene que tags  soporta el servicio api, que significa cada tag y que restricciones tiene, también contiene los catálogos de SUNAT, respuesta del servicio API y su tratamiento.
 [Descargar archivo (botón Download)](https://github.com/mifact/apijson/blob/master/integracionConJson_GuiaRemision/DocumentacionGuiaRemisionTransportistaJson.xlsx) 
-  Archivo URLs_PRUEBAS.txt: están las URL de pruebas, el token de conexión y un ruc de pruebas, cuando termine de hacer sus pruebas deberá de cambiar la URL por la de producción, cambiar el token por cada RUC (emisor).  [Ver Archivo](https://github.com/mifact/apijson/blob/master/integracionConJson_GuiaRemision/URLs_PRUEBAS.txt) 
- NOTA IMPORTANTE: Por favor tome en cuenta que tenemos un ambiente de pruebas con casuísticas limitadas. Para hacer una validación plena se deberá hacer directamente en producción con los servidores de SUNAT (validación de placas, DNI, licencia de conducir, registros MTC etc). Está limitación se debe a que SUNAT no tiene servidores de pruebas para Guías de Remisión Electrónicas.

## Estructura para Retenciones (integracionConJson_RetencionesPercepciones) 👇
- Carpeta Ejemplos Archivos JSON: contiene ejemplos json armados para distintos escenarios, anulaciones, enviar correo, ver estado, descargar pdf. [Ver Carpeta](https://github.com/mifact/apijson/tree/master/integracionConJson_RetencionesPercepciones/Ejemplos_Json_Retencion)
- Archivo DocumentacionRetencionJson.xlsx: contiene que tags soporta el servicio api, que significa cada tag y que restricciones tiene, también contiene los catálogos de SUNAT, respuesta del servicio API y su tratamiento.  [Descargar archivo (botón Download)](https://github.com/mifact/apijson/blob/master/integracionConJson_RetencionesPercepciones/DocumentacionRetencionJson.xlsx) 

- Archivo URLs_PRUEBAS.txt: están las URL de pruebas, el token de conexión y un ruc de pruebas, cuando termine de hacer sus pruebas deberá de cambiar la URL por la de producción, cambiar el token por cada RUC (emisor).  [Ver Archivo](https://github.com/mifact/apijson/blob/master/integracionConJson_RetencionesPercepciones/URLs_PRUEBAS.txt)
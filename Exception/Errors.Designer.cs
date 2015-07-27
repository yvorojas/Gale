﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gale.Exception {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Errors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Errors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Gale.Exception.Errors", typeof(Errors).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Acceso no autorizado.
        /// </summary>
        internal static string ACCESS_UNAUTHORIZED {
            get {
                return ResourceManager.GetString("ACCESS_UNAUTHORIZED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se pudo establecer el valor enviado en la propiedad &quot;{0}&quot; para la tabla &quot;{1}&quot;.
        /// </summary>
        internal static string API_CANT_SETVALUE {
            get {
                return ResourceManager.GetString("API_CANT_SETVALUE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ha ocurrido un error con la conexión a la base de datos (&quot;{0}&quot;).
        /// </summary>
        internal static string API_DB_ERROR {
            get {
                return ResourceManager.GetString("API_DB_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se ha enviado algun dato en el cuerpo del mensaje.
        /// </summary>
        internal static string API_EMPTY_BODY {
            get {
                return ResourceManager.GetString("API_EMPTY_BODY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El valor del operator &quot;Equals&quot; debe estar entre comillas simples.
        /// </summary>
        internal static string API_OP_CONTAINS_WITHOUT_QUOTE {
            get {
                return ResourceManager.GetString("API_OP_CONTAINS_WITHOUT_QUOTE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El valor del operator &quot;Equals&quot; debe estar entre comillas simples.
        /// </summary>
        internal static string API_OP_EQUAL_WITHOUT_QUOTE {
            get {
                return ResourceManager.GetString("API_OP_EQUAL_WITHOUT_QUOTE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se encuentra la relación para el tipo &quot;{0}&quot;.
        /// </summary>
        internal static string API001 {
            get {
                return ResourceManager.GetString("API001", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Para implementar el operador es necesario que tenga el attributo &quot;Gale.API.Common.Operator&quot; en su declaración y que contenga un alias de identificación.
        /// </summary>
        internal static string API002 {
            get {
                return ResourceManager.GetString("API002", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to La tabla de resumen devuelta por la base de datos no contiene el campo &quot;total&quot; , para poder mostrar la información de paginacion.
        /// </summary>
        internal static string API003 {
            get {
                return ResourceManager.GetString("API003", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El operator &quot;{0}&quot; no existe o no ha sido registrado por el alias .
        /// </summary>
        internal static string API004 {
            get {
                return ResourceManager.GetString("API004", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo &quot;{0}&quot; filtrado por la clausula &quot;{0}&quot; no existe en el modelo consultado.
        /// </summary>
        internal static string API005 {
            get {
                return ResourceManager.GetString("API005", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formato Incorrecto para la clausula de filtro &quot;{0}&quot;.
        /// </summary>
        internal static string API006 {
            get {
                return ResourceManager.GetString("API006", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se encuentra mapeado el modelo &quot;{0}&quot; para crear una tabla .
        /// </summary>
        internal static string API007 {
            get {
                return ResourceManager.GetString("API007", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Los sinonimos de los campos mapeados (&quot;{0}&quot;) , deben ser distintos a los nombres originales de la fuente..
        /// </summary>
        internal static string API008 {
            get {
                return ResourceManager.GetString("API008", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to La columna foranea &quot;{0}&quot; para la clausula de filtado no se encuentra en el modelo.
        /// </summary>
        internal static string API009 {
            get {
                return ResourceManager.GetString("API009", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formato incorrecto para el filtro foraneo &quot;{0}&quot;.
        /// </summary>
        internal static string API010 {
            get {
                return ResourceManager.GetString("API010", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formato incorrecto la seleccion de campos, los campos deben ir separados por el caracter &quot;,&quot;.
        /// </summary>
        internal static string API011 {
            get {
                return ResourceManager.GetString("API011", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formato incorrecto para la selección de los campos de tablas foraneas &quot;{0}&quot;..
        /// </summary>
        internal static string API012 {
            get {
                return ResourceManager.GetString("API012", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to no se encuentra la columna para el filtro de selección &quot;{0}&quot;.
        /// </summary>
        internal static string API013 {
            get {
                return ResourceManager.GetString("API013", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo de llave primaria  no puede ser objeto de filtro..
        /// </summary>
        internal static string API014 {
            get {
                return ResourceManager.GetString("API014", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se encuentra el campo &quot;{0}&quot;.
        /// </summary>
        internal static string API015 {
            get {
                return ResourceManager.GetString("API015", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El orden de una columna solo puede ser asc (ascendente) o desc (descendiente).
        /// </summary>
        internal static string API016 {
            get {
                return ResourceManager.GetString("API016", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formato incorrecto para la clausula orderby.
        /// </summary>
        internal static string API017 {
            get {
                return ResourceManager.GetString("API017", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El uso de el operador like solo esta disponible para campos de tipo texto.
        /// </summary>
        internal static string API018 {
            get {
                return ResourceManager.GetString("API018", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debe existir una llave primaria para la tabla &quot;{0}&quot;.
        /// </summary>
        internal static string API019 {
            get {
                return ResourceManager.GetString("API019", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se ha encontrado la cabecera de autenticación requerida.
        /// </summary>
        internal static string BEARER_TOKEN_NOT_FOUND {
            get {
                return ResourceManager.GetString("BEARER_TOKEN_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ha ocurrido un error en la conexión de la fuente de datos.
        /// </summary>
        internal static string DB001 {
            get {
                return ResourceManager.GetString("DB001", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to La cadena de conexion &quot;Application:default&quot; en el web.config no ha sido inicializada.
        /// </summary>
        internal static string DB002 {
            get {
                return ResourceManager.GetString("DB002", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se encuentra el valor del &quot;claim&quot; buscado.
        /// </summary>
        internal static string SECURITY_CLAIMS_NOT_FOUND {
            get {
                return ResourceManager.GetString("SECURITY_CLAIMS_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se encuentra una autenticación basada en &quot;claims&quot;..
        /// </summary>
        internal static string SECURITY_CLAIMS_NOT_IMPLEMENTED {
            get {
                return ResourceManager.GetString("SECURITY_CLAIMS_NOT_IMPLEMENTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El Token de autenticación ha expirado.
        /// </summary>
        internal static string TOKEN_EXPIRED {
            get {
                return ResourceManager.GetString("TOKEN_EXPIRED", resourceCulture);
            }
        }
    }
}

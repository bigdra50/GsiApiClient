/*
 * 国土地理院測量計算API
 *
 * 国土地理院が提供する測量計算のためのREST API
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = GsiApi.Client.OpenAPIDateConverter;

namespace GsiApi.Model
{
    /// <summary>
    /// SurveycalcTransPlGet400Response
    /// </summary>
    [DataContract(Name = "_surveycalc_trans_pl_get_400_response")]
    public partial class SurveycalcTransPlGet400Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveycalcTransPlGet400Response" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        public SurveycalcTransPlGet400Response(string error = default(string))
        {
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SurveycalcTransPlGet400Response {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

    }

}
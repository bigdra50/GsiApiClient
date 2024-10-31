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
    /// SurveycalcBl2xyPlGet200ResponseOutputData
    /// </summary>
    [DataContract(Name = "_surveycalc_bl2xy_pl_get_200_response_OutputData")]
    public partial class SurveycalcBl2xyPlGet200ResponseOutputData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveycalcBl2xyPlGet200ResponseOutputData" /> class.
        /// </summary>
        /// <param name="publicX">publicX.</param>
        /// <param name="publicY">publicY.</param>
        /// <param name="gridConv">gridConv.</param>
        /// <param name="scaleFactor">scaleFactor.</param>
        public SurveycalcBl2xyPlGet200ResponseOutputData(double publicX = default(double), double publicY = default(double), decimal gridConv = default(decimal), decimal scaleFactor = default(decimal))
        {
            this.PublicX = publicX;
            this.PublicY = publicY;
            this.GridConv = gridConv;
            this.ScaleFactor = scaleFactor;
        }

        /// <summary>
        /// Gets or Sets PublicX
        /// </summary>
        [DataMember(Name = "publicX", EmitDefaultValue = false)]
        public double PublicX { get; set; }

        /// <summary>
        /// Gets or Sets PublicY
        /// </summary>
        [DataMember(Name = "publicY", EmitDefaultValue = false)]
        public double PublicY { get; set; }

        /// <summary>
        /// Gets or Sets GridConv
        /// </summary>
        [DataMember(Name = "gridConv", EmitDefaultValue = false)]
        public decimal GridConv { get; set; }

        /// <summary>
        /// Gets or Sets ScaleFactor
        /// </summary>
        [DataMember(Name = "scaleFactor", EmitDefaultValue = false)]
        public decimal ScaleFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SurveycalcBl2xyPlGet200ResponseOutputData {\n");
            sb.Append("  PublicX: ").Append(PublicX).Append("\n");
            sb.Append("  PublicY: ").Append(PublicY).Append("\n");
            sb.Append("  GridConv: ").Append(GridConv).Append("\n");
            sb.Append("  ScaleFactor: ").Append(ScaleFactor).Append("\n");
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
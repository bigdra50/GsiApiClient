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
    /// SurveycalcXy2stPlGet200ResponseOutputData
    /// </summary>
    [DataContract(Name = "_surveycalc_xy2st_pl_get_200_response_OutputData")]
    public partial class SurveycalcXy2stPlGet200ResponseOutputData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveycalcXy2stPlGet200ResponseOutputData" /> class.
        /// </summary>
        /// <param name="geoLength">geoLength.</param>
        /// <param name="gridBearing1">gridBearing1.</param>
        /// <param name="gridBearing2">gridBearing2.</param>
        public SurveycalcXy2stPlGet200ResponseOutputData(double geoLength = default(double), double gridBearing1 = default(double), double gridBearing2 = default(double))
        {
            this.GeoLength = geoLength;
            this.GridBearing1 = gridBearing1;
            this.GridBearing2 = gridBearing2;
        }

        /// <summary>
        /// Gets or Sets GeoLength
        /// </summary>
        [DataMember(Name = "geoLength", EmitDefaultValue = false)]
        public double GeoLength { get; set; }

        /// <summary>
        /// Gets or Sets GridBearing1
        /// </summary>
        [DataMember(Name = "gridBearing1", EmitDefaultValue = false)]
        public double GridBearing1 { get; set; }

        /// <summary>
        /// Gets or Sets GridBearing2
        /// </summary>
        [DataMember(Name = "gridBearing2", EmitDefaultValue = false)]
        public double GridBearing2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SurveycalcXy2stPlGet200ResponseOutputData {\n");
            sb.Append("  GeoLength: ").Append(GeoLength).Append("\n");
            sb.Append("  GridBearing1: ").Append(GridBearing1).Append("\n");
            sb.Append("  GridBearing2: ").Append(GridBearing2).Append("\n");
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

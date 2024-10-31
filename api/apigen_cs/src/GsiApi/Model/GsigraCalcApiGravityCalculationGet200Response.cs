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
    /// GsigraCalcApiGravityCalculationGet200Response
    /// </summary>
    [DataContract(Name = "_gsigra_calc_api_gravityCalculation_get_200_response")]
    public partial class GsigraCalcApiGravityCalculationGet200Response
    {
        /// <summary>
        /// Defines Result
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultEnum
        {
            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 1
        }


        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "Result", EmitDefaultValue = false)]
        public ResultEnum? Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GsigraCalcApiGravityCalculationGet200Response" /> class.
        /// </summary>
        /// <param name="calcResult">calcResult.</param>
        /// <param name="result">result.</param>
        public GsigraCalcApiGravityCalculationGet200Response(GsigraCalcApiGravityCalculationGet200ResponseCalcResult calcResult = default(GsigraCalcApiGravityCalculationGet200ResponseCalcResult), ResultEnum? result = default(ResultEnum?))
        {
            this.CalcResult = calcResult;
            this.Result = result;
        }

        /// <summary>
        /// Gets or Sets CalcResult
        /// </summary>
        [DataMember(Name = "CalcResult", EmitDefaultValue = false)]
        public GsigraCalcApiGravityCalculationGet200ResponseCalcResult CalcResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GsigraCalcApiGravityCalculationGet200Response {\n");
            sb.Append("  CalcResult: ").Append(CalcResult).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
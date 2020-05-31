/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.5.20
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using HoneybeeSchema;


namespace DragonflySchema
{
    /// <summary>
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [DataContract]
    public partial class BuildingEnergyPropertiesAbridged : HoneybeeObject, IEquatable<BuildingEnergyPropertiesAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="constructionSet">Name of a ConstructionSet to specify all constructions for the Building. If None, the Model global_construction_set will be used..</param>
        public BuildingEnergyPropertiesAbridged
        (
             // Required parameters
            string constructionSet= default// Optional parameters
        )// BaseClass
        {
            this.ConstructionSet = constructionSet;

            // Set non-required readonly properties with defaultValue
            this.Type = "BuildingEnergyPropertiesAbridged";
        }
        
        /// <summary>
        /// Name of a ConstructionSet to specify all constructions for the Building. If None, the Model global_construction_set will be used.
        /// </summary>
        /// <value>Name of a ConstructionSet to specify all constructions for the Building. If None, the Model global_construction_set will be used.</value>
        [DataMember(Name="construction_set", EmitDefaultValue=false)]
        [JsonProperty("construction_set")]
        public string ConstructionSet { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"BuildingEnergyPropertiesAbridged {iDd.Identifier}";
       
            return "BuildingEnergyPropertiesAbridged";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("BuildingEnergyPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ConstructionSet: ").Append(ConstructionSet).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>BuildingEnergyPropertiesAbridged object</returns>
        public static BuildingEnergyPropertiesAbridged FromJson(string json)
        {
            return JsonConvert.DeserializeObject<BuildingEnergyPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BuildingEnergyPropertiesAbridged);
        }

        /// <summary>
        /// Returns true if BuildingEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildingEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildingEnergyPropertiesAbridged input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ConstructionSet == input.ConstructionSet ||
                    (this.ConstructionSet != null &&
                    this.ConstructionSet.Equals(input.ConstructionSet))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ConstructionSet != null)
                    hashCode = hashCode * 59 + this.ConstructionSet.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Type (string) pattern
            Regex regexType = new Regex(@"^BuildingEnergyPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // ConstructionSet (string) maxLength
            if(this.ConstructionSet != null && this.ConstructionSet.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConstructionSet, length must be less than 100.", new [] { "ConstructionSet" });
            }

            // ConstructionSet (string) minLength
            if(this.ConstructionSet != null && this.ConstructionSet.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConstructionSet, length must be greater than 1.", new [] { "ConstructionSet" });
            }

            yield break;
        }
    }

}

/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.5.9
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


namespace DragonflySchema
{
    /// <summary>
    /// A single overhang over an entire wall.
    /// </summary>
    [DataContract]
    public partial class Overhang :  IEquatable<Overhang>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Overhang" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Overhang() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Overhang" /> class.
        /// </summary>
        /// <param name="depth">A number for the overhang depth. (required).</param>
        /// <param name="angle">A number between -90 and 90 for the for an angle to rotate the overhang in degrees. 0 indicates an overhang perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation. (default to 0D).</param>
        public Overhang(double depth, double angle = 0D)
        {
            // to ensure "depth" is required (not null)
            if (depth == null)
            {
                throw new InvalidDataException("depth is a required property for Overhang and cannot be null");
            }
            else
            {
                this.Depth = depth;
            }
            
            // use default value if no "angle" provided
            if (angle == null)
            {
                this.Angle = 0D;
            }
            else
            {
                this.Angle = angle;
            }
        }
        
        /// <summary>
        /// A number for the overhang depth.
        /// </summary>
        /// <value>A number for the overhang depth.</value>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        [JsonProperty("depth")]
        public double Depth { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// A number between -90 and 90 for the for an angle to rotate the overhang in degrees. 0 indicates an overhang perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.
        /// </summary>
        /// <value>A number between -90 and 90 for the for an angle to rotate the overhang in degrees. 0 indicates an overhang perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.</value>
        [DataMember(Name="angle", EmitDefaultValue=false)]
        [JsonProperty("angle")]
        public double Angle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Overhang {\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Overhang object</returns>
        public static Overhang FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Overhang>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Overhang);
        }

        /// <summary>
        /// Returns true if Overhang instances are equal
        /// </summary>
        /// <param name="input">Instance of Overhang to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Overhang input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Angle == input.Angle ||
                    (this.Angle != null &&
                    this.Angle.Equals(input.Angle))
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
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Angle != null)
                    hashCode = hashCode * 59 + this.Angle.GetHashCode();
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
            Regex regexType = new Regex(@"^Overhang$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Angle (double) maximum
            if(this.Angle > (double)90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Angle, must be a value less than or equal to 90.", new [] { "Angle" });
            }

            // Angle (double) minimum
            if(this.Angle < (double)-90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Angle, must be a value greater than or equal to -90.", new [] { "Angle" });
            }

            yield break;
        }
    }

}

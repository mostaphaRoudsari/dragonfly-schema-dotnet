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
    /// Base class for all objects requiring a valid EnergyPlus identifier.
    /// </summary>
    [DataContract]
    public partial class ProgramType :  IEquatable<ProgramType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProgramType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramType" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="people">People to describe the occupancy of the program. If None, no occupancy will be assumed for the program..</param>
        /// <param name="lighting">Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program..</param>
        /// <param name="electricEquipment">ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed..</param>
        /// <param name="gasEquipment">GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed..</param>
        /// <param name="infiltration">Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program..</param>
        /// <param name="ventilation">Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed..</param>
        /// <param name="setpoint">Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned..</param>
        public ProgramType(string identifier, string displayName = default, People people = default, Lighting lighting = default, ElectricEquipment electricEquipment = default, GasEquipment gasEquipment = default, Infiltration infiltration = default, Ventilation ventilation = default, Setpoint setpoint = default)
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for ProgramType and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }
            
            this.DisplayName = displayName;
            this.People = people;
            this.Lighting = lighting;
            this.ElectricEquipment = electricEquipment;
            this.GasEquipment = gasEquipment;
            this.Infiltration = infiltration;
            this.Ventilation = ventilation;
            this.Setpoint = setpoint;
        }
        
        /// <summary>
        /// Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).
        /// </summary>
        /// <value>Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// People to describe the occupancy of the program. If None, no occupancy will be assumed for the program.
        /// </summary>
        /// <value>People to describe the occupancy of the program. If None, no occupancy will be assumed for the program.</value>
        [DataMember(Name="people", EmitDefaultValue=false)]
        [JsonProperty("people")]
        public People People { get; set; }

        /// <summary>
        /// Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program.
        /// </summary>
        /// <value>Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program.</value>
        [DataMember(Name="lighting", EmitDefaultValue=false)]
        [JsonProperty("lighting")]
        public Lighting Lighting { get; set; }

        /// <summary>
        /// ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed.
        /// </summary>
        /// <value>ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed.</value>
        [DataMember(Name="electric_equipment", EmitDefaultValue=false)]
        [JsonProperty("electric_equipment")]
        public ElectricEquipment ElectricEquipment { get; set; }

        /// <summary>
        /// GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed.
        /// </summary>
        /// <value>GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed.</value>
        [DataMember(Name="gas_equipment", EmitDefaultValue=false)]
        [JsonProperty("gas_equipment")]
        public GasEquipment GasEquipment { get; set; }

        /// <summary>
        /// Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program.
        /// </summary>
        /// <value>Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program.</value>
        [DataMember(Name="infiltration", EmitDefaultValue=false)]
        [JsonProperty("infiltration")]
        public Infiltration Infiltration { get; set; }

        /// <summary>
        /// Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed.
        /// </summary>
        /// <value>Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed.</value>
        [DataMember(Name="ventilation", EmitDefaultValue=false)]
        [JsonProperty("ventilation")]
        public Ventilation Ventilation { get; set; }

        /// <summary>
        /// Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned.
        /// </summary>
        /// <value>Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned.</value>
        [DataMember(Name="setpoint", EmitDefaultValue=false)]
        [JsonProperty("setpoint")]
        public Setpoint Setpoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramType {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  People: ").Append(People).Append("\n");
            sb.Append("  Lighting: ").Append(Lighting).Append("\n");
            sb.Append("  ElectricEquipment: ").Append(ElectricEquipment).Append("\n");
            sb.Append("  GasEquipment: ").Append(GasEquipment).Append("\n");
            sb.Append("  Infiltration: ").Append(Infiltration).Append("\n");
            sb.Append("  Ventilation: ").Append(Ventilation).Append("\n");
            sb.Append("  Setpoint: ").Append(Setpoint).Append("\n");
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
        /// <returns>ProgramType object</returns>
        public static ProgramType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ProgramType>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProgramType);
        }

        /// <summary>
        /// Returns true if ProgramType instances are equal
        /// </summary>
        /// <param name="input">Instance of ProgramType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.People == input.People ||
                    (this.People != null &&
                    this.People.Equals(input.People))
                ) && 
                (
                    this.Lighting == input.Lighting ||
                    (this.Lighting != null &&
                    this.Lighting.Equals(input.Lighting))
                ) && 
                (
                    this.ElectricEquipment == input.ElectricEquipment ||
                    (this.ElectricEquipment != null &&
                    this.ElectricEquipment.Equals(input.ElectricEquipment))
                ) && 
                (
                    this.GasEquipment == input.GasEquipment ||
                    (this.GasEquipment != null &&
                    this.GasEquipment.Equals(input.GasEquipment))
                ) && 
                (
                    this.Infiltration == input.Infiltration ||
                    (this.Infiltration != null &&
                    this.Infiltration.Equals(input.Infiltration))
                ) && 
                (
                    this.Ventilation == input.Ventilation ||
                    (this.Ventilation != null &&
                    this.Ventilation.Equals(input.Ventilation))
                ) && 
                (
                    this.Setpoint == input.Setpoint ||
                    (this.Setpoint != null &&
                    this.Setpoint.Equals(input.Setpoint))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.People != null)
                    hashCode = hashCode * 59 + this.People.GetHashCode();
                if (this.Lighting != null)
                    hashCode = hashCode * 59 + this.Lighting.GetHashCode();
                if (this.ElectricEquipment != null)
                    hashCode = hashCode * 59 + this.ElectricEquipment.GetHashCode();
                if (this.GasEquipment != null)
                    hashCode = hashCode * 59 + this.GasEquipment.GetHashCode();
                if (this.Infiltration != null)
                    hashCode = hashCode * 59 + this.Infiltration.GetHashCode();
                if (this.Ventilation != null)
                    hashCode = hashCode * 59 + this.Ventilation.GetHashCode();
                if (this.Setpoint != null)
                    hashCode = hashCode * 59 + this.Setpoint.GetHashCode();
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
            // Identifier (string) maxLength
            if(this.Identifier != null && this.Identifier.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be less than 100.", new [] { "Identifier" });
            }

            // Identifier (string) minLength
            if(this.Identifier != null && this.Identifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be greater than 1.", new [] { "Identifier" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^ProgramType$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}

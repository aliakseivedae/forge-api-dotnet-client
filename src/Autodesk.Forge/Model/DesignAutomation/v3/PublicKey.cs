/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk�s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model.DesignAutomation.v3
{
    /// <summary>
    /// PublicKey
    /// </summary>
    [DataContract]
    [Obsolete("Please use NuGet package Autodesk.Forge.DesignAutomation instead")]
    public partial class PublicKey :  IEquatable<PublicKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKey" /> class.
        /// </summary>
        /// <param name="Exponent">Exponent (required).</param>
        /// <param name="Modulus">Modulus (required).</param>
        public PublicKey(byte[] Exponent = null, byte[] Modulus = null)
        {
            // to ensure "Exponent" is required (not null)
            if (Exponent == null)
            {
                throw new InvalidDataException("Exponent is a required property for PublicKey and cannot be null");
            }
            else
            {
                this.Exponent = Exponent;
            }
            // to ensure "Modulus" is required (not null)
            if (Modulus == null)
            {
                throw new InvalidDataException("Modulus is a required property for PublicKey and cannot be null");
            }
            else
            {
                this.Modulus = Modulus;
            }
        }
        
        /// <summary>
        /// Gets or Sets Exponent
        /// </summary>
        [DataMember(Name="Exponent", EmitDefaultValue=false)]
        public byte[] Exponent { get; set; }
        /// <summary>
        /// Gets or Sets Modulus
        /// </summary>
        [DataMember(Name="Modulus", EmitDefaultValue=false)]
        public byte[] Modulus { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicKey {\n");
            sb.Append("  Exponent: ").Append(Exponent).Append("\n");
            sb.Append("  Modulus: ").Append(Modulus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PublicKey);
        }

        /// <summary>
        /// Returns true if PublicKey instances are equal
        /// </summary>
        /// <param name="other">Instance of PublicKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicKey other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Exponent == other.Exponent ||
                    this.Exponent != null &&
                    this.Exponent.Equals(other.Exponent)
                ) && 
                (
                    this.Modulus == other.Modulus ||
                    this.Modulus != null &&
                    this.Modulus.Equals(other.Modulus)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Exponent != null)
                    hash = hash * 59 + this.Exponent.GetHashCode();
                if (this.Modulus != null)
                    hash = hash * 59 + this.Modulus.GetHashCode();
                return hash;
            }
        }
    }

}


/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *

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

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// A flat JSON object of attribute-value pairs in which the attributes specify available profile image sizes in the format sizeX&lt;pixels&gt; (where &lt;pixels&gt; is an integer that represents both height and width in pixels of square profile images) and the values are URLs for downloading the images via HTTP
    /// </summary>
    [DataContract]
    public partial class UserProfileProfileImages :  IEquatable<UserProfileProfileImages>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileProfileImages" /> class.
        /// </summary>
        /// <param name="SizeX20">SizeX20.</param>
        /// <param name="SizeX40">SizeX40.</param>
        /// <param name="SizeX50">SizeX50.</param>
        /// <param name="SizeX58">SizeX58.</param>
        /// <param name="SizeX80">SizeX80.</param>
        /// <param name="SizeX120">SizeX120.</param>
        /// <param name="SizeX160">SizeX160.</param>
        /// <param name="SizeX176">SizeX176.</param>
        /// <param name="SizeX240">SizeX240.</param>
        /// <param name="SizeX360">SizeX360.</param>
        public UserProfileProfileImages(string SizeX20 = null, string SizeX40 = null, string SizeX50 = null, string SizeX58 = null, string SizeX80 = null, string SizeX120 = null, string SizeX160 = null, string SizeX176 = null, string SizeX240 = null, string SizeX360 = null)
        {
            this.SizeX20 = SizeX20;
            this.SizeX40 = SizeX40;
            this.SizeX50 = SizeX50;
            this.SizeX58 = SizeX58;
            this.SizeX80 = SizeX80;
            this.SizeX120 = SizeX120;
            this.SizeX160 = SizeX160;
            this.SizeX176 = SizeX176;
            this.SizeX240 = SizeX240;
            this.SizeX360 = SizeX360;
        }
        
        /// <summary>
        /// Gets or Sets SizeX20
        /// </summary>
        [DataMember(Name="sizeX20", EmitDefaultValue=false)]
        public string SizeX20 { get; set; }
        /// <summary>
        /// Gets or Sets SizeX40
        /// </summary>
        [DataMember(Name="sizeX40", EmitDefaultValue=false)]
        public string SizeX40 { get; set; }
        /// <summary>
        /// Gets or Sets SizeX50
        /// </summary>
        [DataMember(Name="sizeX50", EmitDefaultValue=false)]
        public string SizeX50 { get; set; }
        /// <summary>
        /// Gets or Sets SizeX58
        /// </summary>
        [DataMember(Name="sizeX58", EmitDefaultValue=false)]
        public string SizeX58 { get; set; }
        /// <summary>
        /// Gets or Sets SizeX80
        /// </summary>
        [DataMember(Name="sizeX80", EmitDefaultValue=false)]
        public string SizeX80 { get; set; }
        /// <summary>
        /// Gets or Sets SizeX120
        /// </summary>
        [DataMember(Name="sizeX120", EmitDefaultValue=false)]
        public string SizeX120 { get; set; }
        /// <summary>
        /// Gets or Sets SizeX160
        /// </summary>
        [DataMember(Name="sizeX160", EmitDefaultValue=false)]
        public string SizeX160 { get; set; }
        /// <summary>
        /// Gets or Sets SizeX176
        /// </summary>
        [DataMember(Name="sizeX176", EmitDefaultValue=false)]
        public string SizeX176 { get; set; }
        /// <summary>
        /// Gets or Sets SizeX240
        /// </summary>
        [DataMember(Name="sizeX240", EmitDefaultValue=false)]
        public string SizeX240 { get; set; }
        /// <summary>
        /// Gets or Sets SizeX360
        /// </summary>
        [DataMember(Name="sizeX360", EmitDefaultValue=false)]
        public string SizeX360 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileProfileImages {\n");
            sb.Append("  SizeX20: ").Append(SizeX20).Append("\n");
            sb.Append("  SizeX40: ").Append(SizeX40).Append("\n");
            sb.Append("  SizeX50: ").Append(SizeX50).Append("\n");
            sb.Append("  SizeX58: ").Append(SizeX58).Append("\n");
            sb.Append("  SizeX80: ").Append(SizeX80).Append("\n");
            sb.Append("  SizeX120: ").Append(SizeX120).Append("\n");
            sb.Append("  SizeX160: ").Append(SizeX160).Append("\n");
            sb.Append("  SizeX176: ").Append(SizeX176).Append("\n");
            sb.Append("  SizeX240: ").Append(SizeX240).Append("\n");
            sb.Append("  SizeX360: ").Append(SizeX360).Append("\n");
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
            return this.Equals(obj as UserProfileProfileImages);
        }

        /// <summary>
        /// Returns true if UserProfileProfileImages instances are equal
        /// </summary>
        /// <param name="other">Instance of UserProfileProfileImages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfileProfileImages other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SizeX20 == other.SizeX20 ||
                    this.SizeX20 != null &&
                    this.SizeX20.Equals(other.SizeX20)
                ) && 
                (
                    this.SizeX40 == other.SizeX40 ||
                    this.SizeX40 != null &&
                    this.SizeX40.Equals(other.SizeX40)
                ) && 
                (
                    this.SizeX50 == other.SizeX50 ||
                    this.SizeX50 != null &&
                    this.SizeX50.Equals(other.SizeX50)
                ) && 
                (
                    this.SizeX58 == other.SizeX58 ||
                    this.SizeX58 != null &&
                    this.SizeX58.Equals(other.SizeX58)
                ) && 
                (
                    this.SizeX80 == other.SizeX80 ||
                    this.SizeX80 != null &&
                    this.SizeX80.Equals(other.SizeX80)
                ) && 
                (
                    this.SizeX120 == other.SizeX120 ||
                    this.SizeX120 != null &&
                    this.SizeX120.Equals(other.SizeX120)
                ) && 
                (
                    this.SizeX160 == other.SizeX160 ||
                    this.SizeX160 != null &&
                    this.SizeX160.Equals(other.SizeX160)
                ) && 
                (
                    this.SizeX176 == other.SizeX176 ||
                    this.SizeX176 != null &&
                    this.SizeX176.Equals(other.SizeX176)
                ) && 
                (
                    this.SizeX240 == other.SizeX240 ||
                    this.SizeX240 != null &&
                    this.SizeX240.Equals(other.SizeX240)
                ) && 
                (
                    this.SizeX360 == other.SizeX360 ||
                    this.SizeX360 != null &&
                    this.SizeX360.Equals(other.SizeX360)
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
                if (this.SizeX20 != null)
                    hash = hash * 59 + this.SizeX20.GetHashCode();
                if (this.SizeX40 != null)
                    hash = hash * 59 + this.SizeX40.GetHashCode();
                if (this.SizeX50 != null)
                    hash = hash * 59 + this.SizeX50.GetHashCode();
                if (this.SizeX58 != null)
                    hash = hash * 59 + this.SizeX58.GetHashCode();
                if (this.SizeX80 != null)
                    hash = hash * 59 + this.SizeX80.GetHashCode();
                if (this.SizeX120 != null)
                    hash = hash * 59 + this.SizeX120.GetHashCode();
                if (this.SizeX160 != null)
                    hash = hash * 59 + this.SizeX160.GetHashCode();
                if (this.SizeX176 != null)
                    hash = hash * 59 + this.SizeX176.GetHashCode();
                if (this.SizeX240 != null)
                    hash = hash * 59 + this.SizeX240.GetHashCode();
                if (this.SizeX360 != null)
                    hash = hash * 59 + this.SizeX360.GetHashCode();
                return hash;
            }
        }
    }

}


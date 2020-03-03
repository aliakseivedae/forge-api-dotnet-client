/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
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

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// CreatePdfGetResponseData
    /// </summary>
    [DataContract]
    public partial class CreatePdfGetResponseData :  IEquatable<CreatePdfGetResponseData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePdfGetResponseData" /> class.
        /// </summary>
        /// <param name="VersionUrnVersionUrn">VersionUrn.</param>
        /// <param name="ResourceIdResourceId">ResourceId.</param>
        /// <param name="LinkLink">Link.</param>
        public CreatePdfGetResponseData(string versionUrn, string resourceId, string link)
        {
            this.VersionUrn = versionUrn;
                this.ResourceId = resourceId;
            this.Link = link;
        }
        
        /// <summary>
        /// Gets or Sets VersionUrn
        /// </summary>
        [DataMember(Name= "versionId", EmitDefaultValue=true)]
        public string VersionUrn { get; set; }
        /// <summary>
        /// Gets or Sets ResourceId
        /// </summary>
        [DataMember(Name= "resourceId", EmitDefaultValue=true)]
        public string ResourceId { get; set; }
        /// <summary>
        /// Gets or Sets ResourceId
        /// </summary>
        [DataMember(Name= "link", EmitDefaultValue=true)]
        public string Link { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePdfGetResponseData {\n");
            sb.Append("  VersionUrn: ").Append(VersionUrn).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(obj as CreatePdfGetResponseData);
        }

        /// <summary>
        /// Returns true if CreateRef instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePdfGetResponseData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.VersionUrn == other.VersionUrn ||
                    this.VersionUrn != null &&
                    this.VersionUrn.Equals(other.VersionUrn)
                ) && 
                (
                    this.ResourceId == other.ResourceId ||
                    this.ResourceId != null &&
                    this.ResourceId.Equals(other.ResourceId)
                ) &&
                (
                    this.Link == other.Link ||
                    this.Link != null &&
                    this.Link.Equals(other.Link)
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
                if (this.VersionUrn != null)
                    hash = hash * 59 + this.VersionUrn.GetHashCode();
                if (this.ResourceId != null)
                    hash = hash * 59 + this.ResourceId.GetHashCode();
                if (this.Link != null)
                    hash = hash * 59 + this.Link.GetHashCode();
                return hash;
            }
        }
    }

}


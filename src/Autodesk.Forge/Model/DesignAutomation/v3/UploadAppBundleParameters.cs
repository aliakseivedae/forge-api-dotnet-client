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
    /// UploadAppBundleParameters
    /// </summary>
    [DataContract]
    [Obsolete("Please use NuGet package Autodesk.Forge.DesignAutomation instead")]
    public partial class UploadAppBundleParameters :  IEquatable<UploadAppBundleParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAppBundleParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UploadAppBundleParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAppBundleParameters" /> class.
        /// </summary>
        /// <param name="EndpointURL">EndpointURL (required).</param>
        /// <param name="FormData">FormData (required).</param>
        public UploadAppBundleParameters(string EndpointURL = null, UploadAppBundleParameteresFormData FormData = null)
        {
            // to ensure "EndpointURL" is required (not null)
            if (EndpointURL == null)
            {
                throw new InvalidDataException("EndpointURL is a required property for UploadAppBundleParameters and cannot be null");
            }
            else
            {
                this.EndpointURL = EndpointURL;
            }
            // to ensure "FormData" is required (not null)
            if (FormData == null)
            {
                throw new InvalidDataException("FormData is a required property for UploadAppBundleParameters and cannot be null");
            }
            else
            {
                this.FormData = FormData;
            }
        }
        
        /// <summary>
        /// Gets or Sets EndpointURL
        /// </summary>
        [DataMember(Name="endpointURL", EmitDefaultValue=false)]
        public string EndpointURL { get; set; }
        /// <summary>
        /// Gets or Sets FormData
        /// </summary>
        [DataMember(Name="formData", EmitDefaultValue=false)]
        public UploadAppBundleParameteresFormData FormData { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadAppBundleParameters {\n");
            sb.Append("  EndpointURL: ").Append(EndpointURL).Append("\n");
            sb.Append("  FormData: ").Append(FormData).Append("\n");
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
            return this.Equals(obj as UploadAppBundleParameters);
        }

        /// <summary>
        /// Returns true if UploadAppBundleParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of UploadAppBundleParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadAppBundleParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndpointURL == other.EndpointURL ||
                    this.EndpointURL != null &&
                    this.EndpointURL.Equals(other.EndpointURL)
                ) && 
                (
                    this.FormData == other.FormData ||
                    this.FormData != null &&
                    this.FormData.Equals(other.FormData)
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
                if (this.EndpointURL != null)
                    hash = hash * 59 + this.EndpointURL.GetHashCode();
                if (this.FormData != null)
                    hash = hash * 59 + this.FormData.GetHashCode();
                return hash;
            }
        }
    }

}


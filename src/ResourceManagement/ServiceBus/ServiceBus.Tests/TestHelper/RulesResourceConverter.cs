// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace ServiceBus.Tests.TestHelper
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using Newtonsoft.Json;
    using System.Reflection;
    using Microsoft.Azure.Management.ServiceBus.Models;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Serialization;
    using System.Linq;

    public class RulesResourceConverter : JsonConverter
    {
        private Type currentType;
        public override bool CanConvert(Type objectType)
        {
            return (typeof(RuleResource) == objectType);

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }
            if (objectType == null)
            {
                throw new ArgumentNullException("objectType");
            }
            if (serializer == null)
            {
                throw new ArgumentNullException("serializer");
            }

            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            JObject jsonObject = JObject.Load(reader);


            // Initialize appropriate type instance
            var resource = Activator.CreateInstance(objectType);

            // For each property in resource - populate property
            var contract = (JsonObjectContract)serializer.ContractResolver.ResolveContract(objectType);
            foreach (JsonProperty property in contract.Properties)
            {
                JToken propertyValueToken = null;

                //string[] parentPath;
                //string propertyName = property.GetPropertyName(out parentPath);
                string propertyName = property.PropertyName;

                switch (propertyName)
                {
                    case "filter":
                        {
                            propertyValueToken = jsonObject["properties"]["filter"];
                            if (propertyValueToken.ToString().Contains("sqlExpression"))
                            {
                                property.PropertyType = typeof(SqlFilter);
                            }
                            break;
                        }
                    case "action":
                        {
                            propertyValueToken = jsonObject["properties"]["action"];
                            if (propertyValueToken.ToString() != null)
                            {
                                property.PropertyType = typeof(SqlRuleAction);
                            }
                            break;
                        }
                    default:
                        {
                            propertyValueToken = jsonObject[propertyName];
                            break;
                        }
                }

                if (propertyValueToken != null && property.Writable)
                {
                    var propertyValue = propertyValueToken.ToObject(property.PropertyType, serializer);
                    property.ValueProvider.SetValue(resource, propertyValue);
                }

            }
            return resource;
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}

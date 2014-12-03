﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Salesforce.VisualStudio.Services.ConnectedService.CodeModel
{
    [Serializable]
    public class ConfigurationKeyNames
    {
        private string generatedArtifactSuffix;

        internal ConfigurationKeyNames(string generatedArtifactSuffix)
        {
            this.generatedArtifactSuffix = generatedArtifactSuffix;
        }

        public string ConsumerKey
        {
            get { return this.GetQualifiedKeyName(Constants.ConfigKey_ConsumerKey); }
        }

        public string ConsumerSecret
        {
            get { return this.GetQualifiedKeyName(Constants.ConfigKey_ConsumerSecret); }
        }

        public string Domain
        {
            get { return this.GetQualifiedKeyName(Constants.ConfigKey_Domain); }
        }

        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public string RedirectUri
        {
            get { return this.GetQualifiedKeyName(Constants.ConfigKey_RedirectUri); }
        }

        public string UserName
        {
            get { return this.GetQualifiedKeyName(Constants.ConfigKey_UserName); }
        }

        public string Password
        {
            get { return this.GetQualifiedKeyName(Constants.ConfigKey_Password); }
        }

        public string SecurityToken
        {
            get { return this.GetQualifiedKeyName(Constants.ConfigKey_SecurityToken); }
        }

        private string GetQualifiedKeyName(string keyName)
        {
            return ConfigurationKeyNames.GetQualifiedKeyName(keyName, this.generatedArtifactSuffix);
        }

        internal static string GetQualifiedKeyName(string keyName, string generatedArtifactSuffix)
        {
            return String.Format(CultureInfo.InvariantCulture, Constants.ConfigKeyFormat, generatedArtifactSuffix, keyName);
        }
    }
}
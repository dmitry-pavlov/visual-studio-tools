﻿using System;
using System.Collections.Generic;

namespace Salesforce.VisualStudio.Services.ConnectedService.CodeModel
{
    /// <summary>
    /// Represents a Salesforce object to generate code for.
    /// </summary>
    [Serializable]
    public sealed class GeneratedObject
    {
        internal GeneratedObject()
        {
        }

        public SObjectDescription Model { get; internal set; }

        public GeneratedService Service { get; internal set; }

        public IEnumerable<GeneratedStorageProperty> StorageProperties { get; internal set; }
    }
}

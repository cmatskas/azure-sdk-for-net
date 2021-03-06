// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.HDInsight.Models;

namespace Microsoft.Azure.Management.HDInsight.Models
{
    /// <summary>
    /// Describes a role on the cluster.
    /// </summary>
    public partial class Role
    {
        private HardwareProfile _hardwareProfile;
        
        /// <summary>
        /// Optional. Gets or sets the hardware profile.
        /// </summary>
        public HardwareProfile HardwareProfile
        {
            get { return this._hardwareProfile; }
            set { this._hardwareProfile = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the name of the role.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private OsProfile _osProfile;
        
        /// <summary>
        /// Optional. Gets or sets the operating system profile.
        /// </summary>
        public OsProfile OsProfile
        {
            get { return this._osProfile; }
            set { this._osProfile = value; }
        }
        
        private IList<ScriptAction> _scriptActions;
        
        /// <summary>
        /// Optional. Gets or sets the list of script actions on the role.
        /// </summary>
        public IList<ScriptAction> ScriptActions
        {
            get { return this._scriptActions; }
            set { this._scriptActions = value; }
        }
        
        private int _targetInstanceCount;
        
        /// <summary>
        /// Optional. Gets or sets the instance count of the cluster.
        /// </summary>
        public int TargetInstanceCount
        {
            get { return this._targetInstanceCount; }
            set { this._targetInstanceCount = value; }
        }
        
        private VirtualNetworkProfile _virtualNetworkProfile;
        
        /// <summary>
        /// Optional. Gets or sets the virtual network profile.
        /// </summary>
        public VirtualNetworkProfile VirtualNetworkProfile
        {
            get { return this._virtualNetworkProfile; }
            set { this._virtualNetworkProfile = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Role class.
        /// </summary>
        public Role()
        {
            this.ScriptActions = new LazyList<ScriptAction>();
        }
    }
}

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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Storage;
using Microsoft.Azure.Management.Storage.Models;

namespace Microsoft.Azure.Management.Storage
{
    /// <summary>
    /// The Storage Management Client.
    /// </summary>
    public static partial class StorageManagementClientExtensions
    {
        /// <summary>
        /// The Get Create Operation Status operation returns the status of the
        /// specified create operation. After calling the asynchronous Begin
        /// Create operation, you can call Get Create Operation Status to
        /// determine whether the operation has succeeded, failed, or is still
        /// in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Storage.IStorageManagementClient.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. The URL where the status of the long-running create
        /// operation can be checked.
        /// </param>
        /// <returns>
        /// The Create storage account operation response.
        /// </returns>
        public static StorageAccountCreateResponse GetCreateOperationStatus(this IStorageManagementClient operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStorageManagementClient)s).GetCreateOperationStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Create Operation Status operation returns the status of the
        /// specified create operation. After calling the asynchronous Begin
        /// Create operation, you can call Get Create Operation Status to
        /// determine whether the operation has succeeded, failed, or is still
        /// in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Storage.IStorageManagementClient.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. The URL where the status of the long-running create
        /// operation can be checked.
        /// </param>
        /// <returns>
        /// The Create storage account operation response.
        /// </returns>
        public static Task<StorageAccountCreateResponse> GetCreateOperationStatusAsync(this IStorageManagementClient operations, string operationStatusLink)
        {
            return operations.GetCreateOperationStatusAsync(operationStatusLink, CancellationToken.None);
        }
    }
}

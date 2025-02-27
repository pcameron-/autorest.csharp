// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of BlobInventoryPolicy and their operations over its parent. </summary>
    public partial class BlobInventoryPolicyCollection : ArmCollection, IEnumerable<BlobInventoryPolicy>, IAsyncEnumerable<BlobInventoryPolicy>
    {
        private readonly ClientDiagnostics _blobInventoryPolicyClientDiagnostics;
        private readonly BlobInventoryPoliciesRestOperations _blobInventoryPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="BlobInventoryPolicyCollection"/> class for mocking. </summary>
        protected BlobInventoryPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BlobInventoryPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BlobInventoryPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _blobInventoryPolicyClientDiagnostics = new ClientDiagnostics("Azure.Management.Storage", BlobInventoryPolicy.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(BlobInventoryPolicy.ResourceType, out string blobInventoryPolicyApiVersion);
            _blobInventoryPolicyRestClient = new BlobInventoryPoliciesRestOperations(_blobInventoryPolicyClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, blobInventoryPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageAccount.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageAccount.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: BlobInventoryPolicies_CreateOrUpdate
        /// <summary> Sets the blob inventory policy to the specified storage account. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="properties"> The blob inventory policy set to a storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public async virtual Task<ArmOperation<BlobInventoryPolicy>> CreateOrUpdateAsync(bool waitForCompletion, BlobInventoryPolicyName blobInventoryPolicyName, BlobInventoryPolicyData properties, CancellationToken cancellationToken = default)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _blobInventoryPolicyClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _blobInventoryPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, properties, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<BlobInventoryPolicy>(Response.FromValue(new BlobInventoryPolicy(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: BlobInventoryPolicies_CreateOrUpdate
        /// <summary> Sets the blob inventory policy to the specified storage account. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="properties"> The blob inventory policy set to a storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public virtual ArmOperation<BlobInventoryPolicy> CreateOrUpdate(bool waitForCompletion, BlobInventoryPolicyName blobInventoryPolicyName, BlobInventoryPolicyData properties, CancellationToken cancellationToken = default)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _blobInventoryPolicyClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _blobInventoryPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, properties, cancellationToken);
                var operation = new StorageArmOperation<BlobInventoryPolicy>(Response.FromValue(new BlobInventoryPolicy(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: BlobInventoryPolicies_Get
        /// <summary> Gets the blob inventory policy associated with the specified storage account. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<BlobInventoryPolicy>> GetAsync(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _blobInventoryPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _blobInventoryPolicyClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BlobInventoryPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: BlobInventoryPolicies_Get
        /// <summary> Gets the blob inventory policy associated with the specified storage account. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BlobInventoryPolicy> Get(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _blobInventoryPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _blobInventoryPolicyClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlobInventoryPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: BlobInventoryPolicies_List
        /// <summary> Gets the blob inventory policy associated with the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BlobInventoryPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BlobInventoryPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BlobInventoryPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _blobInventoryPolicyClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _blobInventoryPolicyRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobInventoryPolicy(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: BlobInventoryPolicies_List
        /// <summary> Gets the blob inventory policy associated with the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BlobInventoryPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BlobInventoryPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BlobInventoryPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _blobInventoryPolicyClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _blobInventoryPolicyRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobInventoryPolicy(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: BlobInventoryPolicies_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(blobInventoryPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: BlobInventoryPolicies_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(blobInventoryPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: BlobInventoryPolicies_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<BlobInventoryPolicy>> GetIfExistsAsync(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _blobInventoryPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<BlobInventoryPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new BlobInventoryPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: BlobInventoryPolicies_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BlobInventoryPolicy> GetIfExists(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _blobInventoryPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<BlobInventoryPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new BlobInventoryPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BlobInventoryPolicy> IEnumerable<BlobInventoryPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BlobInventoryPolicy> IAsyncEnumerable<BlobInventoryPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of ObjectReplicationPolicy and their operations over its parent. </summary>
    public partial class ObjectReplicationPolicyCollection : ArmCollection, IEnumerable<ObjectReplicationPolicy>, IAsyncEnumerable<ObjectReplicationPolicy>
    {
        private readonly ClientDiagnostics _objectReplicationPolicyClientDiagnostics;
        private readonly ObjectReplicationPoliciesRestOperations _objectReplicationPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ObjectReplicationPolicyCollection"/> class for mocking. </summary>
        protected ObjectReplicationPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ObjectReplicationPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ObjectReplicationPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _objectReplicationPolicyClientDiagnostics = new ClientDiagnostics("Azure.Management.Storage", ObjectReplicationPolicy.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ObjectReplicationPolicy.ResourceType, out string objectReplicationPolicyApiVersion);
            _objectReplicationPolicyRestClient = new ObjectReplicationPoliciesRestOperations(_objectReplicationPolicyClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, objectReplicationPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageAccount.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageAccount.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ObjectReplicationPolicies_CreateOrUpdate
        /// <summary> Create or update the object replication policy of the storage account. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="properties"> The object replication policy set to a storage account. A unique policy ID will be created if absent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<ArmOperation<ObjectReplicationPolicy>> CreateOrUpdateAsync(bool waitForCompletion, string objectReplicationPolicyId, ObjectReplicationPolicyData properties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _objectReplicationPolicyClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _objectReplicationPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, properties, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<ObjectReplicationPolicy>(Response.FromValue(new ObjectReplicationPolicy(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ObjectReplicationPolicies_CreateOrUpdate
        /// <summary> Create or update the object replication policy of the storage account. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="properties"> The object replication policy set to a storage account. A unique policy ID will be created if absent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> or <paramref name="properties"/> is null. </exception>
        public virtual ArmOperation<ObjectReplicationPolicy> CreateOrUpdate(bool waitForCompletion, string objectReplicationPolicyId, ObjectReplicationPolicyData properties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _objectReplicationPolicyClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _objectReplicationPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, properties, cancellationToken);
                var operation = new StorageArmOperation<ObjectReplicationPolicy>(Response.FromValue(new ObjectReplicationPolicy(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ObjectReplicationPolicies_Get
        /// <summary> Get the object replication policy of the storage account by policy ID. </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public async virtual Task<Response<ObjectReplicationPolicy>> GetAsync(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _objectReplicationPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _objectReplicationPolicyClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ObjectReplicationPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ObjectReplicationPolicies_Get
        /// <summary> Get the object replication policy of the storage account by policy ID. </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public virtual Response<ObjectReplicationPolicy> Get(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _objectReplicationPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, cancellationToken);
                if (response.Value == null)
                    throw _objectReplicationPolicyClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ObjectReplicationPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ObjectReplicationPolicies_List
        /// <summary> List the object replication policies associated with the storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ObjectReplicationPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ObjectReplicationPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ObjectReplicationPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _objectReplicationPolicyClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _objectReplicationPolicyRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ObjectReplicationPolicy(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ObjectReplicationPolicies_List
        /// <summary> List the object replication policies associated with the storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ObjectReplicationPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ObjectReplicationPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ObjectReplicationPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _objectReplicationPolicyClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _objectReplicationPolicyRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ObjectReplicationPolicy(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ObjectReplicationPolicies_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(objectReplicationPolicyId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ObjectReplicationPolicies_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public virtual Response<bool> Exists(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(objectReplicationPolicyId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ObjectReplicationPolicies_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public async virtual Task<Response<ObjectReplicationPolicy>> GetIfExistsAsync(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _objectReplicationPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ObjectReplicationPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ObjectReplicationPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ObjectReplicationPolicies_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public virtual Response<ObjectReplicationPolicy> GetIfExists(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _objectReplicationPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ObjectReplicationPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ObjectReplicationPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ObjectReplicationPolicy> IEnumerable<ObjectReplicationPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ObjectReplicationPolicy> IAsyncEnumerable<ObjectReplicationPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

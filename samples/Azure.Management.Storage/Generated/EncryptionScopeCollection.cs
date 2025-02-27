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
    /// <summary> A class representing collection of EncryptionScope and their operations over its parent. </summary>
    public partial class EncryptionScopeCollection : ArmCollection, IEnumerable<EncryptionScope>, IAsyncEnumerable<EncryptionScope>
    {
        private readonly ClientDiagnostics _encryptionScopeClientDiagnostics;
        private readonly EncryptionScopesRestOperations _encryptionScopeRestClient;

        /// <summary> Initializes a new instance of the <see cref="EncryptionScopeCollection"/> class for mocking. </summary>
        protected EncryptionScopeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EncryptionScopeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EncryptionScopeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _encryptionScopeClientDiagnostics = new ClientDiagnostics("Azure.Management.Storage", EncryptionScope.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(EncryptionScope.ResourceType, out string encryptionScopeApiVersion);
            _encryptionScopeRestClient = new EncryptionScopesRestOperations(_encryptionScopeClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, encryptionScopeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageAccount.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageAccount.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/encryptionScopes/{encryptionScopeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: EncryptionScopes_Put
        /// <summary> Synchronously creates or updates an encryption scope under the specified storage account. If an encryption scope is already created and a subsequent request is issued with different properties, the encryption scope properties will be updated per the specified request. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="encryptionScope"> Encryption scope properties to be used for the create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="encryptionScopeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="encryptionScopeName"/> or <paramref name="encryptionScope"/> is null. </exception>
        public async virtual Task<ArmOperation<EncryptionScope>> CreateOrUpdateAsync(bool waitForCompletion, string encryptionScopeName, EncryptionScopeData encryptionScope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));
            if (encryptionScope == null)
            {
                throw new ArgumentNullException(nameof(encryptionScope));
            }

            using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _encryptionScopeRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionScopeName, encryptionScope, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<EncryptionScope>(Response.FromValue(new EncryptionScope(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/encryptionScopes/{encryptionScopeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: EncryptionScopes_Put
        /// <summary> Synchronously creates or updates an encryption scope under the specified storage account. If an encryption scope is already created and a subsequent request is issued with different properties, the encryption scope properties will be updated per the specified request. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="encryptionScope"> Encryption scope properties to be used for the create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="encryptionScopeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="encryptionScopeName"/> or <paramref name="encryptionScope"/> is null. </exception>
        public virtual ArmOperation<EncryptionScope> CreateOrUpdate(bool waitForCompletion, string encryptionScopeName, EncryptionScopeData encryptionScope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));
            if (encryptionScope == null)
            {
                throw new ArgumentNullException(nameof(encryptionScope));
            }

            using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _encryptionScopeRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionScopeName, encryptionScope, cancellationToken);
                var operation = new StorageArmOperation<EncryptionScope>(Response.FromValue(new EncryptionScope(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/encryptionScopes/{encryptionScopeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: EncryptionScopes_Get
        /// <summary> Returns the properties for the specified encryption scope. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="encryptionScopeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="encryptionScopeName"/> is null. </exception>
        public async virtual Task<Response<EncryptionScope>> GetAsync(string encryptionScopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));

            using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.Get");
            scope.Start();
            try
            {
                var response = await _encryptionScopeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionScopeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _encryptionScopeClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new EncryptionScope(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/encryptionScopes/{encryptionScopeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: EncryptionScopes_Get
        /// <summary> Returns the properties for the specified encryption scope. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="encryptionScopeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="encryptionScopeName"/> is null. </exception>
        public virtual Response<EncryptionScope> Get(string encryptionScopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));

            using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.Get");
            scope.Start();
            try
            {
                var response = _encryptionScopeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionScopeName, cancellationToken);
                if (response.Value == null)
                    throw _encryptionScopeClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EncryptionScope(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/encryptionScopes
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: EncryptionScopes_List
        /// <summary> Lists all the encryption scopes available under the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EncryptionScope" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EncryptionScope> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EncryptionScope>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _encryptionScopeRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionScope(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EncryptionScope>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _encryptionScopeRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionScope(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/encryptionScopes
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: EncryptionScopes_List
        /// <summary> Lists all the encryption scopes available under the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EncryptionScope" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EncryptionScope> GetAll(CancellationToken cancellationToken = default)
        {
            Page<EncryptionScope> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _encryptionScopeRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionScope(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EncryptionScope> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _encryptionScopeRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionScope(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/encryptionScopes/{encryptionScopeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: EncryptionScopes_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="encryptionScopeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="encryptionScopeName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string encryptionScopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));

            using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(encryptionScopeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/encryptionScopes/{encryptionScopeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: EncryptionScopes_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="encryptionScopeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="encryptionScopeName"/> is null. </exception>
        public virtual Response<bool> Exists(string encryptionScopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));

            using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(encryptionScopeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/encryptionScopes/{encryptionScopeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: EncryptionScopes_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="encryptionScopeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="encryptionScopeName"/> is null. </exception>
        public async virtual Task<Response<EncryptionScope>> GetIfExistsAsync(string encryptionScopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));

            using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _encryptionScopeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionScopeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<EncryptionScope>(null, response.GetRawResponse());
                return Response.FromValue(new EncryptionScope(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/encryptionScopes/{encryptionScopeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: EncryptionScopes_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="encryptionScopeName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="encryptionScopeName"/> is null. </exception>
        public virtual Response<EncryptionScope> GetIfExists(string encryptionScopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));

            using var scope = _encryptionScopeClientDiagnostics.CreateScope("EncryptionScopeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _encryptionScopeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionScopeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<EncryptionScope>(null, response.GetRawResponse());
                return Response.FromValue(new EncryptionScope(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EncryptionScope> IEnumerable<EncryptionScope>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EncryptionScope> IAsyncEnumerable<EncryptionScope>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

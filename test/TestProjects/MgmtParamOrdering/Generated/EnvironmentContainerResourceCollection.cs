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

namespace MgmtParamOrdering
{
    /// <summary> A class representing collection of EnvironmentContainerResource and their operations over its parent. </summary>
    public partial class EnvironmentContainerResourceCollection : ArmCollection, IEnumerable<EnvironmentContainerResource>, IAsyncEnumerable<EnvironmentContainerResource>
    {
        private readonly ClientDiagnostics _environmentContainerResourceEnvironmentContainersClientDiagnostics;
        private readonly EnvironmentContainersRestOperations _environmentContainerResourceEnvironmentContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="EnvironmentContainerResourceCollection"/> class for mocking. </summary>
        protected EnvironmentContainerResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EnvironmentContainerResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EnvironmentContainerResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _environmentContainerResourceEnvironmentContainersClientDiagnostics = new ClientDiagnostics("MgmtParamOrdering", EnvironmentContainerResource.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(EnvironmentContainerResource.ResourceType, out string environmentContainerResourceEnvironmentContainersApiVersion);
            _environmentContainerResourceEnvironmentContainersRestClient = new EnvironmentContainersRestOperations(_environmentContainerResourceEnvironmentContainersClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, environmentContainerResourceEnvironmentContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Workspace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Workspace.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// OperationId: EnvironmentContainers_CreateOrUpdate
        /// <summary> Create or update container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> Container name. </param>
        /// <param name="body"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="body"/> is null. </exception>
        public async virtual Task<ArmOperation<EnvironmentContainerResource>> CreateOrUpdateAsync(bool waitForCompletion, string name, EnvironmentContainerResourceData body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _environmentContainerResourceEnvironmentContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, body, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtParamOrderingArmOperation<EnvironmentContainerResource>(Response.FromValue(new EnvironmentContainerResource(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// OperationId: EnvironmentContainers_CreateOrUpdate
        /// <summary> Create or update container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> Container name. </param>
        /// <param name="body"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="body"/> is null. </exception>
        public virtual ArmOperation<EnvironmentContainerResource> CreateOrUpdate(bool waitForCompletion, string name, EnvironmentContainerResourceData body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _environmentContainerResourceEnvironmentContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, body, cancellationToken);
                var operation = new MgmtParamOrderingArmOperation<EnvironmentContainerResource>(Response.FromValue(new EnvironmentContainerResource(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// OperationId: EnvironmentContainers_Get
        /// <summary> Get container. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<EnvironmentContainerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _environmentContainerResourceEnvironmentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new EnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// OperationId: EnvironmentContainers_Get
        /// <summary> Get container. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<EnvironmentContainerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _environmentContainerResourceEnvironmentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// OperationId: EnvironmentContainers_List
        /// <summary> Get container. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EnvironmentContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EnvironmentContainerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EnvironmentContainerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _environmentContainerResourceEnvironmentContainersRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentContainerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// OperationId: EnvironmentContainers_List
        /// <summary> Get container. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EnvironmentContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EnvironmentContainerResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<EnvironmentContainerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _environmentContainerResourceEnvironmentContainersRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentContainerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// OperationId: EnvironmentContainers_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// OperationId: EnvironmentContainers_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// OperationId: EnvironmentContainers_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<EnvironmentContainerResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _environmentContainerResourceEnvironmentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<EnvironmentContainerResource>(null, response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// OperationId: EnvironmentContainers_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<EnvironmentContainerResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _environmentContainerResourceEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _environmentContainerResourceEnvironmentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<EnvironmentContainerResource>(null, response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EnvironmentContainerResource> IEnumerable<EnvironmentContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EnvironmentContainerResource> IAsyncEnumerable<EnvironmentContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

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

namespace MgmtMultipleParentResource
{
    /// <summary> A class representing collection of SubParent and their operations over its parent. </summary>
    public partial class SubParentCollection : ArmCollection, IEnumerable<SubParent>, IAsyncEnumerable<SubParent>
    {
        private readonly ClientDiagnostics _subParentClientDiagnostics;
        private readonly SubParentsRestOperations _subParentRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubParentCollection"/> class for mocking. </summary>
        protected SubParentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubParentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubParentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subParentClientDiagnostics = new ClientDiagnostics("MgmtMultipleParentResource", SubParent.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SubParent.ResourceType, out string subParentApiVersion);
            _subParentRestClient = new SubParentsRestOperations(_subParentClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, subParentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TheParent.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TheParent.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}/subParents/{instanceId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// OperationId: SubParents_CreateOrUpdate
        /// <summary> The operation to create or update the VMSS VM run command. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="subBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> or <paramref name="subBody"/> is null. </exception>
        public async virtual Task<ArmOperation<SubParent>> CreateOrUpdateAsync(bool waitForCompletion, string instanceId, SubParentData subBody, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));
            if (subBody == null)
            {
                throw new ArgumentNullException(nameof(subBody));
            }

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subParentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, subBody, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtMultipleParentResourceArmOperation<SubParent>(new SubParentOperationSource(Client), _subParentClientDiagnostics, Pipeline, _subParentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, subBody).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}/subParents/{instanceId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// OperationId: SubParents_CreateOrUpdate
        /// <summary> The operation to create or update the VMSS VM run command. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="subBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> or <paramref name="subBody"/> is null. </exception>
        public virtual ArmOperation<SubParent> CreateOrUpdate(bool waitForCompletion, string instanceId, SubParentData subBody, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));
            if (subBody == null)
            {
                throw new ArgumentNullException(nameof(subBody));
            }

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subParentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, subBody, cancellationToken);
                var operation = new MgmtMultipleParentResourceArmOperation<SubParent>(new SubParentOperationSource(Client), _subParentClientDiagnostics, Pipeline, _subParentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, subBody).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}/subParents/{instanceId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// OperationId: SubParents_Get
        /// <summary> The operation to get the VMSS VM run command. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<SubParent>> GetAsync(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.Get");
            scope.Start();
            try
            {
                var response = await _subParentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _subParentClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}/subParents/{instanceId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// OperationId: SubParents_Get
        /// <summary> The operation to get the VMSS VM run command. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<SubParent> Get(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.Get");
            scope.Start();
            try
            {
                var response = _subParentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken);
                if (response.Value == null)
                    throw _subParentClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}/subParents
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// OperationId: SubParents_List
        /// <summary> The operation to get all run commands of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubParent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubParent> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SubParent>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubParent>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}/subParents
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// OperationId: SubParents_List
        /// <summary> The operation to get all run commands of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubParent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubParent> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<SubParent> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubParent> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}/subParents/{instanceId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// OperationId: SubParents_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(instanceId, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}/subParents/{instanceId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// OperationId: SubParents_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<bool> Exists(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(instanceId, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}/subParents/{instanceId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// OperationId: SubParents_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<SubParent>> GetIfExistsAsync(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subParentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SubParent>(null, response.GetRawResponse());
                return Response.FromValue(new SubParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}/subParents/{instanceId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}
        /// OperationId: SubParents_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<SubParent> GetIfExists(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subParentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SubParent>(null, response.GetRawResponse());
                return Response.FromValue(new SubParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubParent> IEnumerable<SubParent>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubParent> IAsyncEnumerable<SubParent>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

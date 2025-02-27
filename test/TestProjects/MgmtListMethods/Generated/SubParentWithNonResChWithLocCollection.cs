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
using Azure.ResourceManager.Resources;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of SubParentWithNonResChWithLoc and their operations over its parent. </summary>
    public partial class SubParentWithNonResChWithLocCollection : ArmCollection, IEnumerable<SubParentWithNonResChWithLoc>, IAsyncEnumerable<SubParentWithNonResChWithLoc>
    {
        private readonly ClientDiagnostics _subParentWithNonResChWithLocClientDiagnostics;
        private readonly SubParentWithNonResChWithLocsRestOperations _subParentWithNonResChWithLocRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubParentWithNonResChWithLocCollection"/> class for mocking. </summary>
        protected SubParentWithNonResChWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubParentWithNonResChWithLocCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubParentWithNonResChWithLocCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subParentWithNonResChWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", SubParentWithNonResChWithLoc.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SubParentWithNonResChWithLoc.ResourceType, out string subParentWithNonResChWithLocApiVersion);
            _subParentWithNonResChWithLocRestClient = new SubParentWithNonResChWithLocsRestOperations(_subParentWithNonResChWithLocClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, subParentWithNonResChWithLocApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<SubParentWithNonResChWithLoc>> CreateOrUpdateAsync(bool waitForCompletion, string subParentWithNonResChWithLocName, SubParentWithNonResChWithLocData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChWithLocRestClient.CreateOrUpdateAsync(Id.SubscriptionId, subParentWithNonResChWithLocName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<SubParentWithNonResChWithLoc>(Response.FromValue(new SubParentWithNonResChWithLoc(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SubParentWithNonResChWithLoc> CreateOrUpdate(bool waitForCompletion, string subParentWithNonResChWithLocName, SubParentWithNonResChWithLocData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChWithLocRestClient.CreateOrUpdate(Id.SubscriptionId, subParentWithNonResChWithLocName, parameters, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<SubParentWithNonResChWithLoc>(Response.FromValue(new SubParentWithNonResChWithLoc(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<SubParentWithNonResChWithLoc>> GetAsync(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _subParentWithNonResChWithLocClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubParentWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<SubParentWithNonResChWithLoc> Get(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChWithLocRestClient.Get(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken);
                if (response.Value == null)
                    throw _subParentWithNonResChWithLocClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubParentWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubParentWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubParentWithNonResChWithLoc> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubParentWithNonResChWithLoc>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentWithNonResChWithLocRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubParentWithNonResChWithLoc>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentWithNonResChWithLocRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubParentWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubParentWithNonResChWithLoc> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubParentWithNonResChWithLoc> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentWithNonResChWithLocRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubParentWithNonResChWithLoc> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentWithNonResChWithLocRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subParentWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subParentWithNonResChWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<SubParentWithNonResChWithLoc>> GetIfExistsAsync(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SubParentWithNonResChWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new SubParentWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChWithLocs_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<SubParentWithNonResChWithLoc> GetIfExists(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChWithLocRestClient.Get(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SubParentWithNonResChWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new SubParentWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubParentWithNonResChWithLoc> IEnumerable<SubParentWithNonResChWithLoc>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubParentWithNonResChWithLoc> IAsyncEnumerable<SubParentWithNonResChWithLoc>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

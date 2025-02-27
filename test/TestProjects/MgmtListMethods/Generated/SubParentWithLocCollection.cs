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
    /// <summary> A class representing collection of SubParentWithLoc and their operations over its parent. </summary>
    public partial class SubParentWithLocCollection : ArmCollection, IEnumerable<SubParentWithLoc>, IAsyncEnumerable<SubParentWithLoc>
    {
        private readonly ClientDiagnostics _subParentWithLocClientDiagnostics;
        private readonly SubParentWithLocsRestOperations _subParentWithLocRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubParentWithLocCollection"/> class for mocking. </summary>
        protected SubParentWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubParentWithLocCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubParentWithLocCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subParentWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", SubParentWithLoc.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SubParentWithLoc.ResourceType, out string subParentWithLocApiVersion);
            _subParentWithLocRestClient = new SubParentWithLocsRestOperations(_subParentWithLocClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, subParentWithLocApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithLocs/{subParentWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="subParentWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<SubParentWithLoc>> CreateOrUpdateAsync(bool waitForCompletion, string subParentWithLocName, SubParentWithLocData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithLocName, nameof(subParentWithLocName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subParentWithLocRestClient.CreateOrUpdateAsync(Id.SubscriptionId, subParentWithLocName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<SubParentWithLoc>(Response.FromValue(new SubParentWithLoc(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithLocs/{subParentWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="subParentWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SubParentWithLoc> CreateOrUpdate(bool waitForCompletion, string subParentWithLocName, SubParentWithLocData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithLocName, nameof(subParentWithLocName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subParentWithLocRestClient.CreateOrUpdate(Id.SubscriptionId, subParentWithLocName, parameters, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<SubParentWithLoc>(Response.FromValue(new SubParentWithLoc(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithLocs/{subParentWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="subParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithLocName"/> is null. </exception>
        public async virtual Task<Response<SubParentWithLoc>> GetAsync(string subParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithLocName, nameof(subParentWithLocName));

            using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _subParentWithLocRestClient.GetAsync(Id.SubscriptionId, subParentWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _subParentWithLocClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubParentWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithLocs/{subParentWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="subParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithLocName"/> is null. </exception>
        public virtual Response<SubParentWithLoc> Get(string subParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithLocName, nameof(subParentWithLocName));

            using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _subParentWithLocRestClient.Get(Id.SubscriptionId, subParentWithLocName, cancellationToken);
                if (response.Value == null)
                    throw _subParentWithLocClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubParentWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithLocs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithLocs_List
        /// <summary> Lists all. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubParentWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubParentWithLoc> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubParentWithLoc>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentWithLocRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubParentWithLoc>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentWithLocRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithLocs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithLocs_List
        /// <summary> Lists all. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubParentWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubParentWithLoc> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubParentWithLoc> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentWithLocRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubParentWithLoc> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentWithLocRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithLocs/{subParentWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithLocs_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="subParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithLocName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string subParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithLocName, nameof(subParentWithLocName));

            using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subParentWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithLocs/{subParentWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithLocs_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="subParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string subParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithLocName, nameof(subParentWithLocName));

            using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subParentWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithLocs/{subParentWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithLocs_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithLocName"/> is null. </exception>
        public async virtual Task<Response<SubParentWithLoc>> GetIfExistsAsync(string subParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithLocName, nameof(subParentWithLocName));

            using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subParentWithLocRestClient.GetAsync(Id.SubscriptionId, subParentWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SubParentWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new SubParentWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithLocs/{subParentWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithLocs_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithLocName"/> is null. </exception>
        public virtual Response<SubParentWithLoc> GetIfExists(string subParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithLocName, nameof(subParentWithLocName));

            using var scope = _subParentWithLocClientDiagnostics.CreateScope("SubParentWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subParentWithLocRestClient.Get(Id.SubscriptionId, subParentWithLocName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SubParentWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new SubParentWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubParentWithLoc> IEnumerable<SubParentWithLoc>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubParentWithLoc> IAsyncEnumerable<SubParentWithLoc>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

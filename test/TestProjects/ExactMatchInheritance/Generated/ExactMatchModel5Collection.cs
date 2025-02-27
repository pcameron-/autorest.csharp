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

namespace ExactMatchInheritance
{
    /// <summary> A class representing collection of ExactMatchModel5 and their operations over its parent. </summary>
    public partial class ExactMatchModel5Collection : ArmCollection, IEnumerable<ExactMatchModel5>, IAsyncEnumerable<ExactMatchModel5>
    {
        private readonly ClientDiagnostics _exactMatchModel5ClientDiagnostics;
        private readonly ExactMatchModel5SRestOperations _exactMatchModel5RestClient;

        /// <summary> Initializes a new instance of the <see cref="ExactMatchModel5Collection"/> class for mocking. </summary>
        protected ExactMatchModel5Collection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExactMatchModel5Collection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExactMatchModel5Collection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _exactMatchModel5ClientDiagnostics = new ClientDiagnostics("ExactMatchInheritance", ExactMatchModel5.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ExactMatchModel5.ResourceType, out string exactMatchModel5ApiVersion);
            _exactMatchModel5RestClient = new ExactMatchModel5SRestOperations(_exactMatchModel5ClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, exactMatchModel5ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5SName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel5s_Put
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="exactMatchModel5SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel5 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ExactMatchModel5>> CreateOrUpdateAsync(bool waitForCompletion, string exactMatchModel5SName, ExactMatchModel5Data parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _exactMatchModel5RestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ExactMatchInheritanceArmOperation<ExactMatchModel5>(Response.FromValue(new ExactMatchModel5(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5SName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel5s_Put
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="exactMatchModel5SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel5 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ExactMatchModel5> CreateOrUpdate(bool waitForCompletion, string exactMatchModel5SName, ExactMatchModel5Data parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _exactMatchModel5RestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, parameters, cancellationToken);
                var operation = new ExactMatchInheritanceArmOperation<ExactMatchModel5>(Response.FromValue(new ExactMatchModel5(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5SName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel5s_Get
        /// <param name="exactMatchModel5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public async virtual Task<Response<ExactMatchModel5>> GetAsync(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.Get");
            scope.Start();
            try
            {
                var response = await _exactMatchModel5RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _exactMatchModel5ClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExactMatchModel5(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5SName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel5s_Get
        /// <param name="exactMatchModel5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public virtual Response<ExactMatchModel5> Get(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.Get");
            scope.Start();
            try
            {
                var response = _exactMatchModel5RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, cancellationToken);
                if (response.Value == null)
                    throw _exactMatchModel5ClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExactMatchModel5(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel5s_List
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExactMatchModel5" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExactMatchModel5> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExactMatchModel5>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.GetAll");
                scope.Start();
                try
                {
                    var response = await _exactMatchModel5RestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExactMatchModel5(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel5s_List
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExactMatchModel5" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExactMatchModel5> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExactMatchModel5> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.GetAll");
                scope.Start();
                try
                {
                    var response = _exactMatchModel5RestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExactMatchModel5(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5SName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel5s_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="exactMatchModel5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(exactMatchModel5SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5SName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel5s_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="exactMatchModel5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public virtual Response<bool> Exists(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(exactMatchModel5SName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5SName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel5s_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="exactMatchModel5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public async virtual Task<Response<ExactMatchModel5>> GetIfExistsAsync(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _exactMatchModel5RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExactMatchModel5>(null, response.GetRawResponse());
                return Response.FromValue(new ExactMatchModel5(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5SName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel5s_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="exactMatchModel5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public virtual Response<ExactMatchModel5> GetIfExists(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _exactMatchModel5RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExactMatchModel5>(null, response.GetRawResponse());
                return Response.FromValue(new ExactMatchModel5(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExactMatchModel5> IEnumerable<ExactMatchModel5>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExactMatchModel5> IAsyncEnumerable<ExactMatchModel5>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

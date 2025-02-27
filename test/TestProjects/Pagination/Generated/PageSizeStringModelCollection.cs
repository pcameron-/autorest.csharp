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

namespace Pagination
{
    /// <summary> A class representing collection of PageSizeStringModel and their operations over its parent. </summary>
    public partial class PageSizeStringModelCollection : ArmCollection, IEnumerable<PageSizeStringModel>, IAsyncEnumerable<PageSizeStringModel>
    {
        private readonly ClientDiagnostics _pageSizeStringModelClientDiagnostics;
        private readonly PageSizeStringModelsRestOperations _pageSizeStringModelRestClient;

        /// <summary> Initializes a new instance of the <see cref="PageSizeStringModelCollection"/> class for mocking. </summary>
        protected PageSizeStringModelCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PageSizeStringModelCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PageSizeStringModelCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _pageSizeStringModelClientDiagnostics = new ClientDiagnostics("Pagination", PageSizeStringModel.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(PageSizeStringModel.ResourceType, out string pageSizeStringModelApiVersion);
            _pageSizeStringModelRestClient = new PageSizeStringModelsRestOperations(_pageSizeStringModelClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, pageSizeStringModelApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The PageSizeStringModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<PageSizeStringModel>> CreateOrUpdateAsync(bool waitForCompletion, string name, PageSizeStringModelData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _pageSizeStringModelRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new PaginationArmOperation<PageSizeStringModel>(Response.FromValue(new PageSizeStringModel(Client, response), response.GetRawResponse()));
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

        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The PageSizeStringModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<PageSizeStringModel> CreateOrUpdate(bool waitForCompletion, string name, PageSizeStringModelData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _pageSizeStringModelRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken);
                var operation = new PaginationArmOperation<PageSizeStringModel>(Response.FromValue(new PageSizeStringModel(Client, response), response.GetRawResponse()));
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

        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<PageSizeStringModel>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.Get");
            scope.Start();
            try
            {
                var response = await _pageSizeStringModelRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _pageSizeStringModelClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PageSizeStringModel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<PageSizeStringModel> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.Get");
            scope.Start();
            try
            {
                var response = _pageSizeStringModelRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw _pageSizeStringModelClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PageSizeStringModel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="maxpagesize"> Optional. Specified maximum number of containers that can be included in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PageSizeStringModel" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PageSizeStringModel> GetAllAsync(string maxpagesize = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PageSizeStringModel>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _pageSizeStringModelRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, maxpagesize, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PageSizeStringModel(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PageSizeStringModel>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _pageSizeStringModelRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, maxpagesize, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PageSizeStringModel(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <param name="maxpagesize"> Optional. Specified maximum number of containers that can be included in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PageSizeStringModel" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PageSizeStringModel> GetAll(string maxpagesize = null, CancellationToken cancellationToken = default)
        {
            Page<PageSizeStringModel> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _pageSizeStringModelRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, maxpagesize, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PageSizeStringModel(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PageSizeStringModel> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _pageSizeStringModelRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, maxpagesize, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PageSizeStringModel(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.Exists");
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

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.Exists");
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

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<PageSizeStringModel>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _pageSizeStringModelRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PageSizeStringModel>(null, response.GetRawResponse());
                return Response.FromValue(new PageSizeStringModel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<PageSizeStringModel> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _pageSizeStringModelClientDiagnostics.CreateScope("PageSizeStringModelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _pageSizeStringModelRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PageSizeStringModel>(null, response.GetRawResponse());
                return Response.FromValue(new PageSizeStringModel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PageSizeStringModel> IEnumerable<PageSizeStringModel>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PageSizeStringModel> IAsyncEnumerable<PageSizeStringModel>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

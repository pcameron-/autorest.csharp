// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Pagination
{
    /// <summary> A Class representing a PageSizeFloatModel along with the instance operations that can be performed on it. </summary>
    public partial class PageSizeFloatModel : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PageSizeFloatModel"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeFloatModel/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _pageSizeFloatModelClientDiagnostics;
        private readonly PageSizeFloatModelsRestOperations _pageSizeFloatModelRestClient;
        private readonly PageSizeFloatModelData _data;

        /// <summary> Initializes a new instance of the <see cref="PageSizeFloatModel"/> class for mocking. </summary>
        protected PageSizeFloatModel()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PageSizeFloatModel"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PageSizeFloatModel(ArmClient client, PageSizeFloatModelData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PageSizeFloatModel"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PageSizeFloatModel(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _pageSizeFloatModelClientDiagnostics = new ClientDiagnostics("Pagination", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string pageSizeFloatModelApiVersion);
            _pageSizeFloatModelRestClient = new PageSizeFloatModelsRestOperations(_pageSizeFloatModelClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, pageSizeFloatModelApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/pageSizeFloatModel";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PageSizeFloatModelData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<PageSizeFloatModel>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _pageSizeFloatModelClientDiagnostics.CreateScope("PageSizeFloatModel.Get");
            scope.Start();
            try
            {
                var response = await _pageSizeFloatModelRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _pageSizeFloatModelClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PageSizeFloatModel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PageSizeFloatModel> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _pageSizeFloatModelClientDiagnostics.CreateScope("PageSizeFloatModel.Get");
            scope.Start();
            try
            {
                var response = _pageSizeFloatModelRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _pageSizeFloatModelClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PageSizeFloatModel(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

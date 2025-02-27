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
using MgmtExpandResourceTypes.Models;

namespace MgmtExpandResourceTypes
{
    /// <summary> A class representing collection of RecordSet and their operations over its parent. </summary>
    public partial class RecordSetPtrCollection : ArmCollection, IEnumerable<RecordSetPtr>, IAsyncEnumerable<RecordSetPtr>
    {
        private readonly ClientDiagnostics _recordSetPtrRecordSetsClientDiagnostics;
        private readonly RecordSetsRestOperations _recordSetPtrRecordSetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RecordSetPtrCollection"/> class for mocking. </summary>
        protected RecordSetPtrCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RecordSetPtrCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RecordSetPtrCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _recordSetPtrRecordSetsClientDiagnostics = new ClientDiagnostics("MgmtExpandResourceTypes", RecordSetPtr.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(RecordSetPtr.ResourceType, out string recordSetPtrRecordSetsApiVersion);
            _recordSetPtrRecordSetsRestClient = new RecordSetsRestOperations(_recordSetPtrRecordSetsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, recordSetPtrRecordSetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Zone.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Zone.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/PTR/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_CreateOrUpdate
        /// <summary> Creates or updates a record set within a DNS zone. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="parameters"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The etag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen etag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new record set to be created, but to prevent updating an existing record set. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<RecordSetPtr>> CreateOrUpdateAsync(bool waitForCompletion, string relativeRecordSetName, RecordSetData parameters, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _recordSetPtrRecordSetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "PTR".ToRecordType(), relativeRecordSetName, parameters, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtExpandResourceTypesArmOperation<RecordSetPtr>(Response.FromValue(new RecordSetPtr(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/PTR/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_CreateOrUpdate
        /// <summary> Creates or updates a record set within a DNS zone. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="parameters"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The etag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen etag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new record set to be created, but to prevent updating an existing record set. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<RecordSetPtr> CreateOrUpdate(bool waitForCompletion, string relativeRecordSetName, RecordSetData parameters, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _recordSetPtrRecordSetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "PTR".ToRecordType(), relativeRecordSetName, parameters, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new MgmtExpandResourceTypesArmOperation<RecordSetPtr>(Response.FromValue(new RecordSetPtr(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/PTR/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_Get
        /// <summary> Gets a record set. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public async virtual Task<Response<RecordSetPtr>> GetAsync(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.Get");
            scope.Start();
            try
            {
                var response = await _recordSetPtrRecordSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "PTR".ToRecordType(), relativeRecordSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _recordSetPtrRecordSetsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RecordSetPtr(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/PTR/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_Get
        /// <summary> Gets a record set. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public virtual Response<RecordSetPtr> Get(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.Get");
            scope.Start();
            try
            {
                var response = _recordSetPtrRecordSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "PTR".ToRecordType(), relativeRecordSetName, cancellationToken);
                if (response.Value == null)
                    throw _recordSetPtrRecordSetsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecordSetPtr(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/PTR
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_ListByType
        /// <summary> Lists the record sets of a specified type in a DNS zone. </summary>
        /// <param name="top"> The maximum number of record sets to return. If not specified, returns up to 100 record sets. </param>
        /// <param name="recordsetnamesuffix"> The suffix label of the record set name that has to be used to filter the record set enumerations. If this parameter is specified, Enumeration will return only records that end with .&lt;recordSetNameSuffix&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecordSetPtr" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecordSetPtr> GetAllAsync(int? top = null, string recordsetnamesuffix = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<RecordSetPtr>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _recordSetPtrRecordSetsRestClient.ListByTypeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "PTR".ToRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RecordSetPtr(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RecordSetPtr>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _recordSetPtrRecordSetsRestClient.ListByTypeNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "PTR".ToRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RecordSetPtr(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/PTR
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_ListByType
        /// <summary> Lists the record sets of a specified type in a DNS zone. </summary>
        /// <param name="top"> The maximum number of record sets to return. If not specified, returns up to 100 record sets. </param>
        /// <param name="recordsetnamesuffix"> The suffix label of the record set name that has to be used to filter the record set enumerations. If this parameter is specified, Enumeration will return only records that end with .&lt;recordSetNameSuffix&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecordSetPtr" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecordSetPtr> GetAll(int? top = null, string recordsetnamesuffix = null, CancellationToken cancellationToken = default)
        {
            Page<RecordSetPtr> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _recordSetPtrRecordSetsRestClient.ListByType(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "PTR".ToRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RecordSetPtr(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RecordSetPtr> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _recordSetPtrRecordSetsRestClient.ListByTypeNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "PTR".ToRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RecordSetPtr(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/PTR/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(relativeRecordSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/PTR/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(relativeRecordSetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/PTR/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public async virtual Task<Response<RecordSetPtr>> GetIfExistsAsync(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _recordSetPtrRecordSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "PTR".ToRecordType(), relativeRecordSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RecordSetPtr>(null, response.GetRawResponse());
                return Response.FromValue(new RecordSetPtr(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/PTR/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public virtual Response<RecordSetPtr> GetIfExists(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _recordSetPtrRecordSetsClientDiagnostics.CreateScope("RecordSetPtrCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _recordSetPtrRecordSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "PTR".ToRecordType(), relativeRecordSetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RecordSetPtr>(null, response.GetRawResponse());
                return Response.FromValue(new RecordSetPtr(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RecordSetPtr> IEnumerable<RecordSetPtr>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RecordSetPtr> IAsyncEnumerable<RecordSetPtr>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

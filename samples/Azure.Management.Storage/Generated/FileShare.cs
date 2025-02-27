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
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A Class representing a FileShare along with the instance operations that can be performed on it. </summary>
    public partial class FileShare : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FileShare"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string shareName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _fileShareClientDiagnostics;
        private readonly FileSharesRestOperations _fileShareRestClient;
        private readonly FileShareData _data;

        /// <summary> Initializes a new instance of the <see cref="FileShare"/> class for mocking. </summary>
        protected FileShare()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FileShare"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FileShare(ArmClient client, FileShareData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FileShare"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FileShare(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fileShareClientDiagnostics = new ClientDiagnostics("Azure.Management.Storage", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string fileShareApiVersion);
            _fileShareRestClient = new FileSharesRestOperations(_fileShareClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, fileShareApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Storage/storageAccounts/fileServices/shares";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FileShareData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Get
        /// <summary> Gets properties of a specified share. </summary>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: stats. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="xMsSnapshot"> Optional, used to retrieve properties of a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<FileShare>> GetAsync(string expand = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            using var scope = _fileShareClientDiagnostics.CreateScope("FileShare.Get");
            scope.Start();
            try
            {
                var response = await _fileShareRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, expand, xMsSnapshot, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _fileShareClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FileShare(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Get
        /// <summary> Gets properties of a specified share. </summary>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: stats. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="xMsSnapshot"> Optional, used to retrieve properties of a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileShare> Get(string expand = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            using var scope = _fileShareClientDiagnostics.CreateScope("FileShare.Get");
            scope.Start();
            try
            {
                var response = _fileShareRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, expand, xMsSnapshot, cancellationToken);
                if (response.Value == null)
                    throw _fileShareClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FileShare(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Delete
        /// <summary> Deletes specified share under its account. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="xMsSnapshot"> Optional, used to delete a snapshot. </param>
        /// <param name="include"> Optional. Valid values are: snapshots, leased-snapshots, none. The default value is snapshots. For &apos;snapshots&apos;, the file share is deleted including all of its file share snapshots. If the file share contains leased-snapshots, the deletion fails. For &apos;leased-snapshots&apos;, the file share is deleted included all of its file share snapshots (leased/unleased). For &apos;none&apos;, the file share is deleted if it has no share snapshots. If the file share contains any snapshots (leased or unleased), the deletion fails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, string xMsSnapshot = null, string include = null, CancellationToken cancellationToken = default)
        {
            using var scope = _fileShareClientDiagnostics.CreateScope("FileShare.Delete");
            scope.Start();
            try
            {
                var response = await _fileShareRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, xMsSnapshot, include, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Delete
        /// <summary> Deletes specified share under its account. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="xMsSnapshot"> Optional, used to delete a snapshot. </param>
        /// <param name="include"> Optional. Valid values are: snapshots, leased-snapshots, none. The default value is snapshots. For &apos;snapshots&apos;, the file share is deleted including all of its file share snapshots. If the file share contains leased-snapshots, the deletion fails. For &apos;leased-snapshots&apos;, the file share is deleted included all of its file share snapshots (leased/unleased). For &apos;none&apos;, the file share is deleted if it has no share snapshots. If the file share contains any snapshots (leased or unleased), the deletion fails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, string xMsSnapshot = null, string include = null, CancellationToken cancellationToken = default)
        {
            using var scope = _fileShareClientDiagnostics.CreateScope("FileShare.Delete");
            scope.Start();
            try
            {
                var response = _fileShareRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, xMsSnapshot, include, cancellationToken);
                var operation = new StorageArmOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Update
        /// <summary> Updates share properties as specified in request body. Properties not mentioned in the request will not be changed. Update fails if the specified share does not already exist. </summary>
        /// <param name="fileShare"> Properties to update for the file share. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileShare"/> is null. </exception>
        public async virtual Task<Response<FileShare>> UpdateAsync(FileShareData fileShare, CancellationToken cancellationToken = default)
        {
            if (fileShare == null)
            {
                throw new ArgumentNullException(nameof(fileShare));
            }

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShare.Update");
            scope.Start();
            try
            {
                var response = await _fileShareRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, fileShare, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FileShare(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Update
        /// <summary> Updates share properties as specified in request body. Properties not mentioned in the request will not be changed. Update fails if the specified share does not already exist. </summary>
        /// <param name="fileShare"> Properties to update for the file share. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileShare"/> is null. </exception>
        public virtual Response<FileShare> Update(FileShareData fileShare, CancellationToken cancellationToken = default)
        {
            if (fileShare == null)
            {
                throw new ArgumentNullException(nameof(fileShare));
            }

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShare.Update");
            scope.Start();
            try
            {
                var response = _fileShareRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, fileShare, cancellationToken);
                return Response.FromValue(new FileShare(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}/restore
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Restore
        /// <summary> Restore a file share within a valid retention days if share soft delete is enabled. </summary>
        /// <param name="deletedShare"> The DeletedShare to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedShare"/> is null. </exception>
        public async virtual Task<Response> RestoreAsync(DeletedShare deletedShare, CancellationToken cancellationToken = default)
        {
            if (deletedShare == null)
            {
                throw new ArgumentNullException(nameof(deletedShare));
            }

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShare.Restore");
            scope.Start();
            try
            {
                var response = await _fileShareRestClient.RestoreAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, deletedShare, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}/restore
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Restore
        /// <summary> Restore a file share within a valid retention days if share soft delete is enabled. </summary>
        /// <param name="deletedShare"> The DeletedShare to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedShare"/> is null. </exception>
        public virtual Response Restore(DeletedShare deletedShare, CancellationToken cancellationToken = default)
        {
            if (deletedShare == null)
            {
                throw new ArgumentNullException(nameof(deletedShare));
            }

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShare.Restore");
            scope.Start();
            try
            {
                var response = _fileShareRestClient.Restore(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, deletedShare, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}/lease
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Lease
        /// <summary> The Lease Share operation establishes and manages a lock on a share for delete operations. The lock duration can be 15 to 60 seconds, or can be infinite. </summary>
        /// <param name="parameters"> Lease Share request body. </param>
        /// <param name="xMsSnapshot"> Optional. Specify the snapshot time to lease a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<LeaseShareResponse>> LeaseAsync(LeaseShareRequest parameters = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            using var scope = _fileShareClientDiagnostics.CreateScope("FileShare.Lease");
            scope.Start();
            try
            {
                var response = await _fileShareRestClient.LeaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, parameters, xMsSnapshot, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}/lease
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Lease
        /// <summary> The Lease Share operation establishes and manages a lock on a share for delete operations. The lock duration can be 15 to 60 seconds, or can be infinite. </summary>
        /// <param name="parameters"> Lease Share request body. </param>
        /// <param name="xMsSnapshot"> Optional. Specify the snapshot time to lease a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LeaseShareResponse> Lease(LeaseShareRequest parameters = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            using var scope = _fileShareClientDiagnostics.CreateScope("FileShare.Lease");
            scope.Start();
            try
            {
                var response = _fileShareRestClient.Lease(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, parameters, xMsSnapshot, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

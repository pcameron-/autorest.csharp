// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Management.Storage.Models;
using Azure.ResourceManager.Resources;

namespace Azure.Management.Storage
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeletedAccounts in the DeletedAccount. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeletedAccounts and their operations over a DeletedAccount. </returns>
        public static DeletedAccountCollection GetDeletedAccounts(this Subscription subscription)
        {
            return GetExtensionClient(subscription).GetDeletedAccounts();
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Skus_List
        /// <summary> Lists the available SKUs supported by Microsoft.Storage for given subscription. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SkuInformation> GetSkusAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetSkusAsync(cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Skus_List
        /// <summary> Lists the available SKUs supported by Microsoft.Storage for given subscription. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SkuInformation> GetSkus(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetSkus(cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: StorageAccounts_List
        /// <summary> Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccount" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageAccount> GetStorageAccountsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetStorageAccountsAsync(cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: StorageAccounts_List
        /// <summary> Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccount" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageAccount> GetStorageAccounts(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetStorageAccounts(cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Usages_ListByLocation
        /// <summary> Gets the current usage count and the limit for the resources of the location under the subscription. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Usage> GetUsagesByLocationAsync(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetUsagesByLocationAsync(location, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Usages_ListByLocation
        /// <summary> Gets the current usage count and the limit for the resources of the location under the subscription. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<Usage> GetUsagesByLocation(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetUsagesByLocation(location, cancellationToken);
        }
    }
}

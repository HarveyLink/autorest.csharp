// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.ResourceManager.Resources;

namespace MgmtExtensionCommonRestOperation
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

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.TypeOne/typeOnes
        /// Operation Id: Common_ListTypeOnesBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TypeOne" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<TypeOne> GetTypeOnesAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetTypeOnesAsync(cancellationToken);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.TypeOne/typeOnes
        /// Operation Id: Common_ListTypeOnesBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TypeOne" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<TypeOne> GetTypeOnes(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetTypeOnes(cancellationToken);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.TypeTwo/typeTwos
        /// Operation Id: Common_ListTypeTwosBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TypeTwo" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<TypeTwo> GetTypeTwosAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetTypeTwosAsync(cancellationToken);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.TypeTwo/typeTwos
        /// Operation Id: Common_ListTypeTwosBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TypeTwo" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<TypeTwo> GetTypeTwos(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetTypeTwos(cancellationToken);
        }
    }
}

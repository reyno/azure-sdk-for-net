namespace Microsoft.Azure.Management.Storage
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure;
    using Models;

    public static partial class StorageAccountsOperationsExtensions
    {
            /// <summary>
            /// Checks that account name is valid and is not in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            public static CheckNameAvailabilityResponse CheckNameAvailability(this IStorageAccountsOperations operations, StorageAccountCheckNameAvailabilityParameters accountName)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).CheckNameAvailabilityAsync(accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks that account name is valid and is not in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResponse> CheckNameAvailabilityAsync( this IStorageAccountsOperations operations, StorageAccountCheckNameAvailabilityParameters accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<CheckNameAvailabilityResponse> result = await operations.CheckNameAvailabilityWithOperationResponseAsync(accountName, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Asynchronously creates a new storage account with the specified
            /// parameters. Existing accounts cannot be updated with this API and should
            /// instead use the Update Storage Account API. If an account is already
            /// created and subsequent create request is issued with exact same set of
            /// properties, the request succeeds.The max number of storage accounts that
            /// can be created per subscription is limited to 20.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            public static StorageAccount Create(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountCreateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).CreateAsync(resourceGroupName, accountName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Asynchronously creates a new storage account with the specified
            /// parameters. Existing accounts cannot be updated with this API and should
            /// instead use the Update Storage Account API. If an account is already
            /// created and subsequent create request is issued with exact same set of
            /// properties, the request succeeds.The max number of storage accounts that
            /// can be created per subscription is limited to 20.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<StorageAccount> CreateAsync( this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<StorageAccount> result = await operations.CreateWithOperationResponseAsync(resourceGroupName, accountName, parameters, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Asynchronously creates a new storage account with the specified
            /// parameters. Existing accounts cannot be updated with this API and should
            /// instead use the Update Storage Account API. If an account is already
            /// created and subsequent create request is issued with exact same set of
            /// properties, the request succeeds.The max number of storage accounts that
            /// can be created per subscription is limited to 20.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            public static StorageAccount BeginCreate(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountCreateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).BeginCreateAsync(resourceGroupName, accountName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Asynchronously creates a new storage account with the specified
            /// parameters. Existing accounts cannot be updated with this API and should
            /// instead use the Update Storage Account API. If an account is already
            /// created and subsequent create request is issued with exact same set of
            /// properties, the request succeeds.The max number of storage accounts that
            /// can be created per subscription is limited to 20.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<StorageAccount> BeginCreateAsync( this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<StorageAccount> result = await operations.BeginCreateWithOperationResponseAsync(resourceGroupName, accountName, parameters, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Deletes a storage account in Microsoft Azure.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            public static void Delete(this IStorageAccountsOperations operations, string resourceGroupName, string accountName)
            {
                Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).DeleteAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a storage account in Microsoft Azure.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IStorageAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithOperationResponseAsync(resourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns the properties for the specified storage account including but not
            /// limited to name, account type, location, and account status. The ListKeys
            /// operation should be used to retrieve storage keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            public static StorageAccount GetProperties(this IStorageAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).GetPropertiesAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the properties for the specified storage account including but not
            /// limited to name, account type, location, and account status. The ListKeys
            /// operation should be used to retrieve storage keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<StorageAccount> GetPropertiesAsync( this IStorageAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<StorageAccount> result = await operations.GetPropertiesWithOperationResponseAsync(resourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Updates the account type or tags for a storage account. It can also be
            /// used to add a custom domain (note that custom domains cannot be added via
            /// the Create operation). Only one custom domain is supported per storage
            /// account. This API can only be used to update one of tags, accountType, or
            /// customDomain per call. To update multiple of these properties, call the
            /// API multiple times with one change per call. This call does not change
            /// the storage keys for the account. If you want to change storage account
            /// keys, use the RegenerateKey operation. The location and name of the
            /// storage account cannot be changed after creation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to update on the account. Note that only one property can
            /// be changed at a time using this API.
            /// </param>
            public static StorageAccount Update(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountUpdateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).UpdateAsync(resourceGroupName, accountName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the account type or tags for a storage account. It can also be
            /// used to add a custom domain (note that custom domains cannot be added via
            /// the Create operation). Only one custom domain is supported per storage
            /// account. This API can only be used to update one of tags, accountType, or
            /// customDomain per call. To update multiple of these properties, call the
            /// API multiple times with one change per call. This call does not change
            /// the storage keys for the account. If you want to change storage account
            /// keys, use the RegenerateKey operation. The location and name of the
            /// storage account cannot be changed after creation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to update on the account. Note that only one property can
            /// be changed at a time using this API.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<StorageAccount> UpdateAsync( this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<StorageAccount> result = await operations.UpdateWithOperationResponseAsync(resourceGroupName, accountName, parameters, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Lists the access keys for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account.
            /// </param>
            public static StorageAccountKeys ListKeys(this IStorageAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).ListKeysAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the access keys for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<StorageAccountKeys> ListKeysAsync( this IStorageAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<StorageAccountKeys> result = await operations.ListKeysWithOperationResponseAsync(resourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Lists all the storage accounts available under the subscription. Note that
            /// storage keys are not returned; use the ListKeys operation for this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static StorageAccountListResponse List(this IStorageAccountsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).ListAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the storage accounts available under the subscription. Note that
            /// storage keys are not returned; use the ListKeys operation for this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<StorageAccountListResponse> ListAsync( this IStorageAccountsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<StorageAccountListResponse> result = await operations.ListWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Lists all the storage accounts available under the given resource group.
            /// Note that storage keys are not returned; use the ListKeys operation for
            /// this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            public static StorageAccountListResponse ListByResourceGroup(this IStorageAccountsOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).ListByResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the storage accounts available under the given resource group.
            /// Note that storage keys are not returned; use the ListKeys operation for
            /// this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<StorageAccountListResponse> ListByResourceGroupAsync( this IStorageAccountsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<StorageAccountListResponse> result = await operations.ListByResourceGroupWithOperationResponseAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Regenerates the access keys for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='regenerateKey'>
            /// Specifies name of the key which should be regenerated.
            /// </param>
            public static StorageAccountKeys RegenerateKey(this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountRegenerateKeyParameters regenerateKey)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).RegenerateKeyAsync(resourceGroupName, accountName, regenerateKey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the access keys for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the userâ€™s subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and
            /// use numbers and lower-case letters only.
            /// </param>
            /// <param name='regenerateKey'>
            /// Specifies name of the key which should be regenerated.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<StorageAccountKeys> RegenerateKeyAsync( this IStorageAccountsOperations operations, string resourceGroupName, string accountName, StorageAccountRegenerateKeyParameters regenerateKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<StorageAccountKeys> result = await operations.RegenerateKeyWithOperationResponseAsync(resourceGroupName, accountName, regenerateKey, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Lists all the storage accounts available under the subscription. Note that
            /// storage keys are not returned; use the ListKeys operation for this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static StorageAccountListResponse ListNext(this IStorageAccountsOperations operations, string nextLink)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).ListNextAsync(nextLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the storage accounts available under the subscription. Note that
            /// storage keys are not returned; use the ListKeys operation for this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<StorageAccountListResponse> ListNextAsync( this IStorageAccountsOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<StorageAccountListResponse> result = await operations.ListNextWithOperationResponseAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Lists all the storage accounts available under the given resource group.
            /// Note that storage keys are not returned; use the ListKeys operation for
            /// this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static StorageAccountListResponse ListByResourceGroupNext(this IStorageAccountsOperations operations, string nextLink)
            {
                return Task.Factory.StartNew(s => ((IStorageAccountsOperations)s).ListByResourceGroupNextAsync(nextLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the storage accounts available under the given resource group.
            /// Note that storage keys are not returned; use the ListKeys operation for
            /// this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<StorageAccountListResponse> ListByResourceGroupNextAsync( this IStorageAccountsOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<StorageAccountListResponse> result = await operations.ListByResourceGroupNextWithOperationResponseAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
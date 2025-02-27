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
using Azure.ResourceManager.Management;

namespace MgmtExtensionResource
{
    /// <summary> A class representing collection of PolicyDefinition and their operations over its parent. </summary>
    public partial class ManagementGroupPolicyDefinitionCollection : ArmCollection, IEnumerable<ManagementGroupPolicyDefinition>, IAsyncEnumerable<ManagementGroupPolicyDefinition>
    {
        private readonly ClientDiagnostics _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics;
        private readonly PolicyDefinitionsRestOperations _managementGroupPolicyDefinitionPolicyDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicyDefinitionCollection"/> class for mocking. </summary>
        protected ManagementGroupPolicyDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicyDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagementGroupPolicyDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics = new ClientDiagnostics("MgmtExtensionResource", ManagementGroupPolicyDefinition.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ManagementGroupPolicyDefinition.ResourceType, out string managementGroupPolicyDefinitionPolicyDefinitionsApiVersion);
            _managementGroupPolicyDefinitionPolicyDefinitionsRestClient = new PolicyDefinitionsRestOperations(_managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managementGroupPolicyDefinitionPolicyDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagementGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagementGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyDefinitions_CreateOrUpdateAtManagementGroup
        /// <summary> This operation creates or updates a policy definition in the given management group with the given name. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ManagementGroupPolicyDefinition>> CreateOrUpdateAsync(bool waitForCompletion, string policyDefinitionName, PolicyDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateOrUpdateAtManagementGroupAsync(Id.Name, policyDefinitionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtExtensionResourceArmOperation<ManagementGroupPolicyDefinition>(Response.FromValue(new ManagementGroupPolicyDefinition(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyDefinitions_CreateOrUpdateAtManagementGroup
        /// <summary> This operation creates or updates a policy definition in the given management group with the given name. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ManagementGroupPolicyDefinition> CreateOrUpdate(bool waitForCompletion, string policyDefinitionName, PolicyDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.CreateOrUpdateAtManagementGroup(Id.Name, policyDefinitionName, parameters, cancellationToken);
                var operation = new MgmtExtensionResourceArmOperation<ManagementGroupPolicyDefinition>(Response.FromValue(new ManagementGroupPolicyDefinition(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyDefinitions_GetAtManagementGroup
        /// <summary> This operation retrieves the policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public async virtual Task<Response<ManagementGroupPolicyDefinition>> GetAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroupAsync(Id.Name, policyDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagementGroupPolicyDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyDefinitions_GetAtManagementGroup
        /// <summary> This operation retrieves the policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<ManagementGroupPolicyDefinition> Get(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroup(Id.Name, policyDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyDefinitions_ListByManagementGroup
        /// <summary> This operation retrieves a list of all the policy definitions in a given management group that match the optional given $filter. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy definitions associated with the management group, including those that apply directly or from management groups that contain the given management group. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given management group. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy definitions whose category match the {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagementGroupPolicyDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagementGroupPolicyDefinition> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagementGroupPolicyDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.ListByManagementGroupAsync(Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupPolicyDefinition(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagementGroupPolicyDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.ListByManagementGroupNextPageAsync(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupPolicyDefinition(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyDefinitions_ListByManagementGroup
        /// <summary> This operation retrieves a list of all the policy definitions in a given management group that match the optional given $filter. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy definitions associated with the management group, including those that apply directly or from management groups that contain the given management group. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given management group. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy definitions whose category match the {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagementGroupPolicyDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagementGroupPolicyDefinition> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ManagementGroupPolicyDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.ListByManagementGroup(Id.Name, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupPolicyDefinition(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagementGroupPolicyDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.ListByManagementGroupNextPage(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupPolicyDefinition(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyDefinitions_GetAtManagementGroup
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyDefinitions_GetAtManagementGroup
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyDefinitionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyDefinitions_GetAtManagementGroup
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public async virtual Task<Response<ManagementGroupPolicyDefinition>> GetIfExistsAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroupAsync(Id.Name, policyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagementGroupPolicyDefinition>(null, response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyDefinitions_GetAtManagementGroup
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<ManagementGroupPolicyDefinition> GetIfExists(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroup(Id.Name, policyDefinitionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagementGroupPolicyDefinition>(null, response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagementGroupPolicyDefinition> IEnumerable<ManagementGroupPolicyDefinition>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagementGroupPolicyDefinition> IAsyncEnumerable<ManagementGroupPolicyDefinition>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

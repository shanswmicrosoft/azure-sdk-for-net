// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RoleAssignmentsOperations.
    /// </summary>
    public static partial class RoleAssignmentsOperationsExtensions
    {
            /// <summary>
            /// Gets role assignments for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='parentResourcePath'>
            /// The parent resource identity.
            /// </param>
            /// <param name='resourceType'>
            /// The resource type of the resource.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource to get role assignments for.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<RoleAssignmentInner> ListForResource(this IRoleAssignmentsOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, ODataQuery<RoleAssignmentFilterInner> odataQuery = default(ODataQuery<RoleAssignmentFilterInner>))
            {
                return ((IRoleAssignmentsOperations)operations).ListForResourceAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role assignments for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='parentResourcePath'>
            /// The parent resource identity.
            /// </param>
            /// <param name='resourceType'>
            /// The resource type of the resource.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource to get role assignments for.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleAssignmentInner>> ListForResourceAsync(this IRoleAssignmentsOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, ODataQuery<RoleAssignmentFilterInner> odataQuery = default(ODataQuery<RoleAssignmentFilterInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceWithHttpMessagesAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets role assignments for a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<RoleAssignmentInner> ListForResourceGroup(this IRoleAssignmentsOperations operations, string resourceGroupName, ODataQuery<RoleAssignmentFilterInner> odataQuery = default(ODataQuery<RoleAssignmentFilterInner>))
            {
                return ((IRoleAssignmentsOperations)operations).ListForResourceGroupAsync(resourceGroupName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role assignments for a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleAssignmentInner>> ListForResourceGroupAsync(this IRoleAssignmentsOperations operations, string resourceGroupName, ODataQuery<RoleAssignmentFilterInner> odataQuery = default(ODataQuery<RoleAssignmentFilterInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupWithHttpMessagesAsync(resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment to delete.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to delete.
            /// </param>
            public static RoleAssignmentInner Delete(this IRoleAssignmentsOperations operations, string scope, string roleAssignmentName)
            {
                return operations.DeleteAsync(scope, roleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment to delete.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignmentInner> DeleteAsync(this IRoleAssignmentsOperations operations, string scope, string roleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(scope, roleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment to create. The scope can be any REST
            /// resource instance. For example, use '/subscriptions/{subscription-id}/' for
            /// a subscription,
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for
            /// a resource group, and
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider}/{resource-type}/{resource-name}'
            /// for a resource.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to create. It can be any valid GUID.
            /// </param>
            /// <param name='properties'>
            /// Role assignment properties.
            /// </param>
            public static RoleAssignmentInner Create(this IRoleAssignmentsOperations operations, string scope, string roleAssignmentName, RoleAssignmentPropertiesInner properties = default(RoleAssignmentPropertiesInner))
            {
                return operations.CreateAsync(scope, roleAssignmentName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment to create. The scope can be any REST
            /// resource instance. For example, use '/subscriptions/{subscription-id}/' for
            /// a subscription,
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for
            /// a resource group, and
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider}/{resource-type}/{resource-name}'
            /// for a resource.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to create. It can be any valid GUID.
            /// </param>
            /// <param name='properties'>
            /// Role assignment properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignmentInner> CreateAsync(this IRoleAssignmentsOperations operations, string scope, string roleAssignmentName, RoleAssignmentPropertiesInner properties = default(RoleAssignmentPropertiesInner), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(scope, roleAssignmentName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the specified role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to get.
            /// </param>
            public static RoleAssignmentInner Get(this IRoleAssignmentsOperations operations, string scope, string roleAssignmentName)
            {
                return operations.GetAsync(scope, roleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignment.
            /// </param>
            /// <param name='roleAssignmentName'>
            /// The name of the role assignment to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignmentInner> GetAsync(this IRoleAssignmentsOperations operations, string scope, string roleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, roleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to delete.
            /// </param>
            public static RoleAssignmentInner DeleteById(this IRoleAssignmentsOperations operations, string roleAssignmentId)
            {
                return operations.DeleteByIdAsync(roleAssignmentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a role assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignmentInner> DeleteByIdAsync(this IRoleAssignmentsOperations operations, string roleAssignmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteByIdWithHttpMessagesAsync(roleAssignmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a role assignment by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to create.
            /// </param>
            /// <param name='properties'>
            /// Role assignment properties.
            /// </param>
            public static RoleAssignmentInner CreateById(this IRoleAssignmentsOperations operations, string roleAssignmentId, RoleAssignmentPropertiesInner properties = default(RoleAssignmentPropertiesInner))
            {
                return operations.CreateByIdAsync(roleAssignmentId, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a role assignment by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to create.
            /// </param>
            /// <param name='properties'>
            /// Role assignment properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignmentInner> CreateByIdAsync(this IRoleAssignmentsOperations operations, string roleAssignmentId, RoleAssignmentPropertiesInner properties = default(RoleAssignmentPropertiesInner), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateByIdWithHttpMessagesAsync(roleAssignmentId, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a role assignment by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to get.
            /// </param>
            public static RoleAssignmentInner GetById(this IRoleAssignmentsOperations operations, string roleAssignmentId)
            {
                return operations.GetByIdAsync(roleAssignmentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a role assignment by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleAssignmentId'>
            /// The ID of the role assignment to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleAssignmentInner> GetByIdAsync(this IRoleAssignmentsOperations operations, string roleAssignmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(roleAssignmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all role assignments for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<RoleAssignmentInner> List(this IRoleAssignmentsOperations operations, ODataQuery<RoleAssignmentFilterInner> odataQuery = default(ODataQuery<RoleAssignmentFilterInner>))
            {
                return ((IRoleAssignmentsOperations)operations).ListAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all role assignments for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleAssignmentInner>> ListAsync(this IRoleAssignmentsOperations operations, ODataQuery<RoleAssignmentFilterInner> odataQuery = default(ODataQuery<RoleAssignmentFilterInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets role assignments for a scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignments.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<RoleAssignmentInner> ListForScope(this IRoleAssignmentsOperations operations, string scope, ODataQuery<RoleAssignmentFilterInner> odataQuery = default(ODataQuery<RoleAssignmentFilterInner>))
            {
                return operations.ListForScopeAsync(scope, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role assignments for a scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role assignments.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleAssignmentInner>> ListForScopeAsync(this IRoleAssignmentsOperations operations, string scope, ODataQuery<RoleAssignmentFilterInner> odataQuery = default(ODataQuery<RoleAssignmentFilterInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForScopeWithHttpMessagesAsync(scope, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets role assignments for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RoleAssignmentInner> ListForResourceNext(this IRoleAssignmentsOperations operations, string nextPageLink)
            {
                return operations.ListForResourceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role assignments for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleAssignmentInner>> ListForResourceNextAsync(this IRoleAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets role assignments for a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RoleAssignmentInner> ListForResourceGroupNext(this IRoleAssignmentsOperations operations, string nextPageLink)
            {
                return operations.ListForResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role assignments for a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleAssignmentInner>> ListForResourceGroupNextAsync(this IRoleAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all role assignments for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RoleAssignmentInner> ListNext(this IRoleAssignmentsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all role assignments for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleAssignmentInner>> ListNextAsync(this IRoleAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets role assignments for a scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RoleAssignmentInner> ListForScopeNext(this IRoleAssignmentsOperations operations, string nextPageLink)
            {
                return operations.ListForScopeNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role assignments for a scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleAssignmentInner>> ListForScopeNextAsync(this IRoleAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForScopeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

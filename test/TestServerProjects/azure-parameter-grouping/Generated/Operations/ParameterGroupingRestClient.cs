// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using azure_parameter_grouping.Models;

namespace azure_parameter_grouping
{
    internal partial class ParameterGroupingRestClient
    {
        private string host;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ParameterGroupingRestClient. </summary>
        public ParameterGroupingRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.host = host;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreatePostRequiredRequest(ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/parameterGrouping/postRequired/", false);
            uri.AppendPath(parameterGroupingPostRequiredParameters.Path, true);
            if (parameterGroupingPostRequiredParameters?.Query != null)
            {
                uri.AppendQuery("query", parameterGroupingPostRequiredParameters.Query.Value, true);
            }
            request.Uri = uri;
            if (parameterGroupingPostRequiredParameters?.CustomHeader != null)
            {
                request.Headers.Add("customHeader", parameterGroupingPostRequiredParameters.CustomHeader);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteNumberValue(parameterGroupingPostRequiredParameters.Body);
            request.Content = content;
            return message;
        }

        /// <summary> Post a bunch of required parameters grouped. </summary>
        /// <param name="parameterGroupingPostRequiredParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostRequiredAsync(ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters, CancellationToken cancellationToken = default)
        {
            if (parameterGroupingPostRequiredParameters == null)
            {
                throw new ArgumentNullException(nameof(parameterGroupingPostRequiredParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ParameterGroupingClient.PostRequired");
            scope.Start();
            try
            {
                using var message = CreatePostRequiredRequest(parameterGroupingPostRequiredParameters);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Post a bunch of required parameters grouped. </summary>
        /// <param name="parameterGroupingPostRequiredParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostRequired(ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters, CancellationToken cancellationToken = default)
        {
            if (parameterGroupingPostRequiredParameters == null)
            {
                throw new ArgumentNullException(nameof(parameterGroupingPostRequiredParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ParameterGroupingClient.PostRequired");
            scope.Start();
            try
            {
                using var message = CreatePostRequiredRequest(parameterGroupingPostRequiredParameters);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreatePostOptionalRequest(ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/parameterGrouping/postOptional", false);
            if (parameterGroupingPostOptionalParameters?.Query != null)
            {
                uri.AppendQuery("query", parameterGroupingPostOptionalParameters.Query.Value, true);
            }
            request.Uri = uri;
            if (parameterGroupingPostOptionalParameters?.CustomHeader != null)
            {
                request.Headers.Add("customHeader", parameterGroupingPostOptionalParameters.CustomHeader);
            }
            return message;
        }

        /// <summary> Post a bunch of optional parameters grouped. </summary>
        /// <param name="parameterGroupingPostOptionalParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostOptionalAsync(ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParameterGroupingClient.PostOptional");
            scope.Start();
            try
            {
                using var message = CreatePostOptionalRequest(parameterGroupingPostOptionalParameters);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Post a bunch of optional parameters grouped. </summary>
        /// <param name="parameterGroupingPostOptionalParameters"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostOptional(ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParameterGroupingClient.PostOptional");
            scope.Start();
            try
            {
                using var message = CreatePostOptionalRequest(parameterGroupingPostOptionalParameters);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreatePostMultiParamGroupsRequest(FirstParameterGroup firstParameterGroup, ParameterGroupingPostMultiParamGroupsSecondParamGroup parameterGroupingPostMultiParamGroupsSecondParamGroup)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/parameterGrouping/postMultipleParameterGroups", false);
            if (firstParameterGroup?.QueryOne != null)
            {
                uri.AppendQuery("query-one", firstParameterGroup.QueryOne.Value, true);
            }
            if (parameterGroupingPostMultiParamGroupsSecondParamGroup?.QueryTwo != null)
            {
                uri.AppendQuery("query-two", parameterGroupingPostMultiParamGroupsSecondParamGroup.QueryTwo.Value, true);
            }
            request.Uri = uri;
            if (firstParameterGroup?.HeaderOne != null)
            {
                request.Headers.Add("header-one", firstParameterGroup.HeaderOne);
            }
            if (parameterGroupingPostMultiParamGroupsSecondParamGroup?.HeaderTwo != null)
            {
                request.Headers.Add("header-two", parameterGroupingPostMultiParamGroupsSecondParamGroup.HeaderTwo);
            }
            return message;
        }

        /// <summary> Post parameters from multiple different parameter groups. </summary>
        /// <param name="firstParameterGroup"> Parameter group. </param>
        /// <param name="parameterGroupingPostMultiParamGroupsSecondParamGroup"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostMultiParamGroupsAsync(FirstParameterGroup firstParameterGroup = null, ParameterGroupingPostMultiParamGroupsSecondParamGroup parameterGroupingPostMultiParamGroupsSecondParamGroup = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParameterGroupingClient.PostMultiParamGroups");
            scope.Start();
            try
            {
                using var message = CreatePostMultiParamGroupsRequest(firstParameterGroup, parameterGroupingPostMultiParamGroupsSecondParamGroup);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Post parameters from multiple different parameter groups. </summary>
        /// <param name="firstParameterGroup"> Parameter group. </param>
        /// <param name="parameterGroupingPostMultiParamGroupsSecondParamGroup"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostMultiParamGroups(FirstParameterGroup firstParameterGroup = null, ParameterGroupingPostMultiParamGroupsSecondParamGroup parameterGroupingPostMultiParamGroupsSecondParamGroup = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParameterGroupingClient.PostMultiParamGroups");
            scope.Start();
            try
            {
                using var message = CreatePostMultiParamGroupsRequest(firstParameterGroup, parameterGroupingPostMultiParamGroupsSecondParamGroup);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreatePostSharedParameterGroupObjectRequest(FirstParameterGroup firstParameterGroup)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/parameterGrouping/sharedParameterGroupObject", false);
            if (firstParameterGroup?.QueryOne != null)
            {
                uri.AppendQuery("query-one", firstParameterGroup.QueryOne.Value, true);
            }
            request.Uri = uri;
            if (firstParameterGroup?.HeaderOne != null)
            {
                request.Headers.Add("header-one", firstParameterGroup.HeaderOne);
            }
            return message;
        }

        /// <summary> Post parameters with a shared parameter group object. </summary>
        /// <param name="firstParameterGroup"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostSharedParameterGroupObjectAsync(FirstParameterGroup firstParameterGroup = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParameterGroupingClient.PostSharedParameterGroupObject");
            scope.Start();
            try
            {
                using var message = CreatePostSharedParameterGroupObjectRequest(firstParameterGroup);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Post parameters with a shared parameter group object. </summary>
        /// <param name="firstParameterGroup"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostSharedParameterGroupObject(FirstParameterGroup firstParameterGroup = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParameterGroupingClient.PostSharedParameterGroupObject");
            scope.Start();
            try
            {
                using var message = CreatePostSharedParameterGroupObjectRequest(firstParameterGroup);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
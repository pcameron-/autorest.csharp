// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using MgmtListMethods;

namespace MgmtListMethods.Models
{
    /// <summary> Create or update. </summary>
    public partial class FakeParentWithAncestorWithLocCreateOrUpdateOperation : Operation<FakeParentWithAncestorWithLoc>
    {
        private readonly OperationOrResponseInternals<FakeParentWithAncestorWithLoc> _operation;

        /// <summary> Initializes a new instance of FakeParentWithAncestorWithLocCreateOrUpdateOperation for mocking. </summary>
        protected FakeParentWithAncestorWithLocCreateOrUpdateOperation()
        {
        }

        internal FakeParentWithAncestorWithLocCreateOrUpdateOperation(ArmClient armClient, Response<FakeParentWithAncestorWithLocData> response)
        {
            _operation = new OperationOrResponseInternals<FakeParentWithAncestorWithLoc>(Response.FromValue(new FakeParentWithAncestorWithLoc(armClient, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override FakeParentWithAncestorWithLoc Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<FakeParentWithAncestorWithLoc>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<FakeParentWithAncestorWithLoc>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}

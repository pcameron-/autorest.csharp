﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License

using System;
using System.Linq;
using System.Collections.Generic;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Models;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Types;
using Azure.ResourceManager.Core;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Input;

namespace AutoRest.CSharp.Mgmt.Output
{
    internal class MgmtExtensionClient : MgmtTypeProvider
    {
        private string _defaultName;
        public MgmtExtensionClient(BuildContext<MgmtOutputLibrary> context, MgmtExtensions publicExtension)
            : base(context, publicExtension.ResourceName)
        {
            Extension = publicExtension;
            _defaultName = $"{ResourceName}ExtensionClient";
        }

        protected override ConstructorSignature? EnsureArmClientCtor()
        {
            return new ConstructorSignature(
                Name: Type.Name,
                Description: $"Initializes a new instance of the <see cref=\"{Type.Name}\"/> class.",
                Modifiers: "internal",
                Parameters: new[] { ArmClientParameter, ResourceIdentifierParameter },
                Initializer: new(
                    isBase: true,
                    arguments: new[] { ArmClientParameter, ResourceIdentifierParameter }));
        }

        protected override IEnumerable<MgmtClientOperation> EnsureAllOperations()
        {
            return Extension.AllRawOperations.Select(operation =>
            {
                var operationName = Extension.GetOperationName(operation);
                // TODO -- these logic needs a thorough refactor -- the values MgmtRestOperation consumes here are actually coupled together, some of the values are calculated multiple times (here and in writers).
                // we just leave this implementation here since it could work for now
                return MgmtClientOperation.FromOperation(
                    new MgmtRestOperation(
                        _context.Library.GetRestClientMethod(operation),
                        _context.Library.GetRestClient(operation),
                        operation.GetRequestPath(_context),
                        Extension.ContextualPath,
                        operationName,
                        _context),
                    _context);
            });
        }

        protected override string CalculateOperationName(Operation operation, string clientResourceName)
        {
            return base.CalculateOperationName(operation, clientResourceName);
        }

        public override CSharpType? BaseType => typeof(ArmResource);

        protected override string DefaultName => _defaultName;

        public MgmtExtensions Extension { get; }

        public override IEnumerable<Resource> ChildResources => Extension.ChildResources;

        private string? _description;
        public override string Description => _description ??= $"A class to add extension methods to {ResourceName}.";

        protected override string DefaultAccessibility => "internal";

        protected override IEnumerable<MgmtClientOperation> EnsureClientOperations() => Extension.ClientOperations;
    }
}

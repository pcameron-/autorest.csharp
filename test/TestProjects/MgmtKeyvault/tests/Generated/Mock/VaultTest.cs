// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for Vault. </summary>
    public partial class VaultMockTests : MockTestBase
    {
        public VaultMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Retrieve a vault
            var vaultId = MgmtKeyvault.Vault.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vault = GetArmClient().GetVault(vaultId);

            await vault.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete a vault
            var vaultId = MgmtKeyvault.Vault.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vault = GetArmClient().GetVault(vaultId);

            await vault.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Update an existing vault
            var vaultId = MgmtKeyvault.Vault.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vault = GetArmClient().GetVault(vaultId);
            MgmtKeyvault.Models.VaultPatchParameters parameters = new MgmtKeyvault.Models.VaultPatchParameters()
            {
                Properties = new MgmtKeyvault.Models.VaultPatchProperties()
                {
                    TenantId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                    Sku = new MgmtKeyvault.Models.Sku(family: new MgmtKeyvault.Models.SkuFamily("A"), name: MgmtKeyvault.Models.SkuName.Standard),
                    EnabledForDeployment = true,
                    EnabledForDiskEncryption = true,
                    EnabledForTemplateDeployment = true,
                },
            };

            await vault.UpdateAsync(parameters);
        }

        [RecordedTest]
        public async Task UpdateAccessPolicy()
        {
            // Example: Add an access policy, or update an access policy with new permissions
            var vaultId = MgmtKeyvault.Vault.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var vault = GetArmClient().GetVault(vaultId);
            MgmtKeyvault.Models.AccessPolicyUpdateKind operationKind = MgmtKeyvault.Models.AccessPolicyUpdateKind.Add;
            MgmtKeyvault.Models.VaultAccessPolicyParameters parameters = new MgmtKeyvault.Models.VaultAccessPolicyParameters(properties: new MgmtKeyvault.Models.VaultAccessPolicyProperties(accessPolicies: new List<MgmtKeyvault.Models.AccessPolicyEntry>()
{
new MgmtKeyvault.Models.AccessPolicyEntry(tenantId: Guid.Parse("00000000-0000-0000-0000-000000000000"),objectId: "00000000-0000-0000-0000-000000000000",permissions: new MgmtKeyvault.Models.Permissions()),}));

            await vault.UpdateAccessPolicyAsync(operationKind, parameters);
        }

        [RecordedTest]
        public async Task GetPrivateLinkResources()
        {
            // Example: KeyVaultListPrivateLinkResources
            var vaultId = MgmtKeyvault.Vault.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var vault = GetArmClient().GetVault(vaultId);

            await foreach (var _ in vault.GetPrivateLinkResourcesAsync())
            {
            }
        }
    }
}

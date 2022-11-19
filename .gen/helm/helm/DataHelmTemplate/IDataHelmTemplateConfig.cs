using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.DataHelmTemplate
{
    [JsiiInterface(nativeType: typeof(IDataHelmTemplateConfig), fullyQualifiedName: "helm.dataHelmTemplate.DataHelmTemplateConfig")]
    public interface IDataHelmTemplateConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Chart name to be installed. A path may be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#chart DataHelmTemplate#chart}
        /// </remarks>
        [JsiiProperty(name: "chart", typeJson: "{\"primitive\":\"string\"}")]
        string Chart
        {
            get;
        }

        /// <summary>Release name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#name DataHelmTemplate#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Kubernetes api versions used for Capabilities.APIVersions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#api_versions DataHelmTemplate#api_versions}
        /// </remarks>
        [JsiiProperty(name: "apiVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ApiVersions
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, installation process purges chart on fail. The wait flag will be set automatically if atomic is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#atomic DataHelmTemplate#atomic}
        /// </remarks>
        [JsiiProperty(name: "atomic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Atomic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Create the namespace if it does not exist.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#create_namespace DataHelmTemplate#create_namespace}
        /// </remarks>
        [JsiiProperty(name: "createNamespace", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreateNamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Run helm dependency update before installing the chart.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#dependency_update DataHelmTemplate#dependency_update}
        /// </remarks>
        [JsiiProperty(name: "dependencyUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DependencyUpdate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Add a custom description.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#description DataHelmTemplate#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Use chart development versions, too. Equivalent to version '&gt;0.0.0-0'. If `version` is set, this is ignored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#devel DataHelmTemplate#devel}
        /// </remarks>
        [JsiiProperty(name: "devel", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Devel
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, the installation process will not validate rendered templates against the Kubernetes OpenAPI Schema.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#disable_openapi_validation DataHelmTemplate#disable_openapi_validation}
        /// </remarks>
        [JsiiProperty(name: "disableOpenapiValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableOpenapiValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Prevent hooks from running.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#disable_webhooks DataHelmTemplate#disable_webhooks}
        /// </remarks>
        [JsiiProperty(name: "disableWebhooks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableWebhooks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#id DataHelmTemplate#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include CRDs in the templated output.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#include_crds DataHelmTemplate#include_crds}
        /// </remarks>
        [JsiiProperty(name: "includeCrds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeCrds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set .Release.IsUpgrade instead of .Release.IsInstall.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#is_upgrade DataHelmTemplate#is_upgrade}
        /// </remarks>
        [JsiiProperty(name: "isUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsUpgrade
        {
            get
            {
                return null;
            }
        }

        /// <summary>Location of public keys used for verification. Used only if `verify` is true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#keyring DataHelmTemplate#keyring}
        /// </remarks>
        [JsiiProperty(name: "keyring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Keyring
        {
            get
            {
                return null;
            }
        }

        /// <summary>Concatenated rendered chart templates. This corresponds to the output of the `helm template` command.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#manifest DataHelmTemplate#manifest}
        /// </remarks>
        [JsiiProperty(name: "manifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Manifest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Map of rendered chart templates indexed by the template name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#manifests DataHelmTemplate#manifests}
        /// </remarks>
        [JsiiProperty(name: "manifests", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Manifests
        {
            get
            {
                return null;
            }
        }

        /// <summary>Namespace to install the release into.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#namespace DataHelmTemplate#namespace}
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Rendered notes if the chart contains a `NOTES.txt`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#notes DataHelmTemplate#notes}
        /// </remarks>
        [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Notes
        {
            get
            {
                return null;
            }
        }

        /// <summary>postrender block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#postrender DataHelmTemplate#postrender}
        /// </remarks>
        [JsiiProperty(name: "postrender", typeJson: "{\"fqn\":\"helm.dataHelmTemplate.DataHelmTemplatePostrender\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        helm.DataHelmTemplate.IDataHelmTemplatePostrender? Postrender
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, render subchart notes along with the parent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#render_subchart_notes DataHelmTemplate#render_subchart_notes}
        /// </remarks>
        [JsiiProperty(name: "renderSubchartNotes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RenderSubchartNotes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Re-use the given name, even if that name is already used. This is unsafe in production.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#replace DataHelmTemplate#replace}
        /// </remarks>
        [JsiiProperty(name: "replace", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Replace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Repository where to locate the requested chart. If is a URL the chart is installed without installing the repository.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository DataHelmTemplate#repository}
        /// </remarks>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Repository
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Repositories CA File.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository_ca_file DataHelmTemplate#repository_ca_file}
        /// </remarks>
        [JsiiProperty(name: "repositoryCaFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryCaFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>The repositories cert file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository_cert_file DataHelmTemplate#repository_cert_file}
        /// </remarks>
        [JsiiProperty(name: "repositoryCertFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryCertFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>The repositories cert key file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository_key_file DataHelmTemplate#repository_key_file}
        /// </remarks>
        [JsiiProperty(name: "repositoryKeyFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryKeyFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password for HTTP basic authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository_password DataHelmTemplate#repository_password}
        /// </remarks>
        [JsiiProperty(name: "repositoryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Username for HTTP basic authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository_username DataHelmTemplate#repository_username}
        /// </remarks>
        [JsiiProperty(name: "repositoryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>When upgrading, reset the values to the ones built into the chart.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#reset_values DataHelmTemplate#reset_values}
        /// </remarks>
        [JsiiProperty(name: "resetValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResetValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>When upgrading, reuse the last release's values and merge in any overrides. If 'reset_values' is specified, this is ignored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#reuse_values DataHelmTemplate#reuse_values}
        /// </remarks>
        [JsiiProperty(name: "reuseValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReuseValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#set DataHelmTemplate#set}
        /// </remarks>
        [JsiiProperty(name: "set", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"helm.dataHelmTemplate.DataHelmTemplateSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Set
        {
            get
            {
                return null;
            }
        }

        /// <summary>set_sensitive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#set_sensitive DataHelmTemplate#set_sensitive}
        /// </remarks>
        [JsiiProperty(name: "setSensitive", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"helm.dataHelmTemplate.DataHelmTemplateSetSensitive\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SetSensitive
        {
            get
            {
                return null;
            }
        }

        /// <summary>set_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#set_string DataHelmTemplate#set_string}
        /// </remarks>
        [JsiiProperty(name: "setString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"helm.dataHelmTemplate.DataHelmTemplateSetString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SetString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only show manifests rendered from the given templates.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#show_only DataHelmTemplate#show_only}
        /// </remarks>
        [JsiiProperty(name: "showOnly", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ShowOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, no CRDs will be installed. By default, CRDs are installed if not already present.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#skip_crds DataHelmTemplate#skip_crds}
        /// </remarks>
        [JsiiProperty(name: "skipCrds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipCrds
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, tests will not be rendered. By default, tests are rendered.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#skip_tests DataHelmTemplate#skip_tests}
        /// </remarks>
        [JsiiProperty(name: "skipTests", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipTests
        {
            get
            {
                return null;
            }
        }

        /// <summary>Time in seconds to wait for any individual kubernetes operation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#timeout DataHelmTemplate#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Validate your manifests against the Kubernetes cluster you are currently pointing at.</summary>
        /// <remarks>
        /// This is the same validation performed on an install
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#validate DataHelmTemplate#validate}
        /// </remarks>
        [JsiiProperty(name: "validate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Validate
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of values in raw yaml format to pass to helm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#values DataHelmTemplate#values}
        /// </remarks>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Values
        {
            get
            {
                return null;
            }
        }

        /// <summary>Verify the package before installing it.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#verify DataHelmTemplate#verify}
        /// </remarks>
        [JsiiProperty(name: "verify", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Verify
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the exact chart version to install. If this is not specified, the latest version is installed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#version DataHelmTemplate#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>Will wait until all resources are in a ready state before marking the release as successful.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#wait DataHelmTemplate#wait}
        /// </remarks>
        [JsiiProperty(name: "wait", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Wait
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataHelmTemplateConfig), fullyQualifiedName: "helm.dataHelmTemplate.DataHelmTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, helm.DataHelmTemplate.IDataHelmTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Chart name to be installed. A path may be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#chart DataHelmTemplate#chart}
            /// </remarks>
            [JsiiProperty(name: "chart", typeJson: "{\"primitive\":\"string\"}")]
            public string Chart
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Release name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#name DataHelmTemplate#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Kubernetes api versions used for Capabilities.APIVersions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#api_versions DataHelmTemplate#api_versions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ApiVersions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>If set, installation process purges chart on fail. The wait flag will be set automatically if atomic is used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#atomic DataHelmTemplate#atomic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "atomic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Atomic
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Create the namespace if it does not exist.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#create_namespace DataHelmTemplate#create_namespace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createNamespace", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CreateNamespace
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Run helm dependency update before installing the chart.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#dependency_update DataHelmTemplate#dependency_update}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependencyUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DependencyUpdate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Add a custom description.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#description DataHelmTemplate#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Use chart development versions, too. Equivalent to version '&gt;0.0.0-0'. If `version` is set, this is ignored.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#devel DataHelmTemplate#devel}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "devel", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Devel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If set, the installation process will not validate rendered templates against the Kubernetes OpenAPI Schema.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#disable_openapi_validation DataHelmTemplate#disable_openapi_validation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableOpenapiValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableOpenapiValidation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Prevent hooks from running.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#disable_webhooks DataHelmTemplate#disable_webhooks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableWebhooks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableWebhooks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#id DataHelmTemplate#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include CRDs in the templated output.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#include_crds DataHelmTemplate#include_crds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeCrds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeCrds
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Set .Release.IsUpgrade instead of .Release.IsInstall.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#is_upgrade DataHelmTemplate#is_upgrade}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsUpgrade
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Location of public keys used for verification. Used only if `verify` is true.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#keyring DataHelmTemplate#keyring}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Keyring
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Concatenated rendered chart templates. This corresponds to the output of the `helm template` command.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#manifest DataHelmTemplate#manifest}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "manifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Manifest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Map of rendered chart templates indexed by the template name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#manifests DataHelmTemplate#manifests}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "manifests", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Manifests
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Namespace to install the release into.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#namespace DataHelmTemplate#namespace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Rendered notes if the chart contains a `NOTES.txt`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#notes DataHelmTemplate#notes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Notes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>postrender block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#postrender DataHelmTemplate#postrender}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postrender", typeJson: "{\"fqn\":\"helm.dataHelmTemplate.DataHelmTemplatePostrender\"}", isOptional: true)]
            public helm.DataHelmTemplate.IDataHelmTemplatePostrender? Postrender
            {
                get => GetInstanceProperty<helm.DataHelmTemplate.IDataHelmTemplatePostrender?>();
            }

            /// <summary>If set, render subchart notes along with the parent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#render_subchart_notes DataHelmTemplate#render_subchart_notes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renderSubchartNotes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RenderSubchartNotes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Re-use the given name, even if that name is already used. This is unsafe in production.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#replace DataHelmTemplate#replace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replace", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Replace
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Repository where to locate the requested chart. If is a URL the chart is installed without installing the repository.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository DataHelmTemplate#repository}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Repository
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Repositories CA File.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository_ca_file DataHelmTemplate#repository_ca_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryCaFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryCaFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The repositories cert file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository_cert_file DataHelmTemplate#repository_cert_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryCertFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryCertFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The repositories cert key file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository_key_file DataHelmTemplate#repository_key_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryKeyFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryKeyFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password for HTTP basic authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository_password DataHelmTemplate#repository_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Username for HTTP basic authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#repository_username DataHelmTemplate#repository_username}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When upgrading, reset the values to the ones built into the chart.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#reset_values DataHelmTemplate#reset_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resetValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ResetValues
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When upgrading, reuse the last release's values and merge in any overrides. If 'reset_values' is specified, this is ignored.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#reuse_values DataHelmTemplate#reuse_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reuseValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ReuseValues
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#set DataHelmTemplate#set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "set", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"helm.dataHelmTemplate.DataHelmTemplateSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Set
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>set_sensitive block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#set_sensitive DataHelmTemplate#set_sensitive}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setSensitive", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"helm.dataHelmTemplate.DataHelmTemplateSetSensitive\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SetSensitive
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>set_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#set_string DataHelmTemplate#set_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"helm.dataHelmTemplate.DataHelmTemplateSetString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SetString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Only show manifests rendered from the given templates.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#show_only DataHelmTemplate#show_only}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "showOnly", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ShowOnly
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>If set, no CRDs will be installed. By default, CRDs are installed if not already present.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#skip_crds DataHelmTemplate#skip_crds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipCrds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipCrds
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If set, tests will not be rendered. By default, tests are rendered.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#skip_tests DataHelmTemplate#skip_tests}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipTests", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipTests
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Time in seconds to wait for any individual kubernetes operation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#timeout DataHelmTemplate#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Validate your manifests against the Kubernetes cluster you are currently pointing at.</summary>
            /// <remarks>
            /// This is the same validation performed on an install
            ///
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#validate DataHelmTemplate#validate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Validate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>List of values in raw yaml format to pass to helm.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#values DataHelmTemplate#values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Values
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Verify the package before installing it.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#verify DataHelmTemplate#verify}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verify", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Verify
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specify the exact chart version to install. If this is not specified, the latest version is installed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#version DataHelmTemplate#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Will wait until all resources are in a ready state before marking the release as successful.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#wait DataHelmTemplate#wait}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wait", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Wait
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}

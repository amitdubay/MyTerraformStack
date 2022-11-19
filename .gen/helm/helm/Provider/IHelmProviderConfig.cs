using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.Provider
{
    [JsiiInterface(nativeType: typeof(IHelmProviderConfig), fullyQualifiedName: "helm.provider.HelmProviderConfig")]
    public interface IHelmProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#alias HelmProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Debug indicates whether or not Helm is running in Debug mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#debug HelmProvider#debug}
        /// </remarks>
        [JsiiProperty(name: "debug", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Debug
        {
            get
            {
                return null;
            }
        }

        /// <summary>experiments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#experiments HelmProvider#experiments}
        /// </remarks>
        [JsiiProperty(name: "experiments", typeJson: "{\"fqn\":\"helm.provider.HelmProviderExperiments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        helm.Provider.IHelmProviderExperiments? Experiments
        {
            get
            {
                return null;
            }
        }

        /// <summary>The backend storage driver. Values are: configmap, secret, memory, sql.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#helm_driver HelmProvider#helm_driver}
        /// </remarks>
        [JsiiProperty(name: "helmDriver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HelmDriver
        {
            get
            {
                return null;
            }
        }

        /// <summary>kubernetes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#kubernetes HelmProvider#kubernetes}
        /// </remarks>
        [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"helm.provider.HelmProviderKubernetes\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        helm.Provider.IHelmProviderKubernetes? Kubernetes
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to the helm plugins directory.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#plugins_path HelmProvider#plugins_path}
        /// </remarks>
        [JsiiProperty(name: "pluginsPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PluginsPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to the registry config file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#registry_config_path HelmProvider#registry_config_path}
        /// </remarks>
        [JsiiProperty(name: "registryConfigPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegistryConfigPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to the file containing cached repository indexes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#repository_cache HelmProvider#repository_cache}
        /// </remarks>
        [JsiiProperty(name: "repositoryCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryCache
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to the file containing repository names and URLs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#repository_config_path HelmProvider#repository_config_path}
        /// </remarks>
        [JsiiProperty(name: "repositoryConfigPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryConfigPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHelmProviderConfig), fullyQualifiedName: "helm.provider.HelmProviderConfig")]
        internal sealed class _Proxy : DeputyBase, helm.Provider.IHelmProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#alias HelmProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Debug indicates whether or not Helm is running in Debug mode.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#debug HelmProvider#debug}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "debug", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Debug
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>experiments block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#experiments HelmProvider#experiments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "experiments", typeJson: "{\"fqn\":\"helm.provider.HelmProviderExperiments\"}", isOptional: true)]
            public helm.Provider.IHelmProviderExperiments? Experiments
            {
                get => GetInstanceProperty<helm.Provider.IHelmProviderExperiments?>();
            }

            /// <summary>The backend storage driver. Values are: configmap, secret, memory, sql.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#helm_driver HelmProvider#helm_driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "helmDriver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HelmDriver
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>kubernetes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#kubernetes HelmProvider#kubernetes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"helm.provider.HelmProviderKubernetes\"}", isOptional: true)]
            public helm.Provider.IHelmProviderKubernetes? Kubernetes
            {
                get => GetInstanceProperty<helm.Provider.IHelmProviderKubernetes?>();
            }

            /// <summary>The path to the helm plugins directory.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#plugins_path HelmProvider#plugins_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pluginsPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PluginsPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to the registry config file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#registry_config_path HelmProvider#registry_config_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registryConfigPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistryConfigPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to the file containing cached repository indexes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#repository_cache HelmProvider#repository_cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryCache
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to the file containing repository names and URLs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#repository_config_path HelmProvider#repository_config_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryConfigPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryConfigPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

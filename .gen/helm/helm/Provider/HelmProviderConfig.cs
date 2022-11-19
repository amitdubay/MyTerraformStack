using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.Provider
{
    [JsiiByValue(fqn: "helm.provider.HelmProviderConfig")]
    public class HelmProviderConfig : helm.Provider.IHelmProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#alias HelmProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        private object? _debug;

        /// <summary>Debug indicates whether or not Helm is running in Debug mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#debug HelmProvider#debug}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "debug", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Debug
        {
            get => _debug;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _debug = value;
            }
        }

        /// <summary>experiments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#experiments HelmProvider#experiments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "experiments", typeJson: "{\"fqn\":\"helm.provider.HelmProviderExperiments\"}", isOptional: true)]
        public helm.Provider.IHelmProviderExperiments? Experiments
        {
            get;
            set;
        }

        /// <summary>The backend storage driver. Values are: configmap, secret, memory, sql.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#helm_driver HelmProvider#helm_driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "helmDriver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HelmDriver
        {
            get;
            set;
        }

        /// <summary>kubernetes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#kubernetes HelmProvider#kubernetes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"helm.provider.HelmProviderKubernetes\"}", isOptional: true)]
        public helm.Provider.IHelmProviderKubernetes? Kubernetes
        {
            get;
            set;
        }

        /// <summary>The path to the helm plugins directory.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#plugins_path HelmProvider#plugins_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pluginsPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PluginsPath
        {
            get;
            set;
        }

        /// <summary>The path to the registry config file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#registry_config_path HelmProvider#registry_config_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registryConfigPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistryConfigPath
        {
            get;
            set;
        }

        /// <summary>The path to the file containing cached repository indexes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#repository_cache HelmProvider#repository_cache}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryCache
        {
            get;
            set;
        }

        /// <summary>The path to the file containing repository names and URLs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#repository_config_path HelmProvider#repository_config_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryConfigPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryConfigPath
        {
            get;
            set;
        }
    }
}

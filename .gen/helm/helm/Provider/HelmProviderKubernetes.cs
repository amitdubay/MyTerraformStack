using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.Provider
{
    [JsiiByValue(fqn: "helm.provider.HelmProviderKubernetes")]
    public class HelmProviderKubernetes : helm.Provider.IHelmProviderKubernetes
    {
        /// <summary>PEM-encoded client certificate for TLS authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#client_certificate HelmProvider#client_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificate
        {
            get;
            set;
        }

        /// <summary>PEM-encoded client certificate key for TLS authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#client_key HelmProvider#client_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientKey
        {
            get;
            set;
        }

        /// <summary>PEM-encoded root certificates bundle for TLS authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#cluster_ca_certificate HelmProvider#cluster_ca_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterCaCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_context HelmProvider#config_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigContext
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_context_auth_info HelmProvider#config_context_auth_info}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configContextAuthInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigContextAuthInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_context_cluster HelmProvider#config_context_cluster}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configContextCluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigContextCluster
        {
            get;
            set;
        }

        /// <summary>Path to the kube config file. Can be set with KUBE_CONFIG_PATH.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_path HelmProvider#config_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigPath
        {
            get;
            set;
        }

        /// <summary>A list of paths to kube config files. Can be set with KUBE_CONFIG_PATHS environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_paths HelmProvider#config_paths}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ConfigPaths
        {
            get;
            set;
        }

        /// <summary>exec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#exec HelmProvider#exec}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exec", typeJson: "{\"fqn\":\"helm.provider.HelmProviderKubernetesExec\"}", isOptional: true)]
        public helm.Provider.IHelmProviderKubernetesExec? Exec
        {
            get;
            set;
        }

        /// <summary>The hostname (in form of URI) of Kubernetes master.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#host HelmProvider#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Host
        {
            get;
            set;
        }

        private object? _insecure;

        /// <summary>Whether server should be accessed without verifying the TLS certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#insecure HelmProvider#insecure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Insecure
        {
            get => _insecure;
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
                _insecure = value;
            }
        }

        /// <summary>The password to use for HTTP basic authentication when accessing the Kubernetes master endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#password HelmProvider#password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Token to authenticate an service account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#token HelmProvider#token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }

        /// <summary>The username to use for HTTP basic authentication when accessing the Kubernetes master endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#username HelmProvider#username}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}

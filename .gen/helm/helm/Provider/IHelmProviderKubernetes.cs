using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.Provider
{
    [JsiiInterface(nativeType: typeof(IHelmProviderKubernetes), fullyQualifiedName: "helm.provider.HelmProviderKubernetes")]
    public interface IHelmProviderKubernetes
    {
        /// <summary>PEM-encoded client certificate for TLS authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#client_certificate HelmProvider#client_certificate}
        /// </remarks>
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>PEM-encoded client certificate key for TLS authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#client_key HelmProvider#client_key}
        /// </remarks>
        [JsiiProperty(name: "clientKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>PEM-encoded root certificates bundle for TLS authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#cluster_ca_certificate HelmProvider#cluster_ca_certificate}
        /// </remarks>
        [JsiiProperty(name: "clusterCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterCaCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_context HelmProvider#config_context}.</summary>
        [JsiiProperty(name: "configContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_context_auth_info HelmProvider#config_context_auth_info}.</summary>
        [JsiiProperty(name: "configContextAuthInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigContextAuthInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_context_cluster HelmProvider#config_context_cluster}.</summary>
        [JsiiProperty(name: "configContextCluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigContextCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>Path to the kube config file. Can be set with KUBE_CONFIG_PATH.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_path HelmProvider#config_path}
        /// </remarks>
        [JsiiProperty(name: "configPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of paths to kube config files. Can be set with KUBE_CONFIG_PATHS environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_paths HelmProvider#config_paths}
        /// </remarks>
        [JsiiProperty(name: "configPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ConfigPaths
        {
            get
            {
                return null;
            }
        }

        /// <summary>exec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#exec HelmProvider#exec}
        /// </remarks>
        [JsiiProperty(name: "exec", typeJson: "{\"fqn\":\"helm.provider.HelmProviderKubernetesExec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        helm.Provider.IHelmProviderKubernetesExec? Exec
        {
            get
            {
                return null;
            }
        }

        /// <summary>The hostname (in form of URI) of Kubernetes master.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#host HelmProvider#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether server should be accessed without verifying the TLS certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#insecure HelmProvider#insecure}
        /// </remarks>
        [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Insecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>The password to use for HTTP basic authentication when accessing the Kubernetes master endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#password HelmProvider#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Token to authenticate an service account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#token HelmProvider#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        /// <summary>The username to use for HTTP basic authentication when accessing the Kubernetes master endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#username HelmProvider#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHelmProviderKubernetes), fullyQualifiedName: "helm.provider.HelmProviderKubernetes")]
        internal sealed class _Proxy : DeputyBase, helm.Provider.IHelmProviderKubernetes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>PEM-encoded client certificate for TLS authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#client_certificate HelmProvider#client_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>PEM-encoded client certificate key for TLS authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#client_key HelmProvider#client_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>PEM-encoded root certificates bundle for TLS authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#cluster_ca_certificate HelmProvider#cluster_ca_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterCaCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_context HelmProvider#config_context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigContext
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_context_auth_info HelmProvider#config_context_auth_info}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configContextAuthInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigContextAuthInfo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_context_cluster HelmProvider#config_context_cluster}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configContextCluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigContextCluster
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Path to the kube config file. Can be set with KUBE_CONFIG_PATH.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_path HelmProvider#config_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of paths to kube config files. Can be set with KUBE_CONFIG_PATHS environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#config_paths HelmProvider#config_paths}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ConfigPaths
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>exec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#exec HelmProvider#exec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exec", typeJson: "{\"fqn\":\"helm.provider.HelmProviderKubernetesExec\"}", isOptional: true)]
            public helm.Provider.IHelmProviderKubernetesExec? Exec
            {
                get => GetInstanceProperty<helm.Provider.IHelmProviderKubernetesExec?>();
            }

            /// <summary>The hostname (in form of URI) of Kubernetes master.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#host HelmProvider#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Host
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether server should be accessed without verifying the TLS certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#insecure HelmProvider#insecure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Insecure
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The password to use for HTTP basic authentication when accessing the Kubernetes master endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#password HelmProvider#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Token to authenticate an service account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#token HelmProvider#token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The username to use for HTTP basic authentication when accessing the Kubernetes master endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#username HelmProvider#username}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

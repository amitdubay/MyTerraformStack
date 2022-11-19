using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.Provider
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/helm helm}.</summary>
    [JsiiClass(nativeType: typeof(helm.Provider.HelmProvider), fullyQualifiedName: "helm.provider.HelmProvider", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"helm.provider.HelmProviderConfig\"}}]")]
    public class HelmProvider : HashiCorp.Cdktf.TerraformProvider
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/helm helm} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public HelmProvider(Constructs.Construct scope, string id, helm.Provider.IHelmProviderConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, helm.Provider.IHelmProviderConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HelmProvider(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HelmProvider(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDebug")]
        public virtual void ResetDebug()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExperiments")]
        public virtual void ResetExperiments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHelmDriver")]
        public virtual void ResetHelmDriver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKubernetes")]
        public virtual void ResetKubernetes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPluginsPath")]
        public virtual void ResetPluginsPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistryConfigPath")]
        public virtual void ResetRegistryConfigPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryCache")]
        public virtual void ResetRepositoryCache()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryConfigPath")]
        public virtual void ResetRepositoryConfigPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(helm.Provider.HelmProvider))!;

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "debugInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DebugInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "experimentsInput", typeJson: "{\"fqn\":\"helm.provider.HelmProviderExperiments\"}", isOptional: true)]
        public virtual helm.Provider.IHelmProviderExperiments? ExperimentsInput
        {
            get => GetInstanceProperty<helm.Provider.IHelmProviderExperiments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "helmDriverInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HelmDriverInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetesInput", typeJson: "{\"fqn\":\"helm.provider.HelmProviderKubernetes\"}", isOptional: true)]
        public virtual helm.Provider.IHelmProviderKubernetes? KubernetesInput
        {
            get => GetInstanceProperty<helm.Provider.IHelmProviderKubernetes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluginsPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PluginsPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryConfigPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegistryConfigPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryCacheInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryCacheInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryConfigPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryConfigPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public override string? Alias
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "debug", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? Debug
        {
            get => GetInstanceProperty<object?>();
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
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "experiments", typeJson: "{\"fqn\":\"helm.provider.HelmProviderExperiments\"}", isOptional: true)]
        public virtual helm.Provider.IHelmProviderExperiments? Experiments
        {
            get => GetInstanceProperty<helm.Provider.IHelmProviderExperiments?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "helmDriver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HelmDriver
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"helm.provider.HelmProviderKubernetes\"}", isOptional: true)]
        public virtual helm.Provider.IHelmProviderKubernetes? Kubernetes
        {
            get => GetInstanceProperty<helm.Provider.IHelmProviderKubernetes?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluginsPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PluginsPath
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryConfigPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegistryConfigPath
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryCache
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryConfigPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryConfigPath
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }
    }
}

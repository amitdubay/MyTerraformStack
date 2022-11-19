using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.Provider
{
    [JsiiInterface(nativeType: typeof(IHelmProviderExperiments), fullyQualifiedName: "helm.provider.HelmProviderExperiments")]
    public interface IHelmProviderExperiments
    {
        /// <summary>Enable full diff by storing the rendered manifest in the state.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#manifest HelmProvider#manifest}
        /// </remarks>
        [JsiiProperty(name: "manifest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Manifest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHelmProviderExperiments), fullyQualifiedName: "helm.provider.HelmProviderExperiments")]
        internal sealed class _Proxy : DeputyBase, helm.Provider.IHelmProviderExperiments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enable full diff by storing the rendered manifest in the state.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm#manifest HelmProvider#manifest}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "manifest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Manifest
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

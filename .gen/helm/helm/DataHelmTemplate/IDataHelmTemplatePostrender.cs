using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.DataHelmTemplate
{
    [JsiiInterface(nativeType: typeof(IDataHelmTemplatePostrender), fullyQualifiedName: "helm.dataHelmTemplate.DataHelmTemplatePostrender")]
    public interface IDataHelmTemplatePostrender
    {
        /// <summary>The command binary path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#binary_path DataHelmTemplate#binary_path}
        /// </remarks>
        [JsiiProperty(name: "binaryPath", typeJson: "{\"primitive\":\"string\"}")]
        string BinaryPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataHelmTemplatePostrender), fullyQualifiedName: "helm.dataHelmTemplate.DataHelmTemplatePostrender")]
        internal sealed class _Proxy : DeputyBase, helm.DataHelmTemplate.IDataHelmTemplatePostrender
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The command binary path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#binary_path DataHelmTemplate#binary_path}
            /// </remarks>
            [JsiiProperty(name: "binaryPath", typeJson: "{\"primitive\":\"string\"}")]
            public string BinaryPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

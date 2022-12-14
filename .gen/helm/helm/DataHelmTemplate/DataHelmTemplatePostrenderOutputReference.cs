using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.DataHelmTemplate
{
    [JsiiClass(nativeType: typeof(helm.DataHelmTemplate.DataHelmTemplatePostrenderOutputReference), fullyQualifiedName: "helm.dataHelmTemplate.DataHelmTemplatePostrenderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataHelmTemplatePostrenderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataHelmTemplatePostrenderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHelmTemplatePostrenderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHelmTemplatePostrenderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "binaryPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BinaryPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "binaryPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BinaryPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"helm.dataHelmTemplate.DataHelmTemplatePostrender\"}", isOptional: true)]
        public virtual helm.DataHelmTemplate.IDataHelmTemplatePostrender? InternalValue
        {
            get => GetInstanceProperty<helm.DataHelmTemplate.IDataHelmTemplatePostrender?>();
            set => SetInstanceProperty(value);
        }
    }
}

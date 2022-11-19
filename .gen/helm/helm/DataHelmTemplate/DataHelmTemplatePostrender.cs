using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.DataHelmTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "helm.dataHelmTemplate.DataHelmTemplatePostrender")]
    public class DataHelmTemplatePostrender : helm.DataHelmTemplate.IDataHelmTemplatePostrender
    {
        /// <summary>The command binary path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#binary_path DataHelmTemplate#binary_path}
        /// </remarks>
        [JsiiProperty(name: "binaryPath", typeJson: "{\"primitive\":\"string\"}")]
        public string BinaryPath
        {
            get;
            set;
        }
    }
}

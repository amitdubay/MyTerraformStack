using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace helm.DataHelmTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "helm.dataHelmTemplate.DataHelmTemplateSetString")]
    public class DataHelmTemplateSetString : helm.DataHelmTemplate.IDataHelmTemplateSetString
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#name DataHelmTemplate#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/helm/d/template#value DataHelmTemplate#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiapweb2022.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Email { get; set; }

        const string Domain = "fiap.com.br";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //base.Process(context, output);

            output.TagName = "a";
            var address = $"{Email}@{Domain}";

            output.Attributes.SetAttribute("href", $"mailto:{address}");
            output.Content.SetContent(address);


        }
    }
}

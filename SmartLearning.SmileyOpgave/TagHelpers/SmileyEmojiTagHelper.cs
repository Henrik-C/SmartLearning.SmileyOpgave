using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SmartLearning.SmileyOpgave.TagHelpers
{
    public class SmileyEmojiTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            int smileyId = 0;
            string filename = "";
            switch (smileyId)
            {
                case 1:
                    filename = "C:\\Users\\Henrik\\source\\repos\\SmartLearning.SmileyOpgave\\SmartLearning.SmileyOpgave\\wwwroot\\images\\Sm1bg.jpg";
                    break;

                case 2:
                    filename = "Sm2bg.jpg";
                    break;

                case 3:
                    filename = "Sm3bg.jpg";
                    break;
            }
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"wwwroot\images\", filename);

            output.TagName = "img";
            output.TagMode = TagMode.SelfClosing;
            output.Attributes.Add("src", filename);
        }
    }
}

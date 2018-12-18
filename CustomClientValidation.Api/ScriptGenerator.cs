
namespace CustomClientValidation.Api
{
    public class ScriptGenerator : IScriptGenerator
    {
        /// <summary>
        /// Generates scripts.
        /// </summary>
        /// <returns>
        /// The script content.
        /// </returns>
        public string GenerateScript()
        {
            var template = new ScriptTemplate();

            return template.TransformText();
        }
    }
}

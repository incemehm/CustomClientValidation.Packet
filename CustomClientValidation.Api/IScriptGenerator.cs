namespace CustomClientValidation.Api
{
    public interface IScriptGenerator
    {
        /// <summary>
		/// Generates the proxy script.
		/// </summary>
		/// <returns>The script content.</returns>
		string GenerateScript();
    }
}

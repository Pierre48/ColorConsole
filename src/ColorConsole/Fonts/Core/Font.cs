namespace ColorConsole.Fonts
{
    /// <summary>
    /// A font class allows to convert text to a custom string representation
    /// </summary>
    public abstract class Font
    {
        public virtual string Convert(string str, FontDefinition fontDefinition)
        {
            return str;
        }
    }
}
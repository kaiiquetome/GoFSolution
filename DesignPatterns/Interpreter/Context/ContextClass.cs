namespace Interpreter.Context
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class ContextClass
    {
        string input;
        int output;
        // Constructor
        public ContextClass(string input)
        {
            this.input = input;
        }
        public string Input
        {
            get { return input; }
            set { input = value; }
        }
        public int Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}

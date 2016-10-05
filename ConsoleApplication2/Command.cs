namespace ConsoleApplication2
{
    public struct Command
    {
        public readonly string Name;
        public readonly string Description;
        public readonly CommandHandler Handler;
        private CommandFlags _flags;

        public Command(string name, string description, CommandHandler handler, CommandFlags flags)
        {
            Name = name.ToLower();
            Description = description;
            Handler = handler;
            _flags = flags;
        }
    }
}
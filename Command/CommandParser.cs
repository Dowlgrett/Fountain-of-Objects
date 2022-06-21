public static class CommandParser
{
    public static bool TryParseCommand(string inputCommand, out ValidCommand cmd, out Argument arg)
    {
        cmd = (ValidCommand)0;
        arg = (Argument)0;
  
        inputCommand = inputCommand.Trim();
        bool twoArguments = inputCommand.Split(' ').Length == 2;

        if (!twoArguments) return false;

        string command = inputCommand.Split(' ')[0];
        string argument = inputCommand.Split(' ')[1];

        bool isValidCommand = Enum.TryParse<ValidCommand>(command, true, out cmd);
        bool isValidArgument = Enum.TryParse<Argument>(argument, true, out arg);

        if (isValidCommand && isValidArgument) return true;

        else return false;
    }
}


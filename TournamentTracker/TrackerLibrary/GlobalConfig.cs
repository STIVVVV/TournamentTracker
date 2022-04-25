namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitalizaConections(bool database, bool textFiles)
        {
            if (database)
            {
                //ToDo - Create the SQL Connection
            }

            if (textFiles)
            {
                //ToDo - Create the Text Connection
            }
        }
    }
}

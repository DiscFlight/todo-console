namespace Todo.Models
{
    public class IdMissingException : Exception
    {
        public IdMissingException()
            :base("No id provided. Correct format is todo {command} {argument}")
        {}
    }

    public class NameMissingException : Exception
    {
        public NameMissingException()
            :base("No name provided. Correct format is todo {command} {argument}")
        {}
    }

    public class NotFoundException : Exception
    {
        public NotFoundException()
            :base("No todo with that id exists.")
        {}
    }
    
    public class DataSourceException : Exception
    {
        public DataSourceException()
            :base("Error connecting to configured data source.")
        {}
    }
}
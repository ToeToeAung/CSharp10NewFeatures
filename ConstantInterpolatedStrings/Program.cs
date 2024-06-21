public static class EmailMessagesBeforeCIS
{   //CIS - Constant Interpolated strings
    private const string Salutation = "Welcome";
    public static class Header
    {
        public const string SalutionTeamplate = Salutation + " to constant Interpolation";
    }
}
public static class EmailMessagesCIS 
{
    private const string Salutation = "Welcome";
    public static class Header
    {
        public const string SalutionTeamplate = $"{Salutation} to Interpolation";
    }
}


namespace person_form.Helpers
{
    public static class Formatter
    {
        public static string FormatIdentityNumber(string identityNumber)
        {
            var identityNumberWithoutSeparator = identityNumber.Replace("-", "");

            return identityNumberWithoutSeparator.Length == 12 
                ? identityNumberWithoutSeparator.Substring(2) 
                : identityNumberWithoutSeparator;
        }
    }
}
    
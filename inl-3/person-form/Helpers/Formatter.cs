namespace person_form.Helpers
{
    public static class Formatter
    {
        public static string FormatIdentityNumber(string identityNumber)
        {
            var identityNumberWithoutSeparator = identityNumber.Replace("-", "");

            if (identityNumberWithoutSeparator.Length == 12)
                return identityNumberWithoutSeparator.Substring(2);

            return identityNumberWithoutSeparator;
        }
    }
}
    
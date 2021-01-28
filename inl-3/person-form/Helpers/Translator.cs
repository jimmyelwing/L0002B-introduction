using person_form.Domain;

namespace person_form.Helpers
{
    public static class Translator
    {
        public static string TranslateGender(Gender personGender)
        {
            return personGender == Gender.Male
                ? "Man"
                : "Kvinna";
        }
    }
}

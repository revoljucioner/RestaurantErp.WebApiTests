namespace TestApplicationCore.Providers
{
    public class AlliasToIdConverter
    {
        private readonly Dictionary<string, string> _idByAllias = new Dictionary<string, string>();

        public string GetIdByAllias(string allias)
        {
            if (allias is "")
                return "";
            bool isAlliasAlreadyPresent = _idByAllias.TryGetValue(allias, out string? id);
            if (!isAlliasAlreadyPresent)
            {
                id = allias + Guid.NewGuid().ToString();
                _idByAllias[allias] = id;
            }
            return id;
        }
    }
}

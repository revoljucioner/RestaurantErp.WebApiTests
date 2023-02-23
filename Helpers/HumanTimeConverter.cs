using System.Text.RegularExpressions;

namespace BackendTestApplicationCore.Core
{
    public class HumanTimeConverter
    {
        private readonly Dictionary<string, Func<string, DateTime>> _convertingFunctionByDatePattern = new Dictionary<string, Func<string, DateTime>>()
        {
            ["Now"] = (string _) => DateTime.UtcNow,
            [@"Now - \d+ seconds?"] = (string input) => DateTime.UtcNow.AddSeconds((-1)*int.Parse(new Regex(@"\d+").Match(input).Value)),
            [@"Now - \d+ minutes?"] = (string input) => DateTime.UtcNow.AddMinutes((-1)*int.Parse(new Regex(@"\d+").Match(input).Value)),
            [@"Now \+ \d+ seconds?"] = (string input) => DateTime.UtcNow.AddSeconds(int.Parse(new Regex(@"\d+").Match(input).Value)),
            [@"Now \+ \d+ minutes?"] = (string input) => DateTime.UtcNow.AddMinutes(int.Parse(new Regex(@"\d+").Match(input).Value)),
        };

        public DateTime Convert(string input)
        {
            var functionToConvertDate = _convertingFunctionByDatePattern.Last(i => new Regex(i.Key).IsMatch(input)).Value;
            DateTime result = functionToConvertDate(input);

            return result;
        }
    }
}

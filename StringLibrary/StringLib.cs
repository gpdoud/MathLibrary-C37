namespace StringLibrary {

    public class StringLib {

        public static string Reverse(string a) {
            var result = string.Empty;
            for (var idx = a.Length - 1; idx >= 0; idx--) {
                result += a[idx];
            }
            return result;

        }

        public static string Rotate(string a) {
            List<char> result = new List<char>();
            result.Add(a[a.Length - 1]);
            for (int idx = 0; idx < a.Length-1; idx++) {
                result.Add(a[idx]);
            }
            return new string(result.ToArray());
        }

        public static string RemoveVowels(string a) {
            var result = string.Empty;
            foreach(var ch in a.ToCharArray()) {
                switch(ch.ToString().ToLower()) {
                    case "a": break;
                    case "e": break;
                    case "i": break;
                    case "o": break;
                    case "u": break;
                    default:
                        result += ch.ToString();
                        break;
                }
            }
            return result;
        }
    }
}

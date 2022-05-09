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

        }

        public static string RemoveVowels(string a) {

        }
    }
}
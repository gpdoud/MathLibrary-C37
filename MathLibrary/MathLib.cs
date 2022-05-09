namespace MathLibrary {
    
    public class MathLib {

        public static string About { get; set; } = "Math Library";

        public static double Inverse(double a) {
            if(a == 0) {
                throw new DivideByZeroException("a cannot be zero");
            }
            return 1 / a;
        }

        public static int Modulo(int a, int b) {
            return a - (a / b * b);
        }

        public static long Cubed(int a) {
            return a * a * a;
        }
    }
}
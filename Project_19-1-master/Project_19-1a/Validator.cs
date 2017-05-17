using System.Windows.Forms;

namespace Project_19_1a {
    public static class Validator {
        public static bool IsPresent(string x) {
            if (x != "" & x != null)
                return true;
            Error("no data entered", "Input Error");
            return false;
        }
        public static bool IsInteger(string x, bool error) {
            if (error) {
                try {
                    int.Parse(x);
                    return true;
                }
                catch {
                    Error("please enter a valid integer", "Type Error");
                    return false;
                }
            }
            else
                try {
                    int.Parse(x);
                    return true;
                }
                catch { return false; }
        }
        public static void Error(string name, string title) { MessageBox.Show("Error found: " + name + ".", title); }

    }
}

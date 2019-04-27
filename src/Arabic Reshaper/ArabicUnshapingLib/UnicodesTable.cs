using System.Collections.Generic;

namespace ArabicUnshaper
{
    public class UnicodesTable
    {
        private static UnicodesTable singeltonInstance;
        private UnicodesTable()
        {
            initializeTable();
        }

        public static Dictionary<string, string[]> GetArabicGliphes()
        {
            if (singeltonInstance == null)
            {
                singeltonInstance = new UnicodesTable();
            }

            return singeltonInstance.arabicGlphies;
        }
        private  Dictionary<string, string[]> arabicGlphies = new Dictionary<string, string[]>();
        private void initializeTable()
        {
            arabicGlphies.Add("\\u0622", new string[] { "\\uFE81", "\\uFE81", "\\uFE82", "\\uFE82", "2" });
            arabicGlphies.Add("\\u0623", new string[] { "\\uFE83", "\\uFE83", "\\uFE84", "\\uFE84", "2" });
            arabicGlphies.Add("\\u0624", new string[] { "\\uFE85", "\\uFE85", "\\uFE86", "\\uFE86", "2" });
            arabicGlphies.Add("\\u0625", new string[] { "\\uFE87", "\\uFE87", "\\uFE88", "\\uFE88", "2" });
            arabicGlphies.Add("\\u0626", new string[] { "\\uFE89", "\\uFE8B", "\\uFE8C", "\\uFE8A", "4" });
            arabicGlphies.Add("\\u0627", new string[] { "\\u0627", "\\u0627", "\\uFE8E", "\\uFE8E", "2" });
            arabicGlphies.Add("\\u0628", new string[] { "\\uFE8F", "\\uFE91", "\\uFE92", "\\uFE90", "4" });
            arabicGlphies.Add("\\u0629", new string[] { "\\uFE93", "\\uFE93", "\\uFE94", "\\uFE94", "2" });
            arabicGlphies.Add("\\u062A", new string[] { "\\uFE95", "\\uFE97", "\\uFE98", "\\uFE96", "4" });
            arabicGlphies.Add("\\u062B", new string[] { "\\uFE99", "\\uFE9B", "\\uFE9C", "\\uFE9A", "4" });
            arabicGlphies.Add("\\u062C", new string[] { "\\uFE9D", "\\uFE9F", "\\uFEA0", "\\uFE9E", "4" });
            arabicGlphies.Add("\\u062D", new string[] { "\\uFEA1", "\\uFEA3", "\\uFEA4", "\\uFEA2", "4" });
            arabicGlphies.Add("\\u062E", new string[] { "\\uFEA5", "\\uFEA7", "\\uFEA8", "\\uFEA6", "4" });
            arabicGlphies.Add("\\u062F", new string[] { "\\uFEA9", "\\uFEA9", "\\uFEAA", "\\uFEAA", "2" });
            arabicGlphies.Add("\\u0630", new string[] { "\\uFEAB", "\\uFEAB", "\\uFEAC", "\\uFEAC", "2" });
            arabicGlphies.Add("\\u0631", new string[] { "\\uFEAD", "\\uFEAD", "\\uFEAE", "\\uFEAE", "2" });
            arabicGlphies.Add("\\u0632", new string[] { "\\uFEAF", "\\uFEAF", "\\uFEB0", "\\uFEB0", "2" });
            arabicGlphies.Add("\\u0633", new string[] { "\\uFEB1", "\\uFEB3", "\\uFEB4", "\\uFEB2", "4" });
            arabicGlphies.Add("\\u0634", new string[] { "\\uFEB5", "\\uFEB7", "\\uFEB8", "\\uFEB6", "4" });
            arabicGlphies.Add("\\u0635", new string[] { "\\uFEB9", "\\uFEBB", "\\uFEBC", "\\uFEBA", "4" });
            arabicGlphies.Add("\\u0636", new string[] { "\\uFEBD", "\\uFEBF", "\\uFEC0", "\\uFEBE", "4" });
            arabicGlphies.Add("\\u0637", new string[] { "\\uFEC1", "\\uFEC3", "\\uFEC4", "\\uFEC2", "4" });
            arabicGlphies.Add("\\u0638", new string[] { "\\uFEC5", "\\uFEC7", "\\uFEC8", "\\uFEC6", "4" });
            arabicGlphies.Add("\\u0639", new string[] { "\\uFEC9", "\\uFECB", "\\uFECC", "\\uFECA", "4" });
            arabicGlphies.Add("\\u063A", new string[] { "\\uFECD", "\\uFECF", "\\uFED0", "\\uFECE", "4" });
            arabicGlphies.Add("\\u0641", new string[] { "\\uFED1", "\\uFED3", "\\uFED4", "\\uFED2", "4" });
            arabicGlphies.Add("\\u0642", new string[] { "\\uFED5", "\\uFED7", "\\uFED8", "\\uFED6", "4" });
            arabicGlphies.Add("\\u0643", new string[] { "\\uFED9", "\\uFEDB", "\\uFEDC", "\\uFEDA", "4" });
            arabicGlphies.Add("\\u0644", new string[] { "\\uFEDD", "\\uFEDF", "\\uFEE0", "\\uFEDE", "4" });
            arabicGlphies.Add("\\u0645", new string[] { "\\uFEE1", "\\uFEE3", "\\uFEE4", "\\uFEE2", "4" });
            arabicGlphies.Add("\\u0646", new string[] { "\\uFEE5", "\\uFEE7", "\\uFEE8", "\\uFEE6", "4" });
            arabicGlphies.Add("\\u0647", new string[] { "\\uFEE9", "\\uFEEB", "\\uFEEC", "\\uFEEA", "4" });
            arabicGlphies.Add("\\u0648", new string[] { "\\uFEED", "\\uFEED", "\\uFEEE", "\\uFEEE", "2" });
            arabicGlphies.Add("\\u0649", new string[] { "\\uFEEF", "\\uFEEF", "\\uFEF0", "\\uFEF0", "2" });
            arabicGlphies.Add("\\u0671", new string[] { "\\u0671", "\\u0671", "\\uFB51", "\\uFB51", "2" });
            arabicGlphies.Add("\\u064A", new string[] { "\\uFEF1", "\\uFEF3", "\\uFEF4", "\\uFEF2", "4" });
            arabicGlphies.Add("\\u066E", new string[] { "\\uFBE4", "\\uFBE8", "\\uFBE9", "\\uFBE5", "4" });
            arabicGlphies.Add("\\u06AA", new string[] { "\\uFB8E", "\\uFB90", "\\uFB91", "\\uFB8F", "4" });
            arabicGlphies.Add("\\u06C1", new string[] { "\\uFBA6", "\\uFBA8", "\\uFBA9", "\\uFBA7", "4" });
            arabicGlphies.Add("\\u06E4", new string[] { "\\u06E4", "\\u06E4", "\\u06E4", "\\uFEEE", "2" });
        }

    }
}

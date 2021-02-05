using System;

namespace CSharpTutorial
{
    class Program
    {

        static void Main(string[] args)
        {
            DBMigrator dBMigrator = new DBMigrator(new FileLogger("C:\\Temp\\info.txt"));
            dBMigrator.Migrate();
        }

        public static void Swap(int[] array, int a, int b)
        {
            int index2 = array[b];
            array[b] = array[a];
            array[a] = index2;
        }

        public enum times
        {
            second = 60,
            mintue = 3600
        }
    }
}

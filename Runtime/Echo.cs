using UnityEngine;

namespace First.Runtime
{
    public static class Echo
    {
        public static string Now(string s)
        {
            var output = "First:" + s;
            return output;
        }
    }
}

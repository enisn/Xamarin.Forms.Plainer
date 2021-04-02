using Android.Content;
using Android.OS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Plainer.Platforms.Droid
{
    public static class Plainer
    {
        internal static Context CurrentActivity { get; private set; }
        public static void Init(Context activity, Bundle bundle)
        {
            CurrentActivity = activity;
        }
    }
}

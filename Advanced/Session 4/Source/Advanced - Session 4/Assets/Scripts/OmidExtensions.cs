using UnityEngine;
using Prime31.ZestKit;

namespace Omid3098
{
    public static class OmidExtensions
    {
        public static Transform Shake(this Transform transform)
        {
            Debug.Log("Salam");
            transform.localPosition += new Vector3(1, 1, 1);
            return transform;
        }

        public static int Add(this int myint, int secondval)
        {
            return myint + secondval;
        }
    }

}
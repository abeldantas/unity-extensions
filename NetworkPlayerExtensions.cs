#if !UNITY_WEBGL

using UnityEngine;

namespace Extensions
{
    /// <summary>
    /// Extension methods for UnityEngine.NetworkPlayer.
    /// </summary>
    public static class NetworkPlayerExtensions
    {
        /// <summary>
        /// Gets the numeric index of the network player.
        /// </summary>
        /// <param name="networkPlayer">Network player.</param>
        /// <returns>Network player index.</returns>
        public static int GetIndex(this NetworkPlayer networkPlayer)
        {
            return int.Parse(networkPlayer.ToString());
        }
    }
}

#endif

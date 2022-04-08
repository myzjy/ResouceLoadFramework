using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResourcesLoadFramework.DebugLog
{
    /// <summary>
    /// resouceLoad Debug
    /// </summary>
    public class ResourcesLoadDebug : UnityEngine.Debug
    {
        /// <summary>
        /// log单例 
        /// </summary>
        private static ResourcesLoadDebug debugInstance = null;

        /// <summary>
        /// 外部调用log 打印
        /// </summary>
        /// <returns></returns>
        public static ResourcesLoadDebug DebugInstance()
        {
            if (debugInstance == null)
            {
                debugInstance = new ResourcesLoadDebug();
            }

            //返回单例
            return debugInstance;
        }

        /// <summary>
        /// 输入到
        /// </summary>
        /// <param name="context"></param>
        public static void Log(string context)
        {
#if DEBUGLOG
            Console.WriteLine(context);
#else
            UnityEngine.Debug.Log(context);
#endif
        }

    }
}
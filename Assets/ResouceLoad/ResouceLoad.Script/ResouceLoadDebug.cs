using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResouceLoadFramework.DebugLog
{
    /// <summary>
    /// resouceLoad Debug
    /// </summary>
    public class ResouceLoadDebug : UnityEngine.Debug
    {
        /// <summary>
        /// log单例 
        /// </summary>
        private static ResouceLoadDebug debugInstance = null;

        /// <summary>
        /// 外部调用log 打印
        /// </summary>
        /// <returns></returns>
        public static ResouceLoadDebug DebugInstance()
        {
            if (debugInstance == null)
            {
                debugInstance = new ResouceLoadDebug();
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
            Console.WriteLine();
        }
    }
}
using System;
using System.Reflection;
using ResouceLoadFramework;
using UnityEditor;
using UnityEngine;

namespace Game.Editor
{
    public class ReouscePathFolderCreation
    {
        /// <summary>
        /// 路径的创建
        /// </summary>
        [MenuItem("Tools/Path/Creation")]
        public static void PathFolderCreation()
        {
            var enumds = typeof(ResouceLoadEnum).GetFields(BindingFlags.Public | BindingFlags.Static);
            int enums = typeof(ResouceLoadEnum).GetFields(BindingFlags.Public | BindingFlags.Static).Length;
            foreach (var _field in enumds)
            {
                var item =(ResouceLoadEnum)_field.GetRawConstantValue();
                
                
            }
        }
    }
}
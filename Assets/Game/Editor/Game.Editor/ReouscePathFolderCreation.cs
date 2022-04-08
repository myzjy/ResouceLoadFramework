using System;
using System.Reflection;
using ResourcesLoadFramework;
using UnityEditor;
using UnityEngine;

namespace Game.Editor
{
    public static class ReourcesPathFolderCreation
    {
        private static string baseResouceLoad =$"{Application.dataPath}/Resources";
        
        /// <summary>
        /// 路径的创建
        /// </summary>
        [MenuItem("Tools/Path/Creation")]
        public static void PathFolderCreation()
        {
            Debug.Log($"基础路径{baseResouceLoad}");
            var enumds = typeof(ResourcesLoadEnum).GetFields(BindingFlags.Public | BindingFlags.Static);
            int enums = typeof(ResourcesLoadEnum).GetFields(BindingFlags.Public | BindingFlags.Static).Length;
            foreach (var _field in enumds)
            {
                var item =(ResourcesLoadEnum)_field.GetRawConstantValue();
                
                
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Game.Editor.Game.Symbols
{
    public class Symbols : UnityEditor.EditorWindow
    {
        /// <summary>
        /// 在unity窗口工具栏启动位置
        /// </summary>
        private const string ITEMTOOLS = "Tool/Editor_Windows/Symbols";

        /// <summary>
        /// 在editorWindows窗口显示的名称
        /// </summary>
        private const string SymbolString_WINDOWS = "Symbol";

        /// <summary>
        /// 自定义标识
        /// </summary>
        public class SymbolData
        {
            /// <summary>
            /// 标识名字
            /// </summary>
            public string name { get; private set; }

            /// <summary>
            /// 标识介绍
            /// </summary>
            public string des { get; private set; }

            /// <summary>
            /// 标识是否启用
            /// </summary>
            public bool IsEnable { get; set; }

            public SymbolData(string name, string des)
            {
                this.name = name.ToUpper();
                this.des = des;
            }
        }

        //追求简单，这里不能就这样，后续要通过配置表去做
        public List<SymbolData> symbolDataList = new List<SymbolData>()
        {
            new SymbolData("DebugLog", "打开自定义log"),
            new SymbolData("Android", "安卓环境")
        };

        private Symbols symbols;

        public void Windwos()
        {
            symbols = ScriptableObject.CreateInstance<Symbols>();
            symbols.name = SymbolString_WINDOWS;
            symbols.Init();
        }

        /// <summary>
        /// 初始化 init windows
        /// </summary>
        private void Init()
        {
            var defineSymbols = PlayerSettings
                .GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup).Split(';');

            foreach (var itemString in symbolDataList)
            {
                itemString.IsEnable = defineSymbols.Any(c => c == itemString.name);
            }
        }

        /// <summary>
        /// 位置
        /// </summary>
        private Vector2 verticalVec;
        private void OnGUI()
        {
            //排序
            EditorGUILayout.BeginVertical();
            verticalVec = EditorGUILayout.BeginScrollView(
                scrollPosition: verticalVec,options:
                GUILayout.Height(position.height));
            foreach (var item in symbolDataList)
            {
                //标准是box包裹
                EditorGUILayout.BeginHorizontal(GUI.skin.box);
                item.IsEnable = EditorGUILayout.Toggle(item.IsEnable, GUILayout.Width(16));
                EditorGUILayout.LabelField(item.name, GUILayout.ExpandWidth(true), GUILayout.MinWidth(0));
                EditorGUILayout.LabelField(item.des, GUILayout.ExpandWidth(true), GUILayout.MinWidth(0));
                EditorGUILayout.EndHorizontal();
            }

            if (GUILayout.Button("save"))
            {
                var str = symbolDataList.Where(a => a.IsEnable).Select(it => it.name).ToArray();
                PlayerSettings.SetScriptingDefineSymbolsForGroup();
            }
            EditorGUILayout.EndScrollView();
            EditorGUILayout.EndVertical();
        }
    }
}
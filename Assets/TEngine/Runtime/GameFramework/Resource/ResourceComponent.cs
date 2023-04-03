﻿using UnityEngine;

namespace TEngine
{
    [DisallowMultipleComponent]
    public class ResourceComponent: GameFrameworkComponent
    {
        private IResourceManager m_ResourceManager;
        
        /// <summary>
        /// 获取当前资源适用的游戏版本号。
        /// </summary>
        public string ApplicableGameVersion => m_ResourceManager.ApplicableGameVersion;

        /// <summary>
        /// 获取当前内部资源版本号。
        /// </summary>
        public int InternalResourceVersion => m_ResourceManager.InternalResourceVersion;

        /// <summary>
        /// 强制执行释放未被使用的资源。
        /// </summary>
        /// <param name="performGCCollect">是否使用垃圾回收。</param>
        public void ForceUnloadUnusedAssets(bool performGCCollect)
        {
            
        }
    }
}
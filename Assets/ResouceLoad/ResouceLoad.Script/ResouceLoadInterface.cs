namespace ResouceLoadFramework
{
    /// <summary>
    /// ResouceLoad 读取接口
    /// </summary>
    public interface ResouceLoadInterface
    {
        /// <summary>
        /// 设置基础Resouce路径
        /// </summary>
        /// <param name="basePath"></param>
        void SetBaseNamePath(string basePath);

        /// <summary>
        /// 根据Enum分别创建出读取路径
        /// </summary>
        /// <param name="_loadEnum"></param>
        void SetResouceEnumPath(ResouceLoadEnum _loadEnum);
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Create
{
    /// <summary>
    /// 单例 独一无二 确保只有一个实例
    /// 常用场景：应用中有对象需要是全局的且唯一
    /// </summary>
    public class Singleton
    {
        private static Singleton singleton = new Singleton();

        /// <summary>
        /// 禁止外部实例化
        /// </summary>
        private Singleton()
        {
        }

        /// <summary>
        /// 提供获取实例
        /// </summary>
        /// <returns></returns>
        public static Singleton Instance()
        {
            return singleton;
        }
    }

    /// <summary>
    /// 延迟加载 线程安全
    /// </summary>
    public class Singleton1
    {
        private static Singleton1 singleto = null;
        private static readonly object lockObject = new object();
        private Singleton1() { }

        public static Singleton1 Instance()
        {
            if (singleto==null)
            {
                lock (lockObject)
                {
                    if (singleto == null)
                        singleto = new Singleton1();
                }
            }
            return singleto;
        }
    }
}

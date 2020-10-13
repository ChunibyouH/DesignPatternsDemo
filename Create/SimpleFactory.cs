using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Create
{
    public enum SimpleFactoryType
    {
        Face,
        Finger
    }

    public interface SimpleFactoryAuthentication
    {
        void Authentication();
    }

    public class FaceAuthentication : SimpleFactoryAuthentication
    {
        public void Authentication()
        {
            Console.WriteLine("人脸人证成功");
        }
    }

    public class FingerAuthentication : SimpleFactoryAuthentication
    {
        public void Authentication()
        {
            Console.WriteLine("指纹人证成功");
        }
    }


    /// <summary>
    /// 简单工厂 静态工厂
    /// 接收不同参数返回不同对象的实例，被创建的实例通常都具有共同的父类。在简单工厂模式中用于创建实例的方法一般为静态（static）方法。
    /// 设计原则：遵循单一职责、违背开闭原则
    /// 常用场景：需要在一堆产品中选择其中一个产品
    /// 选择关键点：一种产品是否可根据某个参数决定它的种类
    /// 缺点：职责过重，不修改无法扩展
    /// </summary>
    public class SimpleFactory
    {
        public static SimpleFactoryAuthentication GetAuthentication(SimpleFactoryType type)
        {
            switch (type)
            {
                case SimpleFactoryType.Face:
                    return new FaceAuthentication();
                case SimpleFactoryType.Finger:
                    return new FingerAuthentication();
                default:
                    return null;
            }
        }
    }


}

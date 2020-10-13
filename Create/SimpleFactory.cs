using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Create.SimpleFactoryType
{
    //工厂角色：该模式的核心，负责实现创建所有产品实例的内部逻辑，提供一个静态的工厂方法GetProduct()，返回抽象产品类型Product的实例。
    //抽象产品角色：所有产品类的父类，封装了各种产品对象的共有方法，它的引入将提高系统的灵活性，使得在工厂类中只需要定义一个通用的工厂方法，因为所有创建的具体产品对象都是其子类对象。
    //具体产品角色：简单工厂模式的创建目标，所有被创建的对象都充当这个角色的某个具体类的实例。

    public enum SimpleFactoryType
    {
        Face,
        Finger
    }

    /// <summary>
    /// 抽象产品角色
    /// </summary>
    public interface SimpleFactoryAuthentication
    {
        void Authentication();
    }

    #region 具体产品角色
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
    #endregion


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
        /// <summary>
        /// 工厂角色
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
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

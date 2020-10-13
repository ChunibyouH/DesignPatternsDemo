using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Create
{
    public enum SimpleFactoryType
    {
        A,
        B
    }

    /// <summary>
    /// 简单工厂 静态工厂则
    /// 接收不同参数返回不同对象的实例，被创建的实例通常都具有共同的父类。在简单工厂模式中用于创建实例的方法一般为静态（static）方法。不修改无法扩展
    /// 设计原则：遵循单一职责、违背开闭原则
    /// 常用场景：需要在一堆产品中选择其中一个产品
    /// 选择关键点：一种产品是否可根据某个参数决定它的种类
    /// </summary>
    public class SimpleFactory
    {

    }


}

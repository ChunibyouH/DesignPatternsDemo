using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Create.FactoryMethod
{
    //Product（抽象产品）：定义产品的接口，是工厂方法模式所创建的对象的超类，也就是产品对象的公共父类。
    //ConcreteProduct（具体产品）：它实现了抽象产品接口，某种类型的具体产品由专门的具体工厂创建，具体工厂和具体产品之间一一对应。
    //Factory（抽象工厂）：抽象工厂类，声明了工厂方法，用于返回一个产品。
    //ConcreteFactory（具体工厂）：抽象工厂的子类，实现了抽象工厂中定义的工厂方法，并可由客户端调用，返回一个具体产品类的实例。

    /// <summary>
    /// 工厂方法 
    /// 定义一个创建产品对象的工厂接口，产品的创建放到子类中去，工厂不再负责产品的创建。
    /// 设计原则：遵循单一职责、依赖倒置、开闭原则
    /// 选择关键点：工厂类和产品类是否是同生同灭的关系
    /// 缺点：增加产品时，需编写具体产品类且还需提供对应的工厂，造成类文件过多增加系统复杂度
    /// </summary>
    public class FactoryMethod
    {
        public void Run()
        {
            IAuthenticationFactory factory = new FaceAuthenticationFactory();
            IAuthentication authentication = factory.Create();
            authentication.Authentication();
        }
    }

    /// <summary>
    /// 抽象产品
    /// </summary>
    public interface IAuthentication
    {
        void Authentication();
    }

    #region 具体产品

    public class FaceAuthentication : IAuthentication
    {
        public void Authentication()
        {
            Console.WriteLine("人脸人证成功");
        }
    }
    public class FingerAuthentication : IAuthentication
    {
        public void Authentication()
        {
            Console.WriteLine("指纹人证成功");
        }
    }
    #endregion

    /// <summary>
    /// 抽象工厂
    /// </summary>
    public interface IAuthenticationFactory
    {
        IAuthentication Create();
    }

    #region 具体工厂

    public class FaceAuthenticationFactory : IAuthenticationFactory
    {
        public IAuthentication Create()
        {
            return new FaceAuthentication();
        }
    }

    public class FingerAuthenticationFactory : IAuthenticationFactory
    {
        public IAuthentication Create()
        {
            return new FingerAuthentication();
        }
    }

    #endregion
}

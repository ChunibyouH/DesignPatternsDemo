using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace DesignPatterns.Create
{
    //Abstract Factory(抽象工厂)：声明了一组用于创建一族产品的方法，每一个方法对应一种产品。
    //Concrete Factory(具体工厂)：实现了在抽象工厂中声明的创建产品的方法，生成一组具体产品，这些产品构成了一个产品族。
    //Abstract Product(抽象产品)：为每种产品声明接口，在抽象产品中声明了所有的业务方法。
    //Concrete Product(具体产品)：定义具体工厂生产的具体产品对象，实现在抽象产品接口中声明的业务方法。
    /// <summary>
    /// 抽象工厂
    /// 设计原则：遵循单一职责、依赖倒置、开闭原则
    /// 为创建一组相关或相互依赖的对象提供一个接口，而且无需指定他们的具体类。
    /// </summary>
    public class AbstractFactory
    {
        public void Run()
        {
            IWearFactory wear = new BlackWearFactory();

            IClothes clothes = wear.CreateClothes();
            ITrousers trousers = wear.CreateTrousers();
            IShoes shoes = wear.CreateShoes();

            clothes.Wear();
            trousers.Wear();
            shoes.Wear();
        }
    }

    #region 抽象产品

    public interface IClothes
    {
        void Wear();
    }
    public interface ITrousers
    {
        void Wear();
    }
    public interface IShoes
    {
        void Wear();
    }

    #endregion

    #region 具体产品

    #region 一身黑
    public class BlackClothes : IClothes
    {
        public void Wear()
        {
            Console.WriteLine("穿黑色衣服");
        }
    }
    public class BlackTrousers : ITrousers
    {
        public void Wear()
        {
            Console.WriteLine("穿黑色裤子");
        }
    }
    public class BlackShoes : IShoes
    {
        public void Wear()
        {
            Console.WriteLine("穿黑色鞋子");
        }
    }
    #endregion

    #region 一身白
    public class WhiteClothes : IClothes
    {
        public void Wear()
        {
            Console.WriteLine("穿黑色衣服");
        }
    }
    public class WhiteTrousers : ITrousers
    {
        public void Wear()
        {
            Console.WriteLine("穿黑色裤子");
        }
    }
    public class WhiteShoes : IShoes
    {
        public void Wear()
        {
            Console.WriteLine("穿黑色鞋子");
        }
    }
    #endregion

    #endregion

    /// <summary>
    /// 抽象工厂 抽象产品族
    /// </summary>
    public interface IWearFactory
    {
        IClothes CreateClothes();
        ITrousers CreateTrousers();
        IShoes CreateShoes();
    }

    /// <summary>
    /// 具体工厂 具体产品族 创建一身黑穿搭
    /// </summary>
    public class BlackWearFactory : IWearFactory
    {
        public IClothes CreateClothes()
        {
            return new BlackClothes();
        }
        public ITrousers CreateTrousers()
        {
            return new BlackTrousers();
        }
        public IShoes CreateShoes()
        {
            return new BlackShoes();
        }

    }

}

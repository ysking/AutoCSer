﻿using System;

namespace AutoCSer.Example.TcpInterfaceOpenServer
{
    /// <summary>
    /// 接口继承与显示接口实现测试
    /// </summary>
    [AutoCSer.Net.TcpOpenServer.Server(Host = "127.0.0.1", Port = 12704)]
    public interface IInherit : IInheritA, IInheritB
    {
        /// <summary>
        /// 加法测试
        /// </summary>
        /// <param name="left">加法左值</param>
        /// <param name="right">加法右值</param>
        /// <returns>和</returns>
        AutoCSer.Net.TcpServer.ReturnValue<int> AddOnly(int left, int right);
    }
    /// <summary>
    /// 显示接口实现测试
    /// </summary>
    public interface IInheritA
    {
        /// <summary>
        /// 显示接口实现测试
        /// </summary>
        /// <param name="left">加法左值</param>
        /// <param name="right">加法右值</param>
        /// <returns>和</returns>
        AutoCSer.Net.TcpServer.ReturnValue<int> Add(int left, int right);
    }
    /// <summary>
    /// 显示接口实现测试
    /// </summary>
    public interface IInheritB
    {
        /// <summary>
        /// 显示接口实现测试
        /// </summary>
        /// <param name="left">加法左值</param>
        /// <param name="right">加法右值</param>
        /// <returns>和</returns>
        AutoCSer.Net.TcpServer.ReturnValue<int> Add(int left, int right);
    }
    /// <summary>
    /// 接口继承与显示接口实现测试 示例
    /// </summary>
    class Inherit : IInherit
    {
        /// <summary>
        /// 加法测试
        /// </summary>
        /// <param name="left">加法左值</param>
        /// <param name="right">加法右值</param>
        /// <returns>和</returns>
        public AutoCSer.Net.TcpServer.ReturnValue<int> AddOnly(int left, int right)
        {
            return left + right;
        }
        /// <summary>
        /// 显示接口实现测试
        /// </summary>
        /// <param name="left">加法左值</param>
        /// <param name="right">加法右值</param>
        /// <returns>和</returns>
        AutoCSer.Net.TcpServer.ReturnValue<int> IInheritA.Add(int left, int right)
        {
            return left + right + 1;
        }
        /// <summary>
        /// 显示接口实现测试
        /// </summary>
        /// <param name="left">加法左值</param>
        /// <param name="right">加法右值</param>
        /// <returns>和</returns>
        AutoCSer.Net.TcpServer.ReturnValue<int> IInheritB.Add(int left, int right)
        {
            return left + right + 2;
        }

        /// <summary>
        /// 接口继承与显示接口实现测试
        /// </summary>
        /// <returns></returns>
        [AutoCSer.Metadata.TestMethod]
        internal static bool TestCase()
        {
            using (AutoCSer.Net.TcpOpenServer.Server server = AutoCSer.Net.TcpOpenServer.Emit.Server<IInherit>.Create(new Inherit()))
            {
                if (server.IsListen)
                {
                    IInherit client = AutoCSer.Net.TcpOpenServer.Emit.Client<IInherit>.Create();
                    using (client as IDisposable)
                    {
                        AutoCSer.Net.TcpServer.ReturnValue<int> sum = ((IInheritA)client).Add(2, 3);
                        if (sum.Type != AutoCSer.Net.TcpServer.ReturnType.Success || sum.Value != 2 + 3 + 1)
                        {
                            return false;
                        }

                        sum = ((IInheritB)client).Add(2, 3);
                        if (sum.Type != AutoCSer.Net.TcpServer.ReturnType.Success || sum.Value != 2 + 3 + 2)
                        {
                            return false;
                        }

                        sum = client.AddOnly(2, 3);
                        if (sum.Type != AutoCSer.Net.TcpServer.ReturnType.Success || sum.Value != 2 + 3)
                        {
                            return false;
                        }

                        return true;
                    }
                }
            }
            return false;
        }
    }
}
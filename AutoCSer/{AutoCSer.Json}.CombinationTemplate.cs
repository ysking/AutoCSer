//本文件由程序自动生成,请不要自行修改
using System;
using AutoCSer;

#if NoAutoCSer
#else
#pragma warning disable

namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 解析
    /// </summary>
    public unsafe sealed partial class Parser
    {
        /// <summary>
        /// 数组解析
        /// </summary>
        /// <param name="array"></param>
        [ParseMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallParse(ref long[] array)
        {
            if (searchArraySize(ref array))
            {
                int index = 0;
                do
                {
                    CallParse(ref array[index]);
                    if (ParseState != ParseState.Success) return;
                    ++index;
                }
                while (IsNextArrayValue());
            }
        }
    }
}
namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 解析
    /// </summary>
    public unsafe sealed partial class Parser
    {
        /// <summary>
        /// 数组解析
        /// </summary>
        /// <param name="array"></param>
        [ParseMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallParse(ref uint[] array)
        {
            if (searchArraySize(ref array))
            {
                int index = 0;
                do
                {
                    CallParse(ref array[index]);
                    if (ParseState != ParseState.Success) return;
                    ++index;
                }
                while (IsNextArrayValue());
            }
        }
    }
}
namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 解析
    /// </summary>
    public unsafe sealed partial class Parser
    {
        /// <summary>
        /// 数组解析
        /// </summary>
        /// <param name="array"></param>
        [ParseMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallParse(ref int[] array)
        {
            if (searchArraySize(ref array))
            {
                int index = 0;
                do
                {
                    CallParse(ref array[index]);
                    if (ParseState != ParseState.Success) return;
                    ++index;
                }
                while (IsNextArrayValue());
            }
        }
    }
}
namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 解析
    /// </summary>
    public unsafe sealed partial class Parser
    {
        /// <summary>
        /// 数组解析
        /// </summary>
        /// <param name="array"></param>
        [ParseMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallParse(ref ushort[] array)
        {
            if (searchArraySize(ref array))
            {
                int index = 0;
                do
                {
                    CallParse(ref array[index]);
                    if (ParseState != ParseState.Success) return;
                    ++index;
                }
                while (IsNextArrayValue());
            }
        }
    }
}
namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 解析
    /// </summary>
    public unsafe sealed partial class Parser
    {
        /// <summary>
        /// 数组解析
        /// </summary>
        /// <param name="array"></param>
        [ParseMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallParse(ref short[] array)
        {
            if (searchArraySize(ref array))
            {
                int index = 0;
                do
                {
                    CallParse(ref array[index]);
                    if (ParseState != ParseState.Success) return;
                    ++index;
                }
                while (IsNextArrayValue());
            }
        }
    }
}
namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 解析
    /// </summary>
    public unsafe sealed partial class Parser
    {
        /// <summary>
        /// 数组解析
        /// </summary>
        /// <param name="array"></param>
        [ParseMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallParse(ref byte[] array)
        {
            if (searchArraySize(ref array))
            {
                int index = 0;
                do
                {
                    CallParse(ref array[index]);
                    if (ParseState != ParseState.Success) return;
                    ++index;
                }
                while (IsNextArrayValue());
            }
        }
    }
}
namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 解析
    /// </summary>
    public unsafe sealed partial class Parser
    {
        /// <summary>
        /// 数组解析
        /// </summary>
        /// <param name="array"></param>
        [ParseMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallParse(ref sbyte[] array)
        {
            if (searchArraySize(ref array))
            {
                int index = 0;
                do
                {
                    CallParse(ref array[index]);
                    if (ParseState != ParseState.Success) return;
                    ++index;
                }
                while (IsNextArrayValue());
            }
        }
    }
}
namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 解析
    /// </summary>
    public unsafe sealed partial class Parser
    {
        /// <summary>
        /// 数组解析
        /// </summary>
        /// <param name="array"></param>
        [ParseMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallParse(ref bool[] array)
        {
            if (searchArraySize(ref array))
            {
                int index = 0;
                do
                {
                    CallParse(ref array[index]);
                    if (ParseState != ParseState.Success) return;
                    ++index;
                }
                while (IsNextArrayValue());
            }
        }
    }
}
namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 解析
    /// </summary>
    public unsafe sealed partial class Parser
    {
        /// <summary>
        /// 数组解析
        /// </summary>
        /// <param name="array"></param>
        [ParseMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallParse(ref DateTime[] array)
        {
            if (searchArraySize(ref array))
            {
                int index = 0;
                do
                {
                    CallParse(ref array[index]);
                    if (ParseState != ParseState.Success) return;
                    ++index;
                }
                while (IsNextArrayValue());
            }
        }
    }
}
namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 序列化
    /// </summary>
    public unsafe sealed partial class Serializer
    {
        /// <summary>
        /// 数组转换 
        /// </summary>
        /// <param name="array">数组</param>
        [SerializeMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallSerialize(long[] array)
        {
            if (array != null)
            {
                switch (array.Length)
                {
                    case 0: CharStream.WriteJsonArray(); return;
                    case 1:
                        CharStream.Write('[');
                        CallSerialize(array[0]);
                        CharStream.Write(']');
                        return;
                    default:
                        bool isNext = false;
                        CharStream.Write('[');
                        foreach (long value in array)
                        {
                            if (isNext) CharStream.Write(',');
                            else isNext = true;
                            CallSerialize(value);
                        }
                        CharStream.Write(']');
                        return;
                }
            }
            CharStream.WriteJsonNull();
        }
    }
}

namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 序列化
    /// </summary>
    public unsafe sealed partial class Serializer
    {
        /// <summary>
        /// 数组转换 
        /// </summary>
        /// <param name="array">数组</param>
        [SerializeMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallSerialize(uint[] array)
        {
            if (array != null)
            {
                switch (array.Length)
                {
                    case 0: CharStream.WriteJsonArray(); return;
                    case 1:
                        CharStream.Write('[');
                        CallSerialize(array[0]);
                        CharStream.Write(']');
                        return;
                    default:
                        bool isNext = false;
                        CharStream.Write('[');
                        foreach (uint value in array)
                        {
                            if (isNext) CharStream.Write(',');
                            else isNext = true;
                            CallSerialize(value);
                        }
                        CharStream.Write(']');
                        return;
                }
            }
            CharStream.WriteJsonNull();
        }
    }
}

namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 序列化
    /// </summary>
    public unsafe sealed partial class Serializer
    {
        /// <summary>
        /// 数组转换 
        /// </summary>
        /// <param name="array">数组</param>
        [SerializeMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallSerialize(int[] array)
        {
            if (array != null)
            {
                switch (array.Length)
                {
                    case 0: CharStream.WriteJsonArray(); return;
                    case 1:
                        CharStream.Write('[');
                        CallSerialize(array[0]);
                        CharStream.Write(']');
                        return;
                    default:
                        bool isNext = false;
                        CharStream.Write('[');
                        foreach (int value in array)
                        {
                            if (isNext) CharStream.Write(',');
                            else isNext = true;
                            CallSerialize(value);
                        }
                        CharStream.Write(']');
                        return;
                }
            }
            CharStream.WriteJsonNull();
        }
    }
}

namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 序列化
    /// </summary>
    public unsafe sealed partial class Serializer
    {
        /// <summary>
        /// 数组转换 
        /// </summary>
        /// <param name="array">数组</param>
        [SerializeMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallSerialize(ushort[] array)
        {
            if (array != null)
            {
                switch (array.Length)
                {
                    case 0: CharStream.WriteJsonArray(); return;
                    case 1:
                        CharStream.Write('[');
                        CallSerialize(array[0]);
                        CharStream.Write(']');
                        return;
                    default:
                        bool isNext = false;
                        CharStream.Write('[');
                        foreach (ushort value in array)
                        {
                            if (isNext) CharStream.Write(',');
                            else isNext = true;
                            CallSerialize(value);
                        }
                        CharStream.Write(']');
                        return;
                }
            }
            CharStream.WriteJsonNull();
        }
    }
}

namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 序列化
    /// </summary>
    public unsafe sealed partial class Serializer
    {
        /// <summary>
        /// 数组转换 
        /// </summary>
        /// <param name="array">数组</param>
        [SerializeMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallSerialize(short[] array)
        {
            if (array != null)
            {
                switch (array.Length)
                {
                    case 0: CharStream.WriteJsonArray(); return;
                    case 1:
                        CharStream.Write('[');
                        CallSerialize(array[0]);
                        CharStream.Write(']');
                        return;
                    default:
                        bool isNext = false;
                        CharStream.Write('[');
                        foreach (short value in array)
                        {
                            if (isNext) CharStream.Write(',');
                            else isNext = true;
                            CallSerialize(value);
                        }
                        CharStream.Write(']');
                        return;
                }
            }
            CharStream.WriteJsonNull();
        }
    }
}

namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 序列化
    /// </summary>
    public unsafe sealed partial class Serializer
    {
        /// <summary>
        /// 数组转换 
        /// </summary>
        /// <param name="array">数组</param>
        [SerializeMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallSerialize(byte[] array)
        {
            if (array != null)
            {
                switch (array.Length)
                {
                    case 0: CharStream.WriteJsonArray(); return;
                    case 1:
                        CharStream.Write('[');
                        CallSerialize(array[0]);
                        CharStream.Write(']');
                        return;
                    default:
                        bool isNext = false;
                        CharStream.Write('[');
                        foreach (byte value in array)
                        {
                            if (isNext) CharStream.Write(',');
                            else isNext = true;
                            CallSerialize(value);
                        }
                        CharStream.Write(']');
                        return;
                }
            }
            CharStream.WriteJsonNull();
        }
    }
}

namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 序列化
    /// </summary>
    public unsafe sealed partial class Serializer
    {
        /// <summary>
        /// 数组转换 
        /// </summary>
        /// <param name="array">数组</param>
        [SerializeMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallSerialize(sbyte[] array)
        {
            if (array != null)
            {
                switch (array.Length)
                {
                    case 0: CharStream.WriteJsonArray(); return;
                    case 1:
                        CharStream.Write('[');
                        CallSerialize(array[0]);
                        CharStream.Write(']');
                        return;
                    default:
                        bool isNext = false;
                        CharStream.Write('[');
                        foreach (sbyte value in array)
                        {
                            if (isNext) CharStream.Write(',');
                            else isNext = true;
                            CallSerialize(value);
                        }
                        CharStream.Write(']');
                        return;
                }
            }
            CharStream.WriteJsonNull();
        }
    }
}

namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 序列化
    /// </summary>
    public unsafe sealed partial class Serializer
    {
        /// <summary>
        /// 数组转换 
        /// </summary>
        /// <param name="array">数组</param>
        [SerializeMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallSerialize(bool[] array)
        {
            if (array != null)
            {
                switch (array.Length)
                {
                    case 0: CharStream.WriteJsonArray(); return;
                    case 1:
                        CharStream.Write('[');
                        CallSerialize(array[0]);
                        CharStream.Write(']');
                        return;
                    default:
                        bool isNext = false;
                        CharStream.Write('[');
                        foreach (bool value in array)
                        {
                            if (isNext) CharStream.Write(',');
                            else isNext = true;
                            CallSerialize(value);
                        }
                        CharStream.Write(']');
                        return;
                }
            }
            CharStream.WriteJsonNull();
        }
    }
}

namespace AutoCSer.Json
{
    /// <summary>
    /// JSON 序列化
    /// </summary>
    public unsafe sealed partial class Serializer
    {
        /// <summary>
        /// 数组转换 
        /// </summary>
        /// <param name="array">数组</param>
        [SerializeMethod]
        [AutoCSer.IOS.Preserve(Conditional = true)]
        public void CallSerialize(DateTime[] array)
        {
            if (array != null)
            {
                switch (array.Length)
                {
                    case 0: CharStream.WriteJsonArray(); return;
                    case 1:
                        CharStream.Write('[');
                        CallSerialize(array[0]);
                        CharStream.Write(']');
                        return;
                    default:
                        bool isNext = false;
                        CharStream.Write('[');
                        foreach (DateTime value in array)
                        {
                            if (isNext) CharStream.Write(',');
                            else isNext = true;
                            CallSerialize(value);
                        }
                        CharStream.Write(']');
                        return;
                }
            }
            CharStream.WriteJsonNull();
        }
    }
}

#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MegaLab
{
    static class CustomFormatter
    {
        public static bool IsSimple(Type type)
        {
            return type == typeof(Object) || type == typeof(String) || type == typeof(Char) || type == typeof(Boolean) || type == typeof(Byte) || type == typeof(Int16) || type == typeof(Int32) || type == typeof(Int64) || type == typeof(UInt16) || type == typeof(UInt32) || type == typeof(UInt64) || type == typeof(IntPtr) || type == typeof(Single) || type == typeof(Double) || type == typeof(Decimal);
        }

        public static void Serialize(BinaryWriter writer, object obj)
        {
            if (obj != null)
            {
                Type type = obj.GetType();
                if (!IsSimple(type))
                {
                    if (type.IsArray)
                    {
                        writer.Write(type.FullName);
                        writer.Write(((Array)obj).Length);
                        int index = 0;
                        for (int i = 0; i < ((Array)obj).Length; i++)
                            if (((Array)obj).GetValue(i) != null)
                                index++;
                        writer.Write(index);
                        index = 0;
                        foreach (var item in (Array)obj)
                        {
                            if (item != null)
                            {
                                Serialize(writer, item);
                                writer.Write(index);
                            }
                            index++;
                        }
                    }
                    else
                    {
                        if (type.IsClass)
                        {
                            writer.Write(type.FullName);
                            while (type != typeof(object))
                            {
                                var fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                                writer.Write(fields.Count(item => !(item.GetValue(obj) is Delegate) && item.GetValue(obj) != null));
                                for (int i = 0; i < fields.Length; i++)
                                    if (!(fields[i].GetValue(obj) is Delegate) && fields[i].GetValue(obj) != null)
                                    {
                                        writer.Write(fields[i].Name);
                                        Serialize(writer, fields[i].GetValue(obj));
                                    }
                                type = type.BaseType;
                            }
                        }
                    }
                }
                else
                {
                    writer.Write(type.FullName);
                    writer.GetType().GetMethod("Write", new Type[] { obj.GetType() }).Invoke(writer, new object[] { obj });
                }
            }
        }

        public static object Deserialize(BinaryReader reader)
        {
            Type type = Type.GetType(reader.ReadString());
            object newObj = null;
            if (!IsSimple(type))
            {
                if (type.IsArray)
                {
                    newObj = Activator.CreateInstance(type, reader.ReadInt32());
                    int length = reader.ReadInt32();
                    for (int i = 0; i < length; i++)
                        ((Array)newObj).SetValue(Deserialize(reader), reader.ReadInt32());
                }
                else
                {
                    if (type.IsClass)
                    {
                        if (type != typeof(string) && !type.IsAbstract && type.Namespace != "System")
                            newObj = Activator.CreateInstance(type);
                        int length;
                        while (type != typeof(object))
                        {
                            length = reader.ReadInt32();
                            for (int i = 0; i < length; i++)
                            {
                                var fieldName = reader.ReadString();
                                var value = Deserialize(reader);
                                type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy).SetValue(newObj, value);
                            }
                            type = type.BaseType;
                        }
                    }
                }
            }
            else
            {
                if (type == typeof(string))
                {
                    newObj = Activator.CreateInstance(type, '\0', 0);
                    newObj = reader.GetType().GetMethod($"Read{type.Name}", new Type[] { }).Invoke(reader, new object[] { });
                }
                else
                {
                    newObj = Activator.CreateInstance(type);
                    newObj = reader.GetType().GetMethod($"Read{type.Name}", new Type[] { }).Invoke(reader, new object[] { });
                }
            }

            return newObj;
        }
    }
}

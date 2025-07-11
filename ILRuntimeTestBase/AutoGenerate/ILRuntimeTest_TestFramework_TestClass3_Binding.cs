using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    [ILRuntimePatchIgnore]
    unsafe class ILRuntimeTest_TestFramework_TestClass3_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(ILRuntimeTest.TestFramework.TestClass3);
            args = new Type[]{typeof(System.Byte).MakeByRefType(), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("setBit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setBit_0);
            args = new Type[]{typeof(System.Int32).MakeByRefType(), typeof(System.Int32)};
            method = type.GetMethod("getString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, getString_1);

            field = type.GetField("Struct", flag);
            app.RegisterCLRFieldGetter(field, get_Struct_0);
            app.RegisterCLRFieldSetter(field, set_Struct_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Struct_0, AssignFromStack_Struct_0);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* setBit_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = __esp - 3;

            ptr_of_this_method = __esp - 1;
            System.Int32 @bit = ptr_of_this_method->Value;

            ptr_of_this_method = __esp - 2;
            System.Int32 @pos = ptr_of_this_method->Value;

            ptr_of_this_method = __esp - 3;
            System.Byte @value = (System.Byte)__intp.RetriveInt32(ptr_of_this_method, __mStack);


            ILRuntimeTest.TestFramework.TestClass3.setBit(ref @value, @pos, @bit);

            ptr_of_this_method = __esp - 1;
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = __esp - 2;
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = __esp - 3;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @value;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @value;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @value);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @value;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @value);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Byte[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @value;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* getString_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = __esp - 2;

            ptr_of_this_method = __esp - 1;
            System.Int32 @length = ptr_of_this_method->Value;

            ptr_of_this_method = __esp - 2;
            System.Int32 @startIndex = __intp.RetriveInt32(ptr_of_this_method, __mStack);


            var result_of_this_method = ILRuntimeTest.TestFramework.TestClass3.getString(ref @startIndex, @length);

            ptr_of_this_method = __esp - 1;
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = __esp - 2;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @startIndex;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @startIndex;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @startIndex);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @startIndex;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @startIndex);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Int32[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @startIndex;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_Struct_0(ref object o)
        {
            return ((ILRuntimeTest.TestFramework.TestClass3)o).Struct;
        }

        static StackObject* CopyToStack_Struct_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((ILRuntimeTest.TestFramework.TestClass3)o).Struct;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Struct_0(ref object o, object v)
        {
            ((ILRuntimeTest.TestFramework.TestClass3)o).Struct = (ILRuntimeTest.TestFramework.TestStruct)v;
        }

        static StackObject* AssignFromStack_Struct_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            ILRuntimeTest.TestFramework.TestStruct @Struct = (ILRuntimeTest.TestFramework.TestStruct)typeof(ILRuntimeTest.TestFramework.TestStruct).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (ILRuntime.CLR.Utils.Extensions.TypeFlags)16);
            ((ILRuntimeTest.TestFramework.TestClass3)o).Struct = @Struct;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = __esp - 0;

            var result_of_this_method = new ILRuntimeTest.TestFramework.TestClass3();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

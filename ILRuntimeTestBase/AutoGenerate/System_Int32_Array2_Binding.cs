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
    unsafe class System_Int32_Array2_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Int32[,]);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Set", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Set_0);

            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Set_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = __esp - 4;

            ptr_of_this_method = __esp - 1;
            System.Int32 a3 = ptr_of_this_method->Value;

            ptr_of_this_method = __esp - 2;
            System.Int32 a2 = ptr_of_this_method->Value;

            ptr_of_this_method = __esp - 3;
            System.Int32 a1 = ptr_of_this_method->Value;

            ptr_of_this_method = __esp - 4;
            System.Int32[,] instance_of_this_method = (System.Int32[,])typeof(System.Int32[,]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (ILRuntime.CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method[a1, a2] = a3;

            return __ret;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = __esp - 2;
            ptr_of_this_method = __esp - 1;
            System.Int32 a2 = ptr_of_this_method->Value;

            ptr_of_this_method = __esp - 2;
            System.Int32 a1 = ptr_of_this_method->Value;


            var result_of_this_method = new System.Int32[a1, a2];

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

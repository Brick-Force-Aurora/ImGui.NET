﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#pragma warning disable IDE0060 // implementations provided as intrinsics
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;

//
// The implementations of most the methods in this file are provided as intrinsics.
// In CoreCLR, the body of the functions are replaced by the EE with unsafe code. See see getILIntrinsicImplementationForUnsafe for details.
// In AOT compilers, see Internal.IL.Stubs.UnsafeIntrinsics for details.
//

#pragma warning disable 8500 // address / sizeof of managed types

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Contains generic, low-level functionality for manipulating pointers.
    /// </summary>
    public static unsafe partial class Unsafe
    {
        /// <summary>
        /// Returns a pointer to the given by-ref parameter.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__AS_POINTER
        // AOT:AsPointer
        // Mono:AsPointer
        
        [CLSCompliant(false)]
        
        public static void* AsPointer<T>(ref T value)
        {
            throw new PlatformNotSupportedException();

            // ldarg.0
            // conv.u
            // ret
        }

        /// <summary>
        /// Returns the size of an object of the given type parameter.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__SIZEOF
        // AOT:SizeOf
        // Mono:SizeOf
        
        
        public static int SizeOf<T>()
        {
            return sizeof(T);
        }

        /// <summary>
        /// Casts the given object to the specified type, performs no dynamic type checking.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__OBJECT_AS
        // AOT:As
        // Mono:As
        
        
        /*[return: NotNullIfNotNull(nameof(o))]
        public static T As<T>(object? o) where T : class?
        {
            throw new PlatformNotSupportedException();

            // ldarg.0
            // ret
        }*/

        /// <summary>
        /// Reinterprets the given reference as a reference to a value of type <typeparamref name="TTo"/>.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_AS
        // AOT:As
        // Mono:As
        
        
        public static ref TTo As<TFrom, TTo>(ref TFrom source)
        {
            throw new PlatformNotSupportedException();

            // ldarg.0
            // ret
        }

        /// <summary>
        /// Adds an element offset to the given reference.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_ADD
        // AOT:Add
        // Mono:Add
        
        
        public static ref T Add<T>(ref T source, int elementOffset)
        {
#if CORECLR
            typeof(T).ToString(); // Type token used by the actual method body
            throw new PlatformNotSupportedException();
#else
            return ref AddByteOffset(ref source, (IntPtr)(elementOffset * (int)sizeof(T)));
#endif
            // ldarg .0
            // ldarg .1
            // sizeof !!T
            // conv.i
            // mul
            // add
            // ret
        }

        /// <summary>
        /// Adds an element offset to the given reference.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_INTPTR_ADD
        // AOT:Add
        // Mono:Add
        
        
        public static ref T Add<T>(ref T source, IntPtr elementOffset)
        {
#if CORECLR
            typeof(T).ToString(); // Type token used by the actual method body
            throw new PlatformNotSupportedException();
#else
            return ref AddByteOffset(ref source, (IntPtr)((int)elementOffset * (int)sizeof(T)));
#endif

            // ldarg .0
            // ldarg .1
            // sizeof !!T
            // mul
            // add
            // ret
        }

        /// <summary>
        /// Adds an element offset to the given pointer.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__PTR_ADD
        // AOT:Add
        // Mono:Add
        
        [CLSCompliant(false)]
        
        public static void* Add<T>(void* source, int elementOffset)
        {
#if CORECLR
            typeof(T).ToString(); // Type token used by the actual method body
            throw new PlatformNotSupportedException();
#else
            return (byte*)source + (elementOffset * (int)sizeof(T));
#endif

            // ldarg .0
            // ldarg .1
            // sizeof !!T
            // conv.i
            // mul
            // add
            // ret
        }

        /// <summary>
        /// Adds an element offset to the given reference.
        /// </summary>
        
        // CoreCLR:
        
        [CLSCompliant(false)]
        
        public static ref T Add<T>(ref T source, uint elementOffset)
        {
#if CORECLR
            typeof(T).ToString();
            throw new PlatformNotSupportedException();
#else
            return ref AddByteOffset(ref source, (uint)(elementOffset * (uint)sizeof(T)));
#endif

            // ldarg .0
            // ldarg .1
            // sizeof !!T
            // mul
            // add
            // ret
        }

        /// <summary>
        /// Adds an byte offset to the given reference.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_ADD_BYTE_OFFSET_UINTPTR
        // AOT:AddByteOffset
        // Mono:AddByteOffset
        
        [CLSCompliant(false)]
        
        public static ref T AddByteOffset<T>(ref T source, uint byteOffset)
        {
#if CORECLR
            typeof(T).ToString();
            throw new PlatformNotSupportedException();
#else
            return ref AddByteOffset(ref source, (IntPtr)(void*)byteOffset);
#endif

            // ldarg .0
            // ldarg .1
            // add
            // ret
        }

        /// <summary>
        /// Determines whether the specified references point to the same location.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_ARE_SAME
        // AOT:AreSame
        // Mono:AreSame
        
        
        /*public static bool AreSame<T>([AllowNull] ref readonly T left, [AllowNull] ref readonly T right)
        {
            throw new PlatformNotSupportedException();

            // ldarg.0
            // ldarg.1
            // ceq
            // ret
        }*/

        /// <summary>
        /// Reinterprets the given value of type <typeparamref name="TFrom" /> as a value of type <typeparamref name="TTo" />.
        /// </summary>
        /// <exception cref="NotSupportedException">The size of <typeparamref name="TFrom" /> and <typeparamref name="TTo" /> are not the same.</exception>
        
        
        
        /*public static TTo BitCast<TFrom, TTo>(TFrom source)
            where TFrom : struct
            where TTo : struct
        {
            if (sizeof(TFrom) != sizeof(TTo))
            {
                //ThrowHelper.ThrowNotSupportedException();
            }
            return ReadUnaligned<TTo>(ref As<TFrom, byte>(ref source));
        }*/

        /// <summary>
        /// Copies a value of type T to the given location.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__PTR_BYREF_COPY
        
        [CLSCompliant(false)]
        
        /*public static void Copy<T>(void* destination, ref readonly T source)
        {
            throw new PlatformNotSupportedException();

            // ldarg .0
            // ldarg .1
            // ldobj !!T
            // stobj !!T
            // ret
        }*/

        /// <summary>
        /// Copies a value of type T to the given location.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_PTR_COPY
        
        public static void Copy<T>(ref T destination, void* source)
        {
            throw new PlatformNotSupportedException();

            // ldarg .0
            // ldarg .1
            // ldobj !!T
            // stobj !!T
            // ret
        }

        /// <summary>
        /// Copies bytes from the source address to the destination address.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__PTR_COPY_BLOCK
        
        [CLSCompliant(false)]
        
        public static void CopyBlock(void* destination, void* source, uint byteCount)
        {
            for (int i = 0; i < byteCount; i++)
            {
                ((byte*)destination)[i] = ((byte*)source)[i];
            }

            // ldarg .0
            // ldarg .1
            // ldarg .2
            // cpblk
            // ret
        }

        /// <summary>
        /// Copies bytes from the source address to the destination address.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_COPY_BLOCK
        
        [CLSCompliant(false)]
        
        /*public static void CopyBlock(ref byte destination, ref readonly byte source, uint byteCount)
        {
            throw new PlatformNotSupportedException();

            // ldarg .0
            // ldarg .1
            // ldarg .2
            // cpblk
            // ret
        }*/

        /// <summary>
        /// Copies bytes from the source address to the destination address without assuming architecture dependent alignment of the addresses.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__PTR_COPY_BLOCK_UNALIGNED
        
        public static void CopyBlockUnaligned(void* destination, void* source, uint byteCount)
        {
            throw new PlatformNotSupportedException();

            // ldarg .0
            // ldarg .1
            // ldarg .2
            // unaligned. 0x1
            // cpblk
            // ret
        }

        /// <summary>
        /// Copies bytes from the source address to the destination address without assuming architecture dependent alignment of the addresses.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_COPY_BLOCK_UNALIGNED
        
        [CLSCompliant(false)]
        
        /*public static void CopyBlockUnaligned(ref byte destination, ref readonly byte source, uint byteCount)
        {
            throw new PlatformNotSupportedException();

            // ldarg .0
            // ldarg .1
            // ldarg .2
            // unaligned. 0x1
            // cpblk
            // ret
        }*/

        /// <summary>
        /// Determines whether the memory address referenced by <paramref name="left"/> is greater than
        /// the memory address referenced by <paramref name="right"/>.
        /// </summary>
        /// <remarks>
        /// This check is conceptually similar to "(void*)(&amp;left) &gt; (void*)(&amp;right)".
        /// </remarks>
        
        // CoreCLR:CoreCLR:METHOD__UNSAFE__BYREF_IS_ADDRESS_GREATER_THAN
        // AOT:IsAddressGreaterThan
        // Mono:IsAddressGreaterThan
        
        
        /*public static bool IsAddressGreaterThan<T>([AllowNull] ref readonly T left, [AllowNull] ref readonly T right)
        {
            throw new PlatformNotSupportedException();

            // ldarg.0
            // ldarg.1
            // cgt.un
            // ret
        }*/

        /// <summary>
        /// Determines whether the memory address referenced by <paramref name="left"/> is less than
        /// the memory address referenced by <paramref name="right"/>.
        /// </summary>
        /// <remarks>
        /// This check is conceptually similar to "(void*)(&amp;left) &lt; (void*)(&amp;right)".
        /// </remarks>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_IS_ADDRESS_LESS_THAN
        // AOT:IsAddressLessThan
        // Mono:IsAddressLessThan
        
        
        /*public static bool IsAddressLessThan<T>([AllowNull] ref readonly T left, [AllowNull] ref readonly T right)
        {
            throw new PlatformNotSupportedException();

            // ldarg.0
            // ldarg.1
            // clt.un
            // ret
        }*/

        /// <summary>
        /// Initializes a block of memory at the given location with a given initial value.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__PTR_INIT_BLOCK
        
        public static void InitBlock(void* startAddress, byte value, uint byteCount)
        {
            throw new PlatformNotSupportedException();

            // ldarg .0
            // ldarg .1
            // ldarg .2
            // initblk
            // ret
        }

        /// <summary>
        /// Initializes a block of memory at the given location with a given initial value.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_INIT_BLOCK
        
        [CLSCompliant(false)]
        
        public static void InitBlock(ref byte startAddress, byte value, uint byteCount)
        {
            throw new PlatformNotSupportedException();

            // ldarg .0
            // ldarg .1
            // ldarg .2
            // initblk
            // ret
        }

        /// <summary>
        /// Initializes a block of memory at the given location with a given initial value
        /// without assuming architecture dependent alignment of the address.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__PTR_INIT_BLOCK_UNALIGNED
        
        [CLSCompliant(false)]
        
        public static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount)
        {
            for (int i = 0; i < byteCount; i++)
                ((byte*)startAddress)[i] = value;

            //throw new PlatformNotSupportedException();

                // ldarg .0
                // ldarg .1
                // ldarg .2
                // unaligned. 0x1
                // initblk
                // ret
        }

        /// <summary>
        /// Initializes a block of memory at the given location with a given initial value
        /// without assuming architecture dependent alignment of the address.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_INIT_BLOCK_UNALIGNED
        // AOT:InitBlockUnaligned
        // Mono:InitBlockUnaligned
        
        [CLSCompliant(false)]
        
        public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount)
        {
            for (uint i = 0; i < byteCount; i++)
            {
                AddByteOffset(ref startAddress, i) = value;
            }

            // ldarg .0
            // ldarg .1
            // ldarg .2
            // unaligned. 0x1
            // initblk
            // ret
        }

        /// <summary>
        /// Reads a value of type <typeparamref name="T"/> from the given location.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__PTR_READ_UNALIGNED
        // AOT:ReadUnaligned
        // Mono:ReadUnaligned
        
        [CLSCompliant(false)]
        
        public static T ReadUnaligned<T>(void* source)
        {
#if CORECLR
            typeof(T).ToString(); // Type token used by the actual method body
            throw new PlatformNotSupportedException();
#else
            return *(T*)source;
#endif

            // ldarg.0
            // unaligned. 0x1
            // ldobj !!T
            // ret
        }

        /// <summary>
        /// Reads a value of type <typeparamref name="T"/> from the given location.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_READ_UNALIGNED
        // AOT:ReadUnaligned
        // Mono:ReadUnaligned
        
        
        /*public static T ReadUnaligned<T>(ref byte source)
        {
#if CORECLR
            typeof(T).ToString(); // Type token used by the actual method body
            throw new PlatformNotSupportedException();
#else
            return As<byte, T>(ref Unsafe.AsRef(in source));
#endif

            // ldarg.0
            // unaligned. 0x1
            // ldobj !!T
            // ret
        }*/

        /// <summary>
        /// Writes a value of type <typeparamref name="T"/> to the given location.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__PTR_WRITE_UNALIGNED
        // AOT:WriteUnaligned
        // Mono:WriteUnaligned
        
        [CLSCompliant(false)]
        
        public static void WriteUnaligned<T>(void* destination, T value)
        {
#if CORECLR
            typeof(T).ToString(); // Type token used by the actual method body
            throw new PlatformNotSupportedException();
#else
            *(T*)destination = value;
#endif

            // ldarg .0
            // ldarg .1
            // unaligned. 0x01
            // stobj !!T
            // ret
        }

        /// <summary>
        /// Writes a value of type <typeparamref name="T"/> to the given location.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_WRITE_UNALIGNED
        // AOT:WriteUnaligned
        // Mono:WriteUnaligned
        
        
        public static void WriteUnaligned<T>(ref byte destination, T value)
        {
#if CORECLR
            typeof(T).ToString(); // Type token used by the actual method body
            throw new PlatformNotSupportedException();
#else
            As<byte, T>(ref destination) = value;
#endif

            // ldarg .0
            // ldarg .1
            // unaligned. 0x01
            // stobj !!T
            // ret
        }

        /// <summary>
        /// Adds an byte offset to the given reference.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_ADD_BYTE_OFFSET_INTPTR
        // AOT:AddByteOffset
        // Mono:AddByteOffset
        
        
        public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset)
        {
            // This method is implemented by the toolchain
            throw new PlatformNotSupportedException();

            // ldarg.0
            // ldarg.1
            // add
            // ret
        }

        /// <summary>
        /// Reads a value of type <typeparamref name="T"/> from the given location.
        /// </summary>
        
        
        [CLSCompliant(false)]
        
        public static T Read<T>(void* source)
        {
            return *(T*)source;
        }

        /// <summary>
        /// Writes a value of type <typeparamref name="T"/> to the given location.
        /// </summary>
        
        
        [CLSCompliant(false)]
        
        public static void Write<T>(void* destination, T value)
        {
            *(T*)destination = value;
        }

        /// <summary>
        /// Reinterprets the given location as a reference to a value of type <typeparamref name="T"/>.
        /// </summary>
        
        
        [CLSCompliant(false)]
        
        public static ref T AsRef<T>(void* source)
        {
            return ref *(T*)source;
        }

        /// <summary>
        /// Reinterprets the given location as a reference to a value of type <typeparamref name="T"/>.
        /// </summary>
        /// <remarks>The lifetime of the reference will not be validated when using this API.</remarks>
        
        // CoreCLR:METHOD__UNSAFE__AS_REF_IN
        // AOT:AsRef
        // Mono:AsRef
        
        
        /*public static ref T AsRef<T>(ref T source)
        {
            throw new PlatformNotSupportedException();

            //ldarg .0
            //ret
        }*/

        /// <summary>
        /// Determines the byte offset from origin to target from the given references.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_BYTE_OFFSET
        // AOT:ByteOffset
        // Mono:ByteOffset
        
        
        /*public static IntPtr ByteOffset<T>([AllowNull] ref readonly T origin, [AllowNull] ref readonly T target)
        {
            throw new PlatformNotSupportedException();

            // ldarg .1
            // ldarg .0
            // sub
            // ret
        }*/

        /// <summary>
        /// Returns a by-ref to type <typeparamref name="T"/> that is a null reference.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_NULLREF
        // AOT:NullRef
        
        
        public static ref T NullRef<T>()
        {
            return ref AsRef<T>(null);

            // ldc.i4.0
            // conv.u
            // ret
        }

        /// <summary>
        /// Returns if a given by-ref to type <typeparamref name="T"/> is a null reference.
        /// </summary>
        /// <remarks>
        /// This check is conceptually similar to "(void*)(&amp;source) == nullptr".
        /// </remarks>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_IS_NULL
        // AOT: IsNullRef
        
        
        /*public static bool IsNullRef<T>(ref readonly T source)
        {
            return AsPointer(ref Unsafe.AsRef(in source)) == null;

            // ldarg.0
            // ldc.i4.0
            // conv.u
            // ceq
            // ret
        }*/

        /// <summary>
        /// Bypasses definite assignment rules by taking advantage of <c>out</c> semantics.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__SKIPINIT
        // AOT:SkipInit
        // Mono:SkipInit
        
        
        public static void SkipInit<T>(out T value)
        {
            throw new PlatformNotSupportedException();

            // ret
        }

        /// <summary>
        /// Subtracts an element offset from the given reference.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_INT_SUBTRACT
        
        
        public static ref T Subtract<T>(ref T source, int elementOffset)
        {
#if CORECLR
            typeof(T).ToString();
            throw new PlatformNotSupportedException();
#else
            return ref SubtractByteOffset(ref source, (IntPtr)(elementOffset * (int)sizeof(T)));
#endif

            // ldarg .0
            // ldarg .1
            // sizeof !!T
            // conv.i
            // mul
            // sub
            // ret
        }

        /// <summary>
        /// Subtracts an element offset from the given void pointer.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__PTR_INT_SUBTRACT
        
        [CLSCompliant(false)]
        
        public static void* Subtract<T>(void* source, int elementOffset)
        {
#if CORECLR
            typeof(T).ToString();
            throw new PlatformNotSupportedException();
#else
            return (byte*)source - (elementOffset * (int)sizeof(T));
#endif

            // ldarg .0
            // ldarg .1
            // sizeof !!T
            // conv.i
            // mul
            // sub
            // ret
        }

        /// <summary>
        /// Subtracts an element offset from the given reference.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_INTPTR_SUBTRACT
        
        
        public static ref T Subtract<T>(ref T source, IntPtr elementOffset)
        {
#if CORECLR
            typeof(T).ToString();
            throw new PlatformNotSupportedException();
#else
            return ref SubtractByteOffset(ref source, (IntPtr)((int)elementOffset * (int)sizeof(T)));
#endif

            // ldarg .0
            // ldarg .1
            // sizeof !!T
            // mul
            // sub
            // ret
        }

        /// <summary>
        /// Subtracts an element offset from the given reference.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_UINTPTR_SUBTRACT
        
        [CLSCompliant(false)]
        
        public static ref T Subtract<T>(ref T source, uint elementOffset)
        {
#if CORECLR
            typeof(T).ToString();
            throw new PlatformNotSupportedException();
#else
            return ref SubtractByteOffset(ref source, (uint)(elementOffset * (uint)sizeof(T)));
#endif

            // ldarg .0
            // ldarg .1
            // sizeof !!T
            // mul
            // sub
            // ret
        }

        /// <summary>
        /// Subtracts a byte offset from the given reference.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_INTPTR_SUBTRACT_BYTE_OFFSET
        
        
        public static ref T SubtractByteOffset<T>(ref T source, IntPtr byteOffset)
        {
            throw new PlatformNotSupportedException();

            // ldarg .0
            // ldarg .1
            // sub
            // ret
        }

        /// <summary>
        /// Subtracts a byte offset from the given reference.
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__BYREF_UINTPTR_SUBTRACT_BYTE_OFFSET
        
        [CLSCompliant(false)]
        
        public static ref T SubtractByteOffset<T>(ref T source, uint byteOffset)
        {
#if CORECLR
            typeof(T).ToString();
            throw new PlatformNotSupportedException();
#else
            return ref SubtractByteOffset(ref source, (IntPtr)(void*)byteOffset);
#endif

            // ldarg .0
            // ldarg .1
            // sub
            // ret
        }

        /// <summary>
        /// Returns a mutable ref to a boxed value
        /// </summary>
        
        // CoreCLR:METHOD__UNSAFE__UNBOX
        
        
        public static ref T Unbox<T>(object box)
            where T : struct
        {
            throw new PlatformNotSupportedException();

            // ldarg .0
            // unbox !!T
            // ret
        }
    }
}

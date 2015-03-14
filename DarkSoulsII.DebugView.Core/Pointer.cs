﻿using System;
using DarkSoulsII.DebugView.Core.Exceptions;

namespace DarkSoulsII.DebugView.Core
{
    public class Pointer<T> : IPointer<T> where T : class, IReadable<T>, new()
    {
        public Pointer(int address, bool relative, bool dereferenced)
        {
            Address = dereferenced ? 0 : address;
            TargetAddress = dereferenced ? address : 0;
            Relative = !dereferenced && relative;
            TargetRelative = dereferenced && relative;
            Dereferenced = dereferenced;
        }

        public int Address { get; set; }
        public bool Relative { get; set; }
        public int TargetAddress { get; set; }
        public bool TargetRelative { get; set; }
        public bool Dereferenced { get; set; }

        public bool IsNull
        {
            get { return TargetAddress == 0; }
        }
        
        public static int Size
        {
            get { return sizeof (int); }
        }
        
        public T Unbox(IPointerFactory pointerFactory, IReader reader)
        {
            if (Dereferenced == false)
                Dereference(reader);
            if (IsNull)
                return null;

            T obj = new T();
            return obj.Read(pointerFactory, reader, TargetAddress, TargetRelative);
        }

        public T TryUnbox(IPointerFactory pointerFactory, IReader reader)
        {
            try
            {
                return Unbox(pointerFactory, reader);
            }
            catch (MemoryInaccessibleException)
            {
                return null;
            }
        }

        public void Dereference(IReader reader)
        {
            TargetAddress = reader.ReadInt32(Address, Relative);
            TargetRelative = false;
            Dereferenced = true;
        }
        
        [Obsolete]
        public static Pointer<T> Create(int address, bool relative = false, bool dereferenced = false)
        {
            return new Pointer<T>(address, relative, dereferenced);
        }
    }
}

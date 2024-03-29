﻿using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Networking.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Netwroking
{

    public sealed class StateObject : IStateObject
    {
        /* Contains the state information. */

        private const int Buffer_Size = 1024;
        private readonly byte[] buffer = new byte[Buffer_Size];
        private readonly StreamSocket listener;
        private readonly int id;
        private StringBuilder sb;

        public StateObject(StreamSocket listener, int id = -1)
        {
            this.listener = listener;
            this.id = id;
            this.Close = false;
            this.Reset();
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public bool Close { get; set; }

        public int BufferSize
        {
            get
            {
                return Buffer_Size;
            }
        }

        public byte[] Buffer
        {
            get
            {
                return this.buffer;
            }
        }

        public StreamSocket Listener
        {
            get
            {
                return this.listener;
            }
        }

        public string Text
        {
            get
            {
                return this.sb.ToString();
            }
        }

        public void Append(string text)
        {
            this.sb.Append(text);
        }

        public void Reset()
        {

            this.sb = new StringBuilder();
        }
    }
}
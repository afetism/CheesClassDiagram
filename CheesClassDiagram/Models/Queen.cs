﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesClassDiagram.Models
{
    public class Queen : IPiece
    {
        public bool Killed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CanMove()
        {
            throw new NotImplementedException();
        }

        public bool IsKilled()
        {
            throw new NotImplementedException();
        }

        public bool IsWhite()
        {
            throw new NotImplementedException();
        }
    }
}

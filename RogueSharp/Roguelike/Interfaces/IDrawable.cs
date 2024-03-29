﻿using RLNET;
using RogueSharp;

namespace Roguelike.Interfaces
{
    public interface IDrawable
    {
        RLColor Color { get; set; }
        char Symbvol { get; set; }
        int X { get; set; }
        int Y { get; set; }

        void Draw(RLConsole console, IMap map);
    }
}
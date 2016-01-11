﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoAnimation
{
    public interface IAnimationController
    {
        void Update(GameTime gameTime, Vector2 velocity);

        void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 position);
    }
}

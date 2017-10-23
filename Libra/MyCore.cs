﻿using MonoGameTests.Scenes;
using Nez;

namespace MonoGameTests
{
    public class MyCore : Core
    {
        public MyCore() : base(width: 1280, height: 960, isFullScreen: false, enableEntitySystems: false)
        {
        }
        
        protected override void Initialize()
        {
            base.Initialize();

            //scene = new TestScene();
            scene = new LevelScene();
        }
    }
}
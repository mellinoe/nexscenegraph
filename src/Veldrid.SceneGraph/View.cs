﻿//
// Copyright 2018 Sean Spicer 
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;

namespace Veldrid.SceneGraph
{
    public class View : IView
    {
        public ICamera Camera { get; set; }

        public static IView Create()
        {
            return new View();
        }
        
        protected View()
        {
            Camera = Veldrid.SceneGraph.Camera.Create(DisplaySettings.Instance.ScreenWidth, DisplaySettings.Instance.ScreenHeight);
            Camera.View = this;

            var height = DisplaySettings.Instance.ScreenHeight;
            var width = DisplaySettings.Instance.ScreenWidth;
            var dist = DisplaySettings.Instance.ScreenDistance;
            
            // TODO: This is tricky - need to fix when ViewAll implemented
            var vfov = (float) Math.Atan2(height / 2.0f, dist) * 2.0f; 

            Camera.SetProjectionMatrixAsPerspective(vfov, width / height, 0.1f, 100f);
        }
    }
}
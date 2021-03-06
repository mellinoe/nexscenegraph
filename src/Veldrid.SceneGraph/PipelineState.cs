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

using System.Collections.Generic;

namespace Veldrid.SceneGraph
{
    public class PipelineState : IPipelineState
    {
        public ShaderDescription? VertexShaderDescription { get; set; }
        public ShaderDescription? FragmentShaderDescription { get; set; }
        
        private List<ITexture2D> _textureList = new List<ITexture2D>();
        public IReadOnlyList<ITexture2D> TextureList => _textureList;

        public BlendStateDescription BlendStateDescription { get; set; } = BlendStateDescription.SingleOverrideBlend;

        public DepthStencilStateDescription DepthStencilState { get; set; } =
            DepthStencilStateDescription.DepthOnlyLessEqual;

        public RasterizerStateDescription RasterizerStateDescription { get; set; } = RasterizerStateDescription.Default;

        public static IPipelineState Create()
        {
            return new PipelineState();
        }
        
        private PipelineState()
        {
            // Nothing to see here.
        }

        public void AddTexture(ITexture2D texture)
        {
            _textureList.Add(texture);
        }
    }
}
//
// Copyright (c) 2018 Sean Spicer
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//

using System.Collections.Generic;
using Veldrid.SceneGraph.Util;

namespace Veldrid.SceneGraph
{
    public class RenderInfo
    {
        public View View { get; set; }= null;
        public State State { get; set; }= null;
        public Stack<Camera> CameraStack { get; set; } = new Stack<Camera>();
        public Stack<RenderBin> RenderBinStack { get; set; } = new Stack<RenderBin>();

        public GraphicsDevice GraphicsDevice { get; set; }
        public ResourceFactory ResourceFactory { get; set; }
        public CommandList CommandList { get; set; }
        public ResourceLayout ResourceLayout { get; set; }
        public ResourceSet ResourceSet { get; set; }
        
        // TODO - these dont really belong here.
        public Pipeline Pipeline { get; set; }
        public DeviceBuffer VertexBuffer { get; set; }
        public DeviceBuffer IndexBuffer { get; set; }
        
        public RenderInfo()
        {
        }

        public RenderInfo(State state, View view)
        {
            State = state;
            View = view;
        }

        public RenderInfo(RenderInfo renderInfo)
        {
            State = renderInfo.State;
            View = renderInfo.View;
            CameraStack = renderInfo.CameraStack;
            RenderBinStack = renderInfo.RenderBinStack;
        }
    }
}
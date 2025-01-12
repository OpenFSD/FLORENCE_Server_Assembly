using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Assembly.game_Instance.gFX
{
    public class Graphics : GameWindow
    {
       MouseState mouse = null;

        public Graphics(OpenTK.Windowing.Desktop.GameWindowSettings gws, OpenTK.Windowing.Desktop.NativeWindowSettings nws) : base(
           gws,
           nws
        )
        {
            mouse = MouseState;
            System.Console.WriteLine("FLORENCE: Graphics & GameWindow");
        }

        ~Graphics()
        {

        }
        protected override void OnFramebufferResize(FramebufferResizeEventArgs e)
        {
            base.OnFramebufferResize(e);
            GL.Viewport(0, 0, e.Width, e.Height);
        }

        protected override void OnLoad()
        {
            base.OnLoad();
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
        }

        protected override void OnUnload()
        {
            base.OnUnload();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            float period = (float)e.Time;
            
            if (!IsFocused) // Check to see if the window is focused
            {
                return;
            }
            if (KeyboardState.IsKeyDown(Keys.Escape))
            {
                this.Close();
            }
            if (KeyboardState.IsKeyDown(Keys.W)
                || KeyboardState.IsKeyDown(Keys.S)
                || KeyboardState.IsKeyDown(Keys.A)
                || KeyboardState.IsKeyDown(Keys.D)
            )
            {
                
            }
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            base.OnMouseWheel(e);
        }
    }
}

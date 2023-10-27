using System;
using System.Drawing;
using System.Numerics;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // Create a new window.
            var window = new Window(800, 600);

            // Create a new graphics context.
            var context = new GraphicsContext(window);

            // Set the clear color.
            context.ClearColor = Color.White;

            // Enable depth testing.
            context.Enable(EnableCap.DepthTest);

            // Set the depth function.
            context.DepthFunc = DepthFunction.Lequal;

            // Create a new cube.
            var cube = new Cube();

            // Translate the cube to the center of the screen.
            cube.Position = new Vector3(0, 0, -5);

            // Start the main loop.
            while (window.IsOpen)
            {
                // Clear the screen.
                context.Clear();

                // Draw the cube.
                cube.Draw(context);

                // Swap the buffers.
                window.SwapBuffers();

                // Poll for events.
                window.PollEvents();
            }
        }
    }
}

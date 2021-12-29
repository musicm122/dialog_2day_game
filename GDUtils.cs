using Godot;
using System;

namespace Dialog2DayGame
{
    public class InputAction
    {
        public const String Shoot = "shoot";
        public const String Left = "left";
        public const String Right = "right";
        public const String Up = "up";
        public const String Down = "down";
        public const String Pause = "pause";
    }

    public static class GDUtils
    {
        public static Vector2 GetTopDownMovementInput(float speed = 1f)
        {
            var velocity = Vector2.Zero;
            if (Input.IsActionPressed(InputAction.Right))
            {
                velocity.x += 1f;
            }
            if (Input.IsActionPressed(InputAction.Left))
            {
                velocity.x -= 1f;
            }
            if (Input.IsActionPressed(InputAction.Up))
            {
                velocity.y -= 1f;
            }
            if (Input.IsActionPressed(InputAction.Down))
            {
                velocity.y += 1f;
            }
            return velocity.Normalized() * speed;
        }
    }
}